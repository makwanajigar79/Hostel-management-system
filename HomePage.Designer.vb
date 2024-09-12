<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.PanelHead = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelModule = New System.Windows.Forms.Panel()
        Me.btnRooms = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.PanelHomePage = New System.Windows.Forms.Panel()
        Me.PanelHead.SuspendLayout()
        Me.PanelModule.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHead
        '
        Me.PanelHead.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelHead.BackColor = System.Drawing.Color.Transparent
        Me.PanelHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelHead.Controls.Add(Me.Label1)
        Me.PanelHead.Location = New System.Drawing.Point(218, 12)
        Me.PanelHead.Name = "PanelHead"
        Me.PanelHead.Size = New System.Drawing.Size(618, 135)
        Me.PanelHead.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(76, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(497, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOSTEL MANAGEMENT SYSTEM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PanelModule
        '
        Me.PanelModule.BackColor = System.Drawing.Color.Transparent
        Me.PanelModule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelModule.Controls.Add(Me.btnRooms)
        Me.PanelModule.Controls.Add(Me.btnReports)
        Me.PanelModule.Controls.Add(Me.PictureBox1)
        Me.PanelModule.Controls.Add(Me.btnStudents)
        Me.PanelModule.Controls.Add(Me.btnLogOut)
        Me.PanelModule.Location = New System.Drawing.Point(12, 12)
        Me.PanelModule.Name = "PanelModule"
        Me.PanelModule.Size = New System.Drawing.Size(255, 656)
        Me.PanelModule.TabIndex = 2
        '
        'btnRooms
        '
        Me.btnRooms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRooms.ForeColor = System.Drawing.Color.Black
        Me.btnRooms.Location = New System.Drawing.Point(13, 215)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(223, 79)
        Me.btnRooms.TabIndex = 2
        Me.btnRooms.Text = "ROOMS"
        Me.btnRooms.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.Black
        Me.btnReports.Location = New System.Drawing.Point(13, 422)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(223, 74)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "REPORTS"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.HMS.My.Resources.Resources.hostel_management_system1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 177)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnStudents
        '
        Me.btnStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudents.ForeColor = System.Drawing.Color.Black
        Me.btnStudents.Location = New System.Drawing.Point(13, 318)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(223, 74)
        Me.btnStudents.TabIndex = 3
        Me.btnStudents.Text = "STUDENTS"
        Me.btnStudents.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Black
        Me.btnLogOut.Location = New System.Drawing.Point(13, 528)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(223, 74)
        Me.btnLogOut.TabIndex = 6
        Me.btnLogOut.Text = "LOG OUT"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'PanelHomePage
        '
        Me.PanelHomePage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelHomePage.BackColor = System.Drawing.Color.Transparent
        Me.PanelHomePage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelHomePage.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelHomePage.Location = New System.Drawing.Point(273, 153)
        Me.PanelHomePage.Name = "PanelHomePage"
        Me.PanelHomePage.Size = New System.Drawing.Size(563, 581)
        Me.PanelHomePage.TabIndex = 3
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.HMS.My.Resources.Resources.Hostel_Wallpaper_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(841, 746)
        Me.Controls.Add(Me.PanelHomePage)
        Me.Controls.Add(Me.PanelModule)
        Me.Controls.Add(Me.PanelHead)
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelHead.ResumeLayout(False)
        Me.PanelHead.PerformLayout()
        Me.PanelModule.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelHead As System.Windows.Forms.Panel
    Friend WithEvents PanelModule As System.Windows.Forms.Panel
    Friend WithEvents btnStudents As System.Windows.Forms.Button
    Friend WithEvents btnRooms As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents PanelHomePage As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
