Imports System.Data.SqlClient
Imports System.Data
Public Class RegisterStudent

    Public Sub GetRegisterID()
        Dim str As String

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        str = "select max(RegiseterationID) from Registration_tb"
        cmd = New SqlCommand(Str, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds)

        Dim st As String
        st = ds.Tables(0).Rows(0).Item(0).ToString()

        If st = vbNullString Then
            txtRegisterID.Text = "1"
        Else
            txtRegisterID.Text = CInt(st) + 1

        End If
        con.Close()
    End Sub

    Private Sub btnRegister_Click(sender As System.Object, e As System.EventArgs) Handles btnRegister.Click
        Dim gender As String

        If RdbtnMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"

        End If

        DateTimePicker1.Value.ToString("dd-mm-yyyy")
        DateTimePicker2.Value.ToString("dd-mm-yyyy")

        con.Open()

        cmd = New SqlCommand("Insert into Registration_tb(RegiseterationID,Department,Date,FirstName,LastName,Address,city,pincode,MobileNo,Dob,gender,emailId) values ('" + txtRegisterID.Text + "', '" + ComboBoxDept.Text + "', '" + DateTimePicker1.Text + "', '" + txtFName.Text + "', '" + txtLname.Text + "','" + txtaddress.Text + "', '" + txtcity.Text + "', '" + txtpincode.Text + "', '" + txtMobileno.Text + "', '" + DateTimePicker2.Text + "', '" + gender + "','" + txtEmailid.Text + "')", con)

        con = cmd.Connection

        cmd.ExecuteNonQuery()

        MsgBox("Student " + txtFName.Text + " Registration Sucessfully.... ")
        con.Close()
    End Sub

    Private Sub btnBACK_Click(sender As System.Object, e As System.EventArgs) Handles btnBACK.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RegisterStudent_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetRegisterID()
    End Sub

    Private Sub txtMobileno_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMobileno.TextChanged

    End Sub

    Private Sub txtMobileno_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobileno.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 10 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only 10 digits are allowed")
        End If
    End Sub

    Private Sub txtRegisterID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRegisterID.TextChanged

    End Sub
End Class