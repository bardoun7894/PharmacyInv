Imports MySql.Data.MySqlClient



Public Class frmFormulation

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtFormulation.Text = String.Empty Then
                MsgBox("الحقل فارغ ؟", vbCritical)
            Else
                If (MsgBox("هل انت متأكد", vbYesNo + vbQuestion) = vbYes) Then
                    cn.Open()
                    cm = New MySqlCommand("update tblFormulation set formulation = '" & txtFormulation.Text & "' where id like ('" & labelId.Text & "')", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("تمت الاضافة بنجاح", vbInformation)
                End If
            End If
            With frmFormulationList
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

            If txtFormulation.Text = String.Empty Then
                MsgBox("الحقل فارغ", vbCritical)

            Else
                If (MsgBox("هل انت متأكد؟", vbYesNo + vbQuestion) = vbYes) Then


                    cn.Open()
                    cm = New MySqlCommand("select * from tblFormulation where formulation = '" + txtFormulation.Text + "'", cn)
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
                        cm = New MySqlCommand("insert into tblFormulation (formulation) values('" & txtFormulation.Text & "')", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()
                        MsgBox("تمت الاضافة بنجاح?", vbInformation)
                    Else
                        MsgBox("هذه البيانات موجودة بالفعل")

                    End If
                End If

            End If
            With frmFormulationList
                .loadRecords()
            End With
            txtFormulation.Clear()
            txtFormulation.Focus()
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()

    End Sub
    Sub clear()
        txtFormulation.Clear()
        txtFormulation.Focus()


    End Sub
End Class