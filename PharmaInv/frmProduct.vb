Imports MySql.Data.MySqlClient


Public Class frmProduct
    Private Sub MetroTextBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()


    End Sub
    Sub clear()
        txtBarcode.Clear()
        txtBrand.Clear()
        txtGeneric.Clear()
        txtClassification.Clear()
        txtType.Clear()
        txtFormulation.Clear()
        txtReOrder.Clear()
        txtQTy.Clear()
        txtPrice.Clear()

    End Sub

    Sub loadBrand()
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tblbrand order by brand ", cn)
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter(cm)
            da.Fill(ds, "brand")
            Dim col As New AutoCompleteStringCollection

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("brand").ToString)
            Next
            txtBrand.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtBrand.AutoCompleteCustomSource = col
            txtBrand.AutoCompleteMode = AutoCompleteMode.Suggest
            cm = Nothing
            cn.Close()
        Catch ex As Exception
            cn.Close()

            MsgBox(ex.Message)
        End Try
    End Sub
    Sub loadGeneric()
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tblGeneric order by generic ", cn)
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter(cm)
            da.Fill(ds, "generic")
            Dim col As New AutoCompleteStringCollection
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("generic").ToString)
            Next
            txtGeneric.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtGeneric.AutoCompleteCustomSource = col
            txtGeneric.AutoCompleteMode = AutoCompleteMode.Suggest
            cm = Nothing
            cn.Close()
        Catch ex As Exception
            cn.Close()

            MsgBox(ex.Message)

        End Try





    End Sub
    Sub loadClassification()
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tblClassification order by classification ", cn)
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter(cm)
            da.Fill(ds, "classification")
            Dim col As New AutoCompleteStringCollection

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("classification").ToString)
            Next
            txtClassification.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtClassification.AutoCompleteCustomSource = col
            txtClassification.AutoCompleteMode = AutoCompleteMode.Suggest
            cm = Nothing
            cn.Close()
        Catch ex As Exception
            cn.Close()

            MsgBox(ex.Message)

        End Try





    End Sub

    Sub loadType()
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tblType order by type ", cn)
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter(cm)
            da.Fill(ds, "type")
            Dim col As New AutoCompleteStringCollection
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("type").ToString)
            Next
            txtType.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtType.AutoCompleteCustomSource = col
            txtType.AutoCompleteMode = AutoCompleteMode.Suggest
            cm = Nothing
            cn.Close()
        Catch ex As Exception
            cn.Close()

            MsgBox(ex.Message)

        End Try





    End Sub

    Sub loadFormulation()
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tblFormulation order by formulation ", cn)
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter(cm)
            da.Fill(ds, "formulation")
            Dim col As New AutoCompleteStringCollection

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("formulation").ToString)
            Next
            txtFormulation.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtFormulation.AutoCompleteCustomSource = col
            txtFormulation.AutoCompleteMode = AutoCompleteMode.Suggest
            cm = Nothing
            cn.Close()
        Catch ex As Exception
            cn.Close()

            MsgBox(ex.Message)

        End Try





    End Sub

    Private Sub txtBrand_TextChanged(sender As Object, e As EventArgs) Handles txtBrand.TextChanged
        Try

            cn.Open()
            cm = New MySqlCommand("select * from tblBrand where brand like '" + txtBrand.Text + "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then lblbrand.Text = dr.Item(0).ToString() Else lblbrand.Text = String.Empty

            cm = Nothing
            dr.Close()


            cn.Close()

        Catch ex As Exception
            cm = Nothing
            dr.Close()
            cn.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub textGeneric_TextChanged(sender As Object, e As EventArgs) Handles txtGeneric.TextChanged
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tblGeneric where generic like '" + txtGeneric.Text + "'", cn)

            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then lblGeneric.Text = dr.Item(0).ToString() Else lblGeneric.Text = String.Empty
            cm = Nothing
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cm = Nothing
            dr.Close()
            cn.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtClassification_TextChanged(sender As Object, e As EventArgs) Handles txtClassification.TextChanged
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tblClassification where classification like '" + txtClassification.Text + "'", cn)


            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then lblclassification.Text = dr.Item(0).ToString() Else lblclassification.Text = String.Empty

            cm = Nothing
            dr.Close()


            cn.Close()

        Catch ex As Exception
            cm = Nothing
            dr.Close()
            cn.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtType_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tblType where type = '" + txtType.Text + "'", cn)


            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then lblType.Text = dr.Item(0).ToString() Else lblType.Text = String.Empty

            cm = Nothing
            dr.Close()
            cn.Close()

        Catch ex As Exception
            cm = Nothing
            dr.Close()
            cn.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtFormulation_TextChanged(sender As Object, e As EventArgs) Handles txtFormulation.TextChanged
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tblFormulation where formulation like '" + txtFormulation.Text + "'", cn)


            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then lblFormulation.Text = dr.Item(0).ToString() Else lblFormulation.Text = String.Empty

            cm = Nothing
            dr.Close()


            cn.Close()

        Catch ex As Exception
            cm = Nothing
            dr.Close()
            cn.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBrand()
        loadGeneric()
        loadClassification()
        loadFormulation()
        loadType()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If IS_EMPTY(txtBarcode) = True Then Return
            If IS_EMPTY(lblbrand, txtBrand) = True Then Return
            If IS_EMPTY(lblGeneric, txtGeneric) = True Then Return
            If IS_EMPTY(txtClassification, lblclassification) = True Then Return
            If IS_EMPTY(lblType, txtType) = True Then Return
            If IS_EMPTY(lblFormulation, txtFormulation) = True Then Return
            If IS_EMPTY(txtReOrder) = True Then Return
            If IS_EMPTY(txtPrice) = True Then Return
            If IS_EMPTY(txtQTy) = True Then Return

            If validateDublicatedEntry("select * from tblProduct where barcode like '" + txtBarcode.Text + "'", txtBarcode) = True Then Return


            If MsgBox("هل تريد اضافة هاته البيانات", vbYesNo, "Yes") = MsgBoxResult.Yes Then
                cn.Open()
                cm = Nothing
                cm = New MySqlCommand("insert into tblproduct ( barcode,bid,gid,cid,tid,fid,reorder,qty,price)values( @barcode,@bid,@gid,@cid,@tid,@fid,@reorder,@qty,@price) ", cn)
                With cm

                    .Parameters.AddWithValue("@barcode", txtBarcode.Text)
                    .Parameters.AddWithValue("@bid", CInt(lblbrand.Text))
                    .Parameters.AddWithValue("@gid", CInt(lblGeneric.Text))
                    .Parameters.AddWithValue("@cid", CInt(lblclassification.Text))
                    .Parameters.AddWithValue("@tid", CInt(lblType.Text))
                    .Parameters.AddWithValue("@fid", CInt(lblFormulation.Text))
                    .Parameters.AddWithValue("@reorder", CInt(txtReOrder.Text))

                    .Parameters.AddWithValue("@price", CDec(txtPrice.Text))
                    .Parameters.AddWithValue("@qty", CInt(txtQTy.Text))
                    .ExecuteNonQuery()

                End With
                MsgBox("تمت الاضافة بنجاح")
                cn.Close()

                clear()
            End If

            With frmProductList
                .loadRecords()

            End With
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message & " المرجو الاتصال بالمبرمج لحل المشكل")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            If IS_EMPTY(txtBarcode) = True Then Return
            If IS_EMPTY(lblbrand, txtBrand) = True Then Return
            If IS_EMPTY(lblGeneric, txtGeneric) = True Then Return
            If IS_EMPTY(txtClassification, lblclassification) = True Then Return
            If IS_EMPTY(lblType, txtType) = True Then Return
            If IS_EMPTY(lblFormulation, txtFormulation) = True Then Return
            If IS_EMPTY(txtReOrder) = True Then Return
            If IS_EMPTY(txtPrice) = True Then Return
            If IS_EMPTY(txtQTy) = True Then Return

            If validateDublicatedEntry("select * from tblProduct where barcode like '" + txtBarcode.Text + "'", txtBarcode) = True Then Return

            If lblGeneric.Text = String.Empty Or lblbrand.Text = String.Empty Or lblFormulation.Text = String.Empty Or lblclassification.Text = String.Empty Then
                MsgBox(" المرجو ادخال المعلومات الصحيحة ")

            ElseIf txtBarcode.Text = String.Empty Or txtGeneric.Text = String.Empty Or txtBrand.Text = String.Empty Or txtType.Text = String.Empty Or txtClassification.Text = String.Empty Or txtFormulation.Text = String.Empty Or txtPrice.Text = String.Empty Or txtQTy.Text = String.Empty Or txtReOrder.Text = String.Empty Then

                MsgBox("المرجو تعبئة الحقول")
            Else
                If MsgBox("هل تريد تعديل هاته البيانات", vbInformation, "Yes") = MsgBoxResult.Yes Then

                    cn.Open()
                    cm = Nothing
                    cm = New MySqlCommand("update  tblproduct set barcode=@barcode,bid=@bid,gid=@gid,cid=@cid,tid=@tid,fid=@fid,reorder=@reorder,qty=@qty,price=@price where id like  '" + labelId.Text + "'", cn)

                    With cm

                        .Parameters.AddWithValue("@barcode", txtBarcode.Text)
                        .Parameters.AddWithValue("@bid", CInt(lblbrand.Text))
                        .Parameters.AddWithValue("@gid", CInt(lblGeneric.Text))
                        .Parameters.AddWithValue("@cid", CInt(lblclassification.Text))
                        .Parameters.AddWithValue("@tid", CInt(lblType.Text))
                        .Parameters.AddWithValue("@fid", CInt(lblFormulation.Text))
                        .Parameters.AddWithValue("@reorder", CInt(txtReOrder.Text))

                        .Parameters.AddWithValue("@price", CDec(txtPrice.Text))
                        .Parameters.AddWithValue("@qty", CInt(txtQTy.Text))
                        .ExecuteNonQuery()

                    End With
                End If

                MsgBox("تمت التعديل بنجاح")
                    cn.Close()

                    clear()
                End If
                With frmProductList
                .loadRecords()

            End With
            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message & " المرجو الاتصال بالمبرمج لحل المشكل")
        End Try
    End Sub

    Private Sub txtReOrder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReOrder.KeyPress
        Select Case Asc(e.KeyChar)

            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        Select Case Asc(e.KeyChar)

            Case 48 To 57  '0--9'
            Case 46   ' (.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtQTy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQTy.KeyPress

        Select Case Asc(e.KeyChar)

            Case 48 To 57  '0--9'
            Case 46   ' (.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select

    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Me.Dispose()

    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub
End Class