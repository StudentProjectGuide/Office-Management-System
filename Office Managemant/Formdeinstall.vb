Public Class Formdeinstall
    Sub loadvehicle()
        sql = "select v_no from association"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)

        Do While Not rs.EOF
            CmbVno.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop

    End Sub

    Private Sub Formdeinstall_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadvehicle()
        loaddeinstall()
        btnupdate.Enabled = False
        Btndelete.Enabled = False
    End Sub
    Sub loaddetails()
        sql = "SELECT dbo.Vehicle.Vehicle_no, dbo.Association.u_no, dbo.Association.m_no, dbo.Association.sim_no, dbo.customer.owner_name,dbo.customer.cno"
        sql = sql & " FROM dbo.Vehicle INNER JOIN dbo.Association ON dbo.Vehicle.Vehicle_no = dbo.Association.v_no"
        sql = sql & " INNER Join dbo.customer ON dbo.Vehicle.CNo = dbo.customer.cno"
        sql = sql & " where dbo.Vehicle.Vehicle_no='" & CmbVno.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            TxtCname.Text = rs(4).Value
            TxtUno.Text = rs(1).Value
            Txtmobile_no.Text = rs(2).Value
            lblconsumer_no.Text = rs(5).Value
        End If

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If CmbVno.Text = "" Then
            MsgBox("Kindly select Vehicle number")
            Exit Sub
        ElseIf txtreport_no.Text = "" Then
            MsgBox("Kindly enter Report number")
            Exit Sub

        ElseIf TxtDname.Text = "" Then
            MsgBox("Kindly enter Driver name")
            Exit Sub

        ElseIf txtfees.Text = "" Then
            MsgBox("Kindly enter fees")
            Exit Sub
        End If

        sql = "select * from deinstallation where report_no = " & txtreport_no.Text & ""
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = True Then
            sql = "insert into deinstallation(consumer_no,cust_name,unit_no,mobile_no,driver_name,DODI,fees,report_no,ttime,VehicleNo) "
            sql = sql & " values('" & lblconsumer_no.Text & "','" & TxtCname.Text & "'," & TxtUno.Text & "," & Txtmobile_no.Text & ",'" & TxtDname.Text & "',convert(date,'" & dtpDODI.Value & "',103)," & txtfees.Text & "," & txtreport_no.Text & ",convert(time(7),'" & dtpTime.Value & "',103),'" & CmbVno.Text & "')"
            conn.Execute(sql)
            MsgBox("Deinstallation details added")
            loaddeinstall()
            clr()
            btnadd.Enabled = False
            btnupdate.Enabled = True
            Btndelete.Enabled = True
        Else
            MsgBox("De-Installation report no already Exist?")
        End If
    End Sub

    Sub clr()
        TxtCname.Text = ""
        CmbVno.Text = ""
        TxtUno.Text = ""
        Txtmobile_no.Text = ""
        txtreport_no.Text = ""
        TxtDname.Text = ""
        txtfees.Text = ""

    End Sub

    Private Sub CmbVno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbVno.SelectedIndexChanged
        loaddetails()
    End Sub

    Private Sub txtfees_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfees.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvdeinstall.DoubleClick
        Dim a
        a = dgvdeinstall.CurrentRow.Index
        lblconsumer_no.Text = dgvdeinstall.Item(0, a).Value 'consumer_no
        TxtCname.Text = dgvdeinstall.Item(1, a).Value 'cust_name
        CmbVno.Text = dgvdeinstall.Item(2, a).Value 'vehicle_no
        TxtUno.Text = dgvdeinstall.Item(3, a).Value 'unit_no
        Txtmobile_no.Text = dgvdeinstall.Item(4, a).Value 'mobile_no
        txtreport_no.Text = dgvdeinstall.Item(5, a).Value 'report_no
        TxtDname.Text = dgvdeinstall.Item(6, a).Value 'driver_name
        dtpDODI.Value = Convert.ToDateTime(dgvdeinstall.Item(7, a).Value) 'date of deinstallation
        dtpTime.Value = Convert.ToDateTime(dgvdeinstall.Item(8, a).Value) 'time
        txtfees.Text = dgvdeinstall.Item(9, a).Value 'fees
        btnadd.Enabled = False
        Btndelete.Enabled = True
        btnupdate.Enabled = True
    End Sub
    Sub loaddeinstall()

        dgvdeinstall.Rows.Clear()
        sql = "select * from Deinstallation"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        Do While Not rs.EOF

            dgvdeinstall.Rows.Add()
            dgvdeinstall.Item(0, i).Value = rs(0).Value.ToString  'cno
            dgvdeinstall.Item(1, i).Value = rs(1).Value.ToString 'cust_name
            dgvdeinstall.Item(6, i).Value = rs(2).Value.ToString 'Driver name
            dgvdeinstall.Item(7, i).Value = rs(3).Value.ToString 'DODI
            dgvdeinstall.Item(9, i).Value = rs(4).Value.ToString 'fees
            dgvdeinstall.Item(5, i).Value = rs(5).Value.ToString 'report no
            dgvdeinstall.Item(8, i).Value = rs(6).Value.ToString 'ttime 
            dgvdeinstall.Item(2, i).Value = rs(7).Value.ToString 'V_no
            dgvdeinstall.Item(3, i).Value = rs(8).Value.ToString 'u_no
            dgvdeinstall.Item(4, i).Value = rs(9).Value.ToString 'mobile_no

            i = i + 1
            rs.MoveNext()
        Loop
    End Sub

   

    Private Sub CmbVno_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbVno.TextChanged
        loaddetails()
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If CmbVno.Text = "" Then
            MsgBox("Kindly select Vehicle number")
            Exit Sub
        ElseIf txtreport_no.Text = "" Then
            MsgBox("Kindly enter Report number")
            Exit Sub

        ElseIf TxtDname.Text = "" Then
            MsgBox("Kindly enter Driver name")
            Exit Sub

        ElseIf txtfees.Text = "" Then
            MsgBox("Kindly enter fees")
            Exit Sub
        End If
        If MsgBox("Do you want to Update!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "update deinstallation set cust_name='" & TxtCname.Text & "',Driver_name='" & TxtDname.Text & "',DODI=convert(date,'" & dtpDODI.Value & "',103),Fees=" & txtfees.Text & ",report_no=" & txtreport_no.Text & ",Ttime=convert(time(7),'" & dtpTime.Value & "',103),unit_no=" & TxtUno.Text & ",mobile_no=" & Txtmobile_no.Text & " where consumer_no='" & lblconsumer_no.Text & "' "
            conn.Execute(sql)
            MsgBox("Record has been updated")
            loaddeinstall()
            clr()
            btnupdate.Enabled = False
            btnadd.Enabled = True
            Btndelete.Enabled = True
        End If
    End Sub

    Private Sub txtreport_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreport_no.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

  
    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        If CmbVno.Text <> "" And txtreport_no.Text <> "" And TxtDname.Text <> "" And txtfees.Text <> "" Then
            If MsgBox("Do you want to Delete!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "delete from deinstallation where VehicleNo='" & CmbVno.Text & "'"
                conn.Execute(sql)
                MsgBox("Record has been deleted")
                loaddeinstall()
                clr()
                Btndelete.Enabled = False
                btnadd.Enabled = True

            End If
        Else
            MsgBox("Record cannot be deleted")
        End If
    End Sub

    Private Sub dgvdeinstall_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdeinstall.CellContentClick

    End Sub
End Class
