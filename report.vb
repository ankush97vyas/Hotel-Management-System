Public Class report

  

    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Dim i As Integer
        sql = "select * from cust"
        If res.State = 1 Then res.Close()
        ' res.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset)
        res.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset)

        For i = 0 To res.RecordCount - 1

            dgv.Rows.Add()
            dgv.Rows(i).Cells(0).Value = res.Fields("ID").Value
            dgv.Rows(i).Cells(1).Value = res.Fields("C_NAME").Value
            dgv.Rows(i).Cells(2).Value = res.Fields("Age").Value
            dgv.Rows(i).Cells(3).Value = res.Fields("Gender").Value
            dgv.Rows(i).Cells(4).Value = res.Fields("ADD").Value
            dgv.Rows(i).Cells(5).Value = res.Fields("CITY").Value
            dgv.Rows(i).Cells(6).Value = res.Fields("state").Value
            dgv.Rows(i).Cells(7).Value = res.Fields("mobile").Value
            dgv.Rows(i).Cells(8).Value = res.Fields("prooftype").Value
            dgv.Rows(i).Cells(9).Value = res.Fields("proofno").Value
            dgv.Rows(i).Cells(10).Value = res.Fields("check_in").Value
            dgv.Rows(i).Cells(11).Value = res.Fields("stay").Value
            dgv.Rows(i).Cells(12).Value = res.Fields("check_out").Value
            dgv.Rows(i).Cells(13).Value = res.Fields("T_member").Value
            dgv.Rows(i).Cells(14).Value = res.Fields("child").Value
            dgv.Rows(i).Cells(15).Value = res.Fields("adults").Value
            dgv.Rows(i).Cells(16).Value = res.Fields("R_type").Value
            dgv.Rows(i).Cells(17).Value = res.Fields("R_no").Value
            dgv.Rows(i).Cells(18).Value = res.Fields("floor").Value
            dgv.Rows(i).Cells(19).Value = res.Fields("amount").Value
            dgv.Rows(i).Cells(20).Value = res.Fields("pre").Value
            dgv.Rows(i).Cells(21).Value = res.Fields("remain").Value
            dgv.Rows(i).Cells(22).Value = res.Fields("T_payment").Value




            res.MoveNext()
        Next
        Label2.Text = dgv.RowCount - 1
    End Sub

   



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MDIParent1.Show()
        MDIParent1.Enabled = True
        Me.Close()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label4.Click

    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class