<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblJoinDate = New System.Windows.Forms.Label()
        Me.txtRegisterID = New System.Windows.Forms.TextBox()
        Me.lblRegisterID = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.btnBACK = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtpincode = New System.Windows.Forms.TextBox()
        Me.lblpincode = New System.Windows.Forms.Label()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.lblcity = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.RdbtnFemale = New System.Windows.Forms.RadioButton()
        Me.RdbtnMale = New System.Windows.Forms.RadioButton()
        Me.txtEmailid = New System.Windows.Forms.TextBox()
        Me.lblStdEmailId = New System.Windows.Forms.Label()
        Me.txtMobileno = New System.Windows.Forms.TextBox()
        Me.lblmobileno = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.ComboBoxDept = New System.Windows.Forms.ComboBox()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(597, 359)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 14
        '
        'lblJoinDate
        '
        Me.lblJoinDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblJoinDate.AutoSize = True
        Me.lblJoinDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblJoinDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoinDate.ForeColor = System.Drawing.Color.White
        Me.lblJoinDate.Location = New System.Drawing.Point(519, 365)
        Me.lblJoinDate.Name = "lblJoinDate"
        Me.lblJoinDate.Size = New System.Drawing.Size(49, 16)
        Me.lblJoinDate.TabIndex = 29
        Me.lblJoinDate.Text = "DATE"
        '
        'txtRegisterID
        '
        Me.txtRegisterID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRegisterID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRegisterID.Enabled = False
        Me.txtRegisterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterID.ForeColor = System.Drawing.Color.Black
        Me.txtRegisterID.Location = New System.Drawing.Point(248, 34)
        Me.txtRegisterID.Name = "txtRegisterID"
        Me.txtRegisterID.Size = New System.Drawing.Size(216, 22)
        Me.txtRegisterID.TabIndex = 0
        '
        'lblRegisterID
        '
        Me.lblRegisterID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRegisterID.AutoSize = True
        Me.lblRegisterID.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRegisterID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterID.ForeColor = System.Drawing.Color.White
        Me.lblRegisterID.Location = New System.Drawing.Point(64, 37)
        Me.lblRegisterID.Name = "lblRegisterID"
        Me.lblRegisterID.Size = New System.Drawing.Size(140, 16)
        Me.lblRegisterID.TabIndex = 24
        Me.lblRegisterID.Text = "REGISTRATION ID"
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(379, 649)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 70)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'txtLname
        '
        Me.txtLname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.ForeColor = System.Drawing.Color.Black
        Me.txtLname.Location = New System.Drawing.Point(248, 163)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(216, 22)
        Me.txtLname.TabIndex = 3
        '
        'lblLname
        '
        Me.lblLname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLname.AutoSize = True
        Me.lblLname.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLname.ForeColor = System.Drawing.Color.White
        Me.lblLname.Location = New System.Drawing.Point(115, 166)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(93, 16)
        Me.lblLname.TabIndex = 17
        Me.lblLname.Text = "LAST NAME"
        '
        'btnBACK
        '
        Me.btnBACK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBACK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBACK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBACK.ForeColor = System.Drawing.Color.Black
        Me.btnBACK.Location = New System.Drawing.Point(615, 649)
        Me.btnBACK.Name = "btnBACK"
        Me.btnBACK.Size = New System.Drawing.Size(160, 70)
        Me.btnBACK.TabIndex = 13
        Me.btnBACK.Text = "BACK"
        Me.btnBACK.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.Location = New System.Drawing.Point(141, 649)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(160, 70)
        Me.btnRegister.TabIndex = 11
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtpincode
        '
        Me.txtpincode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpincode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtpincode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpincode.ForeColor = System.Drawing.Color.Black
        Me.txtpincode.Location = New System.Drawing.Point(250, 422)
        Me.txtpincode.Name = "txtpincode"
        Me.txtpincode.Size = New System.Drawing.Size(216, 22)
        Me.txtpincode.TabIndex = 6
        '
        'lblpincode
        '
        Me.lblpincode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblpincode.AutoSize = True
        Me.lblpincode.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblpincode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpincode.ForeColor = System.Drawing.Color.White
        Me.lblpincode.Location = New System.Drawing.Point(130, 425)
        Me.lblpincode.Name = "lblpincode"
        Me.lblpincode.Size = New System.Drawing.Size(75, 16)
        Me.lblpincode.TabIndex = 9
        Me.lblpincode.Text = "PINCODE"
        '
        'txtcity
        '
        Me.txtcity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcity.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.ForeColor = System.Drawing.Color.Black
        Me.txtcity.Location = New System.Drawing.Point(250, 376)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(216, 22)
        Me.txtcity.TabIndex = 5
        '
        'lblcity
        '
        Me.lblcity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcity.AutoSize = True
        Me.lblcity.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcity.ForeColor = System.Drawing.Color.White
        Me.lblcity.Location = New System.Drawing.Point(150, 379)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(42, 16)
        Me.lblcity.TabIndex = 7
        Me.lblcity.Text = "CITY"
        '
        'txtaddress
        '
        Me.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtaddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.Location = New System.Drawing.Point(248, 212)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(216, 79)
        Me.txtaddress.TabIndex = 4
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(128, 215)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(81, 16)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "ADDRESS"
        '
        'lblDept
        '
        Me.lblDept.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDept.AutoSize = True
        Me.lblDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.ForeColor = System.Drawing.Color.White
        Me.lblDept.Location = New System.Drawing.Point(94, 75)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(113, 16)
        Me.lblDept.TabIndex = 1
        Me.lblDept.Text = "DEPARTMENT"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.lblJoinDate)
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.RdbtnFemale)
        Me.Panel1.Controls.Add(Me.RdbtnMale)
        Me.Panel1.Controls.Add(Me.txtRegisterID)
        Me.Panel1.Controls.Add(Me.lblRegisterID)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.txtLname)
        Me.Panel1.Controls.Add(Me.lblLname)
        Me.Panel1.Controls.Add(Me.btnBACK)
        Me.Panel1.Controls.Add(Me.btnRegister)
        Me.Panel1.Controls.Add(Me.txtEmailid)
        Me.Panel1.Controls.Add(Me.lblStdEmailId)
        Me.Panel1.Controls.Add(Me.txtMobileno)
        Me.Panel1.Controls.Add(Me.lblmobileno)
        Me.Panel1.Controls.Add(Me.txtpincode)
        Me.Panel1.Controls.Add(Me.lblpincode)
        Me.Panel1.Controls.Add(Me.txtcity)
        Me.Panel1.Controls.Add(Me.lblcity)
        Me.Panel1.Controls.Add(Me.txtaddress)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.lblDept)
        Me.Panel1.Controls.Add(Me.txtFName)
        Me.Panel1.Controls.Add(Me.ComboBoxDept)
        Me.Panel1.Controls.Add(Me.lblFname)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(12, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 734)
        Me.Panel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 532)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "DECLARATION"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Gray
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(97, 567)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(633, 36)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "ALL THE INFORMATION PROVIDED ARE CORRECT AND I UNDERTAKE TO ABIDE BY " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         A" & _
    "LL HOSTEL RULES AND ORDERS OF THE ADMISSION."
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(250, 321)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(169, 22)
        Me.DateTimePicker2.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(138, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "DOB"
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.White
        Me.lblGender.Location = New System.Drawing.Point(493, 418)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(72, 16)
        Me.lblGender.TabIndex = 28
        Me.lblGender.Text = "GENDER"
        '
        'RdbtnFemale
        '
        Me.RdbtnFemale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RdbtnFemale.AutoSize = True
        Me.RdbtnFemale.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RdbtnFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbtnFemale.ForeColor = System.Drawing.Color.White
        Me.RdbtnFemale.Location = New System.Drawing.Point(706, 418)
        Me.RdbtnFemale.Name = "RdbtnFemale"
        Me.RdbtnFemale.Size = New System.Drawing.Size(85, 20)
        Me.RdbtnFemale.TabIndex = 9
        Me.RdbtnFemale.TabStop = True
        Me.RdbtnFemale.Text = "FEMALE"
        Me.RdbtnFemale.UseVisualStyleBackColor = False
        '
        'RdbtnMale
        '
        Me.RdbtnMale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RdbtnMale.AutoSize = True
        Me.RdbtnMale.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RdbtnMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbtnMale.ForeColor = System.Drawing.Color.White
        Me.RdbtnMale.Location = New System.Drawing.Point(609, 416)
        Me.RdbtnMale.Name = "RdbtnMale"
        Me.RdbtnMale.Size = New System.Drawing.Size(66, 20)
        Me.RdbtnMale.TabIndex = 8
        Me.RdbtnMale.TabStop = True
        Me.RdbtnMale.Text = "MALE"
        Me.RdbtnMale.UseVisualStyleBackColor = False
        '
        'txtEmailid
        '
        Me.txtEmailid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmailid.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEmailid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailid.ForeColor = System.Drawing.Color.Black
        Me.txtEmailid.Location = New System.Drawing.Point(597, 466)
        Me.txtEmailid.Name = "txtEmailid"
        Me.txtEmailid.Size = New System.Drawing.Size(214, 22)
        Me.txtEmailid.TabIndex = 10
        '
        'lblStdEmailId
        '
        Me.lblStdEmailId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStdEmailId.AutoSize = True
        Me.lblStdEmailId.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStdEmailId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdEmailId.ForeColor = System.Drawing.Color.White
        Me.lblStdEmailId.Location = New System.Drawing.Point(492, 472)
        Me.lblStdEmailId.Name = "lblStdEmailId"
        Me.lblStdEmailId.Size = New System.Drawing.Size(71, 16)
        Me.lblStdEmailId.TabIndex = 13
        Me.lblStdEmailId.Text = "EMAIL ID"
        '
        'txtMobileno
        '
        Me.txtMobileno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMobileno.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMobileno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileno.ForeColor = System.Drawing.Color.Black
        Me.txtMobileno.Location = New System.Drawing.Point(250, 469)
        Me.txtMobileno.Name = "txtMobileno"
        Me.txtMobileno.Size = New System.Drawing.Size(216, 22)
        Me.txtMobileno.TabIndex = 7
        '
        'lblmobileno
        '
        Me.lblmobileno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblmobileno.AutoSize = True
        Me.lblmobileno.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblmobileno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmobileno.ForeColor = System.Drawing.Color.White
        Me.lblmobileno.Location = New System.Drawing.Point(70, 472)
        Me.lblmobileno.Name = "lblmobileno"
        Me.lblmobileno.Size = New System.Drawing.Size(132, 16)
        Me.lblmobileno.TabIndex = 11
        Me.lblmobileno.Text = "MOBILE NUMBER"
        '
        'txtFName
        '
        Me.txtFName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.ForeColor = System.Drawing.Color.Black
        Me.txtFName.Location = New System.Drawing.Point(248, 117)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(216, 22)
        Me.txtFName.TabIndex = 2
        '
        'ComboBoxDept
        '
        Me.ComboBoxDept.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBoxDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ComboBoxDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDept.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxDept.FormattingEnabled = True
        Me.ComboBoxDept.Items.AddRange(New Object() {"ARTS", "COMMERCE", "SCIENCE", "IT", "AGRICULTURE", "MANAGEMENT", "PHARMACY", "ITI", "INDUSTRIAL", "OTHER"})
        Me.ComboBoxDept.Location = New System.Drawing.Point(248, 72)
        Me.ComboBoxDept.Name = "ComboBoxDept"
        Me.ComboBoxDept.Size = New System.Drawing.Size(216, 24)
        Me.ComboBoxDept.TabIndex = 1
        '
        'lblFname
        '
        Me.lblFname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFname.AutoSize = True
        Me.lblFname.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.ForeColor = System.Drawing.Color.White
        Me.lblFname.Location = New System.Drawing.Point(108, 120)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(99, 16)
        Me.lblFname.TabIndex = 3
        Me.lblFname.Text = "FIRST NAME"
        '
        'RegisterStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.HMS.My.Resources.Resources.Hostel_Wallpaper_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(841, 746)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "RegisterStudent"
        Me.Text = "RegisterStudent"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblJoinDate As System.Windows.Forms.Label
    Friend WithEvents txtRegisterID As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterID As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents btnBACK As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents txtpincode As System.Windows.Forms.TextBox
    Friend WithEvents lblpincode As System.Windows.Forms.Label
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxDept As System.Windows.Forms.ComboBox
    Friend WithEvents lblFname As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents RdbtnFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RdbtnMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtEmailid As System.Windows.Forms.TextBox
    Friend WithEvents lblStdEmailId As System.Windows.Forms.Label
    Friend WithEvents txtMobileno As System.Windows.Forms.TextBox
    Friend WithEvents lblmobileno As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
