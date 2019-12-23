
Imports MySql.Data.MySqlClient

Public Class frmDiscount


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 58
            Case 8
            Case 13
            Case 46   ' (.)'
            Case Else
                e.Handled = True
        End Select

    End Sub
    Sub loadDiscounts()
        Try
            Dim i As Integer = 0
            dataGridView2.Rows.Clear()
            cn.Open()

            cm = New MySqlCommand("select * from tblDiscount", cn)
            dr = cm.ExecuteReader

            While dr.Read()

                i += 1
                dataGridView2.Rows.Add(i, dr.Item("id").ToString, dr.Item("description").ToString, dr.Item("discount").ToString)
            End While

            cn.Close()
            dr.Close()
        Catch ex As Exception
            cn.Close()
            dr.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            If IS_EMPTY(txtdescDisc) = True Then Return
            If IS_EMPTY(txtDiscount) = True Then Return
            If validateDublicatedEntry("select * from tblDiscount where description like '" & txtdescDisc.Text & "'", txtdescDisc) = True Then Return

            cn.Open()
            cm = New MySqlCommand("insert into tbldiscount(description,discount)values(@description,@discount)", cn)
            With cm
                .Parameters.AddWithValue("@description", txtdescDisc.Text)
                .Parameters.AddWithValue("@discount", CDbl(txtDiscount.Text))
                .ExecuteNonQuery()

            End With

            cn.Close()

            MsgBox("تم اضافة التخفيضات بنجاح")
            loadDiscounts()
            clearDiscount()

        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()

        End Try
    End Sub

    Private Sub dataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView2.CellContentClick

    End Sub

    Sub clearDiscount()
        txtdescDisc.Clear()
        txtDiscount.Clear()
        btnSave.Enabled = True
        btnUpdate.Enabled = False

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearDiscount()


    End Sub
End Class