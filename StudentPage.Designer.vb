<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentPage
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
        Me.PanelBookPage = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnViewStudent = New System.Windows.Forms.Button()
        Me.PanelBookPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBookPage
        '
        Me.PanelBookPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelBookPage.BackgroundImage = Global.HMS.My.Resources.Resources.images__2_
        Me.PanelBookPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelBookPage.Controls.Add(Me.Button1)
        Me.PanelBookPage.Controls.Add(Me.btnAddStudent)
        Me.PanelBookPage.Controls.Add(Me.btnViewStudent)
        Me.PanelBookPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBookPage.ForeColor = System.Drawing.Color.White
        Me.PanelBookPage.Location = New System.Drawing.Point(0, 0)
        Me.PanelBookPage.Name = "PanelBookPage"
        Me.PanelBookPage.Size = New System.Drawing.Size(506, 429)
        Me.PanelBookPage.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.MintCream
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(138, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 150)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "UPDATE STUDENT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddStudent.BackColor = System.Drawing.Color.MintCream
        Me.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.ForeColor = System.Drawing.Color.Black
        Me.btnAddStudent.Location = New System.Drawing.Point(22, 58)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(217, 150)
        Me.btnAddStudent.TabIndex = 0
        Me.btnAddStudent.Text = "ADD STUDENT"
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'btnViewStudent
        '
        Me.btnViewStudent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnViewStudent.BackColor = System.Drawing.Color.MintCream
        Me.btnViewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewStudent.ForeColor = System.Drawing.Color.Black
        Me.btnViewStudent.Location = New System.Drawing.Point(277, 58)
        Me.btnViewStudent.Name = "btnViewStudent"
        Me.btnViewStudent.Size = New System.Drawing.Size(217, 150)
        Me.btnViewStudent.TabIndex = 1
        Me.btnViewStudent.Text = "VIEW STUDENT"
        Me.btnViewStudent.UseVisualStyleBackColor = False
        '
        'StudentPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelBookPage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentPage"
        Me.Text = "StudentPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelBookPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBookPage As System.Windows.Forms.Panel
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents btnViewStudent As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
