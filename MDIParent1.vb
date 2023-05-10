Imports System.Windows.Forms

Public Class MDIParent1


    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Start()
        Timer3.Start()




    End Sub




    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Are u sure ?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub HouseRulesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HouseRulesToolStripMenuItem.Click
        Me.Enabled = False
        Hotel_room_rules.Show()

    End Sub

    Private Sub AllFcacilitiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllFcacilitiesToolStripMenuItem.Click
        Me.Enabled = False
        Room_facilities.Show()

    End Sub

    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
       
    End Sub

    Private Sub ViewAllRoomsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllRoomsToolStripMenuItem.Click
        Me.Enabled = False
        Rooms.Show()

    End Sub

    Private Sub CheckINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckINToolStripMenuItem.Click
        Me.Enabled = False
        checkin.Show()
    End Sub

    Private Sub CheckOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOUTToolStripMenuItem.Click
        Me.Enabled = False
        checkout.Show()

    End Sub

    Private Sub CostmerInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostmerInformationToolStripMenuItem.Click
        Me.Enabled = False
        custinfo.Show()


    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
          End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If PictureBox1.Visible = True Then
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox1.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
        ElseIf PictureBox2.Visible = True Then
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False

        ElseIf PictureBox3.Visible = True Then
            PictureBox4.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
        ElseIf PictureBox4.Visible = True Then
            PictureBox5.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
        ElseIf PictureBox5.Visible = True Then
            PictureBox6.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
        ElseIf PictureBox6.Visible = True Then
            PictureBox7.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
        ElseIf PictureBox7.Visible = True Then
            PictureBox8.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
        ElseIf PictureBox8.Visible = True Then
            PictureBox9.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False

        ElseIf PictureBox9.Visible = True Then
            PictureBox10.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
        ElseIf PictureBox10.Visible = True Then
            PictureBox11.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
        ElseIf PictureBox11.Visible = True Then
            PictureBox12.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False

        ElseIf PictureBox12.Visible = True Then
            PictureBox13.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
            PictureBox1.Visible = False

        ElseIf PictureBox13.Visible = True Then
            PictureBox14.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox15.Visible = False
            PictureBox16.Visible = False
            PictureBox1.Visible = False

        ElseIf PictureBox14.Visible = True Then
            PictureBox15.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox16.Visible = False
            PictureBox1.Visible = False
        ElseIf PictureBox15.Visible = True Then
            PictureBox16.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox1.Visible = False
        Else
            PictureBox16.Visible = False
            PictureBox13.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label1.Text = Today + "  " + TimeOfDay


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub RoomStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomStatusToolStripMenuItem.Click
        Me.Enabled = False
        roomstatus.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Enabled = False
        about.Show()

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        login.Show()
        Me.Hide()


    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        If MsgBox("Are u sure ?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            End
        End If

    End Sub

    Private Sub CheckINToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckINToolStripMenuItem1.Click
        Me.Enabled = False
        report.Show()


    End Sub

    Private Sub CheckOUTToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOUTToolStripMenuItem1.Click
        Me.Enabled = False
        outreport.Show()
    End Sub
End Class
