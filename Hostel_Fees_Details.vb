Imports System.Data.SqlClient
Imports System.Data

Public Class Hostel_Fees_Details

    Private Sub FillGrid()

        Dim sql As String = "Select * from HostelFees_tb"

        Dim dataadapter As New SqlDataAdapter(sql, con)

        Dim ds As New DataSet()

        con.Open()

        dataadapter.Fill(ds, "HostelFees_tb")

        con.Close()

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "HostelFees_tb"

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

    Public Sub GetTransactionID()
        Dim str As String

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        str = "select max(TransactionID) from Hostelfees_tb"
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds)

        Dim st As String
        st = ds.Tables(0).Rows(0).Item(0).ToString()

        If st = vbNullString Then
            txtTransactionID.Text = "101"
        Else
            txtTransactionID.Text = CInt(st) + 1

        End If
        con.Close()
    End Sub
    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelHostelFees.Paint

    End Sub

    Private Sub lblPanaltyAmount_Click(sender As System.Object, e As System.EventArgs) Handles lblPanaltyAmount.Click

    End Sub

    Private Sub Hostel_Fees_Details_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FillGrid()
        FillStudentName()
        If cmbRoomType.Text = "AC" Then
            txtPanaltyAmount.Text = "4000"
        Else
            txtPanaltyAmount.Text = "3000"
        End If
        GetTransactionID()
    End Sub

    Private Sub btnPayNow_Click(sender As System.Object, e As System.EventArgs) Handles btnPayNow.Click

        If txtRegisterID.Text <> "" And txtTransactionID.Text <> "" And DateTimePicker1.Text <> "" And ComboBoxDept.Text <> "" And cmbFirstName.Text <> "" And txtLname.Text <> "" And txtMobileno.Text <> "" And txtEmailid.Text <> "" And txtPanaltyAmount.Text <> "" And cmbPayMode.Text <> "" And txtDetails.Text <> "" Then

            Try

                con.Open()

                cmd = New SqlCommand("Insert into HostelFees_tb(RegiseterationID,TransactionDate,TransactionID,Department,FirstName,LastName,MobileNo,emailID,HostelAmount,PaymentMode,details) values ('" + txtRegisterID.Text + "', '" + DateTimePicker1.Value.ToString("yyyy/MM/dd") + "','" + txtTransactionID.Text + "', '" + ComboBoxDept.Text + "', '" + cmbFirstName.Text + "', '" + txtLname.Text + "', '" + txtMobileno.Text + "', '" + txtEmailid.Text + "', '" + txtPanaltyAmount.Text + "','" + cmbPayMode.Text + "','" + txtDetails.Text + "')", con)

                con = cmd.Connection

                cmd.ExecuteNonQuery()

                MsgBox(" Name : " + cmbFirstName.Text + " for Pay Total Hostel fees Rs. " + TXTtotalfees.Text + " Sucessfully....")

              

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No Data Inserted..")
        End If

        con.Close()
        FillGrid()
        FillStudentName()
        GetTransactionID()
        reset()

    End Sub

    Private Sub txtPanaltyAmount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPanaltyAmount.TextChanged
        If cmbRoomType.Text = "AC" Then
            txtPanaltyAmount.Text = "4000"
        Else
            txtPanaltyAmount.Text = "3500"
        End If
    End Sub

    Private Sub cmbFirstName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbFirstName.SelectedIndexChanged
        con.Open()

        cmd = New SqlCommand("Select * from Registration_tb where FirstName = '" + cmbFirstName.Text + "'", con)

        con = cmd.Connection

        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            While dr.Read

                txtMobileno.Text = dr("MobileNo")
                'ComboBoxDept.Text = dr("Department")
                txtLname.Text = dr("LastName")
                txtEmailid.Text = dr("emailID")
                cmbFirstName.Text = dr("FirstName")


                'txtDetails.Text = dr("details")
                'txtTransactionID.Text = dr("TransactionID")
                ComboBoxDept.Text = dr("Department")
                txtRegisterID.Text = dr("RegiseterationID")
                '  DateTimePicker1.Text = dr("Date")

            End While
        End If

        con.Close()
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click

        txtPanaltyAmount.Text = ""
        ComboBoxDept.Text = ""
        txtLname.Text = ""
        txtDetails.Text = ""
        txtEmailid.Text = ""
        txtMobileno.Text = ""
        txtTransactionID.Text = ""
        cmbFirstName.Text = ""
        txtRegisterID.Text = ""
        ComboBoxDept.Text = ""
        DateTimePicker1.Text = ""
        cmbPayMode.Text = ""

    End Sub

    Public Sub reset()
        txtPanaltyAmount.Text = ""
        ComboBoxDept.Text = ""
        txtLname.Text = ""
        txtDetails.Text = ""
        txtEmailid.Text = ""
        txtMobileno.Text = ""
        txtTransactionID.Text = ""
        cmbFirstName.Text = ""
        txtRegisterID.Text = ""
        ComboBoxDept.Text = ""
        DateTimePicker1.Text = ""
        cmbPayMode.Text = ""
    End Sub
    Dim Solo As Integer = 2000
    Dim duo As Integer = 1500
    Dim triple As Integer = 1000
    Dim quotra As Integer = 0
    Private Sub cmbRoomOcupancy_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbRoomOcupancy.SelectedIndexChanged
        If cmbRoomOcupancy.SelectedIndex = "0" Then
            TXTtotalfees.Text = Int(txtPanaltyAmount.Text) + Solo
        ElseIf cmbRoomOcupancy.SelectedIndex = "1" Then
            TXTtotalfees.Text = Int(txtPanaltyAmount.Text) + duo
        ElseIf cmbRoomOcupancy.SelectedIndex = "2" Then
            TXTtotalfees.Text = Int(txtPanaltyAmount.Text) + triple
        ElseIf cmbRoomOcupancy.SelectedIndex = "3" Then
            TXTtotalfees.Text = Int(txtPanaltyAmount.Text) + quotra
        End If

    End Sub
   
    Private Sub cmbRoomType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbRoomType.SelectedIndexChanged
        If cmbRoomType.SelectedIndex = "0" Then
            txtPanaltyAmount.Text = "4000"
        Else
            txtPanaltyAmount.Text = "2500"
        End If
    End Sub


    Private Sub btnBACK_Click(sender As System.Object, e As System.EventArgs) Handles btnBACK.Click
        Me.Close()
        RoomsPage.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class