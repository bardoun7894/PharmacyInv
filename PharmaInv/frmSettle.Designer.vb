<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDue = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(427, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "الثمن الواجب دفعه"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(427, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 55)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "الثمن الذي تم قبضه"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arabic Typesetting", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(436, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 55)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "الباقي الواجب رده"
        '
        'lblDue
        '
        Me.lblDue.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblDue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDue.ForeColor = System.Drawing.Color.Green
        Me.lblDue.Location = New System.Drawing.Point(41, 24)
        Me.lblDue.Name = "lblDue"
        Me.lblDue.ReadOnly = True
        Me.lblDue.Size = New System.Drawing.Size(385, 42)
        Me.lblDue.TabIndex = 3
        Me.lblDue.Text = "0.00"
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.ForeColor = System.Drawing.Color.White
        Me.txtCash.Location = New System.Drawing.Point(41, 100)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(385, 42)
        Me.txtCash.TabIndex = 4
        Me.txtCash.Text = "0.00"
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.White
        Me.lblChange.Location = New System.Drawing.Point(41, 192)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.ReadOnly = True
        Me.lblChange.Size = New System.Drawing.Size(385, 42)
        Me.lblChange.TabIndex = 5
        Me.lblChange.Text = "0.00"
        '
        'frmSettle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(695, 286)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.lblDue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSettle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDue As TextBox
    Friend WithEvents txtCash As TextBox
    Friend WithEvents lblChange As TextBox
End Class
