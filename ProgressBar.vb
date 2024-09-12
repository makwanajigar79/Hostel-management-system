Public Class ProgressBar

    Private Sub ProgressBar1_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Enabled = False
            HomePage.Show()
            Me.Close()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 10
        End If
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ProgressBar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class