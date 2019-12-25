Imports MySql.Data.MySqlClient

Public Class frmRecords
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        With frmProductList
            pnlSearch.Visible = True 'خاصة ب ببانل البحث 
            .Dock = DockStyle.Fill
            .TopLevel = False
            Panel2.Controls.Clear()
            Panel2.Controls.Add(frmProductList)
            .BringToFront()
            .lblproduct.Visible = False
            .picStock.Visible = False
            .btnaddProdtuct.Visible = False
            .btnExit.Visible = False
            .searchRecords(cboFilter.Text, txtSearch.Text, txtCount.Text, txtStockCount.Text)
            panelQtyStock.Visible = True





            .Show()

        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        With frmProductList
            .searchRecords(cboFilter.Text, txtSearch.Text, txtCount.Text, txtStockCount.Text)
        End With
    End Sub
End Class