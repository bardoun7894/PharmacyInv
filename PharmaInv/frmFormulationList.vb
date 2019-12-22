Imports MySql.Data.MySqlClient


Public Class frmFormulationList
    Dim id As Integer, _formulation As String




    Sub deleterow()
        Try
            If (MsgBox("هل تريد حذف هاته البيانات", vbYesNo + vbQuestion) = vbYes) Then
                cn.Open()
                cm = New MySqlCommand("delete from tblFormulation where id = '" & id & "' ", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("تم الحذف")
            End If

        Catch ex As Exception
            MsgBox(ex.Message And "من فضلك اتصل بالمبرمج لحل المشكل")
        End Try


    End Sub


    Sub loadRecords()

        Dim i As Integer = 0

        Try
            dataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select * from tblFormulation", cn)
            dr = cm.ExecuteReader

            While dr.Read
                i += 1
                dataGridView2.Rows.Add(dr.Item("id").ToString, i, dr.Item("formulation").ToString)
            End While
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox("من فضلك اتصل بالمبرمج لحل المشكل؟" & ex.Message)

        End Try

        lblCount.Text = " (" & dataGridView2.RowCount & ") : المجموع الكلي للصيغ "
    End Sub





    Private Sub AddNew_Click_1(sender As Object, e As EventArgs) Handles pictureBox1.Click
        With frmFormulation

            .btnSave.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Dispose()
    End Sub

    Private Sub dataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView2.CellContentClick
        Dim colName As String = dataGridView2.Columns(e.ColumnIndex).Name
        If colName = "edit" Then
            With frmFormulation
                .labelId.Text = id
                .txtFormulation.Text = _formulation
                .btnSave.Hide()
                .btnUpdate.Show()
                .ShowDialog()
            End With
        End If
        If colName = "delete" Then

            deleterow()
        End If

        loadRecords()

    End Sub

    Private Sub dataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles dataGridView2.SelectionChanged
        Dim i As Integer = dataGridView2.CurrentRow.Index
        id = dataGridView2.Item(0, i).Value
        _formulation = dataGridView2.Item(2, i).Value
    End Sub
End Class