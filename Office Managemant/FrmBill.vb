
Imports System.Data
Imports System.Data.SqlClient
Public Class FrmBill

    Private Sub FrmBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        'cmbyear1.SelectedIndex = cmbyear1.Items.Count - 1
        'cmbyear2.SelectedIndex = cmbyear2.Items.Count - 1
        'cmbyear1.Text = cmbyear1.SelectedIndex
    End Sub

    Private Sub Generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Generate.Click
        If cmbCustType.Text = "" Then
            MsgBox("Kindly select Customer Type to Generate Bill!!")
        ElseIf cmbMonthTo.Text = "" Then
            MsgBox("Kindly select Month To !")
        ElseIf cmbyear1.Text = "" Then
            MsgBox("Kindly select Year from !")
        ElseIf cmbMonthFrom.Text = "" Then
            MsgBox("Kindly select Month From !")
        Else





            ' FrmConfirm.lblText.Text = "Loading.....Please wait!!"
            ' Me.Hide()
            ' FrmConfirm.Show()

            calBill1()
            ' Me.Show()
            ' FrmConfirm.Close()

        End If


    End Sub
    Sub calBill1()
        Dim b As Boolean
        Dim startdate As New Date
        Dim enddate As New Date
        Dim s As Date
        Dim d As Date
        Dim NoDaysMonth
        Dim Nodays
        Dim pen
        s = lblfromDate.Text & "/" & cmbMonthFrom.SelectedIndex + 1 & "/" & cmbyear1.Text
        startdate = s.ToString("dd/MM/yyyy")
        d = lblTodate.Text & "/" & cmbMonthTo.SelectedIndex + 1 & "/" & cmbyear2.Text
        enddate = d.ToString("dd/MM/yyyy")
        Dim m
        If Month(startdate) = 12 Then
            m = 1
        Else
            m = Month(startdate) + 1
        End If
        Dim y
        If Month(startdate) = 12 Then
            y = cmbyear1.Text + 1
        Else
            y = Year(startdate)
        End If
        If enddate <> "15/" & m & "/" & y Then
            MsgBox("Wrong Billing Period!!!")
            Exit Sub
        End If

        NoDaysMonth = DateDiff(DateInterval.Day, startdate, enddate)

        Dim PBalance As Double
        Dim ars As New ADODB.Recordset
        Dim Payments As Double
        Dim MonthServCharges As Double
        Dim Adj As Double
        Dim AmtOnDate As Double
        Dim AmtOutDate As Double
        Dim totalBalance As Double
        Dim penalty As Double
        Dim VehicleNo
        Dim CustNo
        Dim AdvancePAy
        AdvancePAy = 0

        Dim ascDate As Date
        penalty = 0
        Dim i
        i = 0

        totalBalance = 0.0
        If startdate >= enddate Then
            MsgBox("You have selected wrong Billing Period!!!")
        Else
            conn.Execute("delete from bill_print")

            Dim si = cmbCustType.Text & "%"
            sql = "SELECT a_id, customer, V_No, u_no, m_no, sim_no, irno,date,Customer,status FROM association WHERE Customer like '" & si & "' and convert(date,date,103)<convert(date,'" & enddate & "',103) and status = 'Installed' OR status = 'Inactive' or status='Deinstalled' or status='Association' or status='Active'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)

            dgv.Rows.Clear()

            Do While Not rs.EOF
                dgv.Rows.Add()
                VehicleNo = rs(2).Value.ToString

                
                MonthServCharges = 275
                CustNo = rs(8).Value.ToString
                ascDate = rs(7).Value
                ascDate = ascDate.ToString("dd/MM/yyyy")
                sql = "SELECt * FROM Payments where vehicleNo='" & VehicleNo & "' and custNo='" & CustNo & "' and setled='false' order by billto asc"

                If rss.State = 1 Then rss.Close()

                rss.Open(sql, conn)
                Dim veh
                Dim vrs As New ADODB.Recordset
                If rss.EOF = False Then
                    sql = "select * from bill where billno='" & rss(9).Value & "'"
                    vrs.Open(sql, conn)
                    If vrs.EOF = False Then
                        veh = vrs(13).Value
                    End If
                End If
                If (ascDate >= startdate) = False Then
                    If rss.EOF = False Then
                        Do While Not rss.EOF
                            sql = "select * from bill where sercharges='true' AND vehcleno='" & VehicleNo & "'"
                            Dim brs As New ADODB.Recordset
                            If brs.State = 1 Then brs.Close()
                            brs.Open(sql, conn)

                            Dim startd As Date
                            Dim endd As Date
                            startd = Format(Convert.ToDateTime(rss(2).Value), "dd/MM/yyyy")
                            'MsgBox(startd)
                            If Month(startd) = 12 Then
                                endd = "16/01/" & Year(Now) + 1
                            Else
                                endd = "16/" & Month(startd) + 1 & "/" & Year(Now)
                            End If
                            If brs.EOF = False Then

                                If brs(3).Value < endd Then
                                    penalty = 50
                                Else
l1:
                                    penalty = 0
                                End If
                            Else
                                GoTo l1

                            End If


                            If IsDBNull(rss(4).Value) = False Then
                                'If Total bill is not paid fully
                                Payments = rss(4).Value.ToString
                            Else
                                Payments = 0
                            End If
                            rss.MoveNext()

                        Loop
                    End If
                    Dim rst As New ADODB.Recordset
                    'To get total pending details of a particuler Vehicle
                  

                    Adj = 0



                    sql = "select * from payments where billFrom=convert(date,'" & startdate & "',103) and billTo=convert(date,'" & enddate & "',103) and vehicleNo='" & VehicleNo & "'"
                    Dim ers As New ADODB.Recordset
                    ers.Open(sql, conn)
                    If ers.EOF = True Then


                        '    ' If IsDBNull(rst(0).Value) = False Then

                        '    ' PBalance = rst(0).Value
                        '    ' totalBalance = rst(0).Value
                        '    pen = (rst(0).Value / 275) * 50
                        '    Dim rsss As New ADODB.Recordset
                        '    If rsss.State = 1 Then rsss.Close()
                        '    sql = "select * from bill where billno='" & veh & "'"
                        '    rsss.Open(sql, conn)
                        '    If rsss.EOF = False Then
                        '        pen = 0
                        '    End If

                        '    totalBalance = totalBalance + pen
                        'Else
                        '    totalBalance = 0
                        'End If

                    'Collect net balance
                    sql = "select prevB from prevb where VehicleNo='" & VehicleNo & "' and custNo='" & CustNo & "'"
                    Dim prs As New ADODB.Recordset
                    If prs.State = 1 Then prs.Close()
                    prs.Open(sql, conn)

                    If prs.EOF = False Then
                        totalBalance = Val(totalBalance) + Val(prs(0).Value)
                    End If

                    Dim amt
                        'If IsDBNull(rst(1).Value) = False Then
                        '    amt = rst(1).Value
                        'Else
                        '    amt = 0
                        'End If

                    AmtOnDate = (Val(MonthServCharges) + Val(totalBalance) + Val(amt) - Val(Adj))

                    sql = "SELECT Advance, Remaining, VehicleNo, CustNo,adate FROm Advance"
                    sql = sql & " WHERE (Remaining<=Advance) and remaining<>0 and VehicleNo='" & VehicleNo & "'"
                    Dim adrs As New ADODB.Recordset
                    If adrs.State = 1 Then adrs.Close()
                    adrs.Open(sql, conn)

                    Dim adv As Boolean
                    adv = False
                    Dim remaining
                    Dim small As Boolean
                    If adrs.EOF = False Then


                        remaining = Val(adrs(1).Value) - MonthServCharges
                        If Val(remaining) > 0 Then
                            sql = "update advance set remaining=" & remaining & " where adate=convert(char(10),'" & adrs(4).Value & "',103) and vehicleno='" & VehicleNo & "'"
                            conn.Execute(sql)
                            adv = True
                            b = True
                        Else

                            sql = "update advance set remaining=0 where adate='" & adrs(4).Value & "' and vehicleno='" & VehicleNo & "'"
                            conn.Execute(sql)
                            small = True
                        End If

                    End If
                    If adv = False Then
                        dgv.Item(0, i).Value = CustNo
                        dgv.Item(1, i).Value = VehicleNo
                        dgv.Item(2, i).Value = Format(totalBalance, "0.00")
                        dgv.Item(3, i).Value = Format(Payments, "0.00")
                        dgv.Item(4, i).Value = Format(Adj, "0.00")
                        dgv.Item(5, i).Value = Format(MonthServCharges, "0.00")
                        If small = True Then
                            AmtOnDate = Math.Abs(remaining)
                            dgv.Item(6, i).Value = Format(AmtOnDate, "0.00")
                        Else

                            dgv.Item(6, i).Value = Format(AmtOnDate, "0.00")
                        End If
                        AmtOutDate = Val(AmtOnDate) + 50
                        dgv.Item(7, i).Value = Format(AmtOutDate, "0.00")
                    End If
                    If adv = False Then
                        con.Open()
                            If rst.State = 1 Then rst.Close()
                            sql = "select decr,id from Unique_id where bill='MonthlyServiceCharges'"
                            rst.Open(sql, conn)



                            If rst.EOF = False Then
                                billno = rst(0).Value & rst(1).Value

                                dgv.Item(8, i).Value = billno
                                Dim tempno
                                tempno = Val(rst(1).Value) + 1
                                sql = "update Unique_id set Id=" & tempno & " where bill='MonthlyServiceCharges'"
                                conn.Execute(sql)
                            End If
                        con.Close()
                    End If

                    If adv = True Then
                        sql = "insert into payments(vehicleNo,custNo,billFrom,billTo,Paid,Balance,PrevBalance,Penalty,setled,ReeiptNo)"
                        sql = sql & " values('" & VehicleNo & "','" & CustNo & "',convert(date,'" & startdate & "',103),convert(date,'" & enddate & "',103),0," & MonthServCharges & "," & totalBalance & ",0,'True','" & billno & "')"
                        conn.Execute(sql)

                    Else


                        sql = "insert into payments(vehicleNo,custNo,billFrom,billTo,Paid,Balance,PrevBalance,Penalty,setled,ReeiptNo)"
                        sql = sql & " values('" & VehicleNo & "','" & CustNo & "',convert(date,'" & startdate & "',103),convert(date,'" & enddate & "',103),0," & MonthServCharges & "," & totalBalance & ",0,'False','" & billno & "')"
                        conn.Execute(sql)
                        ' MsgBox("New bill added added")
                    End If
                    If adv = False Then
                        totalBalance = totalBalance + MonthServCharges
                    Else

                        totalBalance = 0
                    End If
                    If Val(totalBalance) > 0 Then
                        sql = "update prevb set prevb=" & totalBalance & " where VehicleNo='" & VehicleNo & "'"
                        conn.Execute(sql)
                    End If

                    'End If
                    totalBalance = 0
                    PBalance = 0

                Else
                    dgv.Item(0, i).Value = ers(1).Value
                    dgv.Item(1, i).Value = ers(0).Value
                    'totalBalance = rst(0).Value
                    'AmtOnDate = Val(MonthServCharges) + Val(totalBalance) + Val(rst(1).Value) - Val(Adj)
                    dgv.Item(2, i).Value = ers(5).Value
                    dgv.Item(3, i).Value = "0.00"
                    dgv.Item(4, i).Value = "0.00"
                    dgv.Item(5, i).Value = Format(MonthServCharges, "0.00")
                    dgv.Item(6, i).Value = ers(5).Value

                    dgv.Item(7, i).Value = Val(ers(5).Value) + 50
                    dgv.Item(8, i).Value = ers(9).Value

                    MsgBox("Already issued")

                End If
                    'End If

                ElseIf ascDate >= startdate Then

                    'If association is done in the middle of billing period
                    'This will be executed for the fitst time of bill generation of new Customer



                    Dim remDays
                    remDays = DateDiff(DateInterval.Day, ascDate, enddate) + 1
                    dgv.Rows.Add()
                    dgv.Item(0, i).Value = CustNo
                    dgv.Item(1, i).Value = VehicleNo
                    totalBalance = 0
                    Dim DailyCharges
                    DailyCharges = MonthServCharges / NoDaysMonth
                    AmtOnDate = DailyCharges * remDays

                    'sql = "select * from AdvancePay where CONVERT(date,billFrom,103)=convert(date,'" & s & "',103) and billTo=convert(date,'" & d & "',103)"

                    'If ars.State = 1 Then ars.Close()
                    'ars.Open(sql, conn)

                    'If ars.EOF = False Then
                    '    AdvancePAy = ars(1).Value
                    'End If

                    AmtOnDate = Math.Round(AmtOnDate) - Val(AdvancePAy)
                    dgv.Item(2, i).Value = Format(PBalance, "0.00")
                    dgv.Item(3, i).Value = Format(Payments, "0.00")
                    dgv.Item(4, i).Value = Format(Adj, "0.00")
                    dgv.Item(5, i).Value = Format(MonthServCharges, "0.00")
                    dgv.Item(6, i).Value = Format(AmtOnDate, "0.00")
                    AmtOutDate = Val(AmtOnDate) + 50
                    dgv.Item(7, i).Value = Format(AmtOutDate, "0.00")
                    sql = "select decr,id from unique_Id where bill='MonthlyServiceCharges'"
                    If nrs.State = 1 Then nrs.Close()
                    nrs.Open(sql, conn)
                    If nrs.EOF = False Then
                        billno = nrs(1).Value.ToString & nrs(0).Value
                        dgv.Item(8, i).Value = billno
                        Dim tempno
                        tempno = Val(nrs(0).Value) + 1
                        sql = "update unique_Id set Id=" & tempno & " where bill='MonthlyServiceCharges'"
                        conn.Execute(sql)
                    End If
                    sql = "select * from payments where billFrom=convert(date,'" & startdate & "',103) and billTo=convert(date,'" & enddate & "',103) and vehicleNo='" & VehicleNo & "' and setled='true'"
                    Dim hrs As New ADODB.Recordset
                    If hrs.State = 1 Then hrs.Close()

                    hrs.Open(sql, conn)

                    If hrs.EOF = True Then
                        sql = "select * from payments where billFrom=convert(date,'" & startdate & "',103) and billTo=convert(date,'" & enddate & "',103) and vehicleNo='" & VehicleNo & "' and setled='false'"
                        If hrs.State = 1 Then hrs.Close()
                        hrs.Open(sql, conn)
                        If hrs.EOF = True Then
                            sql = "insert into payments(vehicleNo,custNo,billFrom,billTo,Paid,Balance,PrevBalance,Penalty,setled,ReeiptNo)"
                            sql = sql & " values('" & VehicleNo & "','" & CustNo & "',convert(date,'" & startdate & "',103),convert(date,'" & enddate & "',103),0," & AmtOnDate & ",0,0,'False','" & billno & "')"
                            conn.Execute(sql)
                            MsgBox("New Bill added")
                            If Val(AmtOnDate) > 0 Then
                                sql = "update prevb set prevb=" & AmtOnDate & " where VehicleNo='" & VehicleNo & "'"
                                conn.Execute(sql)
                            End If
                            totalBalance = 0
                            PBalance = 0
                        Else
                            MsgBox("Bill already Issued")
                        End If
                    Else
                        MsgBox("Already Issued!! and amount collected")
                    End If

                End If


                Dim irs As New ADODB.Recordset
                If irs.State = 1 Then irs.Close()
                sql = "SELECT customer.CNo,customer.owner_name,customer.address,vehicle.total, dbo.vehicle.tax,"
                sql = sql & "customer.mobile_no,customer.phone"
                sql = sql & " FROM vehicle INNER JOIN"
                sql = sql & " customer ON vehicle.CNo = customer.CNo where vehicle.vehicle_no='" & VehicleNo & "'"
                irs.Open(sql, conn)
                Dim taxx
                If irs.EOF = False Then
                    owner = irs(1).Value
                    per_address = irs(2).Value
                    service_tax = irs(4).Value
                    service_amt = irs(3).Value
                    consumno = irs(0).Value
                    mobile = irs(5).Value
                    phone = irs(6).Value
                    consun = irs(0).Value


                    taxx = Val(irs(3).Value) * Val(irs(4).Value) / 100
                    rte = Val(irs(3).Value) - Val(taxx)
                End If
                duedate = DateAdd(DateInterval.Day, 10, enddate)
                amtword = AmtInWord(service_amt)
                sql = "insert into bill_print values('" & dgv.Item(8, i).Value & "','" & owner & "','" & per_address & "',convert(date,'" & Now.Date & "',103),convert(date,'" & startdate & "',103),convert(date,'" & enddate & "',103),'" & phone & "','" & dgv.Item(2, i).Value & "','" & dgv.Item(3, i).Value & "','" & dgv.Item(4, i).Value & "','" & dgv.Item(5, i).Value & "'"
                sql = sql & ",'" & dgv.Item(6, i).Value & "','" & dgv.Item(7, i).Value & "','" & service_tax & "','" & taxx & "','" & service_amt & "','" & VehicleNo & "','" & mobile & "','" & consun & "',convert(date,'" & duedate & "',103),'" & amtword & "','" & rte & "')"
                conn.Execute(sql)

                rs.MoveNext()
                If b = False Then
                    i = i + 1
                End If
                b = False
            Loop

        end if
    End Sub
    Public owner, per_address, service_tax, service_amt, mobile, consumno, phone, consun, duedate, amtword, rte

    Dim billno
    Dim nrs As New ADODB.Recordset

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If dgv.Item(0, 0).Value <> "" Then
            print_bill.Show()
        End If
    End Sub

   
End Class