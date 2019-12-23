<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiscount
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiscount))
        Me.txtdescDisc = New System.Windows.Forms.TextBox()
        Me.categoryName = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdescDisc
        '
        Me.txtdescDisc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdescDisc.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtdescDisc.Location = New System.Drawing.Point(389, 40)
        Me.txtdescDisc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdescDisc.Name = "txtdescDisc"
        Me.txtdescDisc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtdescDisc.Size = New System.Drawing.Size(382, 31)
        Me.txtdescDisc.TabIndex = 38
        '
        'categoryName
        '
        Me.categoryName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.categoryName.AutoSize = True
        Me.categoryName.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.categoryName.ForeColor = System.Drawing.Color.White
        Me.categoryName.Location = New System.Drawing.Point(794, 39)
        Me.categoryName.Name = "categoryName"
        Me.categoryName.Size = New System.Drawing.Size(120, 32)
        Me.categoryName.TabIndex = 37
        Me.categoryName.Text = "وصف التخفيض"
        '
        'txtDiscount
        '
        Me.txtDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtDiscount.Location = New System.Drawing.Point(563, 100)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDiscount.Size = New System.Drawing.Size(208, 31)
        Me.txtDiscount.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(806, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 32)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "قيمة التخفيض "
        '
        'dataGridView2
        '
        Me.dataGridView2.AllowUserToAddRows = False
        Me.dataGridView2.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.dataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridView2.ColumnHeadersHeight = 30
        Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column2, Me.Column7, Me.Column8, Me.edit, Me.delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridView2.EnableHeadersVisualStyles = False
        Me.dataGridView2.Location = New System.Drawing.Point(330, 221)
        Me.dataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.dataGridView2.Name = "dataGridView2"
        Me.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dataGridView2.RowHeadersVisible = False
        Me.dataGridView2.RowHeadersWidth = 51
        Me.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView2.Size = New System.Drawing.Size(605, 316)
        Me.dataGridView2.TabIndex = 42
        '
        'Column10
        '
        Me.Column10.HeaderText = "#"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        Me.Column2.Width = 125
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "وصف التخفيض"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "قيمة التخفيض"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        '
        'edit
        '
        Me.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.edit.HeaderText = " "
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.MinimumWidth = 6
        Me.edit.Name = "edit"
        Me.edit.Width = 19
        '
        'delete
        '
        Me.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.delete.HeaderText = ""
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.MinimumWidth = 6
        Me.delete.Name = "delete"
        Me.delete.Width = 6
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(579, 152)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(86, 35)
        Me.btnUpdate.TabIndex = 48
        Me.btnUpdate.Text = "تعديل"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(474, 152)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 35)
        Me.btnCancel.TabIndex = 47
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
        Me.btnSave.Location = New System.Drawing.Point(685, 152)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 35)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "اضافة"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1282, 749)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dataGridView2)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdescDisc)
        Me.Controls.Add(Me.categoryName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDiscount"
        Me.Text = "frmDiscount"
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtdescDisc As TextBox
    Private WithEvents categoryName As Label
    Public WithEvents txtDiscount As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents dataGridView2 As DataGridView
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewImageColumn
    Friend WithEvents delete As DataGridViewImageColumn
    Public WithEvents btnUpdate As Button
    Private WithEvents btnCancel As Button
    Public WithEvents btnSave As Button
End Class
