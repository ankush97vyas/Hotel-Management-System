Public Class checkin
    Dim sty, id, mem, age, child, ad, am, pre, tot, re, rn As Integer
    Dim nam, add, st, cty, mno, cmbi, ipc, cin, gender, cout, rt, fl, pass, adhar, cmbg, gen As String
   

    Private Sub senddata()
        cmbi = cmboid.Text
        'cmbg = cbg.Text
        If radiofemale.Checked = True Then
            gen = radiofemale.Text
        ElseIf radiomale.Checked = True Then
            gen = radiomale.Text

        End If
        id = Val(txtid.Text)
        nam = txtname.Text
        age = Val(txtage.Text)
        add = txtadd.Text
        cty = txtcty.Text
        st = cmbs.Text
        mno = mstno.Text
        cin = dtpin.Text
        sty = Val(txtstay.Text)
        cout = dtpout.Text
        mem = Val(txtmember.Text)
        child = nudchild.Value
        ad = nudad.Value
        am = Val(txtamt.Text)
        rt = cmbr.Text
        rn = Val(txtrno.Text)
        fl = cmbf.Text
        pre = Val(Txtpre.Text)
        re = Val(txtre.Text)
        tot = Val(lbltot.Text)
        ' If cmboid.Text = "PASSPORT" Then



    End Sub

    Private Sub btnsub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsub.Click


        senddata()


      
        If txtadd.Text = "" Or txtname.Text = "" Or txtage.Text = "" Or txtamt.Text = "" Or txtidc.Text = "" Or txtmember.Text = "" Or txtre.Text = "" Or txtrno.Text = "" Or txtstay.Text = "" Then
            MsgBox("Please Fill All Fields", MsgBoxStyle.Information)

        Else
            If cmboid.Text = "PASSPORT" Then
                cmbi = cmboid.Text
                pass = txtidc.Text
                adhar = "-"
                sql = "insert into cust values(" & id & ",'" & nam & "'," & age & ", '" & gen & " '  ,'" & add & "' , '" & cty & " ' , '" & st & "','" & mno & "', '" & cmbi & " ' , ' " & pass & " ', '" & cin & "' , " & sty & " , '" & cout & "' ,  '" & mem & "','" & child & "' , '" & ad & "', '" & rt & "'," & rn & " , '" & fl & "', " & am & " , " & pre & " , " & re & " , " & tot & " )"

            Else
                adhar = txtidc.Text
                pass = "-"
                sql = "insert into cust values(" & id & ",'" & nam & "'," & age & ", ' " & gen & " ' ,'" & add & "' , '" & cty & " ' , '" & st & "','" & mno & "','" & cmbi & " ',  '" & adhar & " ','" & cin & "' , " & sty & " , '" & cout & "' ,  '" & mem & "','" & child & "' , '" & ad & "', '" & rt & "'," & rn & " , '" & fl & "', " & am & " , " & pre & " , " & re & " , " & tot & " )"

               
            End If
            Dim result As Integer = MsgBox("DO YOU WANT TO SAVE DATA", MsgBoxStyle.YesNo)
            If result = DialogResult.Yes Then

                cnn.Execute(sql)

                MsgBox("DATA SAVE SUCCESSFULLY", MsgBoxStyle.Information, " Room Rserved ")


            End If
        End If
        MDIParent1.Show()
        MDIParent1.Enabled = True
        Me.Close()


    End Sub


       Private Sub gencode()
        Dim id As Integer
        sql = "select * from cust"
        If res.State = 1 Then res.Close()
        res.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset)
        res.MoveLast()
        id = res.Fields("id").Value
        res.MoveNext()
        id = id + 1
        txtid.Text = id

    End Sub
    'Private Sub clear()
    '    txtname.Clear()
    '    txtage.Clear()
    '    txtadd.Clear()
    '    txtcty.Clear()
    '    cmbs.Items.Clear()
    '    mstno.Clear()
    '    cmboid.Items.Clear()
    '    txtidc.Clear()
    '    txtstay.Clear()
    '    '  txtmember.Clear()
    '    cmbr.Items.Clear()
    '    txtrno.Clear()
    '    cmbf.Text = ""

    '    txtamt.Clear()
    '    Txtpre.Clear()
    '    txtre.Clear()
    '    nudad.Value = 0
    '    nudchild.Value = 0
    '    lbltot.Text = "___________"
    'End Sub
    Private Sub checkin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ' cnn.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=my hotel.mdb"
        'cnn.Open()
        dtpin.Text = Date.Today
        dtpout.MinDate = Date.Today




        txtname.Enabled = False
        txtage.Enabled = False
        radiomale.Enabled = False
        radiofemale.Enabled = False
        txtadd.Enabled = False
        txtcty.Enabled = False
        cmbs.Enabled = False
        mstno.Enabled = False
        cmboid.Enabled = False
        txtidc.Enabled = False
        dtpin.Enabled = False
        dtpout.Enabled = False
        nudchild.Enabled = False
        nudad.Enabled = False
        cmbr.Enabled = False
        txtrno.Enabled = False
        cmbf.Enabled = False
        Txtpre.Enabled = False

        btnsub.Enabled = False


        txtname.Focus()


    End Sub

    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        txtname.Focus()

        gencode()





        If txtidc.Enabled = True Then
            dtpout.Enabled = True
            nudchild.Enabled = True
            nudad.Enabled = True
            cmbr.Enabled = True
            txtrno.Enabled = True
            cmbf.Enabled = True
            Txtpre.Enabled = True

        End If

        btnnew.Enabled = True
        txtname.Enabled = True
        txtage.Enabled = True
        radiomale.Enabled = True
        radiofemale.Enabled = True
        txtadd.Enabled = True
        txtcty.Enabled = True
        cmbs.Enabled = True
        mstno.Enabled = True
        cmboid.Enabled = True
        txtidc.Enabled = False


        btnsub.Enabled = True



    End Sub

    Private Sub nudad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudad.LostFocus
        'Dim a, b, t As Integer
        'a = nudad.Value
        'b = nudchild.Value
        't = a + b
        'txtmember.Text = t



    End Sub

    Private Sub nudad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudad.ValueChanged
        a = nudad.Value
        b = nudchild.Value
        t = a + b
        txtmember.Text = t
    End Sub

    Private Sub cmbr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbr.SelectedIndexChanged


    End Sub

    Private Sub txtrno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrno.TextChanged
        Dim amm As Integer
        sty = Val(txtstay.Text)
        rn = Val(txtrno.Text)

        If sty = 0 Then

            If cmbr.Text = "SINGLE" Then
                amm = 5000 * rn
            ElseIf cmbr.Text = "DOUBLE" Then
                amm = 10000 * rn
            ElseIf cmbr.Text = "DELUXE" Then
                amm = 15000 * rn
            ElseIf cmbr.Text = "BEACH SIDE ROOMS" Then
                amm = 25000 * rn
            ElseIf cmbr.Text = "UNDERWATER ROOMS" Then
                amm = 30000 * rn

            End If


        Else

            If cmbr.Text = "SINGLE" Then
                amm = 5000 * sty * rn
            ElseIf cmbr.Text = "DOUBLE" Then
                amm = 10000 * sty * rn
            ElseIf cmbr.Text = "DELUXE" Then
                amm = 15000 * sty * rn
            ElseIf cmbr.Text = "BEACH SIDE ROOMS" Then
                amm = 25000 * sty * rn
            ElseIf cmbr.Text = "UNDERWATER ROOMS" Then
                amm = 30000 * sty * rn

            End If

        End If


        txtamt.Text = amm
        lbltot.Text = amm

    End Sub


    Private Sub txtamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamt.TextChanged

    End Sub

    Private Sub txtre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtre.TextChanged

    End Sub

    Private Sub Txtpre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpre.TextChanged
        Dim amt As Integer
        amt = Val(Txtpre.Text)
        txtre.Text = Val(txtamt.Text) - amt

    End Sub

    Private Sub txtage_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtage.LostFocus
        Dim age As Integer
        age = Val(txtage.Text)
        If (age < 18) Then
            MsgBox("NOT VAILID FOR REGISTER", MsgBoxStyle.Information)
            txtage.Focus()



        End If
    End Sub

    Private Sub txtage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtage.TextChanged

    End Sub

    Private Sub txtmember_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmember.TextChanged
        If txtmember.Text > 6 Then

            MsgBox("ROOM IS NOT SUFICIATE FOR TOO LARGE MEMBERS ")
            nudchild.Focus()




        End If
    End Sub




    Private Sub cmboid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboid.SelectedIndexChanged
        If cmboid.Text = "PASSPORT" Then
            txtidc.Enabled = True
            txtidc.MaxLength = 8

        Else
            txtidc.Enabled = True
            txtidc.MaxLength = 12



        End If
    End Sub
    Dim a, b, t As Integer

    Private Sub nudchild_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudchild.ValueChanged

        a = nudad.Value
        b = nudchild.Value
        t = a + b
        txtmember.Text = t
    End Sub





    Private Sub btnnew_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnew.DoubleClick

    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged

    End Sub

    Private Sub txtidc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidc.TextChanged

    End Sub

    Private Sub txtstay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstay.TextChanged

    End Sub



    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MDIParent1.Show()
        MDIParent1.Enabled = True
        Me.Close()

    End Sub

    Private Sub lbltot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltot.Click

    End Sub

    Private Sub dtpout_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub dtpout_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpout.ValueChanged
        Dim dateone = dtpin.Value
        Dim datetwo = dtpout.Value
        Dim diff As TimeSpan = datetwo.Subtract(dateone)
        Dim years As Double = diff.TotalDays / 365
        Dim y, m, d As Integer
        y = years.ToString
        m = (years * 12).ToString
        d = diff.TotalDays.ToString
        txtstay.Text = d


    End Sub
End Class

