Imports MySql.Data.MySqlClient


Public Class frmSettle
    Private Sub frmSettle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtCash.Focus()

    End Sub

    Private Sub frmSettle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 58
            Case 8
            Case 13
                settlePayment()
            Case Else
                e.Handled = True
        End Select



    End Sub
    Sub settlePayment()

        Dim sdate As String = Now.ToString("yyyy-MM-dd")

        Try
            If CDbl(lblDue.Text) > CDbl(txtCash.Text) Then
                MsgBox("Insuffisant amount ! please input a correct amount ")
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
                    .lblInvoice.Text = .getInvoiceNo

                End With

            End If
            Me.Dispose()


        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()

        End Try

        cn.Close()
        MsgBox("Payment has been successfully saved")


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

End Class