
Imports MySql.Data.MySqlClient




Module Module1

    Public cn As MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader

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

                MsgBox("المنتج موجود بالفعل غير المنتج او الباركود")

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
