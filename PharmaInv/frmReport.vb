
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class frmReport
    Dim sdate1 As String
    Dim sdate2 As String
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'pharmaDataSet.tblpayment' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DataSet3.tblpayment' table. You can move, or remove it, as needed.


        loadUser()




    End Sub
    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click
    End Sub
    Sub loadUser()
        Try
            cboUser.Items.Clear()

            cn.Open()
            cm = New MySqlCommand("select distinct user from tblPayment ", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboUser.Items().Add(dr.Item("user").ToString)

            End While


            cn.Close()

        Catch ex As Exception

        End Try
    End Sub
    Sub loadReport(ByVal sql As String)
        ReportViewer1.RefreshReport()
        Dim rptds As ReportDataSource
        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "/reports/Report1.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            cn.Open()
            da.SelectCommand = Nothing
            da.SelectCommand = New MySqlCommand(sql, cn)
            da.Fill(ds.Tables("dtpayment"))
            cn.Close()
            Dim pdate As New ReportParameter("pDate", "(" & sdate2 & ")<>(" & sdate1 & " ) : نطاق التاريخ  ")
            ReportViewer1.LocalReport.SetParameters(pdate)
            rptds = New ReportDataSource("DataSet1", ds.Tables("dtpayment"))
            ReportViewer1.LocalReport.DataSources.Add(rptds)

            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal)

            ReportViewer1.ZoomMode = ZoomMode.PageWidth


        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        sdate1 = dt1.Value.ToString("yyyy-MM-dd")
        sdate2 = dt2.Value.ToString("yyyy-MM-dd")



        loadReport("select * from tblPayment where sdate between '" & sdate1 & "' and '" & sdate2 & "' and user like '" & cboUser.Text & "' ")

    End Sub
End Class