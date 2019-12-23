Public Class frmArabicMaintenance
    Private Sub btnClassific_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        With frmClassificationList
            .Dock = DockStyle.Fill
            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmClassificationList)
            .BringToFront()
            .loadRecords()

            .Show()
        End With
    End Sub

    Private Sub typebtn_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        With frmTypeList
            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmTypeList)
            .BringToFront()
            .loadRecords()
            .Show()

        End With
    End Sub

    Private Sub btnBrand(sender As Object, e As EventArgs) Handles PictureBox1.Click
        With frmBrandList
            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmBrandList)
            .BringToFront()
            .loadRecords()
            .Show()

        End With
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        With frmGenericList


            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmGenericList)
            .BringToFront()
            .loadRecords()
            .Show()
        End With

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        With frmFormulationList


            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmFormulationList)
            .BringToFront()
            .loadRecords()
            .Show()
        End With
    End Sub

    Private Sub vatEdit_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        With frmVat

            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmVat)
            .BringToFront()
            .txtVat.Text = getVat()

            .Show()
        End With
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        With frmDiscount
            .TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(frmDiscount)
            .BringToFront()
            .loadDiscounts()
            .Show()
        End With
    End Sub
End Class