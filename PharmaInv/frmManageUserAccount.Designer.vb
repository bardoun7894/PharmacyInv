<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageUserAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageUserAccount))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txttypeUser = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtconfirm = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.categoryName = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.panel1.Controls.Add(Me.pictureBox2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(800, 40)
        Me.panel1.TabIndex = 37
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(3, 4)
        Me.pictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(30, 32)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 5
        Me.pictureBox2.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Arabic Typesetting", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(538, 4)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(209, 39)
        Me.label1.TabIndex = 4
        Me.label1.Text = "تعديل حساب المستخدم"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(797, 414)
        Me.TabControl1.TabIndex = 38
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(789, 378)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "انشاء حساب المستخدم"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.cboStatus)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.txttypeUser)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.txtconfirm)
        Me.Panel2.Controls.Add(Me.txtPass)
        Me.Panel2.Controls.Add(Me.txtUser)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.categoryName)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(781, 363)
        Me.Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(602, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 32)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "الاسم الكامل"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtName.Location = New System.Drawing.Point(90, 164)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(476, 31)
        Me.txtName.TabIndex = 75
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"متاح", "غير متاح"})
        Me.cboStatus.Location = New System.Drawing.Point(90, 250)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(476, 31)
        Me.cboStatus.TabIndex = 74
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(21, 322)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(144, 23)
        Me.LinkLabel1.TabIndex = 39
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "اضغط هنا لتغيير كلمة السر"
        '
        'txttypeUser
        '
        Me.txttypeUser.FormattingEnabled = True
        Me.txttypeUser.Items.AddRange(New Object() {"الادمين", "امين الصندوق"})
        Me.txttypeUser.Location = New System.Drawing.Point(90, 201)
        Me.txttypeUser.Name = "txttypeUser"
        Me.txttypeUser.Size = New System.Drawing.Size(476, 31)
        Me.txttypeUser.TabIndex = 73
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(374, 310)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 35)
        Me.btnCancel.TabIndex = 71
        Me.btnCancel.Text = "الغاء"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(480, 310)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 35)
        Me.btnSave.TabIndex = 70
        Me.btnSave.Text = "اضافة"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtconfirm
        '
        Me.txtconfirm.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtconfirm.Location = New System.Drawing.Point(90, 120)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.Size = New System.Drawing.Size(476, 31)
        Me.txtconfirm.TabIndex = 67
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtPass.Location = New System.Drawing.Point(90, 74)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(476, 31)
        Me.txtPass.TabIndex = 66
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtUser.Location = New System.Drawing.Point(90, 28)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(476, 31)
        Me.txtUser.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(659, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 32)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "الحالة"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(603, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 32)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "نوع المستخدم"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(587, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 32)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "اعادة كلمة السر"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(628, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 32)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "كلمة السر"
        '
        'categoryName
        '
        Me.categoryName.AutoSize = True
        Me.categoryName.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.categoryName.Location = New System.Drawing.Point(602, 32)
        Me.categoryName.Name = "categoryName"
        Me.categoryName.Size = New System.Drawing.Size(106, 32)
        Me.categoryName.TabIndex = 60
        Me.categoryName.Text = "اسم المستخدم"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(789, 378)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "لائحة المستخدمين"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dataGridView2)
        Me.Panel3.Location = New System.Drawing.Point(6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(780, 357)
        Me.Panel3.TabIndex = 1
        '
        'dataGridView2
        '
        Me.dataGridView2.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.dataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridView2.ColumnHeadersHeight = 30
        Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column6, Me.Column5, Me.colstatus})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView2.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridView2.EnableHeadersVisualStyles = False
        Me.dataGridView2.Location = New System.Drawing.Point(4, 4)
        Me.dataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.dataGridView2.Name = "dataGridView2"
        Me.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dataGridView2.RowHeadersVisible = False
        Me.dataGridView2.RowHeadersWidth = 51
        Me.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView2.Size = New System.Drawing.Size(775, 349)
        Me.dataGridView2.TabIndex = 22
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "اسم المستخدم"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "نوع المستخدم"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 102
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "الاسم"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 63
        '
        'colstatus
        '
        Me.colstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Highlight
        Me.colstatus.DefaultCellStyle = DataGridViewCellStyle3
        Me.colstatus.HeaderText = "الحالة"
        Me.colstatus.MinimumWidth = 6
        Me.colstatus.Name = "colstatus"
        Me.colstatus.ReadOnly = True
        Me.colstatus.Width = 62
        '
        'frmManageUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManageUserAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmManageUserAccount"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtconfirm As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label2 As Label
    Private WithEvents categoryName As Label
    Private WithEvents btnCancel As Button
    Public WithEvents btnSave As Button
    Friend WithEvents txttypeUser As ComboBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Private WithEvents dataGridView2 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents colstatus As DataGridViewTextBoxColumn
    Friend WithEvents cboStatus As ComboBox
    Private WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
End Class
