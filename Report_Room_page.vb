Public Class Report_Room_page

    Private Sub Report_Room_page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HMS_DBDataSet2.Room_tb' table. You can move, or remove it, as needed.
        Me.Room_tbTableAdapter.Fill(Me.HMS_DBDataSet2.Room_tb)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        HomePage.Show()

    End Sub
End Class