Imports MySql.Data.MySqlClient



Public Class frmSalesInventory

    Dim i As Integer = 0
    Sub loadRecordsSales()
        dataGridView2.Rows.Clear()

        Try
            cn.Open()
            cm = New MySqlCommand("select * from tblPayment where sdate between '" & dt1.Value.ToString("yyyy-MM-dd") & "' and '" & dt2.Value.ToString("yyyy-MM-dd") & "' order by id", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                dataGridView2.Rows.Add(i, dr.Item("id").ToString, dr.Item("invoice").ToString, dr.Item("subtotal").ToString, dr.Item("vat").ToString,
             dr.Item("discount").ToString, dr.Item("amountdue").ToString, dr.Item("sdate").ToString, dr.Item("user").ToString)
            End While

            cn.Close()
            dr.Close()
            txtTotal.Text = dataGridView2.Rows.Count
            txtDiscount.Text = getdata("select ifnull(sum(discount),0) from tblPayment ")
            txtVat.Text = getdata("select ifnull(sum(vat),0) from tblPayment  ")
            txtSubTotal.Text = getdata("select ifnull(sum(subtotal),0) from tblPayment ")
            txtSales.Text = getdata("select ifnull(sum(amountdue),0) from tblPayment ")



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadRecordsSales()

    End Sub

    Private Sub dataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView2.CellContentClick

    End Sub
End Class