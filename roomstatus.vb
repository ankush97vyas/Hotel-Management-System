Public Class roomstatus


    Private Sub roomstatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv2.Rows.Add("101", "Single", "Clean")
        dgv2.Rows.Add("102", "Single", " NOT Clean")
        dgv2.Rows.Add("103", "Single", " NOT Clean")
        dgv2.Rows.Add("104", "Single", "Not Clean")
        dgv2.Rows.Add("105", "Single", "NOT clean")
        dgv2.Rows.Add("", "", "")
        dgv2.Rows.Add("202", "Double", "Clean")
        dgv2.Rows.Add("202", "Double", "Clean")
        dgv2.Rows.Add("203", "Double", "Clean")
        dgv2.Rows.Add("204", "Double", "Not Clean")
        dgv2.Rows.Add("205", "Double", "NOT  clean")
        dgv2.Rows.Add("", "", "")
        dgv2.Rows.Add("301", "Deluxe", "NOT Clean")
        dgv2.Rows.Add("302", "Deluxe", "NOT Clean")
        dgv2.Rows.Add("303", "Deluxe", "NOT Clean")
        dgv2.Rows.Add("304", "Deluxe", "NOT Clean")
        dgv2.Rows.Add("305", "Deluxe", "Clean")
        dgv2.Rows.Add("", "", "")
        dgv2.Rows.Add("401", "Beach Side", "Not Clean")
        dgv2.Rows.Add("402", "Beach Side", "NOT Clean")
        dgv2.Rows.Add("403", "Beach Side", "Clean")
        dgv2.Rows.Add("404", "Beach Side", "Not Clean")
        dgv2.Rows.Add("405", "Beach Side", "Clean")
        dgv2.Rows.Add("", "", "")
        dgv2.Rows.Add("", "", "")
        dgv2.Rows.Add("501", "UnderWater", "Not Clean")
        dgv2.Rows.Add("502", "UnderWater", "NOT Clean")
        dgv2.Rows.Add("503", "UnderWater", "NOT Clean")
        dgv2.Rows.Add("504", "UnderWater", "Not Clean")
        dgv2.Rows.Add("505", "UnderWater", "NOT Clean")
        dgv2.Rows.Add("", "", "")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MDIParent1.Show()
        MDIParent1.Enabled = True
        Me.Hide()



    End Sub

   

    Private Sub Button3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MDIParent1.Show()
        MDIParent1.Enabled = True
        Me.Close()

    End Sub
End Class