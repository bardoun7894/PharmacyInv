Imports MySql.Data.MySqlClient



Public Class frmType
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtType.Text = String.Empty Then
                MsgBox(" الحقل فارغ من فضلك املأه للاستمرار ؟ ", vbCritical)
            Else
                If (MsgBox("هل انت متأكد?", vbYesNo + vbQuestion) = vbYes) Then
                    cn.Open()
                    cm = New MySqlCommand("update tblType set type = '" & txtType.Text & "' where id like ('" & labelId.Text & "')", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("  تم التحديث بنجاح ؟ ", vbInformation)
                End If
            End If
            With frmTypeList
                .loadRecords()
            End With
            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message & " من فضلك اتصل بالمبرمج لحل المشكل")
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim found As Boolean = False
            If txtType.Text = String.Empty Then
                MsgBox("the field is empty?", vbCritical)
            Else
                If (MsgBox("هل انت متأكد ?", vbYesNo + vbQuestion) = vbYes) Then
                    cn.Open()
                    cm = New MySqlCommand("select * from tblType where type = '" + txtType.Text + "'", cn)
                    dr = cm.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        found = True
                    End If

                    dr.Close()
                    cn.Close()
                    If found = False Then
                        cn.Open()
                        cm = New MySqlCommand("insert into tblType (type) values('" & txtType.Text & "')", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()
                        MsgBox("! تمت الاضافة بنجاح   ", vbInformation)
                    Else
                        MsgBox(" البيانات موجودة بالفعل", vbInformation)
                    End If
                End If

            End If
            With frmTypeList

                .loadRecords()
            End With
            txtType.Clear()
            txtType.Focus()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message & " من فضلك اتصل بالمبرمج لحل المشكل ", vbCritical)
        End Try

    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Me.Dispose()

    End Sub

    Private Sub frmType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()

    End Sub
    Sub clear()
        txtType.Clear()
        txtType.Focus()

    End Sub
End Class