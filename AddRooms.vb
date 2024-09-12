Imports System.Data.SqlClient
Imports System.Data

Public Class AddRooms

    Public Sub GetRoomID()
        Dim str As String

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        str = "select max(RoomID) from Room_tb"
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds)

        Dim st As String
        st = ds.Tables(0).Rows(0).Item(0).ToString()

        If st = vbNullString Then
            txtRoomID.Text = "1"
        Else
            txtRoomID.Text = CInt(st) + 1

        End If
        con.Close()
    End Sub

    Private Sub FillGrid()

        Dim sql As String = "Select * from Room_tb "



        Dim dataadapter As New SqlDataAdapter(sql, con)

        Dim ds As New DataSet()

        con.Open()

        dataadapter.Fill(ds, "Room_tb")

        con.Close()

        DataGridViewAddRoom.DataSource = ds
        DataGridViewAddRoom.DataMember = "Room_tb"

    End Sub
    Private Sub txtRoomID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRoomID.TextChanged

    End Sub

    Private Sub AddRooms_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetRoomID()
        FillStudentName()
        FillGrid()
    End Sub

    Private Sub cmbRoomType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbRoomType.SelectedIndexChanged
        If cmbRoomType.SelectedIndex = "0" Then
            txtfees.Text = "4000"
        Else
            txtfees.Text = "2500"
        End If
    End Sub

    Dim Solo As Integer = 2000
    Dim duo As Integer = 1500
    Dim triple As Integer = 1000
    Dim quotra As Integer = 0
    Private Sub cmbRoomOcupancy_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbRoomOcupancy.SelectedIndexChanged

        If cmbRoomOcupancy.SelectedIndex = "0" Then
            txtTotalfees.Text = Int(txtfees.Text) + Solo
        ElseIf cmbRoomOcupancy.SelectedIndex = "1" Then
            txtTotalfees.Text = Int(txtfees.Text) + duo
        ElseIf cmbRoomOcupancy.SelectedIndex = "2" Then
            txtTotalfees.Text = Int(txtfees.Text) + triple
        ElseIf cmbRoomOcupancy.SelectedIndex = "3" Then
            txtTotalfees.Text = Int(txtfees.Text) + quotra
        End If
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click


        DateTimePickerIN.Value.ToString("dd-mm-yyyy")
        DateTimePickerOUT.Value.ToString("dd-mm-yyyy")

        con.Open()

        cmd = New SqlCommand("Insert into Room_tb(RoomID,Room_Block,Room_Type,Room_Occupancy,Fees,Total_Fees,RegiseterationID,FirstName,MobileNo,emailID,Room_Details,Date_Check_IN,Date_Check_OUT) values ('" + txtRoomID.Text + "', '" + txtRoomBlock.Text + "', '" + cmbRoomType.Text + "', '" + cmbRoomOcupancy.Text + "', '" + txtfees.Text + "','" + txtTotalfees.Text + "', '" + txtRegisterID.Text + "', '" + cmbFirstName.Text + "', '" + txtMobileno.Text + "', '" + txtEmailid.Text + "', '" + txtDetails.Text + "','" + DateTimePickerIN.Text + "','" + DateTimePickerOUT.Text + "')", con)

        con = cmd.Connection

        cmd.ExecuteNonQuery()

        MsgBox("Student : " + cmbFirstName.Text + " Room : " + txtRoomID.Text + " booking Sucessfully.... ")

        con.Close()
        Hostel_Fees_Details.Show()

    End Sub

    Private Sub btnREset_Click(sender As System.Object, e As System.EventArgs) Handles btnREset.Click
        txtRoomID.Text = ""
        txtRoomBlock.Text = ""
        cmbRoomType.Text = ""
        cmbRoomOcupancy.Text = ""
        txtfees.Text = ""
        txtTotalfees.Text = ""
        txtRegisterID.Text = ""
        cmbFirstName.Text = ""
        txtMobileno.Text = ""
        txtEmailid.Text = ""
        txtDetails.Text = ""
        DateTimePickerIN.Text = ""
        DateTimePickerOUT.Text = ""

    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        RoomsPage.Show()
    End Sub

    Private Sub cmbFirstName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbFirstName.SelectedIndexChanged
        con.Open()

        cmd = New SqlCommand("Select * from Registration_tb where FirstName = '" + cmbFirstName.Text + "'", con)

        con = cmd.Connection

        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            While dr.Read

                txtMobileno.Text = dr("MobileNo")
               
                txtEmailid.Text = dr("emailID")
                cmbFirstName.Text = dr("FirstName")
               
                txtRegisterID.Text = dr("RegiseterationID")


            End While
        End If

        con.Close()
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
End Class