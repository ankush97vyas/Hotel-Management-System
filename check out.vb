Public Class checkout
    Dim ad, child, tmem, amm, sty, rn, id, remain, pre As Integer
    Dim roomtyp, troom, floor As String









    Private Sub comboid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboid.LostFocus
        If comboid.Text = "PASSPORT" Then
            txtidconf.Enabled = True

        End If

    End Sub


  

    Private Sub checkout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Dim i As Integer
        sql = "select * from cust"
        If res.State = 1 Then res.Close()
        res.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset)
        For i = 0 To res.RecordCount - 1
            cmbid.Items.Add(res.Fields("ID").Value)
            res.MoveNext()
        Next

    End Sub
    Private Sub clear()
        txtname.Clear()
        txtage.Clear()
        tgender.Clear()

        txtadd.Clear()
        txtcty.Clear()
        txtstate.Clear()
        mstno.Clear()
        comboid.Text = ""


        txtidconf.Clear()
        txtstay.Clear()
        txtpre.Clear()
        txtrem.Clear()
        lbltot.Text = "___________"
        cmbpay.Items.Clear()

    End Sub
    Private Sub getdata()
        Dim id As Integer
        id = Val(cmbid.Text)
        sql = "select * from cust where id =" & id & ""
        If res.State = 1 Then res.Close()
        res.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset)

        tmem = res.Fields("t_member").Value
        child = res.Fields("child").Value
        ad = res.Fields("adults").Value
        roomtyp = res.Fields("r_type").Value
        troom = res.Fields("r_no").Value
        floor = res.Fields("floor").Value
        amm = res.Fields("amount").Value

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If cmbpay.Text = "" Then
            MsgBox("BINAA PAYAA DIYA KATE JAYE BHAI ")
        Else

            getdata()
            sql = "insert into checkout values(" & cmbid.Text & ",'" & txtname.Text & "','" & txtage.Text & "', '" & tgender.Text & " '  ,'" & txtadd.Text & "' , '" & txtcty.Text & " ' , '" & txtstate.Text & "','" & mstno.Text & "', '" & comboid.Text & " ' , ' " & txtidconf.Text & " ', '" & dtpin.Text & "' , " & txtstay.Text & " , '" & dtpout.Text & "' ,  '" & tmem & "','" & child & "' , '" & ad & "', '" & roomtyp & "'," & rn & " , '" & floor & "', " & amm & " , " & txtpre.Text & " , " & txtrem.Text & " , " & lbltot.Text & " )"
            cnn.Execute(sql)
            Dim id As Integer
            id = Val(cmbid.Text)
            sql = "DELETE FROM cust WHERE id =" & id & ""
            '    If res.State = 1 Then res.Close()
            '     res.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset)
            cnn.Execute(sql)
            MsgBox("CUSTOMER CHECK  OUT SUCCESSFULLY", MsgBoxStyle.Information, " Check OUT ")
            clear()
            MDIParent1.Show()
            MDIParent1.Enabled = True
            Me.Close()
        End If


    End Sub

    Private Sub cmbid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbid.SelectedIndexChanged
        Dim cn As Integer
        cn = Val(cmbid.Text)
        sql = "select * from cust where ID =" & cn
        If res.State = 1 Then res.Close()
        res.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset)
        txtname.Text = res.Fields("c_name").Value
        txtage.Text = res.Fields("Age").Value
        tgender.Text = res.Fields("gender").Value
        txtadd.Text = res.Fields("Add").Value
        txtcty.Text = res.Fields("city").Value
        txtstate.Text = res.Fields("state").Value
        mstno.Text = res.Fields("mobile").Value
        comboid.Text = res.Fields("prooftype").Value
        txtidconf.Text = res.Fields("proofno").Value
        dtpin.Text = res.Fields("check_in").Value
        txtstay.Text = res.Fields("stay").Value
        dtpout.Text = res.Fields("check_out").Value
        txtpre.Text = res.Fields("pre").Value
        txtrem.Text = res.Fields("remain").Value
        lbltot.Text = res.Fields("t_payment").Value

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub tgender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tgender.TextChanged

    End Sub

   
    Private Sub btnclos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclos.Click
        MDIParent1.Show()
        MDIParent1.Enabled = True
        Me.Close()
    End Sub
End Class