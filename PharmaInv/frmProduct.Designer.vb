<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduct))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.labelId = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.categoryName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.txtGeneric = New System.Windows.Forms.TextBox()
        Me.txtClassification = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtFormulation = New System.Windows.Forms.TextBox()
        Me.txtReOrder = New System.Windows.Forms.TextBox()
        Me.txtQTy = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.labelQtyy = New System.Windows.Forms.Label()
        Me.lblbrand = New System.Windows.Forms.Label()
        Me.lblGeneric = New System.Windows.Forms.Label()
        Me.lblclassification = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblFormulation = New System.Windows.Forms.Label()
        Me.lblreOrder = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
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
        Me.panel1.Size = New System.Drawing.Size(671, 40)
        Me.panel1.TabIndex = 36
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(6, 4)
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
        Me.label1.Location = New System.Drawing.Point(548, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(109, 39)
        Me.label1.TabIndex = 4
        Me.label1.Text = "اعداد المنتج"
        '
        'labelId
        '
        Me.labelId.AutoSize = True
        Me.labelId.Location = New System.Drawing.Point(21, 56)
        Me.labelId.Name = "labelId"
        Me.labelId.Size = New System.Drawing.Size(33, 17)
        Me.labelId.TabIndex = 41
        Me.labelId.Text = "lblid"
        Me.labelId.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(398, 512)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(86, 35)
        Me.btnUpdate.TabIndex = 40
        Me.btnUpdate.Text = "تعديل"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(295, 512)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 35)
        Me.btnCancel.TabIndex = 39
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
        Me.btnSave.Location = New System.Drawing.Point(398, 512)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 35)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "اضافة"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'categoryName
        '
        Me.categoryName.AutoSize = True
        Me.categoryName.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.categoryName.Location = New System.Drawing.Point(548, 90)
        Me.categoryName.Name = "categoryName"
        Me.categoryName.Size = New System.Drawing.Size(63, 32)
        Me.categoryName.TabIndex = 37
        Me.categoryName.Text = "الباركود"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(522, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 32)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "اسم الشعار"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(541, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 32)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "التصنيف"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(524, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 32)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "الاسم العام"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(553, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 32)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "الصيغة"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(564, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 32)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "النوع"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(494, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 32)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "مستوى اعادة الطلب"
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtBarcode.Location = New System.Drawing.Point(12, 86)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(476, 31)
        Me.txtBarcode.TabIndex = 55
        '
        'txtBrand
        '
        Me.txtBrand.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtBrand.Location = New System.Drawing.Point(12, 132)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(476, 31)
        Me.txtBrand.TabIndex = 56
        '
        'txtGeneric
        '
        Me.txtGeneric.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtGeneric.Location = New System.Drawing.Point(12, 178)
        Me.txtGeneric.Name = "txtGeneric"
        Me.txtGeneric.Size = New System.Drawing.Size(476, 31)
        Me.txtGeneric.TabIndex = 57
        '
        'txtClassification
        '
        Me.txtClassification.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtClassification.Location = New System.Drawing.Point(12, 223)
        Me.txtClassification.Name = "txtClassification"
        Me.txtClassification.Size = New System.Drawing.Size(476, 31)
        Me.txtClassification.TabIndex = 58
        '
        'txtType
        '
        Me.txtType.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtType.Location = New System.Drawing.Point(12, 269)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(476, 31)
        Me.txtType.TabIndex = 59
        '
        'txtFormulation
        '
        Me.txtFormulation.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtFormulation.Location = New System.Drawing.Point(12, 318)
        Me.txtFormulation.Name = "txtFormulation"
        Me.txtFormulation.Size = New System.Drawing.Size(476, 31)
        Me.txtFormulation.TabIndex = 60
        '
        'txtReOrder
        '
        Me.txtReOrder.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtReOrder.Location = New System.Drawing.Point(12, 363)
        Me.txtReOrder.Name = "txtReOrder"
        Me.txtReOrder.Size = New System.Drawing.Size(476, 31)
        Me.txtReOrder.TabIndex = 61
        '
        'txtQTy
        '
        Me.txtQTy.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtQTy.Location = New System.Drawing.Point(12, 456)
        Me.txtQTy.Name = "txtQTy"
        Me.txtQTy.Size = New System.Drawing.Size(476, 31)
        Me.txtQTy.TabIndex = 63
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txtPrice.Location = New System.Drawing.Point(12, 411)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(476, 31)
        Me.txtPrice.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(568, 415)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 32)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "الثمن"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(601, 415)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 32)
        Me.Label9.TabIndex = 64
        '
        'labelQtyy
        '
        Me.labelQtyy.AutoSize = True
        Me.labelQtyy.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.labelQtyy.Location = New System.Drawing.Point(556, 460)
        Me.labelQtyy.Name = "labelQtyy"
        Me.labelQtyy.Size = New System.Drawing.Size(51, 32)
        Me.labelQtyy.TabIndex = 66
        Me.labelQtyy.Text = "الكمية"
        '
        'lblbrand
        '
        Me.lblbrand.AutoSize = True
        Me.lblbrand.Location = New System.Drawing.Point(650, 142)
        Me.lblbrand.Name = "lblbrand"
        Me.lblbrand.Size = New System.Drawing.Size(0, 17)
        Me.lblbrand.TabIndex = 67
        Me.lblbrand.Visible = False
        '
        'lblGeneric
        '
        Me.lblGeneric.AutoSize = True
        Me.lblGeneric.Location = New System.Drawing.Point(650, 178)
        Me.lblGeneric.Name = "lblGeneric"
        Me.lblGeneric.Size = New System.Drawing.Size(0, 17)
        Me.lblGeneric.TabIndex = 68
        Me.lblGeneric.Visible = False
        '
        'lblclassification
        '
        Me.lblclassification.AutoSize = True
        Me.lblclassification.Location = New System.Drawing.Point(648, 237)
        Me.lblclassification.Name = "lblclassification"
        Me.lblclassification.Size = New System.Drawing.Size(0, 17)
        Me.lblclassification.TabIndex = 69
        Me.lblclassification.Visible = False
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(650, 288)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(0, 17)
        Me.lblType.TabIndex = 70
        Me.lblType.Visible = False
        '
        'lblFormulation
        '
        Me.lblFormulation.AutoSize = True
        Me.lblFormulation.Location = New System.Drawing.Point(648, 332)
        Me.lblFormulation.Name = "lblFormulation"
        Me.lblFormulation.Size = New System.Drawing.Size(0, 17)
        Me.lblFormulation.TabIndex = 71
        Me.lblFormulation.Visible = False
        '
        'lblreOrder
        '
        Me.lblreOrder.AutoSize = True
        Me.lblreOrder.Location = New System.Drawing.Point(655, 373)
        Me.lblreOrder.Name = "lblreOrder"
        Me.lblreOrder.Size = New System.Drawing.Size(0, 17)
        Me.lblreOrder.TabIndex = 72
        Me.lblreOrder.Visible = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(648, 425)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 17)
        Me.lblPrice.TabIndex = 73
        Me.lblPrice.Visible = False
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(648, 466)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(0, 17)
        Me.lblQty.TabIndex = 74
        Me.lblQty.Visible = False
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(671, 575)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblreOrder)
        Me.Controls.Add(Me.lblFormulation)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblclassification)
        Me.Controls.Add(Me.lblGeneric)
        Me.Controls.Add(Me.lblbrand)
        Me.Controls.Add(Me.labelQtyy)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtQTy)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtReOrder)
        Me.Controls.Add(Me.txtFormulation)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtClassification)
        Me.Controls.Add(Me.txtGeneric)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.labelId)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.categoryName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label1 As Label
    Public WithEvents labelId As Label
    Public WithEvents btnUpdate As Button
    Private WithEvents btnCancel As Button
    Public WithEvents btnSave As Button
    Private WithEvents categoryName As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label6 As Label
    Private WithEvents Label7 As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents txtGeneric As TextBox
    Friend WithEvents txtClassification As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtFormulation As TextBox
    Friend WithEvents txtReOrder As TextBox
    Friend WithEvents txtQTy As TextBox
    Friend WithEvents txtPrice As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents Label9 As Label
    Private WithEvents labelQtyy As Label
    Friend WithEvents lblbrand As Label
    Friend WithEvents lblGeneric As Label
    Friend WithEvents lblclassification As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblFormulation As Label
    Friend WithEvents lblreOrder As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQty As Label
End Class
