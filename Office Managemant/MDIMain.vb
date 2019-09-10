Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient


Public Class MDIMain

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Do you want to Exit Application?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End

        End If
    End Sub
    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupllierToolStripMenuItem.Click
        Formsupp.Show()
    End Sub

    Private Sub HardwareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HardwareToolStripMenuItem.Click
        Formhardware.Show()

    End Sub

    Private Sub SIMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIMToolStripMenuItem.Click
        Formsim.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        With Formcustomer
            .MdiParent = Me
            .Show()

        End With
    End Sub

    Private Sub AssociationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssociationToolStripMenuItem.Click
        With Formassociation
            .MdiParent = Me
            .Show()

        End With

    End Sub

    
    Private Sub DeinstallationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeinstallationToolStripMenuItem.Click
        With Formdeinstall
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub InstallationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallationToolStripMenuItem.Click
        With Forminstallation
            .MdiParent = Me
            .Show()

        End With
    End Sub

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Now.Date
    End Sub

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.txttime.Text = Now.ToLongTimeString
    End Sub

  

    Private Sub BillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillToolStripMenuItem.Click
        FrmBill.Show()

    End Sub

    Private Sub ComplaintsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintsToolStripMenuItem.Click
        With Formcomplaint
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub RecieptsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecieptsToolStripMenuItem.Click
        FrmReciept.Show()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        FrmSearch.Show()
    End Sub

    Private Sub ComplaintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplaintToolStripMenuItem.Click
        FRMcOMPLIANrEPORT.Show()

    End Sub

  

    Private Sub OutstandingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutstandingsToolStripMenuItem.Click
        FrmOutstanding.Show()

    End Sub

    Private Sub HardwareStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HardwareStockToolStripMenuItem.Click
        FrmHardwareStock.Show()

    End Sub

    Private Sub SIMStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIMStockToolStripMenuItem.Click
        FrmSimStock.Show()

    End Sub

    Private Sub AdvanePaidToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvanePaidToolStripMenuItem.Click
        formadvance.Show()
    End Sub

    Private Sub MasterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MasterToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterToolStripMenuItem.Click

    End Sub

    Private Sub StaffToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem.Click
        Formstaff.Show()

    End Sub
End Class
