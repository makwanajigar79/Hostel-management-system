Imports System.Data.SqlClient
Imports System.Data

Public Class ViewStudent

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs)
      
    End Sub

    Private Sub FillStudentName()

        con.Open()

        cmd = New SqlCommand("select * from Registration_tb", con)

        da = New SqlDataAdapter(cmd)

        Dim ds As DataSet = New DataSet()

        da.Fill(ds, "Registration_tb")

        Dim i As Integer = 0

        cmbBoxSearch.Items.Clear()

        For i = 0 To ds.Tables("Registration_tb").Rows.Count - 1
            cmbBoxSearch.Items.Add(ds.Tables(0).Rows(i)(3).ToString())
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

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Registration_tb"

    End Sub

    Private Sub btnBack_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub ViewStudent_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FillGrid()
        FillStudentName()
    End Sub

    Private Sub btnSearch_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Registration_tb where FirstName ='" + cmbBoxSearch.Text + "'"
        Dim v = cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class