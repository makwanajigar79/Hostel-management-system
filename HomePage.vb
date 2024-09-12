Public Class HomePage

    Private Sub btnLogOut_Click(sender As System.Object, e As System.EventArgs) Handles btnLogOut.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnRooms_Click(sender As System.Object, e As System.EventArgs) Handles btnRooms.Click
        With RoomsPage
            .TopLevel = False
            PanelHomePage.Controls.Add(RoomsPage)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub PanelHomePage_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelHomePage.Paint

    End Sub

    Private Sub btnStudents_Click(sender As System.Object, e As System.EventArgs) Handles btnStudents.Click
        With StudentPage
            .TopLevel = False
            PanelHomePage.Controls.Add(StudentPage)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnReports_Click(sender As System.Object, e As System.EventArgs) Handles btnReports.Click

        With ReportPage
            .TopLevel = False
            PanelHomePage.Controls.Add(ReportPage)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class