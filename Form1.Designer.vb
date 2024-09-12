<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBoxPassword = New System.Windows.Forms.CheckBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.lblpwd = New System.Windows.Forms.Label()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.txtunm = New System.Windows.Forms.TextBox()
        Me.lblunm = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.CheckBoxPassword)
        Me.Panel1.Controls.Add(Me.btnsubmit)
        Me.Panel1.Controls.Add(Me.lbllogin)
        Me.Panel1.Controls.Add(Me.lblpwd)
        Me.Panel1.Controls.Add(Me.txtpwd)
        Me.Panel1.Controls.Add(Me.txtunm)
        Me.Panel1.Controls.Add(Me.lblunm)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(181, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 428)
        Me.Panel1.TabIndex = 2
        '
        'CheckBoxPassword
        '
        Me.CheckBoxPassword.AutoSize = True
        Me.CheckBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPassword.ForeColor = System.Drawing.Color.White
        Me.CheckBoxPassword.Location = New System.Drawing.Point(365, 174)
        Me.CheckBoxPassword.Name = "CheckBoxPassword"
        Me.CheckBoxPassword.Size = New System.Drawing.Size(92, 28)
        Me.CheckBoxPassword.TabIndex = 9
        Me.CheckBoxPassword.Text = "SHOW"
        Me.CheckBoxPassword.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.ForeColor = System.Drawing.Color.Black
        Me.btnsubmit.Location = New System.Drawing.Point(164, 285)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(160, 70)
        Me.btnsubmit.TabIndex = 3
        Me.btnsubmit.Text = "SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbllogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.ForeColor = System.Drawing.Color.White
        Me.lbllogin.Location = New System.Drawing.Point(199, 22)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(72, 24)
        Me.lbllogin.TabIndex = 4
        Me.lbllogin.Text = "LOGIN"
        '
        'lblpwd
        '
        Me.lblpwd.AutoSize = True
        Me.lblpwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpwd.ForeColor = System.Drawing.Color.White
        Me.lblpwd.Location = New System.Drawing.Point(34, 178)
        Me.lblpwd.Name = "lblpwd"
        Me.lblpwd.Size = New System.Drawing.Size(126, 24)
        Me.lblpwd.TabIndex = 3
        Me.lblpwd.Text = "PASSWORD"
        '
        'txtpwd
        '
        Me.txtpwd.BackColor = System.Drawing.Color.Silver
        Me.txtpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.ForeColor = System.Drawing.Color.Black
        Me.txtpwd.Location = New System.Drawing.Point(184, 174)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.Size = New System.Drawing.Size(163, 29)
        Me.txtpwd.TabIndex = 2
        Me.txtpwd.UseSystemPasswordChar = True
        '
        'txtunm
        '
        Me.txtunm.BackColor = System.Drawing.Color.Silver
        Me.txtunm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunm.ForeColor = System.Drawing.Color.Black
        Me.txtunm.Location = New System.Drawing.Point(184, 113)
        Me.txtunm.Name = "txtunm"
        Me.txtunm.Size = New System.Drawing.Size(163, 29)
        Me.txtunm.TabIndex = 1
        '
        'lblunm
        '
        Me.lblunm.AutoSize = True
        Me.lblunm.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblunm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunm.ForeColor = System.Drawing.Color.White
        Me.lblunm.Location = New System.Drawing.Point(34, 113)
        Me.lblunm.Name = "lblunm"
        Me.lblunm.Size = New System.Drawing.Size(125, 24)
        Me.lblunm.TabIndex = 0
        Me.lblunm.Text = "USERNAME"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.HMS.My.Resources.Resources.Hostel_Wallpaper_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(828, 508)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CheckBoxPassword As System.Windows.Forms.CheckBox
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents lbllogin As System.Windows.Forms.Label
    Friend WithEvents lblpwd As System.Windows.Forms.Label
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents txtunm As System.Windows.Forms.TextBox
    Friend WithEvents lblunm As System.Windows.Forms.Label

End Class
