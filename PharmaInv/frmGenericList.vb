﻿Imports MySql.Data.MySqlClient
Public Class frmGenericList
    Dim id As Integer, _generic As String

    Sub deleterow()
        Try
            If (MsgBox("هل تريد حذف هاته البيانات", vbYesNo + vbQuestion) = vbYes) Then
                cn.Open()
                cm = New MySqlCommand("delete from tblGeneric where id = '" & id & "' ", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("تم الحذف")
            End If

        Catch ex As Exception
            MsgBox(ex.Message And "من فضلك اتصل بالمبرمج لحل المشكل")
        End Try


    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        With frmGeneric
            .btnSave.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Sub loadRecords()
        Dim i As Integer = 0
        Try
            dataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select * from tblGeneric", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                dataGridView2.Rows.Add(i, dr("id").ToString(), dr("generic").ToString())
            End While
            cn.Close()
            dr.Close()
        Catch ex As Exception
            cn.Close()
            dr.Close()
            MsgBox("من فضلك اتصل بالمبرمج لحل المشكل" & ex.Message)
        End Try

        lblCount.Text = "(" & dataGridView2.RowCount & "): المجموع الكلي للاسماء "
    End Sub




    Private Sub dataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles dataGridView2.SelectionChanged
        Dim i As Integer = dataGridView2.CurrentRow.Index
        id = dataGridView2.Item(1, i).Value
        _generic = dataGridView2.Item(2, i).Value
    End Sub

    Private Sub dataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView2.CellClick
        Dim colName As String = dataGridView2.Columns(e.ColumnIndex).Name
        If colName = "edit" Then
            If (MsgBox("هل تريد تعديل هاته البيانات", vbYesNo + vbQuestion) = vbYes) Then
                With frmGeneric
                    .labelId.Text = id
                    .txtGeneric.Text = _generic
                    .btnSave.Hide()
                    .btnUpdate.Show()
                    .ShowDialog()
                    loadRecords()


                End With
            End If
        End If

        If colName = "delete" Then

            deleterow()
            loadRecords()



        End If

    End Sub
End Class