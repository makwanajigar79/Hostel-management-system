<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomsPage
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
        Me.PanelRoomPage = New System.Windows.Forms.Panel()
        Me.btnHostelFees = New System.Windows.Forms.Button()
        Me.btnAddRooms = New System.Windows.Forms.Button()
        Me.PanelRoomPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRoomPage
        '
        Me.PanelRoomPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelRoomPage.BackgroundImage = Global.HMS.My.Resources.Resources.images__2_1
        Me.PanelRoomPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelRoomPage.Controls.Add(Me.btnHostelFees)
        Me.PanelRoomPage.Controls.Add(Me.btnAddRooms)
        Me.PanelRoomPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRoomPage.ForeColor = System.Drawing.Color.White
        Me.PanelRoomPage.Location = New System.Drawing.Point(0, 0)
        Me.PanelRoomPage.Name = "PanelRoomPage"
        Me.PanelRoomPage.Size = New System.Drawing.Size(506, 429)
        Me.PanelRoomPage.TabIndex = 10
        '
        'btnHostelFees
        '
        Me.btnHostelFees.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHostelFees.BackColor = System.Drawing.Color.MintCream
        Me.btnHostelFees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHostelFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHostelFees.ForeColor = System.Drawing.Color.Black
        Me.btnHostelFees.Location = New System.Drawing.Point(142, 226)
        Me.btnHostelFees.Name = "btnHostelFees"
        Me.btnHostelFees.Size = New System.Drawing.Size(217, 150)
        Me.btnHostelFees.TabIndex = 4
        Me.btnHostelFees.Text = "HOSTEL FEES DETAILS"
        Me.btnHostelFees.UseVisualStyleBackColor = False
        '
        'btnAddRooms
        '
        Me.btnAddRooms.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddRooms.BackColor = System.Drawing.Color.MintCream
        Me.btnAddRooms.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRooms.ForeColor = System.Drawing.Color.Black
        Me.btnAddRooms.Location = New System.Drawing.Point(142, 43)
        Me.btnAddRooms.Name = "btnAddRooms"
        Me.btnAddRooms.Size = New System.Drawing.Size(217, 150)
        Me.btnAddRooms.TabIndex = 0
        Me.btnAddRooms.Text = "ADD ROOMS"
        Me.btnAddRooms.UseVisualStyleBackColor = False
        '
        'RoomsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelRoomPage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RoomsPage"
        Me.ShowIcon = False
        Me.Text = "RoomsPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelRoomPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelRoomPage As System.Windows.Forms.Panel
    Friend WithEvents btnAddRooms As System.Windows.Forms.Button
    Friend WithEvents btnHostelFees As System.Windows.Forms.Button
End Class
