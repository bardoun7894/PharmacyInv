Imports MySql.Data.MySqlClient


Public Class frmVat

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            cn.Open()
            cm = New MySqlCommand("select count(*)  from tblvat ", cn)
            Dim icount As Integer = CInt(cm.ExecuteScalar)
            cn.Close()
            If icount > 0 Then
                cn.Open()
                cm = New MySqlCommand("update tblvat set vat = '" & CDbl(txtVat.Text) & "'", cn)
                MsgBox("تم تعديل الضريبة بنجاح")
                cm.ExecuteNonQuery()
                cn.Close()
            Else
                cn.Open()
                cm = New MySqlCommand("insert into  tblvat   (vat) values  ('" & CDbl(txtVat.Text) & "')", cn)
                cm.ExecuteNonQuery()
                MsgBox("تمت اضافة الضريبة بنجاح")
                cn.Close()
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub txtVat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVat.KeyPress
        Select Case Asc(e.KeyChar)

            Case 48 To 57  '0--9'
            Case 46   ' (.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class