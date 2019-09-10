Public Class FormLogin

    Private Sub ForrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        End
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If CmbUserType.Text = "" Then
            MsgBox("Kindly enter User Type!!!!")
        ElseIf TxtUser.Text = "" Then
            MsgBox("Kindly enter User Name!!!!")
        ElseIf TxtPass.Text = "" Then
            MsgBox("Kindly enter Password!!!!")
        Else
            sql = "select * from login where utype='" & CmbUserType.Text & "' and uname='" & TxtUser.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                sql = "select * from login where utype='" & CmbUserType.Text & "' and uname='" & TxtUser.Text & "' and upass='" & TxtPass.Text & "'"
                If rs.State = 1 Then rs.Close()
                rs.Open(sql, conn)
                If rs.EOF = False Then
                    MsgBox("Login Success")
                    uname = CmbUserType.Text
                    If UCase(uname) = UCase("Technician") Then
                        MDIMain.AccountsToolStripMenuItem.Visible = False
                        MDIMain.FunctionToolStripMenuItem.Visible = False
                        MDIMain.Show()
                        Me.Hide()
                    ElseIf UCase(uname) = UCase("Office Executive") Then
                        MDIMain.MasterToolStripMenuItem.Visible = False
                        MDIMain.Show()
                        Me.Hide()
                    ElseIf UCase(uname) = UCase("Accountant") Then
                        MDIMain.MasterToolStripMenuItem.Visible = False
                        MDIMain.FunctionToolStripMenuItem.Visible = False
                        MDIMain.ServicesToolStripMenuItem.Visible = False
                        MDIMain.CustomerToolStripMenuItem.Visible = False
                        MDIMain.ReportsToolStripMenuItem.Visible = False
                        MDIMain.Show()
                        Me.Hide()
                    Else
                        MDIMain.Show()
                        Me.Hide()
                    End If
                Else
                    MsgBox("Wrong Password")
                End If
            Else
                MsgBox("Login Failed!!!")

            End If
        End If
    End Sub

    Private Sub CmbUserType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUserType.SelectedIndexChanged

    End Sub

    Private Sub TxtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




End Class