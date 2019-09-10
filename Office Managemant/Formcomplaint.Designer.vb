<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formcomplaint
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lblcid = New System.Windows.Forms.Label
        Me.lblVehicle = New System.Windows.Forms.Label
        Me.cmbvehicle = New System.Windows.Forms.ComboBox
        Me.Btnupdate = New System.Windows.Forms.Button
        Me.Btndelete = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Dtprtime = New System.Windows.Forms.DateTimePicker
        Me.Cmbstatus = New System.Windows.Forms.ComboBox
        Me.dtprdate = New System.Windows.Forms.DateTimePicker
        Me.Txtamount = New System.Windows.Forms.TextBox
        Me.Txtremark = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Txtrep_no = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtptime = New System.Windows.Forms.DateTimePicker
        Me.txttyp_of_complt = New System.Windows.Forms.TextBox
        Me.txtowner_name = New System.Windows.Forms.TextBox
        Me.TxtCno = New System.Windows.Forms.TextBox
        Me.txtsim_no = New System.Windows.Forms.TextBox
        Me.lbltech = New System.Windows.Forms.Label
        Me.Cmbtech_name = New System.Windows.Forms.ComboBox
        Me.Dtpcdate = New System.Windows.Forms.DateTimePicker
        Me.Txtunit_no = New System.Windows.Forms.TextBox
        Me.Cmbpriority = New System.Windows.Forms.ComboBox
        Me.lblpriority = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.lbltype = New System.Windows.Forms.Label
        Me.lblowner = New System.Windows.Forms.Label
        Me.lblcno = New System.Windows.Forms.Label
        Me.lblsim = New System.Windows.Forms.Label
        Me.Lblunit_no = New System.Windows.Forms.Label
        Me.Btnadd = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label20 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblv_no = New System.Windows.Forms.Label
        Me.dtpdate = New System.Windows.Forms.DateTimePicker
        Me.cmbsearch = New System.Windows.Forms.ComboBox
        Me.dgvcompliant = New System.Windows.Forms.DataGridView
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvcompliant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(52, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1035, 562)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lblcid)
        Me.TabPage1.Controls.Add(Me.lblVehicle)
        Me.TabPage1.Controls.Add(Me.cmbvehicle)
        Me.TabPage1.Controls.Add(Me.Btnupdate)
        Me.TabPage1.Controls.Add(Me.Btndelete)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Btnadd)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1027, 530)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New"
        '
        'lblcid
        '
        Me.lblcid.AutoSize = True
        Me.lblcid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcid.Location = New System.Drawing.Point(760, 13)
        Me.lblcid.Name = "lblcid"
        Me.lblcid.Size = New System.Drawing.Size(27, 19)
        Me.lblcid.TabIndex = 50
        Me.lblcid.Text = "cid"
        '
        'lblVehicle
        '
        Me.lblVehicle.AutoSize = True
        Me.lblVehicle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicle.ForeColor = System.Drawing.Color.Black
        Me.lblVehicle.Location = New System.Drawing.Point(285, 13)
        Me.lblVehicle.Name = "lblVehicle"
        Me.lblVehicle.Size = New System.Drawing.Size(83, 19)
        Me.lblVehicle.TabIndex = 49
        Me.lblVehicle.Text = "Vehicle No"
        '
        'cmbvehicle
        '
        Me.cmbvehicle.FormattingEnabled = True
        Me.cmbvehicle.Location = New System.Drawing.Point(382, 6)
        Me.cmbvehicle.Name = "cmbvehicle"
        Me.cmbvehicle.Size = New System.Drawing.Size(126, 27)
        Me.cmbvehicle.TabIndex = 48
        '
        'Btnupdate
        '
        Me.Btnupdate.Location = New System.Drawing.Point(322, 484)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(87, 29)
        Me.Btnupdate.TabIndex = 47
        Me.Btnupdate.Text = "Update"
        Me.Btnupdate.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.Location = New System.Drawing.Point(456, 484)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(87, 29)
        Me.Btndelete.TabIndex = 46
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dtprtime)
        Me.GroupBox2.Controls.Add(Me.Cmbstatus)
        Me.GroupBox2.Controls.Add(Me.dtprdate)
        Me.GroupBox2.Controls.Add(Me.Txtamount)
        Me.GroupBox2.Controls.Add(Me.Txtremark)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Txtrep_no)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(24, 273)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(833, 196)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resolved by Search"
        '
        'Dtprtime
        '
        Me.Dtprtime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtprtime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Dtprtime.Location = New System.Drawing.Point(174, 87)
        Me.Dtprtime.Name = "Dtprtime"
        Me.Dtprtime.Size = New System.Drawing.Size(156, 26)
        Me.Dtprtime.TabIndex = 35
        '
        'Cmbstatus
        '
        Me.Cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbstatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbstatus.FormattingEnabled = True
        Me.Cmbstatus.Items.AddRange(New Object() {"Solved", "Not Solved"})
        Me.Cmbstatus.Location = New System.Drawing.Point(530, 28)
        Me.Cmbstatus.Name = "Cmbstatus"
        Me.Cmbstatus.Size = New System.Drawing.Size(161, 27)
        Me.Cmbstatus.TabIndex = 34
        '
        'dtprdate
        '
        Me.dtprdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtprdate.Location = New System.Drawing.Point(175, 33)
        Me.dtprdate.Name = "dtprdate"
        Me.dtprdate.Size = New System.Drawing.Size(156, 26)
        Me.dtprdate.TabIndex = 32
        '
        'Txtamount
        '
        Me.Txtamount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtamount.Location = New System.Drawing.Point(530, 153)
        Me.Txtamount.Name = "Txtamount"
        Me.Txtamount.Size = New System.Drawing.Size(161, 26)
        Me.Txtamount.TabIndex = 30
        '
        'Txtremark
        '
        Me.Txtremark.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtremark.Location = New System.Drawing.Point(530, 69)
        Me.Txtremark.Multiline = True
        Me.Txtremark.Name = "Txtremark"
        Me.Txtremark.Size = New System.Drawing.Size(161, 71)
        Me.Txtremark.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(21, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 19)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Service Report No"
        '
        'Txtrep_no
        '
        Me.Txtrep_no.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtrep_no.Location = New System.Drawing.Point(174, 146)
        Me.Txtrep_no.Name = "Txtrep_no"
        Me.Txtrep_no.Size = New System.Drawing.Size(155, 26)
        Me.Txtrep_no.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(427, 149)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 19)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Amount"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(427, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 19)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Status"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(427, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 19)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Remark"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(22, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 19)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Time"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(23, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 19)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtptime)
        Me.GroupBox1.Controls.Add(Me.txttyp_of_complt)
        Me.GroupBox1.Controls.Add(Me.txtowner_name)
        Me.GroupBox1.Controls.Add(Me.TxtCno)
        Me.GroupBox1.Controls.Add(Me.txtsim_no)
        Me.GroupBox1.Controls.Add(Me.lbltech)
        Me.GroupBox1.Controls.Add(Me.Cmbtech_name)
        Me.GroupBox1.Controls.Add(Me.Dtpcdate)
        Me.GroupBox1.Controls.Add(Me.Txtunit_no)
        Me.GroupBox1.Controls.Add(Me.Cmbpriority)
        Me.GroupBox1.Controls.Add(Me.lblpriority)
        Me.GroupBox1.Controls.Add(Me.lbltime)
        Me.GroupBox1.Controls.Add(Me.lbldate)
        Me.GroupBox1.Controls.Add(Me.lbltype)
        Me.GroupBox1.Controls.Add(Me.lblowner)
        Me.GroupBox1.Controls.Add(Me.lblcno)
        Me.GroupBox1.Controls.Add(Me.lblsim)
        Me.GroupBox1.Controls.Add(Me.Lblunit_no)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(24, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 200)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compliant from Customer"
        '
        'dtptime
        '
        Me.dtptime.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtptime.Location = New System.Drawing.Point(672, 83)
        Me.dtptime.Name = "dtptime"
        Me.dtptime.Size = New System.Drawing.Size(145, 26)
        Me.dtptime.TabIndex = 40
        '
        'txttyp_of_complt
        '
        Me.txttyp_of_complt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttyp_of_complt.Location = New System.Drawing.Point(389, 132)
        Me.txttyp_of_complt.Name = "txttyp_of_complt"
        Me.txttyp_of_complt.Size = New System.Drawing.Size(138, 26)
        Me.txttyp_of_complt.TabIndex = 39
        '
        'txtowner_name
        '
        Me.txtowner_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtowner_name.Location = New System.Drawing.Point(389, 88)
        Me.txtowner_name.Name = "txtowner_name"
        Me.txtowner_name.Size = New System.Drawing.Size(138, 26)
        Me.txtowner_name.TabIndex = 38
        '
        'TxtCno
        '
        Me.TxtCno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCno.Location = New System.Drawing.Point(390, 33)
        Me.TxtCno.Name = "TxtCno"
        Me.TxtCno.Size = New System.Drawing.Size(138, 26)
        Me.TxtCno.TabIndex = 37
        '
        'txtsim_no
        '
        Me.txtsim_no.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsim_no.Location = New System.Drawing.Point(91, 77)
        Me.txtsim_no.Name = "txtsim_no"
        Me.txtsim_no.Size = New System.Drawing.Size(126, 26)
        Me.txtsim_no.TabIndex = 36
        '
        'lbltech
        '
        Me.lbltech.AutoSize = True
        Me.lbltech.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltech.ForeColor = System.Drawing.Color.Black
        Me.lbltech.Location = New System.Drawing.Point(540, 135)
        Me.lbltech.Name = "lbltech"
        Me.lbltech.Size = New System.Drawing.Size(125, 19)
        Me.lbltech.TabIndex = 35
        Me.lbltech.Text = "Technician Name"
        '
        'Cmbtech_name
        '
        Me.Cmbtech_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbtech_name.FormattingEnabled = True
        Me.Cmbtech_name.Location = New System.Drawing.Point(671, 129)
        Me.Cmbtech_name.Name = "Cmbtech_name"
        Me.Cmbtech_name.Size = New System.Drawing.Size(147, 27)
        Me.Cmbtech_name.TabIndex = 34
        '
        'Dtpcdate
        '
        Me.Dtpcdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtpcdate.Location = New System.Drawing.Point(671, 38)
        Me.Dtpcdate.Name = "Dtpcdate"
        Me.Dtpcdate.Size = New System.Drawing.Size(146, 26)
        Me.Dtpcdate.TabIndex = 33
        '
        'Txtunit_no
        '
        Me.Txtunit_no.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtunit_no.Location = New System.Drawing.Point(91, 27)
        Me.Txtunit_no.Name = "Txtunit_no"
        Me.Txtunit_no.Size = New System.Drawing.Size(126, 26)
        Me.Txtunit_no.TabIndex = 31
        '
        'Cmbpriority
        '
        Me.Cmbpriority.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbpriority.FormattingEnabled = True
        Me.Cmbpriority.Items.AddRange(New Object() {"1", "2", "3"})
        Me.Cmbpriority.Location = New System.Drawing.Point(91, 127)
        Me.Cmbpriority.Name = "Cmbpriority"
        Me.Cmbpriority.Size = New System.Drawing.Size(126, 27)
        Me.Cmbpriority.TabIndex = 21
        Me.Cmbpriority.Text = "2"
        '
        'lblpriority
        '
        Me.lblpriority.AutoSize = True
        Me.lblpriority.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpriority.ForeColor = System.Drawing.Color.Black
        Me.lblpriority.Location = New System.Drawing.Point(21, 132)
        Me.lblpriority.Name = "lblpriority"
        Me.lblpriority.Size = New System.Drawing.Size(59, 19)
        Me.lblpriority.TabIndex = 20
        Me.lblpriority.Text = "Priority"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Black
        Me.lbltime.Location = New System.Drawing.Point(553, 88)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(43, 19)
        Me.lbltime.TabIndex = 7
        Me.lbltime.Text = "Time"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.Black
        Me.lbldate.Location = New System.Drawing.Point(553, 38)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(42, 19)
        Me.lbldate.TabIndex = 6
        Me.lbldate.Text = "Date"
        '
        'lbltype
        '
        Me.lbltype.AutoSize = True
        Me.lbltype.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltype.ForeColor = System.Drawing.Color.Black
        Me.lbltype.Location = New System.Drawing.Point(254, 137)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(132, 19)
        Me.lbltype.TabIndex = 5
        Me.lbltype.Text = "Type of Compliant"
        '
        'lblowner
        '
        Me.lblowner.AutoSize = True
        Me.lblowner.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblowner.ForeColor = System.Drawing.Color.Black
        Me.lblowner.Location = New System.Drawing.Point(261, 86)
        Me.lblowner.Name = "lblowner"
        Me.lblowner.Size = New System.Drawing.Size(97, 19)
        Me.lblowner.TabIndex = 4
        Me.lblowner.Text = "Owner Name"
        '
        'lblcno
        '
        Me.lblcno.AutoSize = True
        Me.lblcno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcno.ForeColor = System.Drawing.Color.Black
        Me.lblcno.Location = New System.Drawing.Point(261, 36)
        Me.lblcno.Name = "lblcno"
        Me.lblcno.Size = New System.Drawing.Size(101, 19)
        Me.lblcno.TabIndex = 3
        Me.lblcno.Text = "Consumer No"
        '
        'lblsim
        '
        Me.lblsim.AutoSize = True
        Me.lblsim.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsim.ForeColor = System.Drawing.Color.Black
        Me.lblsim.Location = New System.Drawing.Point(21, 83)
        Me.lblsim.Name = "lblsim"
        Me.lblsim.Size = New System.Drawing.Size(58, 19)
        Me.lblsim.TabIndex = 2
        Me.lblsim.Text = "Sim No"
        '
        'Lblunit_no
        '
        Me.Lblunit_no.AutoSize = True
        Me.Lblunit_no.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblunit_no.ForeColor = System.Drawing.Color.Black
        Me.Lblunit_no.Location = New System.Drawing.Point(22, 33)
        Me.Lblunit_no.Name = "Lblunit_no"
        Me.Lblunit_no.Size = New System.Drawing.Size(61, 19)
        Me.Lblunit_no.TabIndex = 1
        Me.Lblunit_no.Text = "Unit No"
        '
        'Btnadd
        '
        Me.Btnadd.Location = New System.Drawing.Point(179, 484)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(87, 29)
        Me.Btnadd.TabIndex = 43
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(69, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 15)
        Me.Label10.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(485, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Technician"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.ComboBox2)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.CheckBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.lblv_no)
        Me.TabPage2.Controls.Add(Me.dtpdate)
        Me.TabPage2.Controls.Add(Me.cmbsearch)
        Me.TabPage2.Controls.Add(Me.dgvcompliant)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1027, 530)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Search"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label20.Location = New System.Drawing.Point(733, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(125, 19)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Technician Name"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(867, 27)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(147, 27)
        Me.ComboBox2.TabIndex = 44
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label19.Location = New System.Drawing.Point(514, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 19)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Status"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Solved", "Not Solved"})
        Me.ComboBox1.Location = New System.Drawing.Point(566, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 27)
        Me.ComboBox1.TabIndex = 42
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CheckBox1.Location = New System.Drawing.Point(463, 34)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(47, 23)
        Me.CheckBox1.TabIndex = 41
        Me.CheckBox1.Text = "All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(249, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 19)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Date"
        '
        'lblv_no
        '
        Me.lblv_no.AutoSize = True
        Me.lblv_no.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblv_no.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblv_no.Location = New System.Drawing.Point(6, 34)
        Me.lblv_no.Name = "lblv_no"
        Me.lblv_no.Size = New System.Drawing.Size(83, 19)
        Me.lblv_no.TabIndex = 39
        Me.lblv_no.Text = "Vehicle_no"
        '
        'dtpdate
        '
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdate.Location = New System.Drawing.Point(298, 32)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(152, 26)
        Me.dtpdate.TabIndex = 38
        '
        'cmbsearch
        '
        Me.cmbsearch.FormattingEnabled = True
        Me.cmbsearch.Location = New System.Drawing.Point(95, 30)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.Size = New System.Drawing.Size(148, 27)
        Me.cmbsearch.TabIndex = 37
        '
        'dgvcompliant
        '
        Me.dgvcompliant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcompliant.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column3, Me.Column4, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column1, Me.Column2, Me.Column5, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.dgvcompliant.Location = New System.Drawing.Point(25, 98)
        Me.dgvcompliant.Name = "dgvcompliant"
        Me.dgvcompliant.Size = New System.Drawing.Size(943, 377)
        Me.dgvcompliant.TabIndex = 0
        '
        'Column10
        '
        Me.Column10.HeaderText = "Vehicle No"
        Me.Column10.Name = "Column10"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Priority"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "consumer_no"
        Me.Column4.Name = "Column4"
        '
        'Column6
        '
        Me.Column6.HeaderText = "typ_of_comp"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "date"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "time"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "tech_name"
        Me.Column9.Name = "Column9"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Status"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID"
        Me.Column2.Name = "Column2"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Rdate"
        Me.Column5.Name = "Column5"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Rtime"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Remark"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Service report no"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "amount"
        Me.Column14.Name = "Column14"
        '
        'Formcomplaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1225, 629)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Formcomplaint"
        Me.Text = "Formcomplaint"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvcompliant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Btnupdate As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents dtprdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txtamount As System.Windows.Forms.TextBox
    Friend WithEvents Txtrep_no As System.Windows.Forms.TextBox
    Friend WithEvents Txtremark As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltech As System.Windows.Forms.Label
    Friend WithEvents Cmbtech_name As System.Windows.Forms.ComboBox
    Friend WithEvents Dtpcdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txtunit_no As System.Windows.Forms.TextBox
    Friend WithEvents Cmbpriority As System.Windows.Forms.ComboBox
    Friend WithEvents lblpriority As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lbltype As System.Windows.Forms.Label
    Friend WithEvents lblowner As System.Windows.Forms.Label
    Friend WithEvents lblcno As System.Windows.Forms.Label
    Friend WithEvents lblsim As System.Windows.Forms.Label
    Friend WithEvents Lblunit_no As System.Windows.Forms.Label
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtsim_no As System.Windows.Forms.TextBox
    Friend WithEvents txttyp_of_complt As System.Windows.Forms.TextBox
    Friend WithEvents txtowner_name As System.Windows.Forms.TextBox
    Friend WithEvents TxtCno As System.Windows.Forms.TextBox
    Friend WithEvents dgvcompliant As System.Windows.Forms.DataGridView
    Friend WithEvents dtptime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtprtime As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblVehicle As System.Windows.Forms.Label
    Friend WithEvents cmbvehicle As System.Windows.Forms.ComboBox
    Friend WithEvents lblcid As System.Windows.Forms.Label
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents lblv_no As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    ' Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
