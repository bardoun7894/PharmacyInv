<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.Controls.Add(Me.btnExit)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1060, 40)
        Me.panel1.TabIndex = 91
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(3, 4)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(30, 32)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnExit.TabIndex = 6
        Me.btnExit.TabStop = False
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.White
        Me.label1.Font = New System.Drawing.Font("Arabic Typesetting", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(957, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(91, 27)
        Me.label1.TabIndex = 4
        Me.label1.Text = "تقرير المبيعات"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(529, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 23)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "الى"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(735, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 23)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "البحث بالتاريخ  من"
        '
        'dt2
        '
        Me.dt2.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dt2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt2.Location = New System.Drawing.Point(363, 49)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(149, 30)
        Me.dt2.TabIndex = 93
        '
        'dt1
        '
        Me.dt1.CustomFormat = ""
        Me.dt1.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt1.Location = New System.Drawing.Point(567, 50)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(149, 30)
        Me.dt1.TabIndex = 92
        '
        'cboUser
        '
        Me.cboUser.Font = New System.Drawing.Font("Arabic Typesetting", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(872, 49)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(150, 31)
        Me.cboUser.TabIndex = 97
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PharmaInv.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 86)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1036, 478)
        Me.ReportViewer1.TabIndex = 98
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arabic Typesetting", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(244, 49)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 30)
        Me.btnSave.TabIndex = 99
        Me.btnSave.Text = "بحث"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1060, 576)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.cboUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dt2)
        Me.Controls.Add(Me.dt1)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReport"
        Me.Text = "frmReport"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel1 As Panel
    Private WithEvents label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dt2 As DateTimePicker
    Friend WithEvents dt1 As DateTimePicker
    Friend WithEvents cboUser As ComboBox
    Public WithEvents btnExit As PictureBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Public WithEvents btnSave As Button
End Class
