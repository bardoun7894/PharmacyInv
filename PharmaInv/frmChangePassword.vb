
Imports MySql.Data.MySqlClient


Public Class frmChangePassword

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If IS_EMPTY(txtOld) = True Then Return
        If IS_EMPTY(txtNewPass) = True Then Return
        If IS_EMPTY(txtConfirm) = True Then Return
        If txtOld.Text <> strPass Then
            MsgBox("كلمة السر خاطئة")
            Return
        End If
        If txtNewPass.Text <> txtConfirm.Text Then
            MsgBox("كلمة السر غير متوافقة")
            Return
        End If
        cn.Open()
        cm = New MySqlCommand("update tblUser set password= @password where username like @username ", cn)
        With cm
            .Parameters.AddWithValue("@username", strUser)
            .Parameters.AddWithValue("@password", txtNewPass.Text)
            .ExecuteNonQuery()
        End With
        cn.Close()
        strPass = txtNewPass.Text
        MsgBox("تم تغيير كلمة السر")
        clear()
        Me.Dispose()
    End Sub
    Sub clear()
        txtNewPass.Clear()
        txtOld.Clear()
        txtConfirm.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub
End Class