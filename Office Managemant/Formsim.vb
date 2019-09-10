Public Class Formsim

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        If Cmbsname.Text = "" Then
            MsgBox("Kindly Select Supplier name")
            Exit Sub
        ElseIf CmbPname.Text = "" Then
            MsgBox("Kindly Select Plan")
            Exit Sub

        ElseIf CmbMno.Text = "" Then
            MsgBox("Kindly Select Mobile number")
            Exit Sub

        ElseIf txtSimno.Text = "" Then
            MsgBox("Kindly enter Sim number")
            Exit Sub

        ElseIf txtchanlno.Text = "" Then
            MsgBox("Kindly enter Delivery channel number")
            Exit Sub
        End If
        If MsgBox("Do you want to Add!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "insert into sim(s_name,splan,mobile_no,sim_no,doa,dcn)"
            sql = sql & " values('" & Cmbsname.Text & "'," & CmbPname.Text & ", " & CmbMno.Text & "," & txtSimno.Text & ",convert(date,'" & dtpdoa.Value & "',103)," & txtchanlno.Text & ")"
            conn.Execute(sql)
            MsgBox("Sim details added")
            clr()
            Btnadd.Enabled = False
            Btnupdate.Enabled = True
        End If
    End Sub

    Sub clr()
        Cmbsname.Text = ""
        CmbPname.Text = ""
        CmbMno.Text = ""
        txtSimno.Text = ""
        txtchanlno.Text = ""
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvsim.DoubleClick
        Dim a
        a = dgvsim.CurrentRow.Index
        lblsid.Text = dgvsim.Item(0, a).Value
        Cmbsname.Text = dgvsim.Item(1, a).Value
        CmbPname.Text = dgvsim.Item(2, a).Value
        CmbMno.Text = dgvsim.Item(3, a).Value
        txtSimno.Text = dgvsim.Item(4, a).Value
        txtchanlno.Text = dgvsim.Item(6, a).Value
        dtpdoa.Value = Convert.ToDateTime(dgvsim.Item(5, a).Value)
        Btnadd.Enabled = False
        Btnupdate.Enabled = True
        btndelete.Enabled = True
    End Sub

    Private Sub Formsim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadsim()
        loadSimSup()
    End Sub
    Sub loadSimSup()
        sql = "select * from Suppliers where s_type='SIM'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            Cmbsname.Items.Add(rs(2).Value)
            rs.MoveNext()
        Loop

    End Sub
    Sub loadPlan()
        sql = "select splan from S_product where s_id=" & lblsid.Text & ""
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        CmbPname.Items.Clear()

        Do While Not rs.EOF
            CmbPname.Items.Add(rs(0).Value)

            rs.MoveNext()

        Loop
    End Sub
    Sub loadMobile()
        sql = "select mobile_no from S_product where s_id=" & lblsid.Text & " and splan=" & CmbPname.Text & " except (select mobile_no from sim where sid=" & lblsid.Text & " and splan=" & CmbPname.Text & ")"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        CmbMno.Items.Clear()
        Do While Not rs.EOF
            CmbMno.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Sub loadID()
        sql = "select id from Suppliers where s_name='" & Cmbsname.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            lblsid.Text = rs(0).Value
        End If
    End Sub
    Sub loadsim()
        dgvsim.Rows.Clear()
        sql = "select * from sim"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        Do While Not rs.EOF

            dgvsim.Rows.Add()
            dgvsim.Item(0, i).Value = rs(6).Value.ToString  'sid
            dgvsim.Item(1, i).Value = rs(0).Value.ToString 's_name
            dgvsim.Item(2, i).Value = rs(1).Value.ToString 'splan
            dgvsim.Item(3, i).Value = rs(2).Value.ToString 'mobile_no
            dgvsim.Item(4, i).Value = rs(3).Value.ToString 'sim_no
            dgvsim.Item(5, i).Value = rs(4).Value.ToString 'doa
            dgvsim.Item(6, i).Value = rs(5).Value.ToString 'dcn
            i = i + 1
            rs.MoveNext()
        Loop
    End Sub

    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupdate.Click
        If Cmbsname.Text = "" Then
            MsgBox("Kindly Select Supplier name")
            Exit Sub
        ElseIf CmbPname.Text = "" Then
            MsgBox("Kindly Select Plan")
            Exit Sub

        ElseIf CmbMno.Text = "" Then
            MsgBox("Kindly Select Mobile number")
            Exit Sub

        ElseIf txtSimno.Text = "" Then
            MsgBox("Kindly enter Sim number")
            Exit Sub

        ElseIf txtchanlno.Text = "" Then
            MsgBox("Kindly enter Delivery channel number")
            Exit Sub
        End If
        If MsgBox("Do you want to Update!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "update sim set s_name='" & Cmbsname.Text & "',splan=" & CmbPname.Text & ",mobile_no=" & CmbMno.Text & ",sim_no = " & txtSimno.Text & ",doa=convert(date,'" & dtpdoa.Value & "',103) where sid=" & lblsid.Text & ""
            conn.Execute(sql)
            MsgBox("Record has been updated")
            loadsim()
            clr()
            btndelete.Enabled = True
            Btnupdate.Enabled = False
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If Cmbsname.Text <> "" And CmbPname.Text <> "" And CmbMno.Text <> "" And txtSimno.Text <> "" And txtchanlno.Text <> "" Then
            If MsgBox("Do you want to Delete!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "delete from sim where sid= " & lblsid.Text & ""
                conn.Execute(sql)
                MsgBox("Record has been deleted")
                loadsim()
                clr()
                btndelete.Enabled = False
                Btnadd.Enabled = True
            End If
        Else
            MsgBox("Records cannot be deleted")
        End If

    End Sub


    Private Sub Cmbsname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbsname.SelectedIndexChanged
        loadID()
        loadPlan()
    End Sub

    Private Sub CmbPname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPname.SelectedIndexChanged
        loadMobile()
    End Sub

    Private Sub txtchanlno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchanlno.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSimno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSimno.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

  
End Class