﻿Public Class arabicMain

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmArabicMaintenance
            .Dock = DockStyle.Fill
            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmArabicMaintenance)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub arabicMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.WindowState = FormWindowState.Maximized


        Connection()
        btnMaximizar.Visible = False
        With frmRecords

            .Dock = DockStyle.Fill
            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmRecords)
            .BringToFront()
            .Show()
        End With
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        With frmRecords

            .Dock = DockStyle.Fill
            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmRecords)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        With frmManageUserAccount
            .loadUserList()
            .ShowDialog()
        End With
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With frmReport

            .Dock = DockStyle.Fill
            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmReport)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Dispose()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        With StockAdjustement
            .Show()
        End With
    End Sub
End Class
