Imports MySql.Data.MySqlClient


Public Class frmSettle
    Private Sub frmSettle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtCash.Select()



    End Sub

    Private Sub frmSettle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 58
            Case 8
            Case 13

            Case Else
                e.Handled = True
        End Select



    End Sub
    Sub settlePayment()

        Dim sdate As String = Now.ToString("yyyy-MM-dd")
        Try
            If CDbl(lblDue.Text) > CDbl(txtCash.Text) Then
                MsgBox("المبلغ غير كافي !المرجو ادخال المبلغ الصحيح")
                Return
            End If
            If (MsgBox("هل تريد حفظ هذه البيانات ؟  ", vbYesNo + vbQuestion) = vbYes) Then
                cn.Open()
                cm = New MySqlCommand("insert into tblPayment (invoice,subtotal,vat,discount,amountDue,sdate,user)values(@invoice,@subtotal,@vat,@discount,@amountDue,@sdate,@user)", cn)
                With frmSales
                    cm.Parameters.AddWithValue("@invoice", .lblInvoice.Text)
                    cm.Parameters.AddWithValue("@subtotal", CDbl(.lblSubTotal.Text))
                    cm.Parameters.AddWithValue("@vat", CDbl(.lblVat.Text))
                    cm.Parameters.AddWithValue("@discount", CDbl(.lblDisc.Text))
                    cm.Parameters.AddWithValue("@amountDue", CDbl(.lblDue.Text))
                    cm.Parameters.AddWithValue("@sdate", sdate)
                    cm.Parameters.AddWithValue("@user", strUser)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    minusStockQty()

                End With

            End If

            With frmProductList
                .loadRecords()
            End With

            cn.Close()
            MsgBox("تمت عملية البيع بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()

        End Try




    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Try
            Dim change As Double = CDbl(txtCash.Text) - CDbl(lblDue.Text)
            If change < 0 Then
                lblChange.Text = "0.00"
            Else
                lblChange.Text = Format(change, "#,##0.00")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmSettle_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim s As Double = 0

        Select Case e.KeyCode

            Case Keys.Escape

                Me.Dispose()

            Case Keys.Enter


                With frmSales
                    s = CDbl(.lblDue.Text)
                    If s <= 0 Then
                        If (MsgBox("لا يوجد ربح او الربح غير كافي هل تريد الاستمرار", vbYesNo + vbQuestion) = vbYes) Then
                            settlePayment()
                            .txtSearch.Clear()
                            .txtSearch.Enabled = True
                            .txtSearch.Focus()
                        Else
                            .loadCart()
                            .lblInvoice.Enabled = True
                            .lblInvoice.Text = .getInvoiceNo()
                            .cboFilter.Text = "الباركود"
                            .txtSearch.Enabled = True
                            .txtSearch.Focus()
                        End If
                    Else
                        settlePayment()

                        .txtSearch.Clear()
                        .txtSearch.Enabled = True
                        .txtSearch.Focus()
                    End If


                End With


                Me.Dispose()


        End Select
    End Sub
    Sub minusStockQty()
        Try


            With frmSales
                For i = 0 To .dataGridView2.Rows.Count - 1
                    cn.Open()
                    cm = New MySqlCommand("update tblProduct set qty =qty -'" & CInt(.dataGridView2.Rows(i).Cells(10).Value.ToString) & "' where id like '" & CInt(.dataGridView2.Rows(i).Cells(2).Value.ToString) & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                Next
                cn.Open()
                cm = New MySqlCommand("update tblCart set status ='Sold' where invoice like '" & Trim(.lblInvoice.Text) & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                .lblInvoice.Text = .getInvoiceNo

            End With

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

End Class