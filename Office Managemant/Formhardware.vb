Public Class Formhardware
    Private Sub Formhardware_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadmodel()
        loadhardware()
        Btnupdate.Enabled = False
        Btndelete.Enabled = False
    End Sub

    Sub loadmodel()
        sql = "select model from s_product"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)

        Do While Not rs.EOF
            Cmbmodname.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop

    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        If Cmbmodname.Text = "" Then
            MsgBox("Kindly select Model name")
            Exit Sub

        ElseIf Cmbaccer.Text = "" Then
            MsgBox("Kindly select Accesories")
            Exit Sub
        ElseIf txtunitno.Text = "" Then
            MsgBox("Kindly enter Unit number")
            Exit Sub

        ElseIf txtchanlno.Text = "" Then
            MsgBox("Kindly enter Delivery channel number")
            Exit Sub
        End If
        If MsgBox("Do you want to Add!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "insert into hardware(m_name,acce,unit_no,dcn,hdate)"
            sql = sql & " values('" & Cmbmodname.Text & "','" & Cmbaccer.Text & "'," & txtunitno.Text & "," & txtchanlno.Text & ",convert(date,'" & Dtpdate.Value & "',103))"
            conn.Execute(sql)
            MsgBox("Hardware details added")
            loadhardware()
            clr()
            Btnadd.Enabled = False
            Btnupdate.Enabled = True
            Btndelete.Enabled = True
        End If
    End Sub

    Sub clr()
        Cmbmodname.Text = ""
        Cmbaccer.Text = ""
        txtunitno.Text = ""
        txtchanlno.Text = ""
    End Sub
    Sub loadhardware()
        dgvhw.Rows.Clear()
        sql = "select * from hardware"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        Do While Not rs.EOF
            dgvhw.Rows.Add()
            dgvhw.Item(0, i).Value = rs(4).Value.ToString  'id
            dgvhw.Item(1, i).Value = rs(5).Value.ToString 'date
            dgvhw.Item(2, i).Value = rs(0).Value.ToString 'm_name
            dgvhw.Item(3, i).Value = rs(1).Value.ToString 'accer
            dgvhw.Item(4, i).Value = rs(2).Value.ToString 'u_no
            dgvhw.Item(5, i).Value = rs(3).Value.ToString 'dcn

            i = i + 1
            rs.MoveNext()
        Loop

    End Sub
    

    Private Sub Btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupdate.Click
        If Cmbmodname.Text = "" Then
            MsgBox("Kindly select Model name")
            Exit Sub

        ElseIf Cmbaccer.Text = "" Then
            MsgBox("Kindly select Accesories")
            Exit Sub
        ElseIf txtunitno.Text = "" Then
            MsgBox("Kindly enter Unit number")
            Exit Sub

        ElseIf txtchanlno.Text = "" Then
            MsgBox("Kindly enter Delivery channel number")
            Exit Sub
        End If
        If MsgBox("Do you want to Update!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "update hardware set m_name= '" & Cmbmodname.Text & "',acce='" & Cmbaccer.Text & "',unit_no=" & txtunitno.Text & ",dcn=" & txtchanlno.Text & ",hdate=convert(date,'" & Dtpdate.Value & "',103) where hid=" & lblhid.Text & " "
            conn.Execute(sql)
            MsgBox("Record has been updated")
            loadhardware()
            clr()
            Btnupdate.Enabled = False
            Btndelete.Enabled = True
            'Btnadd.Enabled = True
        End If
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        If Cmbmodname.Text <> "" And Cmbaccer.Text <> "" And txtunitno.Text <> "" And txtchanlno.Text <> "" Then
            If MsgBox("Do you want to Delete!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "delete from hardware where hid= " & lblhid.Text & ""
                conn.Execute(sql)
                MsgBox("Record has been deleted")
                loadhardware()
                clr()
                Btnadd.Enabled = True
                Btndelete.Enabled = False
            End If

        Else
            MsgBox("Records cannot be deleted")
        End If
    End Sub

    Private Sub dgvhw_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvhw.DoubleClick
        Dim a
        a = dgvhw.CurrentRow.Index
        lblhid.Text = dgvhw.Item(0, a).Value
        Cmbmodname.Text = dgvhw.Item(2, a).Value
        Cmbaccer.Text = dgvhw.Item(3, a).Value
        txtunitno.Text = dgvhw.Item(4, a).Value
        txtchanlno.Text = dgvhw.Item(5, a).Value
        Dtpdate.Value = Convert.ToDateTime(dgvhw.Item(1, a).Value)
        Btnadd.Enabled = False
        Btnupdate.Enabled = True
        Btndelete.Enabled = True

    End Sub

    Private Sub txtunitno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtunitno.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtchanlno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchanlno.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

   
    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class