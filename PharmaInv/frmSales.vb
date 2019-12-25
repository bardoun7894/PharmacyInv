

Imports MySql.Data.MySqlClient
Public Class frmSales
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInvoice.Enabled = True
        lblInvoice.Text = getInvoiceNo()
        cboFilter.Text = "الباركود"
        txtSearch.Enabled = True
        txtSearch.Select()
        txtSearch.Focus()
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        With frmDailySales
            .loadDailySales()
            .ShowDialog()
        End With
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Me.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        If MsgBox("ابدأ عملية بيع جديدة", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            refreshCard()
            lblInvoice.Enabled = True
            lblInvoice.Text = getInvoiceNo()
            cboFilter.Text = "الباركود"
            txtSearch.Enabled = True
            txtSearch.Focus()
        End If
    End Sub
    Sub refreshCard()
        Dim _total As Double = 0, i As Integer = 0
        Try
            dataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM `tblCart` as ca inner JOIN `tblproduct` as p on ca.pid=p.id INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id where invoice like '" & lblInvoice.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                dataGridView2.Rows.Add(i, dr.Item("id").ToString, dr.Item("pid").ToString, dr.Item("invoice"), dr.Item("brand"), dr.Item("generic").ToString, dr.Item("classification").ToString, dr.Item("type").ToString, dr.Item("formulation").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString)
                _total += CDbl(dr.Item("total").ToString)
            End While
            dr.Close()
            cn.Close()

            If dataGridView2.Rows.Count > 0 Then btnSettle.Enabled = True Else btnSettle.Enabled = False
            If dataGridView2.Rows.Count > 0 Then btnDisc.Enabled = True Else btnDisc.Enabled = False
        Catch ex As Exception
            dr.Close()
            cn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub loadCart()
        Dim _total As Double = 0, i As Integer = 0
        Try
            dataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM `tblCart` as ca inner JOIN `tblproduct` as p on ca.pid=p.id INNER JOIN tblbrand as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id where invoice like '" & lblInvoice.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                dataGridView2.Rows.Add(i, dr.Item("id").ToString, dr.Item("pid").ToString, dr.Item("invoice"), dr.Item("brand"), dr.Item("generic").ToString, dr.Item("classification").ToString, dr.Item("type").ToString, dr.Item("formulation").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString)
                _total += CDbl(dr.Item("total").ToString)
            End While
            dr.Close()
            cn.Close()
            calculateSalesDetails(_total)
            If dataGridView2.Rows.Count > 0 Then btnSettle.Enabled = True Else btnSettle.Enabled = False
            If dataGridView2.Rows.Count > 0 Then btnDisc.Enabled = True Else btnDisc.Enabled = False

        Catch ex As Exception
            dr.Close()
            cn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub calculateSalesDetails(ByVal _total As Double)
        Dim s As Double = 0
        lblTotal.Text = Format(_total, "#,##0.00")
        lblSubTotal.Text = Format(CDbl(lblTotal.Text) - CDbl(lblDisc.Text), "#,##0.00")
        lblVat.Text = Format(CDbl(lblSubTotal.Text) * getVat(), "#,##0.00")
        s = lblSubTotal.Text - lblVat.Text
        lblDue.Text = Format(s, "#,##0.00")
        txtDisplayTotal.Text = lblDue.Text
        btnDisc.Enabled = True

    End Sub
    Function getInvoiceNo() As String
        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")
            cn.Open()
            cm = New MySqlCommand("select * from tblcart where invoice like '%" & sdate & "%' order by id desc limit 1", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                getInvoiceNo = dr.Item("invoice").ToString
            Else
                getInvoiceNo = String.Empty

            End If
            dr.Close()
            cn.Close()
            If getInvoiceNo = String.Empty Then
                getInvoiceNo = sdate & "0001"
                Return getInvoiceNo
            Else
                getInvoiceNo = Trim(Str(CLng(getInvoiceNo) + 1))
                Return getInvoiceNo
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
            Return getInvoiceNo

        End Try
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToString("hh:mm:ss tt")


    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchProduct(cboFilter.Text, txtSearch.Text)

    End Sub

    Sub searchProduct(ByVal pfilter As String, ByVal psearch As String)


        Dim tc As String = ""

        Select Case cboFilter.Text
            Case "اسم الشعار"
                tc = "brand"
            Case "الباركود"
                tc = "barcode"
            Case "الاسم العام"
                tc = "generic"
        End Select

        cn.Open()
        If cboFilter.Text = String.Empty Then Return
        If tc = "barcode" Then cm = New MySqlCommand("SELECT * FROM `tblstockin` as s inner JOIN `tblproduct` as p on s.pid=p.id INNER JOIN tblbrand
as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN 
tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id where barcode like '" & txtSearch.Text & "'", cn)
        If tc = "brand" Then cm = New MySqlCommand("SELECT * FROM `tblstockin` as s inner JOIN `tblproduct` as p on s.pid=p.id INNER JOIN tblbrand
as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN 
tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id where brand like '" & txtSearch.Text & "'", cn)
        If tc = "generic" Then cm = New MySqlCommand("SELECT * FROM `tblstockin` as s inner JOIN `tblproduct` as p on s.pid=p.id INNER JOIN tblbrand
as b on p.bid=b.id INNER JOIN tblclassification as c on p.cid =c.id INNER JOIN 
tblformulation as f on p.fid=f.id INNER JOIN tblgeneric as g on p.gid=g.id INNER JOIN tbltype as t on p.tid=t.id where generic like '" & txtSearch.Text & "'", cn)

        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            With frmQty
                .lblPid.Text = dr.Item("pid").ToString
                .lblPrice.Text = dr.Item("price").ToString
                dr.Close()
                cn.Close()
                .ShowDialog()
            End With
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub dataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView2.CellContentClick
        Dim colName As String = dataGridView2.Columns(e.ColumnIndex).Name

        If colName = "delete" Then
            Try
                If (MsgBox("هل تريد حذف هاته البيانات", vbYesNo + vbQuestion) = vbYes) Then
                    cn.Open()
                    cm = New MySqlCommand("delete from tblCart where id = '" + dataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString + "' ", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("تم الحذف بنجاح")
                End If

            Catch ex As Exception
                MsgBox(ex.Message And " المرجو الاتصال بالمبرمج لحل المشكل")
            End Try
            loadCart()


        End If
    End Sub

    Private Sub btnSettle_Click(sender As Object, e As EventArgs) Handles btnSettle.Click
        With frmSettle
            .lblDue.Text = lblDue.Text
            .ShowDialog()

        End With
    End Sub

    Private Sub btnDisc_Click(sender As Object, e As EventArgs) Handles btnDisc.Click
        With frmChooseDiscount
            .getdiscount()

            .ShowDialog()

        End With
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub
End Class