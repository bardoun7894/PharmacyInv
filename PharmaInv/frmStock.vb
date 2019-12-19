Imports MySql.Data.MySqlClient


Public Class frmStock



    Sub loadRecords()
        DataGridView5.Rows.Clear()
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
                DataGridView5.Rows.Add(
                    i, dr.Item("id").ToString(),
                     dr.Item("brand").ToString() & Space(2) & "|" & Space(2) &
                     dr.Item("generic").ToString() & Space(2) & "|" & Space(2) & dr.Item("classification").ToString() & Space(2) &
                     "|" & Space(2) & dr.Item("type").ToString() & Space(2) & "|" & Space(2) & dr.Item("formulation").ToString())
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try


    End Sub


    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub



    Sub loadStockByHistory()
        Dim i As Integer = 0
        dataGridView2.Rows.Clear()
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM `tblstockin` as s inner JOIN `tblproduct` as p on s.pid=p.id INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id", cn)
            dr = cm.ExecuteReader()
            While dr.Read()
                i += 1
                dataGridView2.Rows.Add(
                    i, dr.Item("id").ToString(), dr.Item("barcode").ToString(),
                     dr.Item("brand").ToString(), dr.Item("generic").ToString(),
                    dr.Item("classification").ToString(), dr.Item("type").ToString(),
                     dr.Item("formulation").ToString(), dr.Item("reorder").ToString(),
                      dr.Item("price").ToString(), dr.Item("qty").ToString())
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            dr.Close()
            cn.Close()
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            For i As Integer = 0 To dataGridView2.Rows.Count - 1
                If dataGridView2.Rows(i).Cells(7).Value = String.Empty Then
                    MsgBox("ادخل الكمية", vbExclamation)
                    Return
                End If
            Next
            Dim sdate As String = sdate1.Value.ToString("yyyy-MM-dd")
            Dim add_rec As Boolean = False

            For i As Integer = 0 To dataGridView2.Rows.Count - 1
                Dim found As Boolean = False
                Dim pid As Integer = CInt(dataGridView2.Rows(i).Cells(1).Value.ToString)
                Dim qty As Integer = CInt(dataGridView2.Rows(i).Cells(7).Value.ToString)



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

            If add_rec = True Then MsgBox("تمت الاضافة بنجاح")




        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Private Sub DataGridView3_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class