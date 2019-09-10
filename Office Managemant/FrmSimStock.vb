Public Class FrmSimStock

    Private Sub FrmSimStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "(select sim_no from sim) except select sim_no from association"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        dgv1.Rows.Clear()
        Dim i
        i = 0
        Do While Not rs.EOF
            dgv1.Rows.Add()
            sql = "select  * from sim where sim_no=" & rs(0).Value & ""
            If rss.State = 1 Then rss.Close()
            rss.Open(sql, conn)
            If rss.EOF = False Then
                dgv1.Item(0, i).Value = rss(0).Value
                dgv1.Item(1, i).Value = rss(1).Value

                dgv1.Item(2, i).Value = rss(2).Value

                dgv1.Item(3, i).Value = rss(3).Value
                dgv1.Item(4, i).Value = rss(4).Value
                dgv1.Item(5, i).Value = rss(5).Value
                i = i + 1
            End If
            rs.MoveNext()
        Loop
        lblsim.Text = i

    End Sub

    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
End Class