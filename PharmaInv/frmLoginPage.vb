

Imports MySql.Data.MySqlClient


Public Class frmLoginPage

    Dim found As Boolean = False


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Try
            If IS_EMPTY(txtuser) = True Then Return
            If IS_EMPTY(txtpass) = True Then Return

            cn.Open()
            cm = New MySqlCommand("select * from tbluser where username like '" & txtuser.Text & "' and password like'" & txtpass.Text & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                strUser = dr.Item("username").ToString
                strpass = dr.Item("password").ToString
                strUserType = dr.Item("user_type").ToString
                strStatus = dr.Item("status").ToString
                strName = dr.Item("name").ToString
                found = True
            Else
                strUser = ""
                strPass = ""
                strUserType = ""
                strStatus = ""
                strName = ""
                found = False
            End If
            cn.Close()
            dr.Close()
            If found = True Then
                If strStatus = "متاح" Then

                    If strUserType = "الادمين" Then
                        MsgBox("انت لديك كل الصلاحيات  " & strName & " مرحبا بك  ")
                        With arabicMain
                            txtuser.Clear()
                            txtpass.Clear()
                            .ShowDialog()
                        End With
                    Else
                        MsgBox("لديك الصلاحية البيع  " & strName & " مرحبا بك  ")
                        With frmSales
                            txtuser.Clear()
                            txtpass.Clear()
                            .ShowDialog()

                        End With
                    End If
                Else
                    MsgBox("  هذا الحساب غير متاح الان  ")
                End If
            ElseIf found = False Then
                    MsgBox("اسم المستخدم او كلمة المرور خاطئة ")

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()

        End Try


    End Sub

    Private Sub frmLoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        txtuser.Select()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub
End Class