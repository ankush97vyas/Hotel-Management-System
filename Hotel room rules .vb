Public Class Hotel_room_rules

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        MDIParent1.Show()
        MDIParent1.Enabled = True
        Me.Hide()
    End Sub
End Class