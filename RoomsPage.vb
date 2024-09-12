Public Class RoomsPage

   
    Private Sub btnAddRooms_Click(sender As System.Object, e As System.EventArgs) Handles btnAddRooms.Click
        Me.Hide()
        AddRooms.Show()
    End Sub

    Private Sub PanelRoomPage_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelRoomPage.Paint

    End Sub

    Private Sub btnHostelFees_Click(sender As System.Object, e As System.EventArgs) Handles btnHostelFees.Click
        Me.Hide()
        Hostel_Fees_Details.Show()
    End Sub

    Private Sub btnViewRooms_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class