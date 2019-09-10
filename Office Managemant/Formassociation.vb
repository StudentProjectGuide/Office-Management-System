Public Class Formassociation

    Private Sub Formassociation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadVehicle()
        loadCustomerNo()
        loadUnitNo()
        loadMob()
        loadDetails()
    End Sub
    Dim search
    Dim serchCol

    Sub loadDetails()
        dgvassociation.Rows.Clear()

        sql = "select * from association"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        Do While Not rs.EOF
            dgvassociation.Rows.Add()
            dgvassociation.Item(0, i).Value = rs(0).Value 'a_id
            dgvassociation.Item(1, i).Value = rs(2).Value 'customer
            dgvassociation.Item(2, i).Value = rs(1).Value 'vehicle_no
            dgvassociation.Item(4, i).Value = rs(4).Value 'mobile_no
            dgvassociation.Item(5, i).Value = rs(5).Value 'sim_no
            dgvassociation.Item(6, i).Value = rs(6).Value 'ir_no
            dgvassociation.Item(7, i).Value = rs(7).Value 'date
            dgvassociation.Item(8, i).Value = rs(8).Value 'status
            dgvassociation.Item(9, i).Value = rs(9).Value 'sim status
            dgvassociation.Item(3, i).Value = rs(3).Value 'unit_no
           
            rs.MoveNext()
            i = i + 1

        Loop
    End Sub

    Sub loadVehicle()
        cmbVehicle.Items.Clear()

        sql = "select vehicle_no from vehicle except select v_no from association"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            cmbVehicle.Items.Add(rs(0).Value)

            rs.MoveNext()
        Loop
    End Sub
    Sub loadUnitNo()
        CmbUno.Items.Clear()

        sql = "select unit_no from hardware except select u_no from association"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            CmbUno.Items.Add(rs(0).Value)

            rs.MoveNext()
        Loop
    End Sub
    Sub loadCustomerNo()
        cmbCustomerNo.Items.Clear()

        sql = "select cno from customer"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            cmbCustomerNo.Items.Add(rs(0).Value)

            rs.MoveNext()
        Loop
    End Sub
    Sub loadMob()
        CmbMno.Items.Clear()

        sql = "select mobile_no from sim except select m_no from association"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            CmbMno.Items.Add(rs(0).Value)

            rs.MoveNext()
        Loop
    End Sub

    Private Sub CmbMno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMno.SelectedIndexChanged
        sql = "select sim_no from sim where mobile_no=" & CmbMno.Text & ""
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtSno.Text = rs(0).Value
        End If
    End Sub

    Private Sub BTnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTnOk.Click
        If cmbVehicle.Text = "" Then
            MsgBox("Kindly select Vehicle_no")
            Exit Sub
        ElseIf cmbCustomerNo.Text = "" Then
            MsgBox("Kindly select Customer_no")
            Exit Sub
        ElseIf CmbUno.Text = "" Then
            MsgBox("Kindly select Unit_no")
            Exit Sub
        ElseIf CmbMno.Text = "" Then
            MsgBox("Kindly select Mobile_no")
            Exit Sub
        ElseIf txtInstno.Text = "" Then
            MsgBox("Kindly enter installation report number")
            Exit Sub
        End If
        sql = "select * from unique_id where bill='Association'"
        If rs.State = 1 Then rs.Close()

        rs.Open(sql, conn)
        Dim assno

        If rs.EOF = False Then
            assno = rs(1).Value & rs(2).Value
        End If

        sql = "insert into association(a_id,v_no,customer,u_no,m_no,sim_no,IRNO,date,Status,SIMStatus)"

        sql = sql & " values('" & assno & "','" & cmbVehicle.Text & "','" & cmbCustomerNo.Text & "'," & CmbUno.Text & "," & CmbMno.Text & "," & txtSno.Text & "," & txtInstno.Text & ",convert(date,'" & DateTimePicker1.Text & "',103),'Installed','Active')"
        conn.Execute(sql)
        MsgBox("Association is Successfull with No :" & assno)
        Dim temp
        temp = Val(Mid(assno, 2)) + 1
        conn.Execute("update unique_id set id=" & temp & " where bill='Association'")
        sql = "insert into advance(VehicleNo,CustNo,Remaining,advance) values('" & cmbVehicle.Text & "','" & cmbCustomerNo.Text & "',0,0)"
        conn.Execute(sql)
        sql = "insert into prevb(CustNo,VehicleNo,Prevb) values('" & cmbCustomerNo.Text & "','" & cmbVehicle.Text & "',0)"
        conn.Execute(sql)

    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearch.SelectedIndexChanged
        If CmbSearch.Text = "Vehicle No" Then
            search = "v_no"
        ElseIf CmbSearch.Text = "Customer No" Then
            search = "customer"
        ElseIf CmbSearch.Text = "Unit No" Then
            search = "u_no"
        ElseIf CmbSearch.Text = "Mobile" Then
            search = "m_no"
        End If
    End Sub
    Sub search1()
        dgvassociation.Rows.Clear()
        Dim s
        s = txtsearch.Text
        sql = "select * from  association where " & search & " like '%" & s & "%'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        Do While Not rs.EOF
            dgvassociation.Rows.Add()
            dgvassociation.Item(0, i).Value = rs(0).Value 'aid
            dgvassociation.Item(1, i).Value = rs(2).Value 'v_no
            dgvassociation.Item(2, i).Value = rs(1).Value 'customer
            dgvassociation.Item(3, i).Value = rs(3).Value 'U_no
            dgvassociation.Item(4, i).Value = rs(4).Value 'M_no
            dgvassociation.Item(5, i).Value = rs(5).Value 'sim_no
            dgvassociation.Item(6, i).Value = rs(6).Value 'IRNO
            dgvassociation.Item(7, i).Value = rs(7).Value 'date
            dgvassociation.Item(8, i).Value = rs(8).Value 'status
            dgvassociation.Item(9, i).Value = rs(9).Value 'simstatus
            rs.MoveNext()
            i = i + 1

        Loop

    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        search1()
    End Sub

    Private Sub txtInstno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInstno.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub dgvassociation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvassociation.CellContentClick

    End Sub
End Class