Imports MySql.Data.MySqlClient



Public Class frmGeneric
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtGeneric.Text = String.Empty Then
                MsgBox("الحقل فارغ", vbCritical)
            Else
                If (MsgBox("هل تريد  تحديث البيانات ؟", vbYesNo + vbQuestion) = vbYes) Then
                    cn.Open()
                    cm = New MySqlCommand("update tblGeneric set generic = '" & txtGeneric.Text & "' where id like ('" & labelId.Text & "')", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("تم التحديث بنجاح ", vbInformation)
                End If
            End If
            With frmGenericList
                .loadRecords()
            End With
            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message & "من فضلك اتصل بالمبرمج لحل المشكل ؟ ")
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim found As Boolean = False


        Try
            If txtGeneric.Text = String.Empty Then
                MsgBox("الحقل فارغ", vbCritical)
            Else
                If (MsgBox("هل تريد الاضافة", vbYesNo + vbQuestion) = vbYes) Then
                    cn.Open()
                    cm = New MySqlCommand("select * from tblGeneric where generic = '" + txtGeneric.Text + "'", cn)
                    dr = cm.ExecuteReader()
                    dr.Read()
                    If dr.HasRows Then
                        found = True
                    End If
                    dr.Close()
                    cn.Close()

                    If found = False Then

                        cn.Open()
                        cm = New MySqlCommand("insert into tblGeneric (generic) values('" & txtGeneric.Text & "')", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()
                        MsgBox("تمت الاضافة بنجاح?", vbInformation)
                    Else
                        MsgBox("هذه البيانات موجودة بالفعل ?", vbInformation)
                    End If
                End If

            End If
            With frmGenericList
                .loadRecords()
            End With
            txtGeneric.Clear()
            txtGeneric.Focus()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message & "من فضلك اتصل بالمبرمج لحل المشكل ؟")
        End Try

    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Me.Dispose()

    End Sub

    Private Sub frmBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
    Sub clear()
        txtGeneric.Clear()
        txtGeneric.Focus()

    End Sub

End Class