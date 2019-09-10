Public Class Forminstallation
    Sub loadReportNo()
        sql = "select irno from association"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            CmbinstalRep.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Sub loaddetils()
        If CmbinstalRep.Text <> "" Then
            sql = "select a_id,v_no,customer,u_no,m_no,sim_no from association where IRNO=" & CmbinstalRep.Text & ""

            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                txtassociation.Text = rs(0).Value
                txtcno.Text = rs(2).Value
                TxtMNo.Text = rs(4).Value
                TxtSNo.Text = rs(5).Value
                TxtVNo.Text = rs(1).Value
                TxtUno.Text = rs(3).Value

            End If
        End If
    End Sub

    Private Sub Forminstallation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadReportNo()
        loadinstall()
        loadTech()
        Btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub

    Sub clear()
        CmbinstalRep.Text = ""
        txtassociation.Text = ""
        txtcno.Text = ""
        TxtUno.Text = ""
        TxtMNo.Text = ""
        TxtSNo.Text = ""
        TxtVNo.Text = ""
        TxtDriverName.Text = ""
        txtplace.Text = ""
        Txtremrk.Text = ""
        Cmbtechni.Text = ""

    End Sub
    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        If CmbinstalRep.Text = "" Then
            MsgBox("Kindly select Installation report number")
            Exit Sub
        ElseIf TxtDriverName.Text = "" Then
            MsgBox("Kindly enter Driver name")
            Exit Sub

        ElseIf txtplace.Text = "" Then
            MsgBox("Kindly enter Place of Installation")
            Exit Sub

        ElseIf Cmbtechni.Text = "" Then
            MsgBox("Kindly enter Technician name")
            Exit Sub

        ElseIf Txtremrk.Text = "" Then
            MsgBox("Kindly enter Remark")
            Exit Sub

        End If
        If MsgBox("Do you want to ADD!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "select * from Installation where IR_NO = " & CmbinstalRep.Text & ""
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = True Then
                sql = "insert into Installation(ir_no,ass_no,D_name,DOI,DTime,POI,TName,Remark,customer_no,Vehicle_no,Unit_no,Mobile_no,sim_no) "
                sql = sql & " values(" & CmbinstalRep.Text & ",'" & txtassociation.Text & "','" & TxtDriverName.Text & "',convert(date,'" & dtpdoi.Value & "',103),convert(time(7),'" & dtpItime.Value & "',103),'" & txtplace.Text & "','" & Cmbtechni.Text & "','" & Txtremrk.Text & "','" & txtcno.Text & "','" & TxtVNo.Text & "'," & TxtUno.Text & "," & TxtMNo.Text & "," & TxtSNo.Text & ")"
                conn.Execute(sql)
                MsgBox("Installation details added")
                loadinstall()
                clear()
                Btnadd.Enabled = False
                Btnupdate.Enabled = True
                btndelete.Enabled = True
            Else
                MsgBox("installation report number already exist")
            End If
        End If
    End Sub

    Private Sub CmbinstalRep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbinstalRep.SelectedIndexChanged
        loaddetils()
    End Sub

    Sub loadinstall()

        dgvinstall.Rows.Clear()
        sql = "select * from Installation"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        Do While Not rs.EOF

            dgvinstall.Rows.Add()
            dgvinstall.Item(0, i).Value = rs(0).Value.ToString  'IRNO
            dgvinstall.Item(1, i).Value = rs(1).Value.ToString 'ASS_No
            dgvinstall.Item(2, i).Value = rs(8).Value.ToString 'Cust_No
            dgvinstall.Item(3, i).Value = rs(9).Value.ToString 'Vehicle_no
            dgvinstall.Item(4, i).Value = rs(10).Value.ToString 'Unit_no
            dgvinstall.Item(5, i).Value = rs(11).Value.ToString 'Mobile no
            dgvinstall.Item(6, i).Value = rs(12).Value.ToString 'sim no
            dgvinstall.Item(7, i).Value = rs(2).Value.ToString 'Driver name
            dgvinstall.Item(8, i).Value = rs(3).Value.ToString 'DOI
            dgvinstall.Item(9, i).Value = rs(4).Value.ToString 'Time
            dgvinstall.Item(10, i).Value = rs(5).Value.ToString 'POI
            dgvinstall.Item(11, i).Value = rs(6).Value.ToString 'tech_name
            dgvinstall.Item(12, i).Value = rs(7).Value.ToString 'Remark

            i = i + 1
            rs.MoveNext()
        Loop

    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvinstall.DoubleClick
        Dim a
        a = dgvinstall.CurrentRow.Index
        CmbinstalRep.Text = dgvinstall.Item(0, a).Value 'IRNo
        txtassociation.Text = dgvinstall.Item(1, a).Value 'ass_no
        txtcno.Text = dgvinstall.Item(2, a).Value 'customer_no
        TxtVNo.Text = dgvinstall.Item(3, a).Value 'vehicle_no
        TxtUno.Text = dgvinstall.Item(4, a).Value 'Unit_no
        TxtMNo.Text = dgvinstall.Item(5, a).Value 'Mobile_no
        TxtSNo.Text = dgvinstall.Item(6, a).Value 'sim_no
        TxtDriverName.Text = dgvinstall.Item(7, a).Value  'driver name
        dtpdoi.Value = Convert.ToDateTime(dgvinstall.Item(8, a).Value) 'DOI
        dtpItime.Value = Convert.ToDateTime(dgvinstall.Item(9, a).Value) 'time
        txtplace.Text = dgvinstall.Item(10, a).Value 'place
        Cmbtechni.Text = dgvinstall.Item(11, a).Value 'tech_name
        Txtremrk.Text = dgvinstall.Item(12, a).Value 'remark
        Btnadd.Enabled = False
        Btnupdate.Enabled = True
        btndelete.Enabled = True
    End Sub

    Private Sub CmbinstalRep_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbinstalRep.TextChanged
        loaddetils()
    End Sub

    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupdate.Click
        If CmbinstalRep.Text = "" Then
            MsgBox("Kindly select Installation report number")
            Exit Sub
        ElseIf TxtDriverName.Text = "" Then
            MsgBox("Kindly enter Driver name")
            Exit Sub

        ElseIf txtplace.Text = "" Then
            MsgBox("Kindly enter Place of Installation")
            Exit Sub

        ElseIf Cmbtechni.Text = "" Then
            MsgBox("Kindly enter Technician name")
            Exit Sub

        ElseIf Txtremrk.Text = "" Then
            MsgBox("Kindly enter Remark")
            Exit Sub

        End If
        If MsgBox("Do you want to Update!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "update Installation set ass_no='" & txtassociation.Text & "',D_name='" & TxtDriverName.Text & "',DOI=convert(date,'" & dtpdoi.Value & "',103),Dtime=convert(time(7),'" & dtpItime.Value & "',103),POI='" & txtplace.Text & "',Tname='" & Cmbtechni.Text & "',Remark='" & Txtremrk.Text & "',customer_no='" & txtcno.Text & "',Vehicle_no='" & TxtVNo.Text & "',Unit_no=" & TxtUno.Text & ",Mobile_no=" & TxtMNo.Text & ",sim_no=" & TxtSNo.Text & " where IR_no=" & CmbinstalRep.Text & " "
            conn.Execute(sql)
            MsgBox("Record has been updated")
            loadinstall()
            clear()
            Btnupdate.Enabled = False
            btndelete.Enabled = True
            Btnadd.Enabled = True
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If CmbinstalRep.Text <> "" And TxtDriverName.Text <> "" And txtplace.Text <> "" And Txtremrk.Text <> "" And Cmbtechni.Text <> "" Then
            If MsgBox("Do you want to Delete!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "delete from installation where IR_no=" & CmbinstalRep.Text & ""
                conn.Execute(sql)
                MsgBox("Record has been deleted")
                loadinstall()
                clear()
                btndelete.Enabled = False
                Btnadd.Enabled = True
            End If
        Else
            MsgBox("Records cannot be deleted")
        End If
    End Sub

    Sub loadTech()
        sql = "select uname from login where utype='Technician'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            Cmbtechni.Items.Add(rs(0).Value)

            rs.MoveNext()
        Loop
    End Sub

    Private Sub dgvinstall_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvinstall.CellContentClick

    End Sub
End Class