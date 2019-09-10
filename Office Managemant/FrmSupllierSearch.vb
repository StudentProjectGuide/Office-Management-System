Public Class FrmSupplierSearch

    Private Sub FrmSupllierSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub loadSupplier()
        DgSupplier.Rows.Clear()
        sql = "select * from Suppliers where s_type='" & cmbType.Text & "'"

        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0

        Do While Not rs.EOF
            DgSupplier.Rows.Add()
            DgSupplier.Item(0, i).Value = rs(2).Value
            DgSupplier.Item(1, i).Value = rs(3).Value
            DgSupplier.Item(2, i).Value = rs(4).Value
            DgSupplier.Item(3, i).Value = rs(5).Value
            DgSupplier.Item(4, i).Value = rs(6).Value
            DgSupplier.Item(5, i).Value = rs(7).Value
            DgSupplier.Item(6, i).Value = rs(0).Value

            rs.MoveNext()
            i = i + 1
        Loop

    End Sub



    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        loadSupplier()
    End Sub

    Private Sub DgSupplier_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgSupplier.CellContentClick

    End Sub

    Private Sub DgSupplier_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgSupplier.DoubleClick
        Dim a
        a = DgSupplier.CurrentRow.Index
        With Formsupp
            .Cmbstype.Text = cmbType.Text
            .txtsname.Text = DgSupplier.Item(0, a).Value()
            .txtphone.Text = DgSupplier.Item(1, a).Value()
            .txtcname.Text = DgSupplier.Item(2, a).Value()
            .txtaddr.Text = DgSupplier.Item(3, a).Value()
            .txtemail.Text = DgSupplier.Item(4, a).Value()
            .txtdesg.Text = DgSupplier.Item(5, a).Value()
            .lblId.Text = DgSupplier.Item(6, a).Value()
            .Btnad.Enabled = False
            .Btnadd.Enabled = False
            .Btnnew.Visible = True
            .Btnadd.Visible = True
            .Btnedit.Visible = True
            .Btndelete.Visible = True
            .Btnedt.Enabled = True
            .Btndelet.Enabled = True
        End With
        Me.Close()
    End Sub
End Class