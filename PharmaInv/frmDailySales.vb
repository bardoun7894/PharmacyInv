
Imports MySql.Data.MySqlClient

Public Class frmDailySales


    Sub loadDailySales()
        Dim sdate As String = Now.ToString("yyyy-MM-dd")
        lblDate.Text = sdate & " : تاريخ اليوم"
        Dim i As Integer = 0
        Try
            dataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM `tblCart` as ca inner JOIN `tblproduct` as p
          on ca.pid=p.id INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c 
           on p.cid =c.id INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g 
           on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id where sdate between '" & sdate & "' and '" & sdate & "' and status like 'Sold'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
               
                dataGridView2.Rows.Add(i, dr.Item("id").ToString, dr.Item("pid").ToString, dr.Item("brand"), dr.Item("generic").ToString, dr.Item("classification").ToString, dr.Item("type").ToString, dr.Item("formulation").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString)

            End While
            dr.Close()
            cn.Close()


            txtTotal.Text = getdata("select sum(total) from tblcart where sdate between '" & sdate & "' and '" & sdate & "' and status like 'Sold'")
            txtDiscount.Text = getdata("select sum(discount) from tblPayment where sdate between '" & sdate & "' and '" & sdate & "' ")
            txtVat.Text = getdata("select sum(vat) from tblPayment where sdate between '" & sdate & "' and '" & sdate & "'")
            txtSubTotal.Text = getdata("select sum(subtotal) from tblPayment where sdate between '" & sdate & "' and '" & sdate & "'")
            txtSales.Text = getdata("select sum(amountdue) from tblPayment where sdate between '" & sdate & "' and '" & sdate & "'")
            lblTotal.Text = txtSales.Text
            dataGridView2.Rows.Add("", "", "", "", "", "", "", "", "", "المجموع", txtTotal.Text)
        Catch ex As Exception
            dr.Close()
            cn.Close()
            MsgBox(ex.Message)

        End Try



    End Sub
    Function getdata(ByVal sql As String) As String
        Try
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            getdata = cm.ExecuteScalar
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function

    Private Sub dataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView2.CellContentClick

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub frmDailySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class