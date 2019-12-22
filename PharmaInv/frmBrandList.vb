Imports MySql.Data.MySqlClient
Public Class frmBrandList
    Dim id As Integer, _brand As String

    Sub deleterow()
        Try
            If (MsgBox("هل تريد حذف هاته البيانات", vbYesNo + vbQuestion) = vbYes) Then
                cn.Open()
                cm = New MySqlCommand("delete from tblBrand where id = '" & id & "' ", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("تم الحذف بنجاح")
            End If
        Catch ex As Exception
            MsgBox(ex.Message And "المرجو الاتصال بالمبرمج لحل المشكل")
        End Try


    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        With frmBrand
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
            cm = New MySqlCommand("select * from tblbrand", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                dataGridView2.Rows.Add(i, dr("id").ToString(), dr("brand").ToString())
            End While
            cn.Close()
            dr.Close()
        Catch ex As Exception
            cn.Close()
            dr.Close()
            MsgBox("من فضلك اتصل بالمبرمج لحل المشكل" & ex.Message)
        End Try

        lblCount.Text = "(" & dataGridView2.RowCount & "): المجموع الكلي للشعارات "
    End Sub



    Private Sub dataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView2.CellContentClick
        Dim colName As String = dataGridView2.Columns(e.ColumnIndex).Name
        If colName = "edit" Then
            With frmBrand
                .labelId.Text = id
                .txtBrand.Text = _brand
                .btnSave.Hide()
                .btnUpdate.Show()
                .ShowDialog()
                loadRecords()


            End With
        End If
        If colName = "delete" Then

            deleterow()
                loadRecords()

            End If


    End Sub
    Private Sub frmBrandList_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub dataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles dataGridView2.SelectionChanged
        Dim i As Integer = dataGridView2.CurrentRow.Index
        id = dataGridView2.Item(1, i).Value
        _brand = dataGridView2.Item(2, i).Value
    End Sub
End Class