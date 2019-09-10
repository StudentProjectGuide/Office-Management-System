<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formsim
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Cmbsname = New System.Windows.Forms.ComboBox
        Me.CmbMno = New System.Windows.Forms.ComboBox
        Me.CmbPname = New System.Windows.Forms.ComboBox
        Me.txtSimno = New System.Windows.Forms.TextBox
        Me.Btnadd = New System.Windows.Forms.Button
        Me.dtpdoa = New System.Windows.Forms.DateTimePicker
        Me.txtchanlno = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btndelete = New System.Windows.Forms.Button
        Me.Btnupdate = New System.Windows.Forms.Button
        Me.lblsid = New System.Windows.Forms.Label
        Me.tabpage2 = New System.Windows.Forms.TabPage
        Me.dgvsim = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tabpage2.SuspendLayout()
        CType(Me.dgvsim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(34, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suppiler Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(34, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " Plan "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mobile No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(401, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sim No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(401, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 38)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date Of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Activation"
        '
        'Cmbsname
        '
        Me.Cmbsname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbsname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbsname.FormattingEnabled = True
        Me.Cmbsname.Location = New System.Drawing.Point(158, 74)
        Me.Cmbsname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cmbsname.Name = "Cmbsname"
        Me.Cmbsname.Size = New System.Drawing.Size(178, 27)
        Me.Cmbsname.TabIndex = 5
        '
        'CmbMno
        '
        Me.CmbMno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMno.FormattingEnabled = True
        Me.CmbMno.Location = New System.Drawing.Point(158, 215)
        Me.CmbMno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbMno.Name = "CmbMno"
        Me.CmbMno.Size = New System.Drawing.Size(178, 27)
        Me.CmbMno.TabIndex = 7
        '
        'CmbPname
        '
        Me.CmbPname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPname.FormattingEnabled = True
        Me.CmbPname.Location = New System.Drawing.Point(158, 142)
        Me.CmbPname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbPname.Name = "CmbPname"
        Me.CmbPname.Size = New System.Drawing.Size(178, 27)
        Me.CmbPname.TabIndex = 8
        '
        'txtSimno
        '
        Me.txtSimno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimno.Location = New System.Drawing.Point(544, 75)
        Me.txtSimno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSimno.Name = "txtSimno"
        Me.txtSimno.Size = New System.Drawing.Size(205, 26)
        Me.txtSimno.TabIndex = 9
        '
        'Btnadd
        '
        Me.Btnadd.ForeColor = System.Drawing.Color.Black
        Me.Btnadd.Location = New System.Drawing.Point(147, 306)
        Me.Btnadd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(96, 34)
        Me.Btnadd.TabIndex = 10
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'dtpdoa
        '
        Me.dtpdoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdoa.Location = New System.Drawing.Point(544, 141)
        Me.dtpdoa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpdoa.Name = "dtpdoa"
        Me.dtpdoa.Size = New System.Drawing.Size(205, 26)
        Me.dtpdoa.TabIndex = 11
        '
        'txtchanlno
        '
        Me.txtchanlno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchanlno.Location = New System.Drawing.Point(544, 215)
        Me.txtchanlno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtchanlno.Name = "txtchanlno"
        Me.txtchanlno.Size = New System.Drawing.Size(205, 26)
        Me.txtchanlno.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(382, 223)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Delivery Channel No"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.tabpage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(38, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(838, 431)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btndelete)
        Me.TabPage1.Controls.Add(Me.Btnupdate)
        Me.TabPage1.Controls.Add(Me.lblsid)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtchanlno)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.dtpdoa)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Btnadd)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtSimno)
        Me.TabPage1.Controls.Add(Me.Cmbsname)
        Me.TabPage1.Controls.Add(Me.CmbPname)
        Me.TabPage1.Controls.Add(Me.CmbMno)
        Me.TabPage1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(830, 399)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New"
        '
        'btndelete
        '
        Me.btndelete.ForeColor = System.Drawing.Color.Black
        Me.btndelete.Location = New System.Drawing.Point(503, 306)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(101, 34)
        Me.btndelete.TabIndex = 17
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Btnupdate
        '
        Me.Btnupdate.ForeColor = System.Drawing.Color.Black
        Me.Btnupdate.Location = New System.Drawing.Point(329, 306)
        Me.Btnupdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(101, 34)
        Me.Btnupdate.TabIndex = 16
        Me.Btnupdate.Text = "Update"
        Me.Btnupdate.UseVisualStyleBackColor = True
        '
        'lblsid
        '
        Me.lblsid.AutoSize = True
        Me.lblsid.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblsid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsid.ForeColor = System.Drawing.Color.Black
        Me.lblsid.Location = New System.Drawing.Point(34, 44)
        Me.lblsid.Name = "lblsid"
        Me.lblsid.Size = New System.Drawing.Size(23, 19)
        Me.lblsid.TabIndex = 15
        Me.lblsid.Text = "Id"
        '
        'tabpage2
        '
        Me.tabpage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tabpage2.Controls.Add(Me.dgvsim)
        Me.tabpage2.Location = New System.Drawing.Point(4, 28)
        Me.tabpage2.Name = "tabpage2"
        Me.tabpage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage2.Size = New System.Drawing.Size(830, 399)
        Me.tabpage2.TabIndex = 1
        Me.tabpage2.Text = "Search"
        '
        'dgvsim
        '
        Me.dgvsim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvsim.GridColor = System.Drawing.Color.Black
        Me.dgvsim.Location = New System.Drawing.Point(41, 52)
        Me.dgvsim.Name = "dgvsim"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgvsim.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvsim.Size = New System.Drawing.Size(741, 315)
        Me.dgvsim.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "s_name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "p_name"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "mob_no"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "sim_no"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "doa"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "dcn"
        Me.Column7.Name = "Column7"
        '
        'Formsim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(911, 516)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Formsim"
        Me.Text = "formsim"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.tabpage2.ResumeLayout(False)
        CType(Me.dgvsim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cmbsname As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMno As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPname As System.Windows.Forms.ComboBox
    Friend WithEvents txtSimno As System.Windows.Forms.TextBox
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents dtpdoa As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtchanlno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tabpage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvsim As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblsid As System.Windows.Forms.Label
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Btnupdate As System.Windows.Forms.Button
End Class
