<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formassociation
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSno = New System.Windows.Forms.TextBox
        Me.txtInstno = New System.Windows.Forms.TextBox
        Me.CmbUno = New System.Windows.Forms.ComboBox
        Me.CmbMno = New System.Windows.Forms.ComboBox
        Me.CmbSearch = New System.Windows.Forms.ComboBox
        Me.dgvassociation = New System.Windows.Forms.DataGridView
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.BTnOk = New System.Windows.Forms.Button
        Me.cmbVehicle = New System.Windows.Forms.ComboBox
        Me.cmbCustomerNo = New System.Windows.Forms.ComboBox
        Me.txtsearch = New System.Windows.Forms.TextBox
        CType(Me.dgvassociation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vehicle No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 254)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mobile No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 314)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sim No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 381)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 38)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Installation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Report No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 456)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(478, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Search By"
        '
        'txtSno
        '
        Me.txtSno.Location = New System.Drawing.Point(117, 312)
        Me.txtSno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSno.Name = "txtSno"
        Me.txtSno.ReadOnly = True
        Me.txtSno.Size = New System.Drawing.Size(154, 26)
        Me.txtSno.TabIndex = 10
        '
        'txtInstno
        '
        Me.txtInstno.Location = New System.Drawing.Point(117, 385)
        Me.txtInstno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInstno.Name = "txtInstno"
        Me.txtInstno.Size = New System.Drawing.Size(154, 26)
        Me.txtInstno.TabIndex = 11
        '
        'CmbUno
        '
        Me.CmbUno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUno.FormattingEnabled = True
        Me.CmbUno.Location = New System.Drawing.Point(117, 184)
        Me.CmbUno.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbUno.Name = "CmbUno"
        Me.CmbUno.Size = New System.Drawing.Size(154, 27)
        Me.CmbUno.TabIndex = 12
        '
        'CmbMno
        '
        Me.CmbMno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMno.FormattingEnabled = True
        Me.CmbMno.Location = New System.Drawing.Point(117, 252)
        Me.CmbMno.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbMno.Name = "CmbMno"
        Me.CmbMno.Size = New System.Drawing.Size(154, 27)
        Me.CmbMno.TabIndex = 14
        '
        'CmbSearch
        '
        Me.CmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Items.AddRange(New Object() {"Vehicle No", "Customer No", "Unit No", "Mobile", ""})
        Me.CmbSearch.Location = New System.Drawing.Point(570, 25)
        Me.CmbSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(130, 27)
        Me.CmbSearch.TabIndex = 15
        '
        'dgvassociation
        '
        Me.dgvassociation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvassociation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvassociation.Location = New System.Drawing.Point(310, 79)
        Me.dgvassociation.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvassociation.Name = "dgvassociation"
        Me.dgvassociation.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvassociation.Size = New System.Drawing.Size(942, 439)
        Me.dgvassociation.TabIndex = 16
        '
        'Column10
        '
        Me.Column10.HeaderText = "a_id"
        Me.Column10.Name = "Column10"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Customer"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Vehicle No"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Unit No"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Mobile No"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sim No"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Installation Report No"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Date"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Status"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "SimStatus"
        Me.Column9.Name = "Column9"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(119, 452)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(154, 26)
        Me.DateTimePicker1.TabIndex = 17
        '
        'BTnOk
        '
        Me.BTnOk.Location = New System.Drawing.Point(58, 509)
        Me.BTnOk.Name = "BTnOk"
        Me.BTnOk.Size = New System.Drawing.Size(160, 36)
        Me.BTnOk.TabIndex = 18
        Me.BTnOk.Text = "Make Association"
        Me.BTnOk.UseVisualStyleBackColor = True
        '
        'cmbVehicle
        '
        Me.cmbVehicle.FormattingEnabled = True
        Me.cmbVehicle.Location = New System.Drawing.Point(119, 79)
        Me.cmbVehicle.Name = "cmbVehicle"
        Me.cmbVehicle.Size = New System.Drawing.Size(157, 27)
        Me.cmbVehicle.TabIndex = 19
        '
        'cmbCustomerNo
        '
        Me.cmbCustomerNo.FormattingEnabled = True
        Me.cmbCustomerNo.Location = New System.Drawing.Point(119, 126)
        Me.cmbCustomerNo.Name = "cmbCustomerNo"
        Me.cmbCustomerNo.Size = New System.Drawing.Size(157, 27)
        Me.cmbCustomerNo.TabIndex = 20
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(743, 25)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(138, 26)
        Me.txtsearch.TabIndex = 21
        '
        'Formassociation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1265, 660)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.cmbCustomerNo)
        Me.Controls.Add(Me.cmbVehicle)
        Me.Controls.Add(Me.BTnOk)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dgvassociation)
        Me.Controls.Add(Me.CmbSearch)
        Me.Controls.Add(Me.CmbMno)
        Me.Controls.Add(Me.CmbUno)
        Me.Controls.Add(Me.txtInstno)
        Me.Controls.Add(Me.txtSno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Formassociation"
        Me.Text = "Formassociation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvassociation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSno As System.Windows.Forms.TextBox
    Friend WithEvents txtInstno As System.Windows.Forms.TextBox
    Friend WithEvents CmbUno As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMno As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents dgvassociation As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BTnOk As System.Windows.Forms.Button
    Friend WithEvents cmbVehicle As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCustomerNo As System.Windows.Forms.ComboBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
