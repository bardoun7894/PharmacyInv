<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChooseDiscount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChooseDiscount))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.categoryName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboDescription = New MetroFramework.Controls.MetroComboBox()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panel1.Size = New System.Drawing.Size(771, 40)
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
        Me.label1.Location = New System.Drawing.Point(659, 1)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(109, 39)
        Me.label1.TabIndex = 4
        Me.label1.Text = "اعداد المنتج"
        '
        'txtdiscount
        '
        Me.txtdiscount.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtdiscount.Location = New System.Drawing.Point(314, 125)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(255, 31)
        Me.txtdiscount.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(614, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 32)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "التخفيض"
        '
        'categoryName
        '
        Me.categoryName.AutoSize = True
        Me.categoryName.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.categoryName.Location = New System.Drawing.Point(620, 78)
        Me.categoryName.Name = "categoryName"
        Me.categoryName.Size = New System.Drawing.Size(66, 32)
        Me.categoryName.TabIndex = 57
        Me.categoryName.Text = "الوصف"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(331, 172)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 35)
        Me.btnSave.TabIndex = 61
        Me.btnSave.Text = "حدد"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cboDescription
        '
        Me.cboDescription.FormattingEnabled = True
        Me.cboDescription.ItemHeight = 24
        Me.cboDescription.Location = New System.Drawing.Point(146, 78)
        Me.cboDescription.Name = "cboDescription"
        Me.cboDescription.Size = New System.Drawing.Size(423, 30)
        Me.cboDescription.TabIndex = 62
        '
        'frmChooseDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 262)
        Me.Controls.Add(Me.cboDescription)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.categoryName)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChooseDiscount"
        Me.Text = "frmAddDiscount"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label1 As Label
    Friend WithEvents txtdiscount As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents categoryName As Label
    Public WithEvents btnSave As Button
    Friend WithEvents cboDescription As MetroFramework.Controls.MetroComboBox
End Class
