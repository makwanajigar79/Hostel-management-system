Public Class Report_Register_details

    Private Sub Report_Register_details_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HMS_DBDataSet3.Registration_tb' table. You can move, or remove it, as needed.
        Me.Registration_tbTableAdapter.Fill(Me.HMS_DBDataSet3.Registration_tb)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        HomePage.Show()
    End Sub
End Class