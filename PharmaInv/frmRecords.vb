Imports MySql.Data.MySqlClient

Public Class frmRecords
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ProductSearchRecords.Click

        With frmProductList
            pnlSearch.Visible = True 'خاصة ب ببانل البحث 
            .Dock = DockStyle.Fill
            .TopLevel = False
            Panel2.Controls.Clear()
            Panel2.Controls.Add(frmProductList)
            .BringToFront()
            .lblproduct.Visible = False
            cboFilter.Visible = True
            txtSearch.Visible = True

            cboStock.Visible = False
            .picStock.Visible = False
            pictureSearch.Visible = True

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

    Private Sub btnOutStock(sender As Object, e As EventArgs) Handles PictureBox3.Click
        With frmProductList
            cboStock.Text = ""
            pnlSearch.Visible = True 'خاصة ب ببانل البحث 
            .Dock = DockStyle.Fill
            .TopLevel = False
            Panel2.Controls.Clear()
            Panel2.Controls.Add(frmProductList)
            .BringToFront()
            .lblproduct.Visible = False
            cboStock.Visible = True
            pictureSearch.Visible = False

            cboFilter.Visible = False
            txtSearch.Visible = False
            .picStock.Visible = False
            .btnaddProdtuct.Visible = False
            .btnExit.Visible = False
            panelQtyStock.Visible = True
            .Show()

        End With
    End Sub

    Private Sub cboStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboStock.KeyPress
        e.Handled = True

    End Sub

    Private Sub cboStock_TextChanged(sender As Object, e As EventArgs) Handles cboStock.TextChanged
        With frmProductList
            .criticalStock(cboStock.Text, txtStockCount.Text, txtCount.Text)
        End With

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If ConnectionState.Open Then cn.Close()
        With frmSalesInventory
            .Dock = DockStyle.Fill
            .TopLevel = False
            pnlSearch.Visible = False
            .loadRecordsSales()
            panelQtyStock.Visible = False
            Panel2.Controls.Clear()
            Panel2.Controls.Add(frmSalesInventory)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        With frmSoldItem
            .pn.Visible = False

            .Dock = DockStyle.Fill
            pnlSearch.Visible = False
            .TopLevel = False
            .GetSoldType()
            Panel2.Controls.Clear()
            Panel2.Controls.Add(frmSoldItem)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        With frmSoldItem
  
            .Dock = DockStyle.Fill
            pnlSearch.Visible = False
            .TopLevel = False
            .GetSoldType()
            Panel2.Controls.Clear()
            Panel2.Controls.Add(frmSoldItem)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class