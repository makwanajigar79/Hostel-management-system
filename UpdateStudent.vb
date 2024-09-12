Imports System.Data.SqlClient
Imports System.Data

Public Class UpdateStudent

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        StudentPage.Show()
    End Sub

    Private Sub FillStudentName()

        con.Open()

        cmd = New SqlCommand("select * from Registration_tb", con)

        da = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()

        da.Fill(ds, "Registration_tb")

        Dim i As Integer = 0

        cmbFirstName.Items.Clear()

        For i = 0 To ds.Tables("Registration_tb").Rows.Count - 1
            cmbFirstName.Items.Add(ds.Tables(0).Rows(i)(3).ToString())
        Next

        con.Close()

    End Sub

    Private Sub FillGrid()

        Dim sql As String = "Select * from Registration_tb "



        Dim dataadapter As New SqlDataAdapter(sql, con)

        Dim ds As New DataSet()

        con.Open()

        dataadapter.Fill(ds, "Registration_tb")

        con.Close()

        DataGridViewUpdateStudent.DataSource = ds
        DataGridViewUpdateStudent.DataMember = "Registration_tb"

    End Sub
    Private Sub cmbFirstName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbFirstName.SelectedIndexChanged

        con.Open()

        cmd = New SqlCommand("Select * from Registration_tb where FirstName = '" + cmbFirstName.Text + "'", con)

        con = cmd.Connection

        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            While dr.Read

                txtMobileno.Text = dr("MobileNo")
                txtaddress.Text = dr("Address")
                txtcity.Text = dr("city")
                txtLname.Text = dr("LastName")
                txtEmailid.Text = dr("emailID")
                cmbFirstName.Text = dr("FirstName")
                DateTimePicker2.Text = dr("Dob")
                txtpincode.Text = dr("pincode")
                ComboBoxDept.Text = dr("Department")
                txtRegisterID.Text = dr("RegiseterationID")
                DateTimePicker1.Text = dr("Date")

            End While
        End If

        con.Close()
    End Sub

    Private Sub reset()
        txtaddress.Text = ""
        txtcity.Text = ""
        TXTLNAME.Text = ""
        txtaddress.Text = ""
        txtEmailid.Text = ""
        txtMobileno.Text = ""
        txtpincode.Text = ""
        cmbFirstName.Text = ""
        txtRegisterID.Text = ""
        ComboBoxDept.Text = ""
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""
    End Sub

    Private Sub UpdateStudent_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        reset()
        FillStudentName()
        FillGrid()

    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click

        Dim rdtype As String

        If RdbtnMale.Checked = True Then
            rdtype = "Male"

        Else
            rdtype = "Female"
        End If

        If txtRegisterID.Text <> "" And ComboBoxDept.Text <> "" And cmbFirstName.Text <> "" And txtaddress.Text <> "" And txtcity.Text <> "" And txtpincode.Text <> "" And txtMobileno.Text <> "" And txtEmailid.Text <> "" Then

            con.Open()

            cmd = New SqlCommand("update Registration_tb set RegiseterationID='" + txtRegisterID.Text + "',Department='" + ComboBoxDept.Text + "',Date='" + DateTimePicker1.Text + "',FirstName='" + cmbFirstName.Text + "',LastName='" + txtLname.Text + "',Address='" + txtaddress.Text + "',city='" + txtcity.Text + "',pincode='" + txtpincode.Text + "',MobileNo='" + txtMobileno.Text + "',Dob='" + DateTimePicker2.Text + "',emailID='" + txtEmailid.Text + "'where RegiseterationID= '" + txtRegisterID.Text + "'", con)

            cmd.ExecuteNonQuery()

            MsgBox("Name : " + cmbFirstName.Text + "  updated Sucessfully.....")

        Else
            MsgBox("No Data Selected...")
        End If

        con.Close()
        FillGrid()

        reset()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        reset()
    End Sub

    Private Sub DataGridViewUpdateStudent_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewUpdateStudent.CellClick
        txtRegisterID.Text = DataGridViewUpdateStudent.Rows(e.RowIndex).Cells(0).Value
        ComboBoxDept.Text = DataGridViewUpdateStudent.Rows(e.RowIndex).Cells(1).Value
        DateTimePicker1.Text = DataGridViewUpdateStudent.Rows(e.RowIndex).Cells(2).Value
        cmbFirstName.Text = DataGridViewUpdateStudent.Rows(e.RowIndex).Cells(3).Value
        txtLname.Text = DataGridViewUpdateStudent.Rows(e.RowIndex).Cells(4).Value
        txtaddress.Text = DataGridViewUpdateStudent.Rows(e.RowIndex).Cells(5).Value
        txtcity.Text = DataGridViewUpdateStudent.Rows(e.RowIndex).Cells(6).Value
        txtpincode.Text = DataGridViewUpdateStudent.Rows(e.RowIndex).Cells(7).Value
        txtMobileno.Text = DataGridViewUpdateStudent.Rows(e.RowIndex).Cells(8).Value
        DateTimePicker2.Text = DataGridViewUpdateStudent.Rows(e.RowIndex).Cells(9).Value
        txtEmailid.Text = DataGridViewUpdateStudent.Rows(e.RowIndex).Cells(11).Value


    End Sub

    Private Sub txtpincode_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtpincode.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 6 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only 6 digits are allowed")
        End If
    End Sub


    Private Sub txtMobileno_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobileno.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 10 Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Only 10 digits are allowed")
        End If
    End Sub

 
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click

        Dim strDelete As String

        strDelete = MsgBox("Do you want to delete ?", vbYesNo)

        If strDelete = vbYes Then

            Dim n As String = "0"

            con.Open()

            cmd = New SqlCommand("Delete from Registration_tb where FirstName = '" + cmbFirstName.Text + "'", con)

            con = cmd.Connection

            n = cmd.ExecuteNonQuery()

            If n.ToString = "3" Then

                MsgBox("Customer Name : " + cmbFirstName.Text + " Delete Sucessfully done")

            Else

                MsgBox("Record Not Found.....")
            End If
        End If

        con.Close()

        FillStudentName()
        FillGrid()
        reset()
    End Sub
End Class