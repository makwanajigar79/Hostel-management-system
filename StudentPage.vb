Public Class StudentPage

    Private Sub btnAddStudent_Click(sender As System.Object, e As System.EventArgs) Handles btnAddStudent.Click
        RegisterStudent.Show()
    End Sub

    Private Sub btnViewStudent_Click(sender As System.Object, e As System.EventArgs) Handles btnViewStudent.Click
        ViewStudent.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        UpdateStudent.Show()
    End Sub
End Class