Public Class Formstaff

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        sql = "insert into login values('" & Cmbdesig.Text & "','" & Txtname.Text & "','" & Txtpasswd.Text & "')"
        conn.Execute(sql)
        MsgBox("Record Added!!!")
        Txtname.Text = ""
        Txtpasswd.Text = ""
        Cmbdesig.Text = ""
        loaddata()
    End Sub

    Private Sub Formstaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Sub loaddata()
        sql = "select * from login"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i

        i = 0
        DataGridView1.Rows.Clear()
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(1).Value
            DataGridView1.Item(1, i).Value = rs(0).Value
            i = i + 1
            rs.MoveNext()
        Loop
    End Sub
End Class