

Imports MySql.Data.MySqlClient
Public Class frmSales
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSales.Click

    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Me.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        lblInvoice.Enabled = True
        lblInvoice.Text = getInvoiceNo()
        txtSearch.Enabled = True
        txtSearch.Focus()


    End Sub

    Function getInvoiceNo() As String
        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")
            cn.Open()
            cm = New MySqlCommand("select * from tblcart where invoice like '" & sdate & "%'", cn)
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
                getInvoiceNo = Str(CLng(getInvoiceNo) + 1)
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
End Class