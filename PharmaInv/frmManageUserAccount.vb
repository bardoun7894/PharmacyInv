
Imports MySql.Data.MySqlClient


Public Class frmManageUserAccount
    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttypeUser.KeyPress
        e.Handled = True

    End Sub
    Sub clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            If IS_EMPTY(txtUser) = True Then Return
            If IS_EMPTY(txtPass) = True Then Return
            If IS_EMPTY(txtconfirm) = True Then Return
            If IS_EMPTY(txttypeUser) = True Then Return
            If IS_EMPTY(cboStatus) = True Then Return
            If txtPass.Text <> txtconfirm.Text Then
                MsgBox("كلمة السر غير متوافقة ")
                Return
            ElseIf MsgBox("هل تريد اضافة حساب جديد ", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("insert into tblUser (username,password,name,user_type,status)values(@username,@password,@name,@user_type,@status)", cn)
                With cm
                    .Parameters.AddWithValue("@username", txtUser.Text)
                    .Parameters.AddWithValue("@password", txtPass.Text)
                    .Parameters.AddWithValue("@name", txtName.Text)
                    .Parameters.AddWithValue("@user_type", txttypeUser.Text)
                    .Parameters.AddWithValue("@status", cboStatus.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("تمت الاضافة الحساب بنجاح ")
                cn.Close()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)

        End Try


    End Sub
    Sub loadUserList()
        Dim i As Integer = 0
        dataGridView2.Rows.Clear()

        cn.Open()
        cm = New MySqlCommand("select * from tbluser order by user_type,username", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            dataGridView2.Rows.Add(i, dr.Item("username").ToString, dr.Item("user_type").ToString, dr.Item("name").ToString, dr.Item("status").ToString)
        End While
        cn.Close()
    End Sub
    Private Sub dataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView2.CellContentClick
        Dim colname As String = dataGridView2.Columns(e.ColumnIndex).Name
        Try
            If colname = "colstatus" Then
                If dataGridView2.Rows(e.RowIndex).Cells(4).Value.ToString = "متاح" Then
                    If MsgBox("هل تريد تغيير هذا الحساب الى غير متاح ", vbYesNo + vbQuestion) = vbYes Then
                        cn.Open()
                        cm = New MySqlCommand("update tbluser set status = 'غير متاح' where username like '" & dataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()
                    End If

                ElseIf dataGridView2.Rows(e.RowIndex).Cells(4).Value.ToString = "غير متاح" Then

                    If MsgBox("هل تريد تغيير هذا الحساب الى  متاح ", vbYesNo + vbQuestion) = vbYes Then
                        cn.Open()
                        cm = New MySqlCommand("update tbluser set status = 'متاح' where username like '" & dataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()

                    End If

                End If
            loadUserList()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()


        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        With frmChangePassword
            .ShowDialog()

        End With
    End Sub
End Class