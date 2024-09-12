<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Register_details
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HMS_DBDataSet3 = New HMS.HMS_DBDataSet3()
        Me.Registration_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registration_tbTableAdapter = New HMS.HMS_DBDataSet3TableAdapters.Registration_tbTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.HMS_DBDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registration_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Registration_tbBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "HMS.Report_Register_details.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 81)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(711, 360)
        Me.ReportViewer1.TabIndex = 0
        '
        'HMS_DBDataSet3
        '
        Me.HMS_DBDataSet3.DataSetName = "HMS_DBDataSet3"
        Me.HMS_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Registration_tbBindingSource
        '
        Me.Registration_tbBindingSource.DataMember = "Registration_tb"
        Me.Registration_tbBindingSource.DataSource = Me.HMS_DBDataSet3
        '
        'Registration_tbTableAdapter
        '
        Me.Registration_tbTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REGISTRATION DETAILS REPORT "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(610, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Report_Register_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HMS.My.Resources.Resources.Hostel_Wallpaper_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(735, 515)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Report_Register_details"
        Me.Text = "Report_Register_details"
        CType(Me.HMS_DBDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registration_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Registration_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HMS_DBDataSet3 As HMS.HMS_DBDataSet3
    Friend WithEvents Registration_tbTableAdapter As HMS.HMS_DBDataSet3TableAdapters.Registration_tbTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
