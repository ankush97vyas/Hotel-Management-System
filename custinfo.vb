Public Class custinfo

    Dim amm, sty, rn, id, remain, pre As Integer
    Dim roomtyp As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        MDIParent1.Show()
        MDIParent1.Enabled = True
        Me.Close()
    End Sub

   

  

    Private Sub custinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' cnn.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=my hotel.mdb"
        'cnn.Open()

        Dim i As Integer
        sql = "select * from cust"
        If res.State = 1 Then res.Close()
        res.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset)
        For i = 0 To res.RecordCount - 1
            cmbid.Items.Add(res.Fields("ID").Value)
            res.MoveNext()
        Next


        'btncon.Enabled = False



    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        dtpout.Enabled = True
        btnupdate.Enabled = False
        btncon.Enabled = True
    End Sub

    Private Sub dtpout_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpout.ValueChanged
        Dim dateone = dtpin.Value
        Dim datetwo = dtpout.Value
        Dim diff As TimeSpan = datetwo.Subtract(dateone)
        Dim years As Double = diff.TotalDays / 365
        Dim y, m, d As Integer
        y = years.ToString
        m = (years * 12).ToString
        d = diff.TotalDays.ToString
        txtsty.Text = d




        id = Val(cmbid.Text)
        sty = Val(txtsty.Text)

        sql = "select * from cust where id =" & id & ""
        If res.State = 1 Then res.Close()
        res.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset)
        rn = res.Fields("R_NO").Value
        roomtyp = res.Fields("R_type").Value
        pre = res.Fields("Pre").Value
        remain = res.Fields("remain").Value



        If sty = 0 Then
            If roomtyp = "SINGLE" Then
                amm = 5000 * rn

            ElseIf roomtyp = "DOUBLE" Then
                amm = 10000 * rn
            ElseIf roomtyp = "DELUXE" Then
                amm = 15000 * rn
            ElseIf roomtyp = "BEACH SIDE ROOMS" Then
                amm = 25000 * rn
            ElseIf roomtyp = "UNDERWATER ROOMS" Then
                amm = 30000 * rn


            End If

        Else

            If roomtyp = "SINGLE" Then
                amm = 5000 * sty * rn

            ElseIf roomtyp = "DOUBLE" Then
                amm = 10000 * sty * rn
            ElseIf roomtyp = "DELUXE" Then
                amm = 15000 * sty * rn
            ElseIf roomtyp = "BEACH SIDE ROOMS" Then
                amm = 25000 * sty * rn
            ElseIf roomtyp = "UNDERWATER ROOMS" Then
                amm = 30000 * sty * rn

            End If
        End If


        

        remain = amm - pre





    End Sub


    Private Sub btncon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncon.Click
        Dim out As String
        out = dtpout.Text



        sql = "update cust set Stay =" & sty & ", check_Out ='" & out & "',Amount =" & amm & ",Remain =" & remain & ",T_payment =" & amm & " where id =" & id & ""
        cnn.Execute(sql)

        btncon.Enabled = True
        btnupdate.Enabled = False


        MsgBox("CUSTOMER UPDATION SUCCESSFULLY", MsgBoxStyle.Information, " UPDATION ")

        btncon.Enabled = False


    End Sub

    Private Sub cmbid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbid.SelectedIndexChanged
        Dim cn As Integer
        cn = Val(cmbid.Text)
        sql = "select * from cust where ID =" & cn
        If res.State = 1 Then res.Close()
        res.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset)
        txtname.Text = res.Fields("c_name").Value
        txtage.Text = res.Fields("Age").Value
        txtgender.Text = res.Fields("gender").Value
        txtadd.Text = res.Fields("Add").Value
        txtcty.Text = res.Fields("city").Value
        cmbstate.Text = res.Fields("state").Value
        mstno.Text = res.Fields("mobile").Value
        comboid.Text = res.Fields("prooftype").Value
        txtidc.Text = res.Fields("proofno").Value
        dtpin.Text = res.Fields("check_in").Value
        txtsty.Text = res.Fields("stay").Value
        dtpout.Text = res.Fields("check_out").Value
        btnupdate.Enabled = True
        
    End Sub

    Private Sub cmbid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbid.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnupdate.Enabled = True

        End If
    End Sub

    Private Sub custinfo_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class