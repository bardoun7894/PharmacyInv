
Imports MySql.Data.MySqlClient

Public Class frmstockin
    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Sub loadRecords()
        DataGridView4.Rows.Clear()
        Dim i As Integer = 0
        Dim tc As String = ""
        Select Case cboFilter.Text
            Case "اسم الشعار"
                tc = "brand"
            Case "الباركود"
                tc = "barcode"
            Case "الاسم العام"
                tc = "generic"
        End Select



        If cboFilter.Text = String.Empty Then Return


        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM `tblproduct` as p INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id where " & tc & " like '" & txtSearch.Text & "%'", cn)
            dr = cm.ExecuteReader()
            While dr.Read()
                i += 1
                DataGridView4.Rows.Add(
                    i, dr.Item("id").ToString(),
                     dr.Item("brand").ToString() & Space(2) & "|" & Space(2) &
                     dr.Item("generic").ToString() & Space(2) & "|" & Space(2) & dr.Item("classification").ToString() & Space(2) &
                     "|" & Space(2) & dr.Item("type").ToString() & Space(2) & "|" & Space(2) & dr.Item("formulation").ToString())
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            dr.Close()
            cn.Close()
        End Try


    End Sub




    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        If IS_EMPTY(txtReference) Then Return
        If IS_EMPTY(txtStockBy) Then Return
        Dim colName As String = DataGridView4.Columns(e.ColumnIndex).Name
        Dim data As String = DataGridView4.Rows(e.RowIndex).Cells(2).Value.ToString
        Dim arr() As String = data.Split("|")
        If colName = "colSelect" Then

            If MsgBox(
                    "Brand :" & arr(0) & vbCr &
                     "generic :" & arr(1) & vbCr &
                     "classification :" & arr(2) & vbCr &
                     "type :" & arr(3) & vbCr &
                     "formulation :" & arr(4) & vbCr &
                     "هل انت متأكد ؟", vbYesNo, vbQuestion) = vbYes Then




                DataGridView3.Rows.Add(DataGridView3.Rows.Count + 1, DataGridView4.Rows(e.RowIndex).Cells(1).Value.ToString, arr(0), arr(1), arr(2), arr(3), arr(4))

            End If


        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadRecords()
    End Sub

    Private Sub cboFilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboFilter.KeyPress
        e.Handled = True
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            For i As Integer = 0 To DataGridView3.Rows.Count - 1
                If DataGridView3.Rows(i).Cells(7).Value = String.Empty Then
                    MsgBox("ادخل الكمية", vbExclamation)
                    Return
                End If
            Next
            Dim sdate As String = sdate1.Value.ToString("yyyy-MM-dd")
            Dim add_rec As Boolean = False

            For i As Integer = 0 To DataGridView3.Rows.Count - 1
                Dim found As Boolean = False
                Dim pid As Integer = CInt(DataGridView3.Rows(i).Cells(1).Value.ToString)
                Dim qty As Integer = CInt(DataGridView3.Rows(i).Cells(7).Value.ToString)



                cn.Open()
                cm = New MySqlCommand("select * from tblStockIn where refno like '" & txtReference.Text & "' and pid like '" & pid & "' and sdate like '" & sdate & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then found = True Else found = False
                dr.Close()
                cn.Close()

                'make a condition to avoid dublicated

                If found = False Then
                    cn.Open()
                    cm = Nothing
                    cm = New MySqlCommand("insert into tblStockin (refno,recievedBy,pid,qty,sdate)values(@refno,@recievedBy,@pid,@qty,@sdate)", cn)
                    With cm
                        .Parameters.AddWithValue("@refno", txtReference.Text)
                        .Parameters.AddWithValue("@recievedBy", txtStockBy.Text)
                        .Parameters.AddWithValue("@pid", pid)
                        .Parameters.AddWithValue("@qty", qty)
                        .Parameters.AddWithValue("@sdate", sdate)
                        .ExecuteNonQuery()
                    End With
                    cn.Close()

                    cn.Open()
                    cm = New MySqlCommand("update  tblProduct set qty = qty + " & qty & " where id like '" & pid & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    add_rec = True


                End If


            Next

            If add_rec = True Then
                MsgBox("تمت الاضافة بنجاح")
                With frmProductList
                    .loadRecords()

                End With
            End If




        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)

        End Try


    End Sub
    Sub loadStockByHistory()
        Dim sdate1 As String = dt1.Value.ToString("yy-MM-dd")
        Dim sdate2 As String = dt2.Value.ToString("yy-MM-dd")
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM `tblstockin` as s inner JOIN `tblproduct` as p on s.pid=p.id INNER JOIN tblbrand
as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN 
tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id where sdate between '" & sdate1 & "' and '" & sdate2 & "' order by s.id", cn)
            dr = cm.ExecuteReader()
            While dr.Read()
                i += 1
                DataGridView1.Rows.Add(
                    i, dr.Item("id").ToString(), dr.Item("refno").ToString(), dr.Item("recievedBy").ToString(),
                     dr.Item("brand").ToString(), dr.Item("generic").ToString(),
                    dr.Item("classification").ToString(), dr.Item("type").ToString(),
                     dr.Item("formulation").ToString(),
                      dr.Item("qty").ToString(), CDate(dr.Item("sdate").ToString()))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            dr.Close()
            cn.Close()
        End Try


    End Sub

    Private Sub DataGridView3_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellValueChanged
        On Error Resume Next

        Dim stock As Double = 0

        For i As Integer = 0 To DataGridView3.Rows.Count - 1
            If DataGridView3.Rows(i).Cells(7).Value.ToString <> String.Empty Then
                stock += CDbl(DataGridView3.Rows(i).Cells(7).Value.ToString)
            End If
            txtCount.Text = stock

        Next
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadStockByHistory()
    End Sub
End Class