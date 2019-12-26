<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecords))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ProductSearchRecords = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.cboStock = New MetroFramework.Controls.MetroComboBox()
        Me.pictureSearch = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboFilter = New MetroFramework.Controls.MetroComboBox()
        Me.panelQtyStock = New System.Windows.Forms.Panel()
        Me.pnlStockR = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStockCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductSearchRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        CType(Me.pictureSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelQtyStock.SuspendLayout()
        Me.pnlStockR.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.ProductSearchRecords)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1282, 89)
        Me.Panel1.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arabic Typesetting", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(576, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 27)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "حالة نفاذ المخزون"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(598, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(61, 53)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(699, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "المبيعات"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(794, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "المخزون"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(694, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'ProductSearchRecords
        '
        Me.ProductSearchRecords.Image = CType(resources.GetObject("ProductSearchRecords.Image"), System.Drawing.Image)
        Me.ProductSearchRecords.Location = New System.Drawing.Point(785, 6)
        Me.ProductSearchRecords.Name = "ProductSearchRecords"
        Me.ProductSearchRecords.Size = New System.Drawing.Size(61, 53)
        Me.ProductSearchRecords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductSearchRecords.TabIndex = 0
        Me.ProductSearchRecords.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1282, 701)
        Me.Panel2.TabIndex = 24
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.White
        Me.pnlSearch.Controls.Add(Me.cboStock)
        Me.pnlSearch.Controls.Add(Me.pictureSearch)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.cboFilter)
        Me.pnlSearch.Location = New System.Drawing.Point(0, 92)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(1282, 39)
        Me.pnlSearch.TabIndex = 25
        Me.pnlSearch.Visible = False
        '
        'cboStock
        '
        Me.cboStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStock.DisplayMember = "الباركود"
        Me.cboStock.FormattingEnabled = True
        Me.cboStock.ItemHeight = 24
        Me.cboStock.Items.AddRange(New Object() {"", "نفاذ المخزون", "اقتراب نفاذ المخزون"})
        Me.cboStock.Location = New System.Drawing.Point(25, 3)
        Me.cboStock.Name = "cboStock"
        Me.cboStock.Size = New System.Drawing.Size(261, 30)
        Me.cboStock.TabIndex = 30
        Me.cboStock.Visible = False
        '
        'pictureSearch
        '
        Me.pictureSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureSearch.Image = CType(resources.GetObject("pictureSearch.Image"), System.Drawing.Image)
        Me.pictureSearch.Location = New System.Drawing.Point(296, 3)
        Me.pictureSearch.Name = "pictureSearch"
        Me.pictureSearch.Size = New System.Drawing.Size(34, 30)
        Me.pictureSearch.TabIndex = 27
        Me.pictureSearch.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(338, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(807, 30)
        Me.txtSearch.TabIndex = 29
        '
        'cboFilter
        '
        Me.cboFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFilter.DisplayMember = "الباركود"
        Me.cboFilter.FormattingEnabled = True
        Me.cboFilter.ItemHeight = 24
        Me.cboFilter.Items.AddRange(New Object() {"الباركود", "اسم الشعار", "الاسم العام"})
        Me.cboFilter.Location = New System.Drawing.Point(25, 3)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(261, 30)
        Me.cboFilter.TabIndex = 28
        '
        'panelQtyStock
        '
        Me.panelQtyStock.Controls.Add(Me.pnlStockR)
        Me.panelQtyStock.Controls.Add(Me.Label4)
        Me.panelQtyStock.Controls.Add(Me.txtCount)
        Me.panelQtyStock.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelQtyStock.Location = New System.Drawing.Point(0, 733)
        Me.panelQtyStock.Name = "panelQtyStock"
        Me.panelQtyStock.Size = New System.Drawing.Size(1282, 57)
        Me.panelQtyStock.TabIndex = 26
        Me.panelQtyStock.Visible = False
        '
        'pnlStockR
        '
        Me.pnlStockR.Controls.Add(Me.Label3)
        Me.pnlStockR.Controls.Add(Me.txtStockCount)
        Me.pnlStockR.Location = New System.Drawing.Point(868, 3)
        Me.pnlStockR.Name = "pnlStockR"
        Me.pnlStockR.Size = New System.Drawing.Size(224, 51)
        Me.pnlStockR.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "عدد المنتجات في المخزن"
        '
        'txtStockCount
        '
        Me.txtStockCount.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtStockCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockCount.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtStockCount.Location = New System.Drawing.Point(14, 19)
        Me.txtStockCount.Name = "txtStockCount"
        Me.txtStockCount.Size = New System.Drawing.Size(48, 18)
        Me.txtStockCount.TabIndex = 23
        Me.txtStockCount.Text = "0"
        Me.txtStockCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1185, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 23)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "كمية الانواع"
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCount.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCount.Location = New System.Drawing.Point(1125, 19)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(48, 18)
        Me.txtCount.TabIndex = 26
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arabic Typesetting", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(491, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 27)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "جرد المبيعات"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(499, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(407, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(61, 53)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arabic Typesetting", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(402, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 27)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "الأكثر مبيعا"
        '
        'frmRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1282, 790)
        Me.Controls.Add(Me.panelQtyStock)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRecords"
        Me.Text = "frmRecords"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductSearchRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.pictureSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelQtyStock.ResumeLayout(False)
        Me.panelQtyStock.PerformLayout()
        Me.pnlStockR.ResumeLayout(False)
        Me.pnlStockR.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ProductSearchRecords As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents pictureSearch As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cboFilter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents panelQtyStock As Panel
    Friend WithEvents pnlStockR As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStockCount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cboStock As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label7 As Label
End Class
