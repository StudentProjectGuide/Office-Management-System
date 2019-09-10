<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupllierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HardwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SIMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AssociationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InstallationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeinstallationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComplaintsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecieptsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OutstandingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdvanePaidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComplaintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HardwareStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SIMStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txttime = New System.Windows.Forms.TextBox
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(70, 100)
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.FunctionToolStripMenuItem, Me.SearchToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.ServicesToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(0, 55)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(22, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1110, 55)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffToolStripMenuItem})
        Me.MasterToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(61, 51)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'FunctionToolStripMenuItem
        '
        Me.FunctionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupllierToolStripMenuItem, Me.HardwareToolStripMenuItem, Me.SIMToolStripMenuItem, Me.AssociationToolStripMenuItem})
        Me.FunctionToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FunctionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FunctionToolStripMenuItem.Name = "FunctionToolStripMenuItem"
        Me.FunctionToolStripMenuItem.Size = New System.Drawing.Size(72, 51)
        Me.FunctionToolStripMenuItem.Text = "Function"
        '
        'SupllierToolStripMenuItem
        '
        Me.SupllierToolStripMenuItem.Name = "SupllierToolStripMenuItem"
        Me.SupllierToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SupllierToolStripMenuItem.Text = "Supplier"
        '
        'HardwareToolStripMenuItem
        '
        Me.HardwareToolStripMenuItem.Name = "HardwareToolStripMenuItem"
        Me.HardwareToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.HardwareToolStripMenuItem.Text = "Hardware"
        '
        'SIMToolStripMenuItem
        '
        Me.SIMToolStripMenuItem.Name = "SIMToolStripMenuItem"
        Me.SIMToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SIMToolStripMenuItem.Text = "SIM"
        '
        'AssociationToolStripMenuItem
        '
        Me.AssociationToolStripMenuItem.Name = "AssociationToolStripMenuItem"
        Me.AssociationToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AssociationToolStripMenuItem.Text = "Association"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(60, 51)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(78, 51)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'ServicesToolStripMenuItem
        '
        Me.ServicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstallationToolStripMenuItem, Me.DeinstallationToolStripMenuItem, Me.ComplaintsToolStripMenuItem})
        Me.ServicesToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        Me.ServicesToolStripMenuItem.Size = New System.Drawing.Size(68, 51)
        Me.ServicesToolStripMenuItem.Text = "Services"
        '
        'InstallationToolStripMenuItem
        '
        Me.InstallationToolStripMenuItem.Name = "InstallationToolStripMenuItem"
        Me.InstallationToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.InstallationToolStripMenuItem.Text = "Installation"
        '
        'DeinstallationToolStripMenuItem
        '
        Me.DeinstallationToolStripMenuItem.Name = "DeinstallationToolStripMenuItem"
        Me.DeinstallationToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DeinstallationToolStripMenuItem.Text = "Deinstallation"
        '
        'ComplaintsToolStripMenuItem
        '
        Me.ComplaintsToolStripMenuItem.Name = "ComplaintsToolStripMenuItem"
        Me.ComplaintsToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ComplaintsToolStripMenuItem.Text = "Complaints"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillToolStripMenuItem, Me.RecieptsToolStripMenuItem, Me.OutstandingsToolStripMenuItem, Me.AdvanePaidToolStripMenuItem})
        Me.AccountsToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(76, 51)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        '
        'BillToolStripMenuItem
        '
        Me.BillToolStripMenuItem.Name = "BillToolStripMenuItem"
        Me.BillToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.BillToolStripMenuItem.Text = "Bill"
        '
        'RecieptsToolStripMenuItem
        '
        Me.RecieptsToolStripMenuItem.Name = "RecieptsToolStripMenuItem"
        Me.RecieptsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.RecieptsToolStripMenuItem.Text = "Reciepts"
        '
        'OutstandingsToolStripMenuItem
        '
        Me.OutstandingsToolStripMenuItem.Name = "OutstandingsToolStripMenuItem"
        Me.OutstandingsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.OutstandingsToolStripMenuItem.Text = "Outstandings"
        '
        'AdvanePaidToolStripMenuItem
        '
        Me.AdvanePaidToolStripMenuItem.Name = "AdvanePaidToolStripMenuItem"
        Me.AdvanePaidToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AdvanePaidToolStripMenuItem.Text = "Advane Paid"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaintToolStripMenuItem, Me.HardwareStockToolStripMenuItem, Me.SIMStockToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(68, 51)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ComplaintToolStripMenuItem
        '
        Me.ComplaintToolStripMenuItem.Name = "ComplaintToolStripMenuItem"
        Me.ComplaintToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ComplaintToolStripMenuItem.Text = "Complaint"
        '
        'HardwareStockToolStripMenuItem
        '
        Me.HardwareStockToolStripMenuItem.Name = "HardwareStockToolStripMenuItem"
        Me.HardwareStockToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.HardwareStockToolStripMenuItem.Text = "Hardware Stock"
        '
        'SIMStockToolStripMenuItem
        '
        Me.SIMStockToolStripMenuItem.Name = "SIMStockToolStripMenuItem"
        Me.SIMStockToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SIMStockToolStripMenuItem.Text = "SIM Stock"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(42, 51)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(820, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Maroon
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 55)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1110, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'txttime
        '
        Me.txttime.BackColor = System.Drawing.Color.Black
        Me.txttime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttime.ForeColor = System.Drawing.Color.White
        Me.txttime.Location = New System.Drawing.Point(701, 33)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(100, 19)
        Me.txttime.TabIndex = 6
        '
        'MDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1110, 527)
        Me.Controls.Add(Me.txttime)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MDIMain"
        Me.Text = "MDIMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FunctionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupllierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HardwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SIMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssociationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstallationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeinstallationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplaintsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecieptsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplaintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutstandingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HardwareStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SIMStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvanePaidToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
