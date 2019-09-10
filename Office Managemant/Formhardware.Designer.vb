<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formhardware
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lblhid = New System.Windows.Forms.Label
        Me.Dtpdate = New System.Windows.Forms.DateTimePicker
        Me.Cmbaccer = New System.Windows.Forms.ComboBox
        Me.txtchanlno = New System.Windows.Forms.TextBox
        Me.txtunitno = New System.Windows.Forms.TextBox
        Me.Btndelete = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Btnupdate = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Btnadd = New System.Windows.Forms.Button
        Me.Cmbmodname = New System.Windows.Forms.ComboBox
        Me.dgvhardware = New System.Windows.Forms.TabPage
        Me.dgvhw = New System.Windows.Forms.DataGridView
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.dgvhardware.SuspendLayout()
        CType(Me.dgvhw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.dgvhardware)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(49, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(761, 461)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lblhid)
        Me.TabPage1.Controls.Add(Me.Dtpdate)
        Me.TabPage1.Controls.Add(Me.Cmbaccer)
        Me.TabPage1.Controls.Add(Me.txtchanlno)
        Me.TabPage1.Controls.Add(Me.txtunitno)
        Me.TabPage1.Controls.Add(Me.Btndelete)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Btnupdate)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Btnadd)
        Me.TabPage1.Controls.Add(Me.Cmbmodname)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(753, 429)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New"
        '
        'lblhid
        '
        Me.lblhid.AutoSize = True
        Me.lblhid.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblhid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhid.ForeColor = System.Drawing.Color.Black
        Me.lblhid.Location = New System.Drawing.Point(83, 44)
        Me.lblhid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhid.Name = "lblhid"
        Me.lblhid.Size = New System.Drawing.Size(33, 19)
        Me.lblhid.TabIndex = 48
        Me.lblhid.Text = "Hid"
        '
        'Dtpdate
        '
        Me.Dtpdate.Location = New System.Drawing.Point(307, 282)
        Me.Dtpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Dtpdate.Name = "Dtpdate"
        Me.Dtpdate.Size = New System.Drawing.Size(173, 26)
        Me.Dtpdate.TabIndex = 46
        '
        'Cmbaccer
        '
        Me.Cmbaccer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbaccer.FormattingEnabled = True
        Me.Cmbaccer.Items.AddRange(New Object() {"Antenna", "Door sensor"})
        Me.Cmbaccer.Location = New System.Drawing.Point(307, 126)
        Me.Cmbaccer.Name = "Cmbaccer"
        Me.Cmbaccer.Size = New System.Drawing.Size(173, 27)
        Me.Cmbaccer.TabIndex = 47
        '
        'txtchanlno
        '
        Me.txtchanlno.Location = New System.Drawing.Point(307, 229)
        Me.txtchanlno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtchanlno.Name = "txtchanlno"
        Me.txtchanlno.Size = New System.Drawing.Size(173, 26)
        Me.txtchanlno.TabIndex = 40
        '
        'txtunitno
        '
        Me.txtunitno.Location = New System.Drawing.Point(307, 185)
        Me.txtunitno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtunitno.Name = "txtunitno"
        Me.txtunitno.Size = New System.Drawing.Size(173, 26)
        Me.txtunitno.TabIndex = 41
        '
        'Btndelete
        '
        Me.Btndelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.ForeColor = System.Drawing.Color.Black
        Me.Btndelete.Location = New System.Drawing.Point(372, 348)
        Me.Btndelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(108, 38)
        Me.Btndelete.TabIndex = 45
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(82, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Model Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(83, 289)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 19)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Date"
        '
        'Btnupdate
        '
        Me.Btnupdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnupdate.ForeColor = System.Drawing.Color.Black
        Me.Btnupdate.Location = New System.Drawing.Point(236, 348)
        Me.Btnupdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(108, 38)
        Me.Btnupdate.TabIndex = 44
        Me.Btnupdate.Text = "Update"
        Me.Btnupdate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(82, 236)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 19)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Delivery Channel No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(83, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Accesseries"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(82, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Unit No/EMEI"
        '
        'Btnadd
        '
        Me.Btnadd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.ForeColor = System.Drawing.Color.Black
        Me.Btnadd.Location = New System.Drawing.Point(86, 348)
        Me.Btnadd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(108, 38)
        Me.Btnadd.TabIndex = 43
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'Cmbmodname
        '
        Me.Cmbmodname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbmodname.FormattingEnabled = True
        Me.Cmbmodname.Location = New System.Drawing.Point(307, 77)
        Me.Cmbmodname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cmbmodname.Name = "Cmbmodname"
        Me.Cmbmodname.Size = New System.Drawing.Size(173, 27)
        Me.Cmbmodname.TabIndex = 42
        '
        'dgvhardware
        '
        Me.dgvhardware.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvhardware.Controls.Add(Me.dgvhw)
        Me.dgvhardware.Location = New System.Drawing.Point(4, 28)
        Me.dgvhardware.Name = "dgvhardware"
        Me.dgvhardware.Padding = New System.Windows.Forms.Padding(3)
        Me.dgvhardware.Size = New System.Drawing.Size(753, 429)
        Me.dgvhardware.TabIndex = 1
        Me.dgvhardware.Text = "Search"
        '
        'dgvhw
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvhw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvhw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Column6, Me.Column1, Me.Column4, Me.Column5, Me.mname})
        Me.dgvhw.Location = New System.Drawing.Point(59, 67)
        Me.dgvhw.Name = "dgvhw"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvhw.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvhw.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvhw.Size = New System.Drawing.Size(643, 306)
        Me.dgvhw.TabIndex = 0
        '
        'Id
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.Id.DefaultCellStyle = DataGridViewCellStyle2
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        '
        'Column6
        '
        Me.Column6.HeaderText = "date"
        Me.Column6.Name = "Column6"
        '
        'Column1
        '
        Me.Column1.HeaderText = "m_name"
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        Me.Column4.HeaderText = "accer"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "u_no"
        Me.Column5.Name = "Column5"
        '
        'mname
        '
        Me.mname.HeaderText = "dcn"
        Me.mname.Name = "mname"
        '
        'Formhardware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 529)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Formhardware"
        Me.Text = "Formhardware"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.dgvhardware.ResumeLayout(False)
        CType(Me.dgvhw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvhardware As System.Windows.Forms.TabPage
    Friend WithEvents Dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmbaccer As System.Windows.Forms.ComboBox
    Friend WithEvents txtchanlno As System.Windows.Forms.TextBox
    Friend WithEvents txtunitno As System.Windows.Forms.TextBox
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btnupdate As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Cmbmodname As System.Windows.Forms.ComboBox
    Friend WithEvents lblhid As System.Windows.Forms.Label
    Friend WithEvents dgvhw As System.Windows.Forms.DataGridView
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mname As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
