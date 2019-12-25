Imports MySql.Data.MySqlClient
Public Class frmProductList


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()

    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles btnaddProdtuct.Click
        With frmProduct
            .btnSave.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub dataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView2.CellContentClick
        Dim colName As String = dataGridView2.Columns(e.ColumnIndex).Name
        If colName = "edit" Then
            If (MsgBox("هل تريد تعديل هاته البيانات", vbYesNo + vbQuestion) = vbYes) Then
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
    'هذه الدالة خاصة بالارشيف
    Sub searchRecords(ByVal cboFilter As String, ByVal txtSearch As String, ByRef rcount As String, ByRef icount As String)
        If ConnectionState.Open Then cn.Close()
        Try
            Dim stock As Double = 0

            Dim i As Integer = 0
            dataGridView2.Rows.Clear()
            Dim tc As String = ""

            Select Case cboFilter
                Case "اسم الشعار"
                    tc = "brand"
                Case "الباركود"
                    tc = "barcode"
                Case "الاسم العام"
                    tc = "generic"
            End Select
            cn.Open()
            cm = Nothing

            If tc = "barcode" Then cm = New MySqlCommand("SELECT * FROM  `tblproduct` as p INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id where qty > 0 and barcode like '%" & txtSearch & "%'", cn)


            If tc = "brand" Then cm = New MySqlCommand("SELECT * FROM  `tblproduct` as p INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id where qty > 0 and brand like '%" & txtSearch & "%'", cn)

            If tc = "generic" Then cm = New MySqlCommand("SELECT * FROM  `tblproduct` as p INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id qty > 0 and where generic like '%" & txtSearch & "%'", cn)

            If tc = "" Then cm = New MySqlCommand("SELECT * FROM `tblproduct` as p INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id", cn)
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

            dr.Close()
            For i = 0 To dataGridView2.Rows.Count - 1
                If dataGridView2.Rows(i).Cells(10).Value.ToString <> String.Empty Then
                    stock += CDbl(dataGridView2.Rows(i).Cells(10).Value.ToString)
                    rcount = dataGridView2.Rows.Count
                End If
                icount = stock

            Next

            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

            cn.Close()
        End Try



    End Sub
    Sub criticalStock(ByVal cboStock As String, ByRef icount As String, ByRef rcount As String)
        If ConnectionState.Open Then cn.Close()

        Try
            Dim i As Integer = 0
            Dim stock As Double = 0
            dataGridView2.Rows.Clear()
            Dim tc As String = ""

            Select Case cboStock
                Case "نفاذ المخزون"
                    tc = "outStock"
                Case "اقتراب نفاذ المخزون"
                    tc = "underStock"
                Case ""
                    tc = ""
            End Select

            cn.Open()
            cm = Nothing

            If cboStock = String.Empty Then Return
            If tc = "outStock" Then cm = New MySqlCommand("SELECT * FROM  `tblproduct` as p INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id where qty = 0", cn)

            If tc = "underStock" Then cm = New MySqlCommand("SELECT * FROM  `tblproduct` as p INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id where qty <= reorder and qty <> 0", cn)


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
            dr.Close()
            For i = 0 To dataGridView2.Rows.Count - 1
                If dataGridView2.Rows(i).Cells(10).Value.ToString <> String.Empty Then
                    stock += CDbl(dataGridView2.Rows(i).Cells(10).Value.ToString)
                    rcount = dataGridView2.Rows.Count
                End If
                icount = stock
            Next

            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

            cn.Close()

        End Try



    End Sub

    Sub loadRecords()
        If ConnectionState.Open Then cn.Close()
        Try
            Dim stock As Double = 0
            Dim i As Integer = 0
            dataGridView2.Rows.Clear()
            cn.Open()
            cm = Nothing

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
            dr.Close()

            For i = 0 To dataGridView2.Rows.Count - 1
                If dataGridView2.Rows(i).Cells(10).Value.ToString <> String.Empty Then
                    stock += CDbl(dataGridView2.Rows(i).Cells(10).Value.ToString)
                End If
                txtCount.Text = stock
            Next

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            cn.Close()
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

End Class