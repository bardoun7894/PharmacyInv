Imports MySql.Data.MySqlClient

Public Class StockAdjustement

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






    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Me.Dispose()

    End Sub


    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                If IS_EMPTY(cboFilter) = True Then Return
                If IS_EMPTY(txtSearch) = True Then Return
                loadRecords()

        End Select

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        Dim colName As String = DataGridView4.Columns(e.ColumnIndex).Name

        Try
            If colName = "colSelect" Then

                cn.Open()
                cm = New MySqlCommand("SELECT * FROM `tblproduct` as p INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id 
INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id 
INNER JOIN tbltype as t on p.tid=t.id where p.id like '" & DataGridView4.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    productID.Text = dr.Item("id").ToString
                    txtBrand.Text = dr.Item("brand").ToString
                    txtGeneric.Text = dr.Item("generic").ToString
                    txtClassification.Text = dr.Item("classification").ToString
                    txtformulation.Text = dr.Item("formulation").ToString
                    txttype.Text = dr.Item("type").ToString
                    txtInHand.Text = dr.Item("qty").ToString

                End If
                dr.Close()
                cn.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If IS_EMPTY(cboFilter) = True Then Return
        If IS_EMPTY(txtSearch) = True Then Return
        loadRecords()
    End Sub
    Sub clear()
        txtBrand.Clear()
        txtClassification.Clear()
        txtformulation.Clear()
        txtGeneric.Clear()
        txtInHand.Clear()
        productID.Clear()
        txtStockAdjusted.Clear()
        txtreason.Clear()
        txttype.Clear()





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()

    End Sub

    Private Sub StockAdjustement_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtaddedby.Text = strUser
    End Sub

    Private Sub txtStockAdjusted_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockAdjusted.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8
            Case Else
                e.Handled = True
        End Select

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            If IS_EMPTY(txtStockAdjusted) = True Then Return
            If rdadd.Checked = False And rdremove.Checked = False Then
                MsgBox("المرجو اختيار نوع الضبط الحذف او الاضافة", vbExclamation)
                Return
            End If
            If IS_EMPTY(txtreason) = True Then Return

            If rdadd.Checked = True Then
                    cn.Open()
                    cm = New MySqlCommand("update tblproduct set qty = (qty + " & CInt(txtStockAdjusted.Text) & ") where id like  '" & productID.Text & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                ElseIf rdremove.Checked = True Then
                    If CInt(txtStockAdjusted.Text) > CInt(txtInHand.Text) Then
                        MsgBox(". فقط" & txtInHand.Text & " المخزون المتاح ", vbExclamation)
                        Return
                    Else
                        cn.Open()
                        cm = New MySqlCommand("update tblproduct set qty = ( qty - " & CInt(txtStockAdjusted.Text) & ") where id like  '" & productID.Text & "'", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()
                    End If

                End If
                Dim stype As String
                If rdadd.Checked = True Then stype = rdadd.Text
                If rdremove.Checked = True Then stype = rdremove.Text
                Dim sdate As String = Now.ToString("yyyy-MM-dd")
                cn.Open()
                cm = New MySqlCommand("insert into tbladjustment (pid,qty,stype,reason,adjustedby,sdate) values (@pid,@qty,@stype,@reason,@adjustedby,@sdate)", cn)
                With cm
                    .Parameters.AddWithValue("@pid", productID.Text)
                    .Parameters.AddWithValue("@qty", txtStockAdjusted.Text)
                    .Parameters.AddWithValue("@stype", stype)
                    .Parameters.AddWithValue("@reason", txtreason.Text)
                    .Parameters.AddWithValue("@adjustedby", txtaddedby.Text)
                    .Parameters.AddWithValue("@sdate", sdate)
                    .ExecuteNonQuery()

                End With

                cn.Close()
                MsgBox("تمت الاضافة بنجاح", vbInformation)

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation)
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Sub loadAdjustmentHistory()

        Dim sdate1 As String = dt1.Value.ToString("yyyy-MM-dd")
        Dim sdate2 As String = dt2.Value.ToString("yyyy-MM-dd")




        Dim i As Integer
        DataGridView1.Rows.Clear()
        cn.Open()
        cm = New MySqlCommand("SELECT a.id ,b.brand ,g.generic,c.classification,t.type,f.formulation,a.qty,a.stype
,a.adjustedby,a.reason from tbladjustment as a INNER JOIN tblproduct as p on a.pid =p.id INNER JOIN tblbrand as
b on b.id =p.bid INNER JOIN tblgeneric as g on g.id =p.gid INNER JOIN tblclassification as c on c.id =p.cid
INNER JOIN tbltype as t on t.id =p.tid INNER JOIN tblformulation as f on f.id =p.fid where sdate between '" & sdate1 & "' and '" & sdate2 & "'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("id").ToString, dr.Item("brand").ToString, dr.Item("generic").ToString, dr.Item("classification").ToString, dr.Item("type").ToString, dr.Item("formulation").ToString, dr.Item("qty").ToString, dr.Item("stype").ToString, dr.Item("reason").ToString, dr.Item("adjustedby").ToString)


        End While
        dr.Close()

        cn.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadAdjustmentHistory()

    End Sub
End Class