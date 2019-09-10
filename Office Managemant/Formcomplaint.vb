Public Class Formcomplaint
    Sub loadvehicle()
        sql = "select v_no from association"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)

        Do While Not rs.EOF
            cmbvehicle.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Sub loadvehicle1()
        sql = "select v_no from association"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)

        Do While Not rs.EOF
            cmbsearch.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop

    End Sub
    Sub loadcompliants()
        sql = " SELECT dbo.customer.owner_name,dbo.Association.customer,dbo.Association.u_no,dbo.Association.sim_no,dbo.Association.v_no"
        sql = sql & " FROM dbo.customer INNER JOIN dbo.Association ON dbo.customer.cno = dbo.Association.customer"
        sql = sql & " where dbo.Association.v_no='" & cmbvehicle.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtowner_name.Text = rs(0).Value
            TxtCno.Text = rs(1).Value
            Txtunit_no.Text = rs(2).Value
            txtsim_no.Text = rs(3).Value
            cmbvehicle.Text = rs(4).Value
        End If
    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        If txttyp_of_complt.Text = "" Then
            MsgBox("Kindly Enter Type of compliant")
            Exit Sub
        ElseIf Cmbtech_name.Text = "" Then
            MsgBox("Kindly select Technician name")
            Exit Sub
        End If
        If MsgBox("Do you want to Add!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If Cmbstatus.Text <> "" Then
                sql = "insert into compliant(Vehicle_no,Cdate,Ctime,Type_of_complt,Rdate,Rtime,tech_name,priority,status)"
                sql = sql & " values('" & cmbvehicle.Text & "',convert(date,'" & Dtpcdate.Value & "',103),convert(time(7),'" & dtptime.Value & "',103),'" & txttyp_of_complt.Text & "',convert(date,'" & dtprdate.Value & "',103),convert(time(7),'" & Dtprtime.Value & "',103),'" & Cmbtech_name.Text & "'," & Cmbpriority.Text & ",'Not Solved')"
                conn.Execute(sql)
                MsgBox("Compliants Added")
                clr()
                Btnupdate.Enabled = True
                Btnadd.Enabled = False
            Else
                MsgBox("Kindly select status!!")
            End If


        End If
    End Sub

    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupdate.Click
        If txttyp_of_complt.Text = "" Then
            MsgBox("Kindly Enter Type of compliant")
            Exit Sub
        ElseIf Cmbtech_name.Text = "" Then
            MsgBox("Kindly select Technician name")
            Exit Sub
        ElseIf Cmbstatus.Text = "" Then
            MsgBox("Kindly select status")
            Exit Sub
        End If
        If MsgBox("Do you want to Update!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "update compliant set rdate=convert(date,'" & dtprdate.Value & "',103),rtime=convert(time(7),'" & Dtprtime.Value & "',103),rep_no=" & Txtrep_no.Text & ",status='" & Cmbstatus.Text & "',remark='" & Txtremark.Text & "',amount=" & Txtamount.Text & " where id=" & lblcid.Text & ""
            conn.Execute(sql)
            MsgBox("Record has been updated")
            clr()
            Btnupdate.Enabled = False
            Btndelete.Enabled = True
            Btnadd.Enabled = True
        End If
    End Sub


    Private Sub cmbvehicle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvehicle.SelectedIndexChanged
        loadcompliants()
        loadcomplt()
    End Sub

    Private Sub Formcomplaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If uname = "Technician" Then
            Btnadd.Enabled = False
            Btndelete.Enabled = False
            Txtunit_no.Enabled = False
            txtsim_no.Enabled = False
            Cmbpriority.Enabled = False
            Cmbtech_name.Enabled = False
            TxtCno.Enabled = False
            txttyp_of_complt.Enabled = False
            txtowner_name.Enabled = False
            Dtpcdate.Enabled = False
            dtptime.Enabled = False
            Lblunit_no.Enabled = False
            lblsim.Enabled = False
            lblpriority.Enabled = False
            lblowner.Enabled = False
            lbltech.Enabled = False
            lbldate.Enabled = False
            lbltime.Enabled = False
            lbltype.Enabled = False
            lblcno.Enabled = False
            GroupBox1.Enabled = False
            Btnadd.Enabled = False
            Btndelete.Enabled = False
        Else
            Cmbstatus.Enabled = True
            Label11.Enabled = False
            Label12.Enabled = False
            Label13.Enabled = False
            Label14.Enabled = True
            Label15.Enabled = False
            Label16.Enabled = False
            dtprdate.Enabled = False
            Dtprtime.Enabled = False
            Txtremark.Enabled = False
            Txtrep_no.Enabled = False
            Txtamount.Enabled = False
            Btnupdate.Enabled = False
            'GroupBox2.Visible = False
        End If

        loadvehicle()
        loadTech()
        loadvehicle1()
        loadTech1()
        CheckBox1.Checked = True
    End Sub
    Sub loadComplieantsDetails()
        sql = "select * from compliant where cdate=convert(date,'" & dtpdate.Value & "',103)"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        dgvcompliant.Rows.Clear()

        Do While Not rs.EOF
            dgvcompliant.Rows.Add()
            dgvcompliant.Item(0, i).Value = rs(0).Value 'vehicle_no
            dgvcompliant.Item(1, i).Value = rs(12).Value 'priority
            dgvcompliant.Item(2, i).Value = rs(13).Value 'c_no
            dgvcompliant.Item(3, i).Value = rs(4).Value 'type_of_complt
            dgvcompliant.Item(4, i).Value = rs(2).Value 'date
            dgvcompliant.Item(5, i).Value = rs(3).Value 'time
            dgvcompliant.Item(6, i).Value = rs(11).Value 'tech_name
            dgvcompliant.Item(7, i).Value = rs(8).Value 'status
            dgvcompliant.Item(8, i).Value = rs(1).Value 'id
            dgvcompliant.Item(9, i).Value = rs(5).Value 'rdate
            dgvcompliant.Item(10, i).Value = rs(6).Value 'rtime
            dgvcompliant.Item(11, i).Value = rs(9).Value 'remark
            dgvcompliant.Item(12, i).Value = rs(7).Value 'service_rep_no
            dgvcompliant.Item(13, i).Value = rs(10).Value 'amount

            rs.MoveNext()
            i = i + 1
        Loop
    End Sub
    Sub loadTech()
        sql = "select uname from login where utype='Technician'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            Cmbtech_name.Items.Add(rs(0).Value)

            rs.MoveNext()
        Loop
    End Sub
    Sub loadTech1()
        sql = "select uname from login where utype='Technician'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            ComboBox2.Items.Add(rs(0).Value)

            rs.MoveNext()
        Loop
    End Sub
    Sub loadcomplt()
        dgvcompliant.Rows.Clear()
        sql = "select * from compliant"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        Do While Not rs.EOF

            dgvcompliant.Rows.Add()
            dgvcompliant.Item(0, i).Value = rs(0).Value 'vehicle_no
            dgvcompliant.Item(1, i).Value = rs(12).Value 'priority
            dgvcompliant.Item(2, i).Value = rs(13).Value 'c_no
            dgvcompliant.Item(3, i).Value = rs(4).Value 'type_of_complt
            dgvcompliant.Item(4, i).Value = rs(2).Value 'date
            dgvcompliant.Item(5, i).Value = rs(3).Value 'time
            dgvcompliant.Item(6, i).Value = rs(11).Value 'tech_name
            dgvcompliant.Item(7, i).Value = rs(8).Value 'status
            dgvcompliant.Item(8, i).Value = rs(1).Value 'id
            dgvcompliant.Item(9, i).Value = rs(5).Value 'rdate
            dgvcompliant.Item(10, i).Value = rs(6).Value 'rtime
            dgvcompliant.Item(11, i).Value = rs(9).Value 'remark
            dgvcompliant.Item(12, i).Value = rs(7).Value 'service_rep_no
            dgvcompliant.Item(13, i).Value = rs(10).Value 'amount

            i = i + 1
            rs.MoveNext()
        Loop
    End Sub

    Sub loadv_no()

        dgvcompliant.Rows.Clear()
        sql = "select * from compliants where Vehicle_no='" & cmbsearch.Text & "'"

        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0

        Do While Not rs.EOF
            dgvcompliant.Rows.Add()
            dgvcompliant.Item(0, i).Value = rs(13).Value
            dgvcompliant.Item(1, i).Value = rs(14).Value
            dgvcompliant.Item(2, i).Value = rs(12).Value
            dgvcompliant.Item(3, i).Value = rs(15).Value
            dgvcompliant.Item(4, i).Value = rs(16).Value
            dgvcompliant.Item(5, i).Value = rs(4).Value
            dgvcompliant.Item(6, i).Value = rs(2).Value
            dgvcompliant.Item(7, i).Value = rs(3).Value
            dgvcompliant.Item(8, i).Value = rs(11).Value

            rs.MoveNext()
            i = i + 1
        Loop

    End Sub
   
    Sub clr()
        cmbvehicle.Text = ""
        Txtunit_no.Text = ""
        txtsim_no.Text = ""
        txtowner_name.Text = ""
        TxtCno.Text = ""
        Cmbpriority.Text = ""
        Cmbtech_name.Text = ""
        txttyp_of_complt.Text = ""
        Cmbstatus.Text = ""
    End Sub

    Private Sub cmbsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsearch.SelectedIndexChanged

        sql = "select * from compliant where Vehicle_no='" & cmbsearch.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        dgvcompliant.Rows.Clear()

        Do While Not rs.EOF
            dgvcompliant.Rows.Add()
            dgvcompliant.Item(0, i).Value = rs(0).Value 'vehicle_no
            dgvcompliant.Item(1, i).Value = rs(12).Value 'priority
            dgvcompliant.Item(2, i).Value = rs(13).Value 'c_no
            dgvcompliant.Item(3, i).Value = rs(4).Value 'type_of_complt
            dgvcompliant.Item(4, i).Value = rs(2).Value 'date
            dgvcompliant.Item(5, i).Value = rs(3).Value 'time
            dgvcompliant.Item(6, i).Value = rs(11).Value 'tech_name
            dgvcompliant.Item(7, i).Value = rs(8).Value 'status
            dgvcompliant.Item(8, i).Value = rs(1).Value 'id
            dgvcompliant.Item(9, i).Value = rs(5).Value 'rdate
            dgvcompliant.Item(10, i).Value = rs(6).Value 'rtime
            dgvcompliant.Item(11, i).Value = rs(9).Value 'remark
            dgvcompliant.Item(12, i).Value = rs(7).Value 'service_rep_no
            dgvcompliant.Item(13, i).Value = rs(10).Value 'amount

            rs.MoveNext()
            i = i + 1
        Loop

    End Sub

    Private Sub dgvcompliant_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvcompliant.CellContentClick

    End Sub
   
    Private Sub dtpdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdate.ValueChanged
        loadComplieantsDetails()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            sql = "select * from compliant"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            Dim i
            i = 0
            dgvcompliant.Rows.Clear()

            Do While Not rs.EOF
                dgvcompliant.Rows.Add()
                dgvcompliant.Item(0, i).Value = rs(0).Value 'vehicle_no
                dgvcompliant.Item(1, i).Value = rs(12).Value 'priority
                dgvcompliant.Item(2, i).Value = rs(13).Value 'c_no
                dgvcompliant.Item(3, i).Value = rs(4).Value 'type_of_complt
                dgvcompliant.Item(4, i).Value = rs(2).Value 'date
                dgvcompliant.Item(5, i).Value = rs(3).Value 'time
                dgvcompliant.Item(6, i).Value = rs(11).Value 'tech_name
                dgvcompliant.Item(7, i).Value = rs(8).Value 'status
                dgvcompliant.Item(8, i).Value = rs(1).Value 'id
                dgvcompliant.Item(9, i).Value = rs(5).Value 'rdate
                dgvcompliant.Item(10, i).Value = rs(6).Value 'rtime
                dgvcompliant.Item(11, i).Value = rs(9).Value 'remark
                dgvcompliant.Item(12, i).Value = rs(7).Value 'service_rep_no
                dgvcompliant.Item(13, i).Value = rs(10).Value 'amount

                rs.MoveNext()
                i = i + 1
            Loop
        Else
            dgvcompliant.Rows.Clear()
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        sql = "select * from compliant where status='" & ComboBox1.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        dgvcompliant.Rows.Clear()

        Do While Not rs.EOF
            dgvcompliant.Rows.Add()
            dgvcompliant.Item(0, i).Value = rs(0).Value 'vehicle_no
            dgvcompliant.Item(1, i).Value = rs(12).Value 'priority
            dgvcompliant.Item(2, i).Value = rs(13).Value 'c_no
            dgvcompliant.Item(3, i).Value = rs(4).Value 'type_of_complt
            dgvcompliant.Item(4, i).Value = rs(2).Value 'date
            dgvcompliant.Item(5, i).Value = rs(3).Value 'time
            dgvcompliant.Item(6, i).Value = rs(11).Value 'tech_name
            dgvcompliant.Item(7, i).Value = rs(8).Value 'status
            dgvcompliant.Item(8, i).Value = rs(1).Value 'id
            dgvcompliant.Item(9, i).Value = rs(5).Value 'rdate
            dgvcompliant.Item(10, i).Value = rs(6).Value 'rtime
            dgvcompliant.Item(11, i).Value = rs(9).Value 'remark
            dgvcompliant.Item(12, i).Value = rs(7).Value 'service_rep_no
            dgvcompliant.Item(13, i).Value = rs(10).Value 'amount

            rs.MoveNext()
            i = i + 1
        Loop
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        sql = "select * from compliant where tech_name='" & ComboBox2.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        dgvcompliant.Rows.Clear()

        Do While Not rs.EOF
            dgvcompliant.Rows.Add()
            dgvcompliant.Item(0, i).Value = rs(0).Value 'vehicle_no
            dgvcompliant.Item(1, i).Value = rs(12).Value 'priority
            dgvcompliant.Item(2, i).Value = rs(13).Value 'c_no
            dgvcompliant.Item(3, i).Value = rs(4).Value 'type_of_complt
            dgvcompliant.Item(4, i).Value = rs(2).Value 'date
            dgvcompliant.Item(5, i).Value = rs(3).Value 'time
            dgvcompliant.Item(6, i).Value = rs(11).Value 'tech_name
            dgvcompliant.Item(7, i).Value = rs(8).Value 'status
            dgvcompliant.Item(8, i).Value = rs(1).Value 'id
            dgvcompliant.Item(9, i).Value = rs(5).Value 'rdate
            dgvcompliant.Item(10, i).Value = rs(6).Value 'rtime
            dgvcompliant.Item(11, i).Value = rs(9).Value 'remark
            dgvcompliant.Item(12, i).Value = rs(7).Value 'service_rep_no
            dgvcompliant.Item(13, i).Value = rs(10).Value 'amount

            rs.MoveNext()
            i = i + 1
        Loop
    End Sub

    Private Sub dgvcompliant_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvcompliant.DoubleClick
        Dim a
        a = dgvcompliant.CurrentRow.Index

        Cmbtech_name.Text = dgvcompliant.Item(6, a).Value

        cmbvehicle.Text = dgvcompliant.Item(0, a).Value
        Cmbpriority.Text = dgvcompliant.Item(1, a).Value
        If IsDBNull(dgvcompliant.Item(2, a).Value) = False Then
            TxtCno.Text = dgvcompliant.Item(2, a).Value
        End If
        txttyp_of_complt.Text = dgvcompliant.Item(3, a).Value
        Dtpcdate.Value = Convert.ToDateTime(dgvcompliant.Item(4, a).Value)
        dtptime.Value = Convert.ToDateTime(dgvcompliant.Item(5, a).Value)


        Cmbstatus.Text = dgvcompliant.Item(7, a).Value
        lblcid.Text = dgvcompliant.Item(8, a).Value
        dtprdate.Value = Convert.ToDateTime(dgvcompliant.Item(9, a).Value)
        Dtprtime.Value = Convert.ToDateTime(dgvcompliant.Item(10, a).Value)
        If IsDBNull(dgvcompliant.Item(11, a).Value) = False Then
            Txtremark.Text = dgvcompliant.Item(11, a).Value
        End If

        If IsDBNull(dgvcompliant.Item(12, a).Value) = False Then
            Txtrep_no.Text = dgvcompliant.Item(12, a).Value
        End If
        If IsDBNull(dgvcompliant.Item(13, a).Value) = False Then
            Txtamount.Text = dgvcompliant.Item(13, a).Value
        End If
        Btnadd.Enabled = False
    End Sub

    Private Sub Cmbtech_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbtech_name.SelectedIndexChanged

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        If cmbvehicle.Text <> "" And txttyp_of_complt.Text <> "" And Cmbtech_name.Text <> "" Then
            If MsgBox("Do you want to Delete!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "delete from compliant where id =" & lblcid.Text & ""
                conn.Execute(sql)
                MsgBox("Record has been deleted")
                clr()
            End If
            Btndelete.Enabled = False
            Btnadd.Enabled = True
        Else
            MsgBox("Records cannot be deleted")
        End If

    End Sub

    Private Sub TxtCno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCno.TextChanged

    End Sub
End Class