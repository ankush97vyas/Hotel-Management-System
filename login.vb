Public Class login
  
    Private Sub atnadmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadmin.Click
        Dim user, pass As String
        user = txtn.Text
        pass = txtpass.Text
        sql = "select * from admin"
        If res.State = 1 Then res.Close()
        res.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset)
        If user = res.Fields("username").Value And pass = res.Fields("password").Value Then
            MsgBox("Login Successfully", MsgBoxStyle.Information, "Login")
            Me.Hide()
            MDIParent1.Show()

            txtn.Clear()
            txtpass.Clear()

        Else
            If txtn.Text = "" And txtpass.Text = "" Then
                MsgBox("Enter Username and Password", MsgBoxStyle.Information, "ENTER")
                txtn.Focus()
            Else
                If txtn.Text = "" Then
                    MsgBox("Enter Username", MsgBoxStyle.Information, "USERNAME")
                    txtn.Clear()
                    txtn.Focus()
                Else
                    If txtpass.Text = "" Then
                        MsgBox("Enter Password", MsgBoxStyle.Information, "PASSWORD")
                        txtpass.Clear()
                        txtpass.Focus()
                    Else

                        MsgBox("Invalid Username And Password", MsgBoxStyle.Information, "Invalid")
                        txtn.Clear()
                        txtpass.Clear()
                        txtn.Focus()
                    End If
                End If
            End If

        End If
        user = txtn.Text
        pass = txtpass.Text
    End Sub


    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtn.Focus()
        cnn.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=my hotel.mdb"
        cnn.Open()
    End Sub

    Private Sub btnclos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclos.Click
        End
    End Sub
End Class