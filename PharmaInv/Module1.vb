
Imports MySql.Data.MySqlClient




Module Module1

    Public cn As MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public strUser As String = ""
    Public strPass As String = ""
    Public strUserType As String = ""
    Public strName As String = ""
    Public strStatus As String = ""

    Public Function getVat()
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tblVat ", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then getVat = CDbl(dr.Item("vat").ToString) Else getVat = "0.00"
            cn.Close()
            dr.Close()
            Return getVat
        Catch ex As Exception
            cn.Close()
            dr.Close()
        End Try
    End Function
    Function getdata(ByVal sql As String) As String
        Try
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            getdata = cm.ExecuteScalar
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function
    Public Sub Connection()
        ' Dim cn As New MySqlConnection("server=localhost;user id=root;database=dbphar")
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server=localhost;user id=root;database=pharma"
        End With


    End Sub

    Public Function IS_EMPTY(ByVal stext As Object, stext1 As Object) As Boolean


        On Error Resume Next
        If stext.text = "" Then
            IS_EMPTY = True
            MsgBox("خطأ : احدى الحقول فارغة او المعلومات خاطئة  ", vbCritical)
            stext1.BackColor = Color.LemonChiffon
            stext1.focus()
        Else
            IS_EMPTY = False
            stext1.BackColor = Color.White
        End If


    End Function
    Public Function IS_EMPTY(ByVal stext As Object) As Boolean

        On Error Resume Next
        If stext.text = "" Then
            IS_EMPTY = True
            MsgBox("خطأ :احدى الحقول فارغة ", vbCritical)
            stext.BackColor = Color.LemonChiffon
            stext.focus()
        Else
            IS_EMPTY = False
            stext.BackColor = Color.White
        End If


    End Function

    Public Function validateDublicatedEntry(ByVal sql As String, ByVal text As Object) As Boolean
        Try
            cn.Open()
            cm = New MySqlCommand(sql, cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                validateDublicatedEntry = True
                text.backColor = Color.LemonChiffon

                MsgBox("البيانات موجودة بالفعل, حاول مجددا ")

            Else
                validateDublicatedEntry = False
                text.backColor = Color.White
            End If

            dr.Close()
            cn.Close()
        Catch ex As Exception

        End Try

    End Function








End Module
