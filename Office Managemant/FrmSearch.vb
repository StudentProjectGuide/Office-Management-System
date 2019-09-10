Public Class FrmSearch

    Private Sub txtconsumerNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconsumerNo.TextChanged
        txtconsumerNo.Text = UCase(txtconsumerNo.Text)
        txtconsumerNo.SelectionStart = Len(txtconsumerNo.Text)
        Dim mt
        mt = txtconsumerNo.Text
        dgv1.Rows.Clear()
        sql = "select distinct(association.V_No),customer.cno,customer.owner_name,customer.address,customer.phone,association.u_no,association.m_no,convert(char(10),association.date,106),association.status from customer left join association on customer.Cno = association.Customer where customer.CNo like '%" & mt & "%'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        Do While Not rs.EOF
            dgv1.Rows.Add()
            dgv1.Item(0, i).Value = rs(0).Value
            dgv1.Item(1, i).Value = rs(1).Value
            dgv1.Item(2, i).Value = rs(2).Value
            dgv1.Item(3, i).Value = rs(3).Value
            dgv1.Item(4, i).Value = rs(4).Value
            dgv1.Item(5, i).Value = rs(5).Value
            dgv1.Item(6, i).Value = rs(6).Value
            dgv1.Item(7, i).Value = rs(7).Value
            dgv1.Item(8, i).Value = rs(8).Value

            i = i + 1
            rs.MoveNext()

        Loop
    End Sub

    Private Sub FrmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select distinct(association.V_No),customer.cno,customer.owner_name,customer.address,customer.phone,association.u_no,association.m_no,convert(char(10),association.date,106),association.status from customer left join association on customer.Cno = association.Customer  order by customer.owner_name"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        Do While Not rs.EOF
            dgv1.Rows.Add()
            dgv1.Item(0, i).Value = rs(0).Value
            dgv1.Item(1, i).Value = rs(1).Value
            dgv1.Item(2, i).Value = rs(2).Value
            dgv1.Item(3, i).Value = rs(3).Value
            dgv1.Item(4, i).Value = rs(4).Value
            dgv1.Item(5, i).Value = rs(5).Value
            dgv1.Item(6, i).Value = rs(6).Value
            dgv1.Item(7, i).Value = rs(7).Value
            dgv1.Item(8, i).Value = rs(8).Value



            i = i + 1
            rs.MoveNext()

        Loop
    End Sub

    Private Sub txtvehicleNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvehicleNo.TextChanged
        txtvehicleNo.Text = UCase(txtvehicleNo.Text)
        txtvehicleNo.SelectionStart = Len(txtvehicleNo.Text)
        Dim mt
        mt = txtvehicleNo.Text
        dgv1.Rows.Clear()
        sql = "select distinct(association.V_No),customer.cno,customer.owner_name,customer.address,customer.phone,association.u_no,association.m_no,convert(char(10),association.date,106),association.status from customer left join association on customer.Cno = association.Customer  where association.V_No  like '%" & mt & "%'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        Do While Not rs.EOF
            dgv1.Rows.Add()
            dgv1.Item(0, i).Value = rs(0).Value
            dgv1.Item(1, i).Value = rs(1).Value
            dgv1.Item(2, i).Value = rs(2).Value
            dgv1.Item(3, i).Value = rs(3).Value
            dgv1.Item(4, i).Value = rs(4).Value
            dgv1.Item(5, i).Value = rs(5).Value
            dgv1.Item(6, i).Value = rs(6).Value
            dgv1.Item(7, i).Value = rs(7).Value
            dgv1.Item(8, i).Value = rs(8).Value


            i = i + 1
            rs.MoveNext()

        Loop
    End Sub

    Private Sub txtconsmername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconsmername.TextChanged
        txtconsmername.Text = UCase(txtconsmername.Text)
        txtconsmername.SelectionStart = Len(txtconsmername.Text)
        Dim mt
        mt = txtconsmername.Text
        dgv1.Rows.Clear()
        sql = "select distinct(association.V_No),customer.cno,customer.owner_name,customer.address,customer.phone,association.u_no,association.m_no,convert(char(10),association.date,106),association.status from customer left join association on customer.Cno = association.Customer  where customer.owner_name like '%" & mt & "%'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Dim i
        i = 0
        Do While Not rs.EOF
            dgv1.Rows.Add()
            dgv1.Item(0, i).Value = rs(0).Value
            dgv1.Item(1, i).Value = rs(1).Value
            dgv1.Item(2, i).Value = rs(2).Value
            dgv1.Item(3, i).Value = rs(3).Value
            dgv1.Item(4, i).Value = rs(4).Value
            dgv1.Item(5, i).Value = rs(5).Value
            dgv1.Item(6, i).Value = rs(6).Value
            dgv1.Item(7, i).Value = rs(7).Value
            dgv1.Item(8, i).Value = rs(8).Value


            i = i + 1
            rs.MoveNext()

        Loop
    End Sub

 
End Class