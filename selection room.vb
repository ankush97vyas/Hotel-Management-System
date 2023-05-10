Public Class Rooms

    Private Sub Rooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()



        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If PictureBox1.Visible = True Then
            PictureBox6.Visible = True
            PictureBox7.Visible = False
            PictureBox1.Visible = False
        ElseIf PictureBox6.Visible = True Then
            PictureBox7.Visible = True
            PictureBox6.Visible = False
            PictureBox1.Visible = False
        Else : PictureBox7.Visible = True
            PictureBox1.Visible = True
            PictureBox6.Visible = False
            PictureBox7.Visible = False

           
           
            End If



    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If PictureBox2.Visible = True Then
            PictureBox4.Visible = True
            PictureBox5.Visible = False
            PictureBox2.Visible = False
        ElseIf PictureBox4.Visible = True Then
            PictureBox5.Visible = True
            PictureBox4.Visible = False
            PictureBox2.Visible = False
        Else
            PictureBox5.Visible = True
            PictureBox2.Visible = True
            PictureBox4.Visible = False
            PictureBox5.Visible = False
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If PictureBox3.Visible = True Then
            PictureBox8.Visible = True
            PictureBox9.Visible = False
            PictureBox3.Visible = False
        ElseIf PictureBox8.Visible = True Then
            PictureBox9.Visible = True
            PictureBox8.Visible = False
            PictureBox3.Visible = False
        Else
            PictureBox9.Visible = True
            PictureBox3.Visible = True
            PictureBox8.Visible = False
            PictureBox9.Visible = False
        End If
    End Sub

   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MDIParent1.Show()
        MDIParent1.Enabled = True
        Me.Close()

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If PictureBox20.Visible = True Then
            PictureBox21.Visible = True
            PictureBox22.Visible = False
            PictureBox20.Visible = False
        ElseIf PictureBox21.Visible = True Then
            PictureBox22.Visible = True
            PictureBox21.Visible = False
            PictureBox20.Visible = False
        Else
            PictureBox22.Visible = True
            PictureBox20.Visible = True
            PictureBox21.Visible = False
            PictureBox22.Visible = False
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If PictureBox23.Visible = True Then
            PictureBox24.Visible = True
            PictureBox25.Visible = False
            PictureBox23.Visible = False
        ElseIf PictureBox24.Visible = True Then
            PictureBox25.Visible = True
            PictureBox24.Visible = False
            PictureBox23.Visible = False
        Else
            PictureBox25.Visible = True
            PictureBox23.Visible = True
            PictureBox24.Visible = False
            PictureBox25.Visible = False
        End If
    End Sub
End Class