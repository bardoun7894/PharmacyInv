Imports MySql.Data.MySqlClient



Public Class frmBrand
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtBrand.Text = String.Empty Then
                MsgBox("الحقل فارغ ؟", vbCritical)
            Else
                If (MsgBox("هل انت متأكد", vbYesNo + vbQuestion) = vbYes) Then
                    cn.Open()
                    cm = New MySqlCommand("update tblBrand set brand = '" & txtBrand.Text & "' where id like ('" & labelId.Text & "')", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("تمت الاضافة بنجاح", vbInformation)
                End If
            End If
            With frmBrandList
                .loadRecords()
            End With
            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message & "من فضلك اتصل بالمبرمج لحل المشكل")
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim found As Boolean = False
            If txtBrand.Text = String.Empty Then
                MsgBox("الحقل فارغ", vbCritical)
            Else

                If (MsgBox("هل انت متأكد؟", vbYesNo + vbQuestion) = vbYes) Then

                    cn.Open()
                    cm = New MySqlCommand("select * from tblBrand where brand = '" + txtBrand.Text + "'", cn)
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
                        cm = New MySqlCommand("insert into tblBrand (brand) values('" & txtBrand.Text & "')", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()
                        MsgBox("تمت الاضافة بنجاح?", vbInformation)
                    Else
                        MsgBox("هذه البيانات موجودة بالفعل")

                    End If
                End If
                End If

            With frmBrandList
                .loadRecords()
            End With
            txtBrand.Clear()
            txtBrand.Focus()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message & "من فضلك اتصل بالمبرمج لحل المشكل")
        End Try

    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Me.Dispose()

    End Sub

    Private Sub frmBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub clear()
        txtBrand.Clear()
        txtBrand.Focus()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
    End Sub
End Class