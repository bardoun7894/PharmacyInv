
Imports MySql.Data.MySqlClient


Public Class frmClassification
    Dim found As Boolean = False
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtClassification.Text = String.Empty Then
                MsgBox("الحقل فارغ", vbCritical)



            Else
                If (MsgBox("هل انت متأكد", vbYesNo + vbQuestion) = vbYes) Then

                    cn.Open()
                    cm = New MySqlCommand("select * from tblClassification where classification = '" + txtClassification.Text + "'", cn)
                    dr = cm.ExecuteReader()
                    dr.Read()
                    If dr.HasRows Then
                        found = True
                    End If
                    dr.Close()
                    cn.Close()
                    If found = False Then
                        cm = Nothing
                        cn.Open()
                        cm = New MySqlCommand("insert into tblClassification (classification) values('" & txtClassification.Text & "')", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()
                        MsgBox(" تمت الاضافة بنجاح", vbInformation)
                    Else
                        MsgBox("هاته البيانات موجودة بالفعل")

                    End If


                End If
            End If
            With frmClassificationList
                .loadRecords()
            End With
            txtClassification.Clear()
            txtClassification.Focus()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message & "من فضلك اتصل بالمبرمج لحل المشكل ؟")
        End Try
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Me.Dispose()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtClassification.Text = String.Empty Then
                MsgBox("الحقل فارغ", vbCritical)
            Else
                If (MsgBox("هل تريد التحديث", vbYesNo + vbQuestion) = vbYes) Then
                    cn.Open()
                    cm = New MySqlCommand("update tblClassification set classification = '" & txtClassification.Text & "' where id like ('" & labelId.Text & "')", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("تم التحديث بنجاح", vbInformation)
                End If
            End If
            With frmClassificationList
                .loadRecords()
            End With
            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message & "من فضلك اتصل بالمبرمج لحل المشكل ؟")
        End Try


    End Sub

    Private Sub frmClassification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()

    End Sub
    Sub clear()
        txtClassification.Clear()
        txtClassification.Focus()


    End Sub
End Class