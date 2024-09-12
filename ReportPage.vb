Public Class ReportPage

   
    Private Sub btnHostelFees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHostelFees.Click
        Me.Hide()
        Report_Hostel_Fees.Show()
    End Sub

    Private Sub BTN_STUDENT_REPORTS_Click(sender As System.Object, e As System.EventArgs) Handles BTN_STUDENT_REPORTS.Click
        Me.Close()
        Report_Register_details.Show()
    End Sub

    Private Sub btnRoomReport_Click(sender As System.Object, e As System.EventArgs) Handles btnRoomReport.Click
        Me.Close()
        Report_Room_page.Show()
    End Sub
End Class