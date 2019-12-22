
Imports MySql.Data.MySqlClient



Public Class frmQty
    Private Sub frmQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtQty.SelectionStart = 0
        txtQty.SelectionLength = txtQty.Text.Length

    End Sub

    Private Sub frmQty_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode

            Case Keys.Escape
                With frmSales
                    .txtSearch.Focus()
                    .txtSearch.SelectionStart = 0
                    .txtSearch.SelectionLength = txtQty.Text.Length
                    Me.Dispose()


                End With
            Case Keys.Enter
                addToCart()

        End Select

    End Sub
    Function getStockAvailable(ByVal sql As String)

        cn.Open()
        cm = New MySqlCommand(sql, cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            getStockAvailable = CInt(dr.Item("qty").ToString)
        Else
            getStockAvailable = 0

        End If

        dr.Close()
        cn.Close()
        Return getStockAvailable

    End Function
    Sub addToCart()
        Dim sdate As String = Now.ToString("yyyy-MM-dd")


        Try
            If txtQty.Text = String.Empty Or txtQty.Text = 0 Then Return
            cn.Open()
            cm = New MySqlCommand("select * from tblProduct where id like '" & CInt(lblPid.Text) & "' and  qty like'" & CInt(txtQty.Text) & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                cn.Close()
                dr.Close()
            Else
                MsgBox("الكمية نفذت ,فقط " & getStockAvailable("select * from tblProduct where id like '" & CInt(lblPid.Text) & "'") & " وحدات باقية")
                dr.Close()
                cn.Close()
                Return

            End If




            cn.Open()
            cm = Nothing
            cm = New MySqlCommand("insert into tblcart ( invoice,pid,price,qty,sdate,user)values( @invoice,@pid,@price,@qty,@sdate,@user ) ", cn)
            With frmSales


                cm.Parameters.AddWithValue("@invoice", .lblInvoice.Text)
                cm.Parameters.AddWithValue("@pid", CInt(lblPid.Text))
                cm.Parameters.AddWithValue("@price", CDbl(lblPrice.Text))
                cm.Parameters.AddWithValue("@qty", CInt(txtQty.Text))
                cm.Parameters.AddWithValue("@sdate", sdate)
                cm.Parameters.AddWithValue("@user", strUser)
                cm.ExecuteNonQuery()
                cn.Close()

                cn.Open()
                cm = New MySqlCommand("update tblcart set total =qty*price where invoice like '" & .lblInvoice.Text & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                .txtSearch.Focus()
                .txtSearch.SelectionStart = 0
                .txtSearch.SelectionLength = txtQty.Text.Length
                .txtSearch.Enabled = False

                .loadCart()
            End With


            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            cn.Close()

        End Try
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 58

            Case 8
            Case 13

            Case Else
                e.Handled = True
        End Select


    End Sub
End Class