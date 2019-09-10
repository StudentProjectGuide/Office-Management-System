Imports System.Data
Imports System.Data.SqlClient
Public Class FrmReciept

    Private Sub cmb_vehical_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_vehical_no.TextChanged
        cmb_vehical_no.Text = UCase(cmb_vehical_no.Text)
        cmb_vehical_no.SelectionStart = Len(cmb_vehical_no.Text)
        If cmb_vehical_no.Text <> "" Then
            load_vehicle()
        End If
    End Sub
    Sub load_vehicle()

        Dim pl = ""
        pl = cmb_vehical_no.Text & "%"

        sql = "select Vehicle_no from Vehicle where Vehicle_no like '%" & pl & "%' except select association.v_no from association where status='association'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)

        lst_vehicle_no.Items.Clear()
        If rs.EOF = False Then
            lst_vehicle_no.Visible = True

            Do While Not rs.EOF
                lst_vehicle_no.Items.Add(rs(0).Value)
                rs.MoveNext()
            Loop
        Else
            lst_vehicle_no.Visible = False
        End If


    End Sub
    Sub loadbill()


        sql = "select * from Payments where vehicleNo='" & cmb_vehical_no.Text & "' and setled='false' order by billto desc"
        Dim rsbill As New ADODB.Recordset
        rsbill.Open(sql, Conn)
        Dim penalty
        penalty = 50
        Dim i
        i = 0
        Dim ldate
        Dim ldate1 As Date
        Dim lastdate As Date
       
        Dim s As Boolean
        s = False
        Dim k
        Dim bill
        If rsbill.EOF = False Then
            '  Do While Not rsbill.EOF
            dgv.Rows.Add()

            dgv.Item(0, i).Value = rsbill(9).Value
            Bill = rsbill(9).Value
            dgv.Item(1, i).Value = rsbill(2).Value
            lastdate = DateAdd(DateInterval.Day, 10, rsbill(3).Value)
            If Now.Date > lastdate Then
                dgv.Item(3, i).Value = penalty
            Else
                dgv.Item(3, i).Value = "0"
            End If

            dgv.Item(2, i).Value = rsbill(3).Value

            If s = False Then
                k = k + Val(dgv.Item(3, i).Value)
            End If
            dgv.Item(4, i).Value = rsbill(5).Value + rsbill(6).Value
            dgv.Item(5, i).Value = Val(txtAmount.Text) + Val(dgv.Item(3, i).Value)
            lblgridtotal.Text = Val(lblgridtotal.Text) + Val(dgv.Item(5, i).Value)
            rsbill.MoveNext()
            i = i + 1
            s = True

            'Loop
        End If
        'If Rss.State = 1 Then Rss.Close()
        'sql = "select * from bill where billno='" & bill & "'"
        'Rss.Open(sql, Conn)
        'If Rss.EOF = False Then
        '    k = 0
        'End If
        txtAmount.Text = Val(txtAmount.Text) + Val(k)
        netbal = netbal + k
    End Sub





    Public totalamt As Integer



    Private Sub lst_vehicle_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lst_vehicle_no.KeyDown
        If e.KeyCode = 13 Then
            cmb_vehical_no.Text = lst_vehicle_no.Text
            lst_vehicle_no.Visible = False
            con.Open()
            Dim cmd As New SqlCommand("select * from vehicle_detail where vehicle_reg_no='" & cmb_vehical_no.Text & "'", con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.Read = True Then

                cmb_customer.Text = dr.Item("Consumer_No").ToString
                txtRecievedFrom.Text = dr.Item("owner").ToString
            End If
            con.Close()
        ElseIf e.KeyCode = Keys.Back Then
            lst_vehicle_no.Focus()
            cmb_vehical_no.TabIndex = 0
        End If
    End Sub

    Private Sub lst_vehicle_no_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_vehicle_no.MouseClick

        cmb_vehical_no.Text = lst_vehicle_no.Text
        lst_vehicle_no.Visible = False

        Dim cmd As New SqlCommand("select * from vehicle where Vehicle_no='" & cmb_vehical_no.Text & "'", con)
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            cmb_customer.Text = rs(0).Value

        End If

    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            loadbill()
        Else
            dgv.Rows.Clear()
            lblgridtotal.Text = "0"
        End If
        loadtot()
    End Sub



    Private Sub cbh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbh.CheckedChanged
        If cbh.Checked = True Then
            txtHard.Enabled = True
        Else
            txtHard.Text = "0"
            txtHard.Enabled = False
        End If
    End Sub


    Private Sub cbdinstall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbdinstall.CheckedChanged
        If cbdinstall.Checked = True Then

            txtdeinst.Enabled = True
        Else
            txtdeinst.Text = "0"
            txtdeinst.Enabled = False
        End If
    End Sub

    Private Sub cbsubfee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbsubfee.CheckedChanged
        If cbsubfee.Checked = True Then

            txtsubfee.Enabled = True
        Else
            txtsubfee.Text = 0
            txtsubfee.Enabled = False
        End If
    End Sub

    Private Sub cbinstal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbinstal.CheckedChanged
        If cbinstal.Checked = True Then
            txtinst.Enabled = True
        Else
            txtinst.Text = "0"

            txtinst.Enabled = False
        End If
    End Sub

    Private Sub txtdeinst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdeinst.TextChanged
        loadtot()
        loadPaid()
    End Sub
    Private Sub txtsubfee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubfee.TextChanged
        loadtot()
        loadPaid()
    End Sub
    Private Sub cbreconnect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbreconnect.CheckedChanged
        If cbreconnect.Checked = True Then
            txtreconnection.Enabled = True
        Else
            txtreconnection.Text = "0"

            txtreconnection.Enabled = False
        End If
    End Sub
    Private Sub txtHard_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHard.TextChanged
        loadtot()
        loadPaid()
    End Sub

    Sub loadtot()
        txtAmount.Text = (Val(netbal) + Val(txtHard.Text) + Val(txtdeinst.Text) + Val(txtsubfee.Text) + Val(txtinst.Text) + Val(txtreconnection.Text) + Val(txtAdvance.Text)) - (Val(txtVawer.Text) + Val(txtEnterAmount.Text))

    End Sub
    Private Sub txtinst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinst.TextChanged
        loadtot()
        loadPaid()
    End Sub
    Private Sub txtreconnection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreconnection.TextChanged
        loadtot()
        loadPaid()
    End Sub
    Private Sub txtVawer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVawer.TextChanged
        loadtot()
        loadPaid()
    End Sub
    Private Sub txtAdvance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdvance.TextChanged
        loadtot()
        loadPaid()
    End Sub
    Dim netbal

    Sub loadPaid()
        totalpaid = Val(txtHard.Text) + Val(txtdeinst.Text) + Val(txtsubfee.Text) + Val(txtinst.Text) + Val(txtreconnection.Text) + Val(txtAdvance.Text) - Val(txtVawer.Text)
        lblpaid.Text = totalpaid
    End Sub

    Private Sub txtRecievedFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRecievedFrom.TextChanged
        txtRecievedFrom.Text = UCase(txtRecievedFrom.Text)
        txtRecievedFrom.SelectionStart = Len(txtRecievedFrom.Text)
    End Sub
    Private Sub cmb_customer_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_customer.TextChanged
        loadbal()
    End Sub
    Sub loadbal()
        sql = "select prevB from prevb where VehicleNo='" & cmb_vehical_no.Text & "'"
        Dim prs As New ADODB.Recordset
        If prs.State = 1 Then prs.Close()
        prs.Open(sql, Conn)

        If prs.EOF = False Then

            txtAmount.Text = Val(prs(0).Value)
            netbal = txtAmount.Text
        End If
    End Sub
    Dim totalpaid

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If txtRecievedFrom.Text = "" Then
            MsgBox("Kindly enter Recieved from!!")
            txtRecievedFrom.Focus()

        ElseIf txtAmount.Text = "0" Then
            MsgBox("Amount should be more than zero!!")
        ElseIf cmb_customer.Text = "" Then
            MsgBox("Kindly select Vehicle Number")
            cmb_vehical_no.Focus()

        ElseIf cmbPayType.Text = "" Then
            MsgBox("Kindly select Pay type!!")
            cmbPayType.Focus()
        ElseIf lblno.Text = "" Then
            MsgBox("Kindly enter Reciept Number!!!")
            lblno.Focus()



        Else
            sql = "select * from bill where receiptNo='" & lblno.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = True Then
                Dim extraAmount
                extraAmount = 0
                Dim hardware As Boolean
                hardware = False
                Dim deinst As Boolean
                deinst = False
                Dim sc As Boolean
                sc = False
                Dim sf As Boolean
                sf = False
                Dim inst As Boolean
                inst = False
                Dim recon As Boolean
                recon = False
                Dim payments As Boolean
                payments = False


                If cbh.Checked = True Then
                    hardware = True
                End If
                If cbdinstall.Checked = True Then
                    deinst = True
                End If
                If CheckBox3.Checked = True Then
                    sc = True
                End If
                If cbsubfee.Checked = True Then
                    sf = True
                End If
                If cbinstal.Checked = True Then
                    inst = True
                End If
                If cbreconnect.Checked = True Then
                    recon = True
                End If
                Dim i

                For i = 0 To dgv.RowCount - 1
                    Dim AmtPayable As Integer
                    Dim paid As Integer
                    Dim bal As Integer
                    bal = 0
                    AmtPayable = 0
                    paid = 0
                    Dim TotalServiceCharge As Integer
                    TotalServiceCharge = 0


                    If dgv.Item(6, i).Value = True Then
                        Dim setled As Boolean
                        setled = False
                        AmtPayable = dgv.Item(5, i).Value
                        paid = dgv.Item(7, i).Value
                        If paid < AmtPayable Then
                            bal = Val(AmtPayable) - Val(paid)
                        ElseIf paid > AmtPayable Then

                            extraAmount = Val(extraAmount) + (Val(paid) - Val(AmtPayable)) - Val(txtVawer.Text)
                            '   txtAmount.Text = txtAmount.Text + extraAmount

                            setled = True
                        Else
                            setled = True

                        End If

                        sql = "update payments set setled='" & setled & "' where vehicleNo='" & cmb_vehical_no.Text & "'  and ReeiptNo='" & dgv.Item(0, i).Value & "'"
                        conn.Execute(sql)
                        totalpaid = Val(totalpaid) + Val(paid)



                    End If

                Next
                If hardware = True Or deinst = True Or sc = True Or inst = True Or recon = True Or sf = True Then

                    sql = "insert into bill(vehcleNo,amount,paytype,paydate,hardware,deinstallation,serCharges,subFee,installation,custNo,receiptNo,Reconnection,RecFrom,billno) "
                    sql = sql & "values('" & cmb_vehical_no.Text & "'," & totalpaid & ",'" & cmbPayType.Text & "',convert(date,'" & dtpdate.Value & "',103),'" & hardware & "','" & deinst & "','" & sc & "','" & sf & "','" & inst & "','" & cmb_customer.Text & "','" & lblno.Text & "','" & recon & "','" & txtRecievedFrom.Text & "','" & dgv.Item(0, 0).Value & "')"
                    conn.Execute(sql)
                End If

                lblpaid.Text = totalpaid
                If Val(totalpaid) > 0 Then
                    If Val(totalpaid) = Val(txtAmount.Text) Then
                        sql = "update prevb set prevb=0 where VehicleNo='" & cmb_vehical_no.Text & "'"
                        conn.Execute(sql)
                        MsgBox("Balance Amount Cleared!!")
                    ElseIf Val(totalpaid) > Val(txtAmount.Text) Then
                        sql = "update prevb set prevb=0 where VehicleNo='" & cmb_vehical_no.Text & "'"
                        conn.Execute(sql)
                        MsgBox("Balance Amount Cleared!!")
                    ElseIf Val(totalpaid) < Val(txtAmount.Text) Then
                        Dim bal
                        bal = Val(txtAmount.Text) - Val(totalpaid)
                        sql = "update prevb set prevb=" & bal & " where VehicleNo='" & cmb_vehical_no.Text & "'"
                        conn.Execute(sql)
                        MsgBox("Balance Amount Set!!=" & bal)
                    End If
                End If
                txtAdvance.Text = Val(txtAdvance.Text) + Val(extraAmount)
                If txtAdvance.Text > 0 Then
                    sql = "select * from advance where vehicleno='" & cmb_vehical_no.Text & "' and custno='" & cmb_customer.Text & "'"
                    If rs.State = 1 Then rs.Close()
                    rs.Open(sql, conn)
                    If rs.EOF = True Then
                        sql = "insert into advance(advance,adate,amount,remaining,custno,vehicleno) "
                        sql = sql & "values(" & txtAdvance.Text & ",convert(date,'" & dtpdate.Value & "',103),0," & txtAdvance.Text & ",'" & cmb_customer.Text & "','" & cmb_vehical_no.Text & "')"
                        conn.Execute(sql)
                        MsgBox("Advance Money Collected")
                        'sql = "insert into AdvanceEntry(VehicleNo,CustNo,Advance,Adate) values('" & cmb_vehical_no.Text & "','" & cmb_customer.Text & "'," & txtAdvance.Text & ",convert(date,'" & dtpdate.Value & "',103))"
                        'conn.Execute(sql)

                    Else
                        sql = "update advance set amount=" & txtAdvance.Text & ",remaining=" & txtAdvance.Text & ",adate=convert(date,'" & dtpdate.Value & "',103) where CustNo='" & cmb_customer.Text & "' and VehicleNo='" & cmb_vehical_no.Text & "'"
                        conn.Execute(sql)

                        'sql = "insert into AdvanceEntry(VehicleNo,CustNo,Advance,Adate) values('" & cmb_vehical_no.Text & "','" & cmb_customer.Text & "'," & txtAdvance.Text & ",convert(date,'" & dtpdate.Value & "',103))"
                        'conn.Execute(sql)

                    End If

                End If

                If Val(txtVawer.Text) > 0 Then
                    sql = "insert into vawer(vehicleNo,amount,vdate,rno) values('" & cmb_vehical_no.Text & "'," & txtVawer.Text & ",convert(date,'" & dtpdate.Value & "',103),'" & lblno.Text & "')"
                    conn.Execute(sql)
                    MsgBox("Vawer Paid!!!")
                End If

     
                
            Else
                MsgBox("Record added!!!!")
            End If
        End If



    End Sub
    Private Sub txtEnterAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEnterAmount.TextChanged
        loadtot()
    End Sub
    Public search_value
    Private Sub cmb_search_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_search.SelectedIndexChanged
        If cmb_search.Text = "Consumer No" Then
            search_value = "custNo"
            search_date.Visible = False
            txt_search.Visible = True
        ElseIf cmb_search.Text = "Vehicle No" Then
            search_value = "vehcleNo"
            search_date.Visible = False
            txt_search.Visible = True
        ElseIf cmb_search.Text = "Receipt No" Then
            search_value = "receiptNo"
            search_date.Visible = False
            txt_search.Visible = True
        ElseIf cmb_search.Text = "Receipt Date" Then
            search_value = "paydate"
            search_date.Visible = True

            txt_search.Visible = False

        ElseIf cmb_search.Text = "Bill No" Then
            search_value = "BillNo"
            search_date.Visible = False

            txt_search.Visible = True

        ElseIf cmb_search.Text = "All" Then
            search_date.Visible = False
            txt_search.Visible = False

            con.Open()


            Dim da As New SqlDataAdapter("select receiptNo,custNo,convert(char(10),paydate,103),vehcleNo,amount,paytype,BillNo,RecFrom from Bill order by receiptNo", con)
            Dim ds As New DataSet
            da.Fill(ds)
            dgv2.Rows.Clear()

            'DataGridView1.DataSource = ds
            'DataGridView1.DataMember = ds.Tables(0).ToString
            Dim drow As DataRow
            Dim i As Integer = 0
            For Each drow In ds.Tables(0).Rows
                dgv2.Rows.Add()
                dgv2.Item(0, i).Value = drow(0).ToString
                dgv2.Item(1, i).Value = drow(1).ToString
                dgv2.Item(2, i).Value = drow(2).ToString
                dgv2.Item(3, i).Value = drow(3).ToString
                dgv2.Item(4, i).Value = drow(4).ToString
                dgv2.Item(5, i).Value = drow(5).ToString
                dgv2.Item(6, i).Value = drow(6).ToString
                dgv2.Item(7, i).Value = drow(7).ToString
                sumTotal_payable = ds.Tables(0).Compute("SUM(amount)", String.Empty).ToString

                lblnetTotal.Text = "TOTAL :" & sumTotal_payable
                count_no = ds.Tables(0).Compute("count(vehcleNo)", String.Empty).ToString

                lbl_count.Text = "Count :" & count_no

                i = i + 1
            Next
            con.Close()
        End If
        txt_search.Text = ""
    End Sub
    Dim sumTotal_payable, count_no
    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged

        con.Open()
        Dim mt
        mt = txt_search.Text

        Dim da As New SqlDataAdapter("select receiptNo,custNo,convert(char(10),paydate,103),vehcleNo,amount,paytype,BillNo,RecFrom from Bill where " & search_value & " like '%" & mt & "%'  order by " & search_value & "", con)
        Dim ds As New DataSet
        da.Fill(ds)
        dgv2.Rows.Clear()

        'DataGridView1.DataSource = ds
        'DataGridView1.DataMember = ds.Tables(0).ToString
        Dim drow As DataRow
        Dim i As Integer = 0
        For Each drow In ds.Tables(0).Rows
            dgv2.Rows.Add()
            dgv2.Item(0, i).Value = drow(0).ToString
            dgv2.Item(1, i).Value = drow(1).ToString
            dgv2.Item(2, i).Value = drow(2).ToString
            dgv2.Item(3, i).Value = drow(3).ToString
            dgv2.Item(4, i).Value = drow(4).ToString
            dgv2.Item(5, i).Value = drow(5).ToString
            dgv2.Item(6, i).Value = drow(6).ToString
            dgv2.Item(7, i).Value = drow(7).ToString
            sumTotal_payable = ds.Tables(0).Compute("SUM(amount)", String.Empty).ToString

            lblnetTotal.Text = "TOTAL :" & sumTotal_payable
            count_no = ds.Tables(0).Compute("count(receiptNo)", String.Empty).ToString

            lbl_count.Text = "Count :" & count_no

            i = i + 1
        Next
        con.Close()

    End Sub

   

    Private Sub search_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search_date.ValueChanged


        con.Open()
        Dim mt
        Dim d = search_date.Value.ToString("dd/MM/yyyy")
        mt = d
        dgv2.Rows.Clear()

        Dim da As New SqlDataAdapter("select receiptNo,custNo,convert(char(10),paydate,103),vehcleNo,amount,paytype,BillNo,RecFrom from Bill where paydate=CONVERT(date, '" & mt & "', 103) ", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim drow As DataRow
        Dim i As Integer = 0
        For Each drow In ds.Tables(0).Rows
            dgv2.Rows.Add()
            dgv2.Item(0, i).Value = drow(0).ToString
            dgv2.Item(1, i).Value = drow(1).ToString
            dgv2.Item(2, i).Value = drow(2).ToString
            dgv2.Item(3, i).Value = drow(3).ToString
            dgv2.Item(4, i).Value = drow(4).ToString
            dgv2.Item(5, i).Value = drow(5).ToString
            dgv2.Item(6, i).Value = drow(6).ToString
            dgv2.Item(7, i).Value = drow(7).ToString
            sumTotal_payable = ds.Tables(0).Compute("SUM(amount)", String.Empty).ToString

            lblnetTotal.Text = "TOTAL :" & sumTotal_payable

            count_no = ds.Tables(0).Compute("count(receiptNo)", String.Empty).ToString

            lbl_count.Text = "Count :" & count_no
            i = i + 1

        Next
        con.Close()
    End Sub

  
  
    Private Sub FrmReciept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()


        Dim da As New SqlDataAdapter("select receiptNo,custNo,convert(char(10),paydate,103),vehcleNo,amount,paytype,BillNo,RecFrom from Bill order by receiptNo", con)
        Dim ds As New DataSet
        da.Fill(ds)
        dgv2.Rows.Clear()

        'DataGridView1.DataSource = ds
        'DataGridView1.DataMember = ds.Tables(0).ToString
        Dim drow As DataRow
        Dim i As Integer = 0
        For Each drow In ds.Tables(0).Rows
            dgv2.Rows.Add()
            dgv2.Item(0, i).Value = drow(0).ToString
            dgv2.Item(1, i).Value = drow(1).ToString
            dgv2.Item(2, i).Value = drow(2).ToString
            dgv2.Item(3, i).Value = drow(3).ToString
            dgv2.Item(4, i).Value = drow(4).ToString
            dgv2.Item(5, i).Value = drow(5).ToString
            dgv2.Item(6, i).Value = drow(6).ToString
            dgv2.Item(7, i).Value = drow(7).ToString
            sql = "select * from vawer where rno='" & dgv2.Item(0, i).Value & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                dgv2.Item(8, i).Value = rs(1).Value

            End If
            sql = "select * from advance where VehicleNo='" & dgv2.Item(3, i).Value & "' and Adate=convert(date,'" & dgv2.Item(2, i).Value & "',103)"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                dgv2.Item(9, i).Value = rs(2).Value
            End If
            sumTotal_payable = ds.Tables(0).Compute("SUM(amount)", String.Empty).ToString

            lblnetTotal.Text = "TOTAL :" & sumTotal_payable
            count_no = ds.Tables(0).Compute("count(vehcleNo)", String.Empty).ToString

            lbl_count.Text = "Count :" & count_no

            i = i + 1
        Next
        con.Close()
    End Sub


    Private Sub p_adv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub cmb_customer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_customer.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class