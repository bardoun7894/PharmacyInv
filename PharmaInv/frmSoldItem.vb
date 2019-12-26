
Imports MySql.Data.MySqlClient

Public Class frmSoldItem



    Sub GetSoldTop()
        Dim i As Integer = 0
        Try
            dataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select ca.pid,b.brand,g.generic ,c.classification,f.formulation,t.type ,sum(ca.qty) from tblCart as ca inner JOIN tblproduct as p on ca.pid=p.id inner JOIN tblbrand as b on p.bid=b.id INNER join tblgeneric as g on p.gid=g.id 
             INNER join tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid =f.id INNER JOIN tbltype as t on p.tid =t.id where sdate between '" & dt1.Value.ToString("yyyy-MM-dd") & "' and '" & dt2.Value.ToString("yyyy-MM-dd") & "' group by ca.pid order by sum(ca.qty) desc limit " & CInt(cboTop.Text) & "", cn)
            dr = cm.ExecuteReader
            While dr.Read()
                i += 1
                dataGridView2.Rows.Add(i, dr.Item("pid").ToString, dr.Item("brand").ToString, dr.Item("generic").ToString, dr.Item("classification").ToString, dr.Item("formulation").ToString, dr.Item("type").ToString, dr.Item("sum(ca.qty)").ToString)
            End While
            cn.Close()
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try





    End Sub
    Sub GetSoldType()
        Dim i As Integer = 0
        Try
            dataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select ca.pid,b.brand,g.generic ,c.classification,f.formulation,t.type ,sum(ca.qty) from tblCart as ca inner JOIN tblproduct as p on ca.pid=p.id inner JOIN tblbrand as b on p.bid=b.id INNER join tblgeneric as g on p.gid=g.id 
             INNER join tblclassification as c on p.cid =c.id INNER JOIN tblformulation as f on p.fid =f.id INNER JOIN tbltype as t on p.tid =t.id where sdate between '" & dt1.Value.ToString("yyyy-MM-dd") & "' and '" & dt2.Value.ToString("yyyy-MM-dd") & "' group by ca.pid order by brand,generic ", cn)
            dr = cm.ExecuteReader
            While dr.Read()
                i += 1
                dataGridView2.Rows.Add(i, dr.Item("pid").ToString, dr.Item("brand").ToString, dr.Item("generic").ToString, dr.Item("classification").ToString, dr.Item("formulation").ToString, dr.Item("type").ToString, dr.Item("sum(ca.qty)").ToString)
            End While
            cn.Close()
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IS_EMPTY(cboTop) = True Then Return

    End Sub

    Private Sub cboTop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTop.SelectedIndexChanged
        GetSoldTop()
    End Sub
End Class