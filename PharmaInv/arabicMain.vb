Public Class arabicMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmArabicMaintenance
            .Dock = DockStyle.Fill
            .TopLevel = False
            panel3.Controls.Clear()
            panel3.Controls.Add(frmArabicMaintenance)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub arabicMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        btnMaximizar.Visible = False
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub

    Private Sub btnxcerrar_Click(sender As Object, e As EventArgs) Handles btnxcerrar.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With frmProductList
            .Dock = DockStyle.Fill
            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmProductList)
            .BringToFront()
            .loadRecords()

            .Show()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With frmSales
            .btnSales.Enabled = True
            .ShowDialog()

        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With frmRecords
            .Dock = DockStyle.Fill
            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmRecords)
            .BringToFront()


            .Show()
        End With
    End Sub
End Class
