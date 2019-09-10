Public Class FrmOutstanding

    Private Sub FrmOutstanding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadbill()
    End Sub
    Sub loadbill()
        dgv.Rows.Clear()

        sql = "SELECT dbo.Payments.vehicleNo, dbo.customer.phone FROM dbo.customer INNER JOIN  dbo.Payments ON dbo.customer.cno = dbo.Payments.custNo COLLATE Latin1_General_CI_AI WHERE (dbo.Payments.setled = 'false')"
        Dim ors As New ADODB.Recordset

        If ors.State = 1 Then ors.Close()
        ors.Open(sql, Conn)

        Dim i
        i = 0
        Dim STOTAL

        Do While Not ors.EOF

            sql = "select * from Payments where vehicleNo='" & ors(0).Value & "' order by billto desc"
            Dim rsbill As New ADODB.Recordset
            If rsbill.State = 1 Then rsbill.Close()
            Dim V
            V = ors(0).Value
            rsbill.Open(sql, Conn)
            Dim penalty
            penalty = 50

            Dim ldate
            Dim ldate1 As Date
            Dim lastdate As Date

            Dim P

            If rsbill.EOF = False Then
                dgv.Rows.Add()


                dgv.Item(0, i).Value = rsbill(9).Value 'Bill No
                dgv.Item(1, i).Value = rsbill(0).Value 'Vehcle No

                dgv.Item(2, i).Value = rsbill(1).Value 'Cust No
                dgv.Item(3, i).Value = rsbill(2).Value 'from
                lastdate = DateAdd(DateInterval.Day, 10, rsbill(3).Value)
                If Now.Date > lastdate Then
                    dgv.Item(5, i).Value = penalty 'Late fee
                    P = P + penalty
                Else
                    dgv.Item(5, i).Value = "0" 'Late fee
                End If


                dgv.Item(4, i).Value = rsbill(3).Value 'to
                dgv.Item(6, i).Value = rsbill(5).Value + Val(rsbill(6).Value) 'balance
                dgv.Item(7, i).Value = Val(dgv.Item(5, i).Value) + dgv.Item(6, i).Value  'total
                'dgv.Item(11, i).Value = ors(1).Value


                rsbill.MoveNext()

                sql = "select prevB from prevb where VehicleNo='" & ors(0).Value & "'"
                Dim prs As New ADODB.Recordset
                If prs.State = 1 Then prs.Close()
                prs.Open(sql, conn)

                If rss.State = 1 Then rss.Close()
                sql = "select * from bill where billno='" & dgv.Item(0, i).Value & "'"
                rss.Open(sql, conn)
                If rss.EOF = False Then
                    P = 0
                End If

                If prs.EOF = False Then

                    dgv.Item(8, i).Value = Val(prs(0).Value) + P
                End If
                i = i + 1

                ' Loop

            End If
            P = 0
            ' STOTAL = 0
            ' lblgridtotal.Text = "0"
            ors.MoveNext()
        Loop

        sql = "select sum(prevB) from prevb"
        Dim prrs As New ADODB.Recordset
        If prrs.State = 1 Then prrs.Close()
        prrs.Open(sql, Conn)
        If prrs.EOF = False Then
            lblnetTotal.Text = prrs(0).Value
        End If


        lbltotal.Text = i


    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class