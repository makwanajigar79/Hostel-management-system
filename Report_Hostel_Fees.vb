Public Class Report_Hostel_Fees

    Private Sub Report_Hostel_Fees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HMS_DBDataSet1.HostelFees_tb' table. You can move, or remove it, as needed.
        Me.HostelFees_tbTableAdapter.Fill(Me.HMS_DBDataSet1.HostelFees_tb)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        HomePage.Show()
    End Sub
End Class