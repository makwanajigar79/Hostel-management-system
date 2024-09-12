Public Class Form1

    Private Sub btnsubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnsubmit.Click
        If txtunm.Text = "" Or txtpwd.Text = "" Then

            MsgBox("Enter UserName and Password")

        ElseIf txtunm.Text = "123" And txtpwd.Text = "123" Then

            Dim Obj = New ProgressBar
            Obj.Show()
            ' RegisterStudent.Show()
            Me.Hide()
            txtpwd.Text = ""
            txtunm.Text = ""

        Else

            MsgBox("Wrong UserName and Password")
            txtunm.Text = ""
            txtpwd.Text = ""
        End If
    End Sub

    Private Sub CheckBoxPassword_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxPassword.CheckedChanged
        If CheckBoxPassword.Checked = True Then

            txtpwd.UseSystemPasswordChar = False

        Else

            txtpwd.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
