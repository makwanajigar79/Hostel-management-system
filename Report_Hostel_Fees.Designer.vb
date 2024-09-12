<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Hostel_Fees
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.HostelFees_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HMS_DBDataSet1 = New HMS.HMS_DBDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HostelFees_tbTableAdapter = New HMS.HMS_DBDataSet1TableAdapters.HostelFees_tbTableAdapter()
        Me.lblHostel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.HostelFees_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HMS_DBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HostelFees_tbBindingSource
        '
        Me.HostelFees_tbBindingSource.DataMember = "HostelFees_tb"
        Me.HostelFees_tbBindingSource.DataSource = Me.HMS_DBDataSet1
        '
        'HMS_DBDataSet1
        '
        Me.HMS_DBDataSet1.DataSetName = "HMS_DBDataSet1"
        Me.HMS_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.HostelFees_tbBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "HMS.Report_Hostel_fees.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(24, 77)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 365)
        Me.ReportViewer1.TabIndex = 0
        '
        'HostelFees_tbTableAdapter
        '
        Me.HostelFees_tbTableAdapter.ClearBeforeFill = True
        '
        'lblHostel
        '
        Me.lblHostel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHostel.AutoSize = True
        Me.lblHostel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHostel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHostel.Location = New System.Drawing.Point(307, 26)
        Me.lblHostel.Name = "lblHostel"
        Me.lblHostel.Size = New System.Drawing.Size(242, 24)
        Me.lblHostel.TabIndex = 1
        Me.lblHostel.Text = "HOSTEL FEES REPORT"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(727, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Report_Hostel_Fees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HMS.My.Resources.Resources.Hostel_Wallpaper_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(836, 489)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblHostel)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Report_Hostel_Fees"
        Me.Text = "Report_Hostel_Fees"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.HostelFees_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HMS_DBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents HostelFees_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HMS_DBDataSet1 As HMS.HMS_DBDataSet1
    Friend WithEvents HostelFees_tbTableAdapter As HMS.HMS_DBDataSet1TableAdapters.HostelFees_tbTableAdapter
    Friend WithEvents lblHostel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
