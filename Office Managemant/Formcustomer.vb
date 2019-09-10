Public Class Formcustomer
    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        If TxtMno.Text <> "" And (Len(TxtMno.Text)) < 10 Then
            MsgBox("Kindly enter valid mobile number")
            Exit Sub
        ElseIf Txtphone.Text <> "" And (Len(Txtphone.Text)) < 7 Then
            MsgBox("Kindly enter valid phone number")
            Exit Sub
        ElseIf TxtMno.Text = "" Or Txtphone.Text = "" Then
            MsgBox("Kindly enter contact Number")
            Exit Sub
        ElseIf txtowner.Text = "" Then
            MsgBox("Kindly enter Owner name")
            Exit Sub
        ElseIf Txtcoordinator.Text = "" Then
            MsgBox("Kindly enter Coordinator name")
            Exit Sub
        ElseIf TxtpNo.Text = "" Then
            MsgBox("Kindly enter Purchase order Number")
            Exit Sub
        ElseIf Txtcompany.Text = "" Then
            MsgBox("Kindly enter Company name")
            Exit Sub
        ElseIf Txtaddr.Text = "" Then
            MsgBox("Kindly enter Address")
            Exit Sub
        End If

        If MsgBox("Do you want to Add!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "insert into customer(cno,cdate,owner_name,email_id,co_name,pu_no,name_compny,phone,address,mobile_no)"
            sql = sql & " values('" & txtCno.Text & "',convert(date,'" & dtpcdate.Value & "',103),'" & txtowner.Text & "','" & Txtemail.Text & "','" & Txtcoordinator.Text & "'," & TxtpNo.Text & ",'" & Txtcompany.Text & "'," & Txtphone.Text & ",'" & Txtaddr.Text & "'," & TxtMno.Text & ")"
            conn.Execute(sql)
            MsgBox("customer details added")

            Dim temp
            temp = Mid(txtCno.Text, 2) + 1
            conn.Execute("update unique_id set id=" & temp & " where bill='Customer'")
            loadcustomer()
            Btnadd.Enabled = False
            Btnupdate.Enabled = True
            clr()

        End If

    End Sub
    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupdate.Click
        If TxtMno.Text <> "" And (Len(TxtMno.Text)) < 10 Then
            MsgBox("Kindly enter valid mobile number")
            Exit Sub
        ElseIf Txtphone.Text <> "" And (Len(Txtphone.Text)) < 7 Then
            MsgBox("Kindly enter valid phone number")
            Exit Sub
        ElseIf TxtMno.Text = "" Or Txtphone.Text = "" Then
            MsgBox("Kindly enter contact Number")
            Exit Sub
        ElseIf txtowner.Text = "" Then
            MsgBox("Kindly enter Owner name")
            Exit Sub
        ElseIf Txtcoordinator.Text = "" Then
            MsgBox("Kindly enter Coordinator name")
            Exit Sub
        ElseIf TxtpNo.Text = "" Then
            MsgBox("Kindly enter Purchase order Number")
            Exit Sub
        ElseIf Txtcompany.Text = "" Then
            MsgBox("Kindly enter Company name")
            Exit Sub
        ElseIf Txtaddr.Text = "" Then
            MsgBox("Kindly enter Address")
            Exit Sub
        End If

        If MsgBox("Do you want to Update!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "update customer set owner_name='" & txtowner.Text & "',email_id='" & Txtemail.Text & "',co_name='" & Txtcoordinator.Text & "',cdate=convert(date,'" & dtpcdate.Value & "',103),pu_no=" & TxtpNo.Text & ",name_compny='" & Txtcompany.Text & "',phone=" & Txtphone.Text & ",address='" & Txtaddr.Text & "',mobile_no=" & TxtMno.Text & " where Cno='" & txtCno.Text & "' "
            conn.Execute(sql)
            MsgBox("Record has been updated")
            loadcustomer()
            clr()
            Btnupdate.Enabled = False
            Btndelete.Enabled = True

        End If

    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        If Lblcno.Text <> "" And txtowner.Text <> "" And Txtemail.Text <> "" And Txtcoordinator.Text <> "" And TxtpNo.Text <> "" And Txtcompany.Text <> "" And Txtphone.Text <> "" And Txtaddr.Text <> "" And TxtMno.Text <> "" Then
            If MsgBox("Do you want to Delete!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "delete from customer where Cno= '" & txtCno.Text & "'"
                conn.Execute(sql)
                MsgBox("Record has been deleted")
                loadcustomer()
                clr()
                Btndelete.Enabled = False
                Btnnew.Enabled = True

            End If
        Else
            MsgBox(" Records cannot be deleted")
        End If
    End Sub
    Sub clr()
        txtCno.Text = ""
        txtowner.Text = ""
        Txtemail.Text = ""
        Txtcoordinator.Text = ""
        TxtpNo.Text = ""
        Txtcompany.Text = ""
        Txtphone.Text = ""
        Txtaddr.Text = ""
        TxtMno.Text = ""
    End Sub
    Sub loadcustomer()
        dgvcustomer.Rows.Clear()
        sql = "select * from customer"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        Do While Not rs.EOF
            dgvcustomer.Rows.Add()
            dgvcustomer.Item(0, i).Value = rs(9).Value.ToString  'cid
            dgvcustomer.Item(1, i).Value = rs(0).Value.ToString  'cdate
            dgvcustomer.Item(2, i).Value = rs(1).Value.ToString 'owner_name
            dgvcustomer.Item(3, i).Value = rs(2).Value.ToString 'email
            dgvcustomer.Item(4, i).Value = rs(3).Value.ToString 'co_name
            dgvcustomer.Item(5, i).Value = rs(4).Value.ToString 'purchase_order_no
            dgvcustomer.Item(6, i).Value = rs(5).Value.ToString 'name_compny
            dgvcustomer.Item(7, i).Value = rs(6).Value.ToString 'phone
            dgvcustomer.Item(8, i).Value = rs(7).Value.ToString 'address
            dgvcustomer.Item(9, i).Value = rs(8).Value.ToString 'mobile_no
            i = i + 1
            rs.MoveNext()
        Loop
    End Sub

    Private Sub dgvcustomer_CellMouseEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvcustomer.CellMouseEnter

    End Sub

    Private Sub dgvcustomer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvcustomer.DoubleClick
        Dim a
        a = dgvcustomer.CurrentRow.Index
        txtCno.Text = dgvcustomer.Item(0, a).Value
        txtowner.Text = dgvcustomer.Item(2, a).Value
        Txtemail.Text = dgvcustomer.Item(3, a).Value
        Txtcoordinator.Text = dgvcustomer.Item(4, a).Value
        dtpcdate.Value = Convert.ToDateTime(dgvcustomer.Item(1, a).Value)
        TxtpNo.Text = dgvcustomer.Item(5, a).Value
        Txtcompany.Text = dgvcustomer.Item(6, a).Value
        Txtphone.Text = dgvcustomer.Item(7, a).Value
        Txtaddr.Text = dgvcustomer.Item(8, a).Value
        TxtMno.Text = dgvcustomer.Item(9, a).Value
        Btnnew.Enabled = False
        Btnadd.Enabled = False
        Btnupdate.Enabled = True
        Btndelete.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnew.Click
        sql = "select * from unique_id where bill='Customer'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtCno.Text = rs(1).Value & rs(2).Value
        End If
        Btnnew.Enabled = False
        Btnadd.Enabled = True
    End Sub
    Sub loadVehicle()
        sql = "select * from vehicle where cno='" & txtCno.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)

        Dim i
        i = 0
        DgVehicle.Rows.Clear()
        Do While Not rs.EOF
            DgVehicle.Rows.Add()
            DgVehicle.Item(0, i).Value = rs(1).Value
            DgVehicle.Item(1, i).Value = rs(2).Value
            DgVehicle.Item(2, i).Value = rs(3).Value
            DgVehicle.Item(3, i).Value = rs(4).Value
            i = i + 1
            rs.MoveNext()
        Loop
    End Sub

    Private Sub Formcustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Btnadd.Enabled = False
        Btnupdate.Enabled = False
        Btndelete.Enabled = False
        loadcustomer()
    End Sub

    Sub calRate()
        txtTotal.Text = (Val(txtRate.Text) * Val(CmbTax.Text) / 100) + Val(txtRate.Text)
    End Sub

    Private Sub txtRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRate.TextChanged
        calRate()
    End Sub

    Private Sub CmbTax_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTax.SelectedIndexChanged
        calRate()
    End Sub

    Private Sub txtCno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCno.TextChanged
        loadVehicle()
    End Sub

    Private Sub BtnVadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVadd.Click
        If TxtVehicleNo.Text = "" Then
            MsgBox("Kindly Enter Vehicle number")
            Exit Sub
        ElseIf txtRate.Text = "" Then
            MsgBox("Kindly Enter Rate")
            Exit Sub
        ElseIf CmbTax.Text = "" Then
            MsgBox("Kindly select tax")
            Exit Sub
        End If

        If MsgBox("Do you want to Add!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "insert into vehicLE(CNo,Vehicle_no,rate,tax,total) VALUES('" & txtCno.Text & "','" & TxtVehicleNo.Text & "'," & txtRate.Text & "," & CmbTax.Text & ",'" & txtTotal.Text & "' )"
            conn.Execute(sql)
            MsgBox("Vehicle details Added")
            TxtVehicleNo.Text = ""
            txtRate.Text = "0"
            txtTotal.Text = "0"
            CmbTax.Text = "0"
            loadVehicle()
        End If
    End Sub

    Private Sub Btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnedit.Click
        If TxtVehicleNo.Text = "" Then
            MsgBox("Kindly Enter Vehicle number")
            Exit Sub
        ElseIf txtRate.Text = "" Then
            MsgBox("Kindly Enter Rate")
            Exit Sub
        ElseIf CmbTax.Text = "" Then
            MsgBox("Kindly select tax")
            Exit Sub
        End If
        If MsgBox("Do you want to Update!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "update vehicle set Rate= " & txtRate.Text & ",tax = " & CmbTax.Text & ", total ='" & txtTotal.Text & "' where  CNo='" & txtCno.Text & "' and Vehicle_no='" & TxtVehicleNo.Text & "'"
            conn.Execute(sql)
            MsgBox("Vehicle details has been updated")
            loadVehicle()
        End If
    End Sub

    Private Sub Btndelet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelet.Click
        If TxtVehicleNo.Text <> "" And txtRate.Text <> "" And CmbTax.Text <> "" Then
            If MsgBox("Do you want to Delete!!!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sql = "delete from vehicle where Cno='" & txtCno.Text & "' and Vehicle_no='" & TxtVehicleNo.Text & "'"
                conn.Execute(sql)
                MsgBox("Vehicle details has been deleted")
                loadVehicle()
            End If
        Else
            MsgBox("Records cannot be Deleted")
        End If
    End Sub

    Private Sub DgVehicle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgVehicle.DoubleClick
        Dim a
        a = DgVehicle.CurrentRow.Index
        TxtVehicleNo.Text = DgVehicle.Item(0, a).Value
        TxtVehicleNo.Enabled = False

        txtRate.Text = DgVehicle.Item(1, a).Value
        CmbTax.Text = DgVehicle.Item(2, a).Value
        txtTotal.Text = DgVehicle.Item(3, a).Value
        BtnVadd.Enabled = False
    End Sub

    Private Sub TxtpNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtpNo.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

  

  
    Private Sub dgvcustomer_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvcustomer.CellContentClick

    End Sub
End Class