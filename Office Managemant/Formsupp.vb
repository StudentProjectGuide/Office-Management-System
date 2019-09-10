Imports System.Text.RegularExpressions

Public Class Formsupp
    Private Sub Cmbstype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbstype.SelectedIndexChanged
        If Cmbstype.Text = "Hardware" Then
            txtmobile.Visible = False
            txtplan.Visible = False
            txtmodel.Visible = True
            Label8.Visible = False
            Label10.Visible = False
            Label11.Visible = True
        Else
            txtmobile.Visible = True
            txtplan.Visible = True
            txtmodel.Visible = False
            Label8.Visible = True
            Label10.Visible = True
            Label11.Visible = False
            Label12.Visible = False
            txtmfrname.Visible = False

        End If
    End Sub

    Private Sub Btnad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnad.Click
        EmailAddressCheck(txtemail.Text)
        If a = True Then
            Exit Sub

        End If
        If txtphone.Text <> "" And (Len(txtphone.Text)) < 7 Then
            MsgBox("Kindly enter valid phone number")
            Exit Sub
        ElseIf txtsname.Text = "" Then
            MsgBox("Kindly enter Supplier name")
            Exit Sub

        ElseIf txtphone.Text = "" Then
            MsgBox("Kindly enter Phone number")
            Exit Sub

        ElseIf txtcname.Text = "" Then
            MsgBox("Kindly enter Coordinator name")
            Exit Sub
        ElseIf txtaddr.Text = "" Then
            MsgBox("Kindly enter Address")
            Exit Sub
        ElseIf txtemail.Text = "" Then
            MsgBox("Kindly enter E_mail address")
            Exit Sub
        ElseIf txtdesg.Text = "" Then
            MsgBox("Kindly enter Designation")
            Exit Sub

        End If

        If MsgBox("Do you want to Add!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "insert into Suppliers(s_type,s_name,s_phone,s_cname,s_add,s_email,s_design)"
            sql = sql & " values('" & Cmbstype.Text & "','" & txtsname.Text & "'," & txtphone.Text & ",'" & txtcname.Text & "','" & txtaddr.Text & "','" & txtemail.Text & "','" & txtdesg.Text & "')"
            conn.Execute(sql)
            MsgBox("Supplier Added")
            loadId()
            clr()
            Btnad.Enabled = False
            Btnedt.Enabled = True
            Btndelet.Enabled = True
            Btnedt.Enabled = True
            Btnadd.Visible = True
            Btnedit.Visible = True
            Btndelete.Visible = True
        End If
    End Sub
    Sub clr()
        Cmbstype.Text = ""
        txtsname.Text = ""
        txtphone.Text = ""
        txtcname.Text = ""
        txtaddr.Text = ""
        txtemail.Text = ""
        txtdesg.Text = ""
    End Sub
    Private Sub Btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsearch.Click
        FrmSupplierSearch.Show()
    End Sub

    Private Sub Btnedt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnedt.Click

        If txtphone.Text <> "" And (Len(txtphone.Text)) < 7 Then
            MsgBox("Kindly enter valid phone number")
            Exit Sub
        ElseIf txtsname.Text = "" Then
            MsgBox("Kindly enter Supplier name")
            Exit Sub

        ElseIf txtphone.Text = "" Then
            MsgBox("Kindly enter Phone number")
            Exit Sub

        ElseIf txtcname.Text = "" Then
            MsgBox("Kindly enter Coordinator name")
            Exit Sub
        ElseIf txtaddr.Text = "" Then
            MsgBox("Kindly enter Address")
            Exit Sub
        ElseIf txtemail.Text = "" Then
            MsgBox("Kindly enter E_mail address")
            Exit Sub
        ElseIf txtdesg.Text = "" Then
            MsgBox("Kindly enter Designation")
            Exit Sub
        Else
            If MsgBox("Do you want to Update!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "update Suppliers set s_name='" & txtsname.Text & "',s_phone=" & txtphone.Text & ",s_cname='" & txtcname.Text & "',s_add='" & txtaddr.Text & "',s_email='" & txtemail.Text & "',s_design='" & txtdesg.Text & "' where id=" & lblId.Text & ""
                conn.Execute(sql)
                MsgBox("Record has been Updated")
                clr()
                Btnedt.Enabled = False
                Btndelet.Enabled = True
                Btnad.Enabled = True
            End If
        End If
    End Sub

    Private Sub Btndelet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelet.Click
        If Cmbstype.Text <> "" And txtsname.Text <> "" And txtphone.Text <> "" And txtcname.Text <> "" And txtdesg.Text <> "" And txtemail.Text <> "" And txtaddr.Text <> "" Then
            If MsgBox("Do you want to Delete!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "delete from suppliers where id=" & lblId.Text & ""
                conn.Execute(sql)
                MsgBox("Record has been deleted")
                clr()
                Btndelet.Enabled = False
                Btnad.Enabled = True
            End If
        Else
            MsgBox("Record cannot be deleted")
        End If
    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        If Cmbstype.Text = "Hardware" Then
            txtmobile.Visible = False
            txtplan.Visible = False
            txtmodel.Visible = True
            Label8.Visible = False
            Label10.Visible = False
            Label11.Visible = True
        Else
            txtmobile.Visible = True
            txtplan.Visible = True
            txtmodel.Visible = False
            Label8.Visible = True
            Label10.Visible = True
            Label11.Visible = False
            Label12.Visible = False
            txtmfrname.Visible = False

            If txtmobile.Text <> "" And (Len(txtmobile.Text)) < 10 Then
                MsgBox("Kindly enter valid Mobile Number")
                Exit Sub
            End If
        End If
        If MsgBox("Do you want to Add!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If lblId.Text = "" Then
                MsgBox("Kindly save supplier details!!")
            Else
                sql = "insert into s_product(p_name,splan,model,m_name,rate,mobile_no,tax,total,sdate,s_id)"
                sql = sql & " values('" & txtprod.Text & "'," & txtplan.Text & ",'" & txtmodel.Text & "','" & txtmfrname.Text & "'," & txtrate.Text & "," & txtmobile.Text & "," & txttax.Text & "," & txttotal.Text & ",convert(date,'" & DtpDate.Value & "',103)," & lblId.Text & ")"
                conn.Execute(sql)
                MsgBox("Product Added")
                loadProducts()
                clear()
                Btnadd.Enabled = False
                Btnedit.Enabled = True
            End If
        End If
    End Sub

    Sub loadProducts()
        dgvProducts.Rows.Clear()

        sql = "select * from s_product where s_id=" & lblId.Text & ""
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)

        Dim i
        i = 0
        Do While Not rs.EOF
            dgvProducts.Rows.Add()
            dgvProducts.Item(0, i).Value = rs(1).Value.ToString 'mobile
            dgvProducts.Item(1, i).Value = rs(5).Value.ToString 'manufacture
            dgvProducts.Item(2, i).Value = rs(2).Value.ToString 'product name
            dgvProducts.Item(3, i).Value = rs(4).Value.ToString 'model
            dgvProducts.Item(4, i).Value = rs(3).Value.ToString 'plan
            dgvProducts.Item(5, i).Value = rs(6).Value.ToString 'rate
            dgvProducts.Item(6, i).Value = rs(7).Value.ToString 'tax
            dgvProducts.Item(7, i).Value = rs(8).Value.ToString 'total
            dgvProducts.Item(8, i).Value = rs(10).Value.ToString 'sid
            i = i + 1
            rs.MoveNext()
        Loop

    End Sub
    Sub loadAmount()
        txttotal.Text = Val(txtrate.Text) + (Val(txtrate.Text) * Val(txttax.Text) / 100)
    End Sub

    Private Sub txtrate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrate.TextChanged
        loadAmount()
    End Sub

    Private Sub txttax_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttax.SelectedIndexChanged
        loadAmount()
    End Sub

    Sub loadId()
        sql = "select * from suppliers where s_type='" & Cmbstype.Text & "' and s_name='" & txtsname.Text & "' and s_phone=" & txtphone.Text & ""
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            lblId.Text = rs(0).Value
        End If
    End Sub

    Private Sub dgvProducts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvProducts.DoubleClick
        Dim a
        a = dgvProducts.CurrentRow.Index
        txtmobile.Text = dgvProducts.Item(0, a).Value
        txtmfrname.Text = dgvProducts.Item(1, a).Value
        txtprod.Text = dgvProducts.Item(2, a).Value
        txtmodel.Text = dgvProducts.Item(3, a).Value
        txtplan.Text = dgvProducts.Item(4, a).Value
        txtrate.Text = dgvProducts.Item(5, a).Value
        txttax.Text = dgvProducts.Item(6, a).Value
        txttotal.Text = dgvProducts.Item(7, a).Value
        lblpid.Text = dgvProducts.Item(8, a).Value
        Btnadd.Enabled = False

    End Sub

    Private Sub lblId_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblId.TextChanged
        loadProducts()
    End Sub

    Private Sub Btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnedit.Click
        'If txtrate.Text <> "" And txttax.Text <> "" And txtmfrname.Text <> "" And txtmobile.Text <> "" And txtprod.Text <> "" And txtplan.Text <> "" And txtmodel.Text <> "" Then
        If MsgBox("Do you want to Update!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "update s_product set mobile_no=" & txtmobile.Text & ",p_name='" & txtprod.Text & "',splan=" & txtplan.Text & ",model='" & txtmodel.Text & "',rate=" & txtrate.Text & ",tax=" & txttax.Text & ",total=" & txttotal.Text & " where id=" & lblpid.Text & " "
            conn.Execute(sql)
            MsgBox("Record has been Updated")
            loadProducts()
            clear()
            Btnedit.Enabled = False
            Btndelete.Enabled = True
        End If
        'Else
        'MsgBox("Kindly enter all the fields")
        'End If
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        'If txtrate.Text <> "" And txttax.Text <> "" And txtmfrname.Text <> "" And txtmobile.Text <> "" And txtprod.Text <> "" And txtplan.Text <> "" And txtmodel.Text <> "" Then
        If MsgBox("Do you want to Delete!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If lblpid.Text <> "" Then
                sql = "delete from s_product where id=" & lblpid.Text & ""
                conn.Execute(sql)
                MsgBox("Record has been deleted")
                loadProducts()
                clear()
                Btndelete.Enabled = False
                Btnadd.Enabled = True
            End If
        End If
        'Else
        'MsgBox("Records cannot be deleted")
        'End If

    End Sub


    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If

        If EmailAddressCheck = False Then
            MsgBox("Kindly enter valid email id")
            a = True
        Else
            a = False
        End If
    End Function
    Dim a As Boolean

    Private Sub Formsupp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgvProducts.Rows.Clear()
        Btnnew.Visible = False
        Btnadd.Visible = False
        Btnedit.Visible = False
        Btndelete.Visible = False
        Btnedt.Enabled = False
        Btndelet.Enabled = False
    End Sub

    Private Sub txtphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Sub clear()
        txtmobile.Text = ""
        txtprod.Text = ""
        txtplan.Text = ""
        txtmodel.Text = ""
        txtmfrname.Text = ""
        txtrate.Text = ""
        txttax.Text = ""
        txttotal.Text = ""
    End Sub

    Private Sub Btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnew.Click
        Btnad.Enabled = True
        Btnadd.Enabled = True
        clr()
        clear()
    End Sub

    Private Sub lblId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblId.Click

    End Sub

    Private Sub txtphone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtphone.TextChanged

    End Sub

    Private Sub dgvProducts_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

    End Sub
End Class