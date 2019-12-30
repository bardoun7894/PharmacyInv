
Imports MySql.Data.MySqlClient

Public Class frmChooseDiscount
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IS_EMPTY(cboDescription) = True Then Return
        With frmSales
            Dim discount As Double = CDbl(.lblSubTotal.Text) * CDbl(txtdiscount.Text)
            .lblDisc.Text = Format(discount, "#,##0.00")
            .loadCart()
            Me.Dispose()

        End With



    End Sub
    Sub getdiscount()

        Try
            cn.Open()
            cm = New MySqlCommand("select * from tbldiscount", cn)
            dr = cm.ExecuteReader
            While dr.Read

                cboDescription.Items.Add(dr.Item("description").ToString())
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub cboDescription_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDescription.SelectedIndexChanged
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tbldiscount where description like '" & cboDescription.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtdiscount.Text = dr.Item("discount").ToString
            Else
                txtdiscount.Text = 0
            End If
            cn.Close()
            dr.Close()

        Catch ex As Exception
            cn.Close()
            dr.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Me.Dispose()

    End Sub
End Class