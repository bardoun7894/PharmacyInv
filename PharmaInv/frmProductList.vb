Imports MySql.Data.MySqlClient
Public Class frmProductList


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Dispose()

    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        With frmProduct
            .btnSave.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub dataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView2.CellContentClick
        Dim colName As String = dataGridView2.Columns(e.ColumnIndex).Name
        If colName = "edit" Then
            With frmProduct
                .labelId.Text = dataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString
                .txtBarcode.Text = dataGridView2.Rows(e.RowIndex).Cells(2).Value.ToString
                .txtBrand.Text = dataGridView2.Rows(e.RowIndex).Cells(3).Value.ToString
                .txtGeneric.Text = dataGridView2.Rows(e.RowIndex).Cells(4).Value.ToString
                .txtClassification.Text = dataGridView2.Rows(e.RowIndex).Cells(5).Value.ToString
                .txtType.Text = dataGridView2.Rows(e.RowIndex).Cells(6).Value.ToString
                .txtFormulation.Text = dataGridView2.Rows(e.RowIndex).Cells(7).Value.ToString
                .txtReOrder.Text = dataGridView2.Rows(e.RowIndex).Cells(8).Value.ToString
                .txtPrice.Text = dataGridView2.Rows(e.RowIndex).Cells(9).Value.ToString
                .txtQTy.Text = dataGridView2.Rows(e.RowIndex).Cells(10).Value.ToString
                .ShowDialog()
            End With
        End If
        If colName = "delete" Then
            Try
                If (MsgBox("هل تريد حذف هاته البيانات", vbYesNo + vbQuestion) = vbYes) Then
                    cn.Open()
                    cm = New MySqlCommand("delete from tblProduct where id = '" + dataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString + "' ", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("تم الحذف بنجاح")
                End If

            Catch ex As Exception
                MsgBox(ex.Message And " المرجو الاتصال بالمبرمج لحل المشكل")
            End Try
            loadRecords()


        End If
    End Sub


    Sub loadRecords()
        Try
            Dim stock As Double = 0

            Dim i As Integer = 0
            dataGridView2.Rows.Clear()

            cn.Open()
            cm = New MySqlCommand("SELECT * FROM `tblproduct` as p INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id", cn)
            dr = cm.ExecuteReader()
            While dr.Read()
                i += 1
                dataGridView2.Rows.Add(
                        i, dr.Item("id").ToString(), dr.Item("barcode").ToString(),
                         dr.Item("brand").ToString(), dr.Item("generic").ToString(),
                        dr.Item("classification").ToString(), dr.Item("type").ToString(),
                         dr.Item("formulation").ToString(), dr.Item("reorder").ToString(),
                          dr.Item("price").ToString(), dr.Item("qty").ToString())
            End While



            For i = 0 To dataGridView2.Rows.Count - 1
                If dataGridView2.Rows(i).Cells(9).Value.ToString <> String.Empty Then
                    stock += CDbl(dataGridView2.Rows(i).Cells(9).Value.ToString)
                End If
                txtCount.Text = stock



            Next
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picStock.Click
        Dim tt As New ToolTip()
        tt.SetToolTip(picStock, "المخزن")
        With frmstockin
            .loadRecords()
            .loadStockByHistory()
            .cboFilter.Text = "الباركود"
            .ShowDialog()

        End With
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class