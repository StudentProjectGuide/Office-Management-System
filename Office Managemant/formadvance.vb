Public Class formadvance

    Sub loadadvance()
        sql = "select * from advance where Remaining > 0"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        dgvadvance.Rows.Clear()
        Dim i
        i = 0
        Do While Not rs.EOF
            dgvadvance.Rows.Add()
            dgvadvance.Item(2, i).Value = rs(0).Value 'advance
            dgvadvance.Item(0, i).Value = rs(5).Value 'vehicleno
            dgvadvance.Item(1, i).Value = rs(4).Value 'customer_no

            i = i + 1

            rs.MoveNext()
        Loop


    End Sub

    Private Sub frmadvance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadadvance()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvadvance.CellContentClick

    End Sub
End Class