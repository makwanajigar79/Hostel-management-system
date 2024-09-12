<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportPage
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
        Me.btnHostelFees = New System.Windows.Forms.Button()
        Me.BTN_STUDENT_REPORTS = New System.Windows.Forms.Button()
        Me.btnRoomReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHostelFees
        '
        Me.btnHostelFees.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHostelFees.BackColor = System.Drawing.Color.MintCream
        Me.btnHostelFees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHostelFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHostelFees.ForeColor = System.Drawing.Color.Black
        Me.btnHostelFees.Location = New System.Drawing.Point(150, 229)
        Me.btnHostelFees.Name = "btnHostelFees"
        Me.btnHostelFees.Size = New System.Drawing.Size(217, 150)
        Me.btnHostelFees.TabIndex = 6
        Me.btnHostelFees.Text = "HOSTEL FEES REPORT"
        Me.btnHostelFees.UseVisualStyleBackColor = False
        '
        'BTN_STUDENT_REPORTS
        '
        Me.BTN_STUDENT_REPORTS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_STUDENT_REPORTS.BackColor = System.Drawing.Color.MintCream
        Me.BTN_STUDENT_REPORTS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_STUDENT_REPORTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_STUDENT_REPORTS.ForeColor = System.Drawing.Color.Black
        Me.BTN_STUDENT_REPORTS.Location = New System.Drawing.Point(29, 48)
        Me.BTN_STUDENT_REPORTS.Name = "BTN_STUDENT_REPORTS"
        Me.BTN_STUDENT_REPORTS.Size = New System.Drawing.Size(217, 150)
        Me.BTN_STUDENT_REPORTS.TabIndex = 5
        Me.BTN_STUDENT_REPORTS.Text = "STUDENT REPORTS"
        Me.BTN_STUDENT_REPORTS.UseVisualStyleBackColor = False
        '
        'btnRoomReport
        '
        Me.btnRoomReport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRoomReport.BackColor = System.Drawing.Color.MintCream
        Me.btnRoomReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRoomReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomReport.ForeColor = System.Drawing.Color.Black
        Me.btnRoomReport.Location = New System.Drawing.Point(288, 48)
        Me.btnRoomReport.Name = "btnRoomReport"
        Me.btnRoomReport.Size = New System.Drawing.Size(217, 150)
        Me.btnRoomReport.TabIndex = 7
        Me.btnRoomReport.Text = "ROOMS REPORT"
        Me.btnRoomReport.UseVisualStyleBackColor = False
        '
        'ReportPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.HMS.My.Resources.Resources.images__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(517, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRoomReport)
        Me.Controls.Add(Me.btnHostelFees)
        Me.Controls.Add(Me.BTN_STUDENT_REPORTS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportPage"
        Me.Text = "ReportPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHostelFees As System.Windows.Forms.Button
    Friend WithEvents BTN_STUDENT_REPORTS As System.Windows.Forms.Button
    Friend WithEvents btnRoomReport As System.Windows.Forms.Button
End Class
