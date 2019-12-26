<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesInventory
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.dataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dt2)
        Me.Panel1.Controls.Add(Me.dt1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1459, 43)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arabic Typesetting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(302, 9)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 28)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "اذهب"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(680, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "الى"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1012, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "البحث بالتاريخ  من"
        '
        'dt2
        '
        Me.dt2.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dt2.Location = New System.Drawing.Point(384, 10)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(287, 30)
        Me.dt2.TabIndex = 42
        '
        'dt1
        '
        Me.dt1.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dt1.Location = New System.Drawing.Point(710, 10)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(287, 30)
        Me.dt1.TabIndex = 41
        '
        'dataGridView2
        '
        Me.dataGridView2.AllowUserToAddRows = False
        Me.dataGridView2.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.dataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.dataGridView2.ColumnHeadersHeight = 40
        Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column6, Me.Column10, Me.Column1, Me.Column2, Me.Column4, Me.Column3, Me.Column8, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridView2.EnableHeadersVisualStyles = False
        Me.dataGridView2.Location = New System.Drawing.Point(12, 19)
        Me.dataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.dataGridView2.Name = "dataGridView2"
        Me.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dataGridView2.RowHeadersVisible = False
        Me.dataGridView2.RowHeadersWidth = 51
        Me.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView2.Size = New System.Drawing.Size(1434, 631)
        Me.dataGridView2.TabIndex = 34
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "المستخدم"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 106
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "التاريخ"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 81
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "المبلغ المستحق"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 147
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "التخفيضات"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 115
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "القيمة المضافة"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 145
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "المبلغ الاجمالي"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 142
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = "رقم الفاتورة"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        '
        'Column6
        '
        Me.Column6.HeaderText = "ID"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        Me.Column6.Width = 125
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column11.HeaderText = "#"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 125
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtDiscount)
        Me.Panel3.Controls.Add(Me.txtTotal)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtSales)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtVat)
        Me.Panel3.Controls.Add(Me.txtSubTotal)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 657)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1459, 55)
        Me.Panel3.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(692, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 23)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "المبلغ الاجمالي"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubTotal.Font = New System.Drawing.Font("A GOOGLE", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txtSubTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtSubTotal.Location = New System.Drawing.Point(599, 2)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubTotal.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtSubTotal.Size = New System.Drawing.Size(80, 25)
        Me.txtSubTotal.TabIndex = 57
        Me.txtSubTotal.Text = "0.00"
        '
        'txtVat
        '
        Me.txtVat.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtVat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVat.Font = New System.Drawing.Font("A GOOGLE", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txtVat.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtVat.Location = New System.Drawing.Point(826, 1)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtVat.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtVat.Size = New System.Drawing.Size(80, 25)
        Me.txtVat.TabIndex = 55
        Me.txtVat.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(504, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 23)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "التخفيضات"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(920, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "القيمة المضافة"
        '
        'txtSales
        '
        Me.txtSales.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSales.Font = New System.Drawing.Font("A GOOGLE", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txtSales.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtSales.Location = New System.Drawing.Point(1018, 1)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSales.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtSales.Size = New System.Drawing.Size(80, 25)
        Me.txtSales.TabIndex = 53
        Me.txtSales.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(106, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 23)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "مجموع الفواتير"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(1108, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 23)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "مجموع المبيعات اليومية"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("A GOOGLE", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtTotal.Location = New System.Drawing.Point(12, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtTotal.Size = New System.Drawing.Size(80, 25)
        Me.txtTotal.TabIndex = 61
        Me.txtTotal.Text = "0.00"
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiscount.Font = New System.Drawing.Font("A GOOGLE", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txtDiscount.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtDiscount.Location = New System.Drawing.Point(418, 1)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDiscount.Size = New System.Drawing.Size(80, 25)
        Me.txtDiscount.TabIndex = 59
        Me.txtDiscount.Text = "0.00"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.dataGridView2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1459, 712)
        Me.Panel2.TabIndex = 1
        '
        'frmSalesInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1459, 755)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalesInventory"
        Me.Text = "frmSalesInventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Public WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dt2 As DateTimePicker
    Friend WithEvents dt1 As DateTimePicker
    Public WithEvents dataGridView2 As DataGridView
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtTotal As TextBox
    Private WithEvents Label2 As Label
    Private WithEvents Label7 As Label
    Friend WithEvents txtSales As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents Label5 As Label
    Friend WithEvents txtVat As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
End Class
