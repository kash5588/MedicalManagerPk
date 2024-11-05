<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IncomeStatement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim label2 As System.Windows.Forms.Label
        Dim label3 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.CCdateTo = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.CCdateFrom = New System.Windows.Forms.DateTimePicker()
        Me.ExpensesDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1()
        Me.MMPrecticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMPrecticeTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMPrecticeTableAdapter()
        Me.ExpensesDetailTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.ExpensesDetailTableAdapter()
        Me.MMCHDxRxLtMtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMCHDxRxLtMtTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RBDoctor = New System.Windows.Forms.RadioButton()
        Me.RBHospital = New System.Windows.Forms.RadioButton()
        Me.CBPhysicain = New System.Windows.Forms.ComboBox()
        label2 = New System.Windows.Forms.Label()
        label3 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        CType(Me.ExpensesDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMPrecticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'label2
        '
        label2.AutoSize = True
        label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        label2.Location = New System.Drawing.Point(10, 173)
        label2.Name = "label2"
        label2.Size = New System.Drawing.Size(68, 15)
        label2.TabIndex = 12
        label2.Text = "Date From:"
        '
        'label3
        '
        label3.AutoSize = True
        label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        label3.Location = New System.Drawing.Point(10, 220)
        label3.Name = "label3"
        label3.Size = New System.Drawing.Size(53, 15)
        label3.TabIndex = 11
        label3.Text = "Date To:"
        '
        'panel1
        '
        Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.panel1.Controls.Add(Me.Panel2)
        Me.panel1.Controls.Add(label2)
        Me.panel1.Controls.Add(Me.CCdateTo)
        Me.panel1.Controls.Add(Me.btnSearch)
        Me.panel1.Controls.Add(Me.CCdateFrom)
        Me.panel1.Controls.Add(label3)
        Me.panel1.Location = New System.Drawing.Point(0, 2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(234, 606)
        Me.panel1.TabIndex = 5
        '
        'CCdateTo
        '
        Me.CCdateTo.CustomFormat = "dd/MM/yyyy"
        Me.CCdateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CCdateTo.Location = New System.Drawing.Point(84, 217)
        Me.CCdateTo.Name = "CCdateTo"
        Me.CCdateTo.Size = New System.Drawing.Size(98, 22)
        Me.CCdateTo.TabIndex = 13
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Location = New System.Drawing.Point(35, 274)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(147, 35)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'CCdateFrom
        '
        Me.CCdateFrom.CustomFormat = "dd/MM/yyyy"
        Me.CCdateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CCdateFrom.Location = New System.Drawing.Point(84, 171)
        Me.CCdateFrom.Name = "CCdateFrom"
        Me.CCdateFrom.Size = New System.Drawing.Size(98, 22)
        Me.CCdateFrom.TabIndex = 14
        '
        'ExpensesDetailBindingSource
        '
        Me.ExpensesDetailBindingSource.DataMember = "ExpensesDetail"
        Me.ExpensesDetailBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMPrecticeBindingSource
        '
        Me.MMPrecticeBindingSource.DataMember = "MMPrectice"
        Me.MMPrecticeBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMPrecticeTableAdapter
        '
        Me.MMPrecticeTableAdapter.ClearBeforeFill = True
        '
        'ExpensesDetailTableAdapter
        '
        Me.ExpensesDetailTableAdapter.ClearBeforeFill = True
        '
        'MMCHDxRxLtMtBindingSource
        '
        Me.MMCHDxRxLtMtBindingSource.DataMember = "MMCHDxRxLtMt"
        Me.MMCHDxRxLtMtBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMCHDxRxLtMtTableAdapter
        '
        Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.IncomeStatement.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(240, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(780, 606)
        Me.ReportViewer1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CBPhysicain)
        Me.Panel2.Controls.Add(Label1)
        Me.Panel2.Controls.Add(Me.RBDoctor)
        Me.Panel2.Controls.Add(Me.RBHospital)
        Me.Panel2.Location = New System.Drawing.Point(3, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(228, 112)
        Me.Panel2.TabIndex = 15
        '
        'RBDoctor
        '
        Me.RBDoctor.AutoSize = True
        Me.RBDoctor.Location = New System.Drawing.Point(133, 14)
        Me.RBDoctor.Name = "RBDoctor"
        Me.RBDoctor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBDoctor.Size = New System.Drawing.Size(65, 20)
        Me.RBDoctor.TabIndex = 149
        Me.RBDoctor.Text = "Doctor"
        Me.RBDoctor.UseVisualStyleBackColor = True
        '
        'RBHospital
        '
        Me.RBHospital.AutoSize = True
        Me.RBHospital.Checked = True
        Me.RBHospital.Location = New System.Drawing.Point(37, 14)
        Me.RBHospital.Name = "RBHospital"
        Me.RBHospital.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RBHospital.Size = New System.Drawing.Size(75, 20)
        Me.RBHospital.TabIndex = 150
        Me.RBHospital.TabStop = True
        Me.RBHospital.Text = "Hospital"
        Me.RBHospital.UseVisualStyleBackColor = True
        '
        'CBPhysicain
        '
        Me.CBPhysicain.FormattingEnabled = True
        Me.CBPhysicain.Location = New System.Drawing.Point(74, 69)
        Me.CBPhysicain.Name = "CBPhysicain"
        Me.CBPhysicain.Size = New System.Drawing.Size(145, 24)
        Me.CBPhysicain.TabIndex = 152
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(9, 72)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 15)
        Label1.TabIndex = 151
        Label1.Text = "Physicain"
        '
        'IncomeStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 611)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "IncomeStatement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IncomeStatement"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.ExpensesDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMPrecticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents CCdateTo As DateTimePicker
    Private WithEvents btnSearch As Button
    Private WithEvents CCdateFrom As DateTimePicker
    Friend WithEvents MMDataDataSet1 As MMDataDataSet1
    Friend WithEvents MMPrecticeBindingSource As BindingSource
    Friend WithEvents MMPrecticeTableAdapter As MMDataDataSet1TableAdapters.MMPrecticeTableAdapter
    Friend WithEvents ExpensesDetailTableAdapter As MMDataDataSet1TableAdapters.ExpensesDetailTableAdapter
    Friend WithEvents ExpensesDetailBindingSource As BindingSource
    Friend WithEvents MMCHDxRxLtMtBindingSource As BindingSource
    Friend WithEvents MMCHDxRxLtMtTableAdapter As MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RBDoctor As RadioButton
    Friend WithEvents RBHospital As RadioButton
    Friend WithEvents CBPhysicain As ComboBox
End Class
