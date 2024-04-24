<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinitoringSystem
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MinitoringSystem))
        Me.MMCHARTViewChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.MonitorByChartDataGridView = New System.Windows.Forms.DataGridView
        Me.DateofService2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChartNumber2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecordType2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsSignedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SignedByDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AssignedToDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaseNumber2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastModifiedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModifieddateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocumentPath2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PostedChangesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ForeignID2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecordSpecific2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Signature = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.MonitorByChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet2 = New MedicalManager.MMDataDataSet2
        Me.MMCentralMonitorDataGridView = New System.Windows.Forms.DataGridView
        Me.PostedChanges = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IsSigned = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DateOfService = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChartNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecordType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AssignedToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SignedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocumentPath = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ModifieddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastModifiedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ForeignID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecordSpecific = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMCentralMonitorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.btnAll = New System.Windows.Forms.Button
        Me.BTNLAB = New System.Windows.Forms.Button
        Me.btnLetter = New System.Windows.Forms.Button
        Me.btnRadiology = New System.Windows.Forms.Button
        Me.btnMessages = New System.Windows.Forms.Button
        Me.btnVisit = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdRotate270 = New System.Windows.Forms.Button
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.cboFrameNo = New System.Windows.Forms.ComboBox
        Me.btnZoom = New System.Windows.Forms.Button
        Me.btnUnZoom = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.cmdRotate90 = New System.Windows.Forms.Button
        Me.picImage = New System.Windows.Forms.PictureBox
        Me.cmdZoomByWidth = New System.Windows.Forms.Button
        Me.cmdZoomOut = New System.Windows.Forms.Button
        Me.cmdZoomIn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdBottom = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdPrev = New System.Windows.Forms.Button
        Me.cmdTop = New System.Windows.Forms.Button
        Me.cmdGo = New System.Windows.Forms.Button
        Me.txtPageNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTotalPage = New System.Windows.Forms.Label
        Me.MMCentralMonitorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MMCentralMonitorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnUpdateSignatures = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.txtFind = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.cmbFilter = New System.Windows.Forms.ToolStripComboBox
        Me.btnFillByChart = New System.Windows.Forms.ToolStripButton
        Me.txtChartNumber = New System.Windows.Forms.ToolStripTextBox
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MMCentralMonitorTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCentralMonitorTableAdapter
        Me.VisitReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisitreportTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.VisitreportTableAdapter
        Me.MMChartRxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMChartRxTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartRxTableAdapter
        Me.MMCHDxRxLtMtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMCHDxRxLtMtTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter
        Me.MMChartTVitalSignBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMChartTVitalSignTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartTVitalSignTableAdapter
        Me.MMCHARTViewChartTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHARTViewChartTableAdapter
        Me.MonitorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonitorTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MonitorTableAdapter
        Me.UpdateSignaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UpdateSignaturesTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.UpdateSignaturesTableAdapter
        Me.VisitReportPracticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisitReportPracticeTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.VisitReportPracticeTableAdapter
        Me.LettersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LettersTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.LettersTableAdapter
        Me.MonitorByChartTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.MonitorByChartTableAdapter
        CType(Me.MMCHARTViewChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.MonitorByChartDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonitorByChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCentralMonitorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCentralMonitorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCentralMonitorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMCentralMonitorBindingNavigator.SuspendLayout()
        CType(Me.VisitReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartRxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartTVitalSignBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonitorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateSignaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitReportPracticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LettersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MMCHARTViewChartBindingSource
        '
        Me.MMCHARTViewChartBindingSource.DataMember = "MMCHARTViewChart"
        Me.MMCHARTViewChartBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.SplitContainer1.Panel1.Controls.Add(Me.MonitorByChartDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MMCentralMonitorDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1250, 728)
        Me.SplitContainer1.SplitterDistance = 570
        Me.SplitContainer1.TabIndex = 0
        '
        'MonitorByChartDataGridView
        '
        Me.MonitorByChartDataGridView.AllowUserToAddRows = False
        Me.MonitorByChartDataGridView.AllowUserToResizeRows = False
        Me.MonitorByChartDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MonitorByChartDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MonitorByChartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MonitorByChartDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateofService2, Me.ChartNumber2, Me.RecordType2, Me.DataGridViewTextBoxColumn1, Me.IsSignedDataGridViewCheckBoxColumn, Me.SignedByDataGridViewTextBoxColumn1, Me.AssignedToDataGridViewTextBoxColumn1, Me.StatusDataGridViewTextBoxColumn1, Me.NameDataGridViewTextBoxColumn1, Me.CaseNumber2, Me.LastModifiedDataGridViewTextBoxColumn1, Me.ModifieddateDataGridViewTextBoxColumn1, Me.DocumentPath2, Me.PostedChangesDataGridViewTextBoxColumn, Me.ForeignID2, Me.RecordSpecific2, Me.Signature})
        Me.MonitorByChartDataGridView.DataSource = Me.MonitorByChartBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MonitorByChartDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.MonitorByChartDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonitorByChartDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MonitorByChartDataGridView.Name = "MonitorByChartDataGridView"
        Me.MonitorByChartDataGridView.Size = New System.Drawing.Size(570, 728)
        Me.MonitorByChartDataGridView.TabIndex = 1
        Me.MonitorByChartDataGridView.Visible = False
        '
        'DateofService2
        '
        Me.DateofService2.DataPropertyName = "Date"
        Me.DateofService2.HeaderText = "Date"
        Me.DateofService2.Name = "DateofService2"
        Me.DateofService2.ReadOnly = True
        Me.DateofService2.Width = 65
        '
        'ChartNumber2
        '
        Me.ChartNumber2.DataPropertyName = "ChartNumber"
        Me.ChartNumber2.HeaderText = "Chart #"
        Me.ChartNumber2.Name = "ChartNumber2"
        Me.ChartNumber2.ReadOnly = True
        Me.ChartNumber2.Width = 65
        '
        'RecordType2
        '
        Me.RecordType2.DataPropertyName = "RecordType"
        Me.RecordType2.HeaderText = "RecordType"
        Me.RecordType2.Name = "RecordType2"
        Me.RecordType2.ReadOnly = True
        Me.RecordType2.Width = 70
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IsSignedDataGridViewCheckBoxColumn
        '
        Me.IsSignedDataGridViewCheckBoxColumn.DataPropertyName = "IsSigned"
        Me.IsSignedDataGridViewCheckBoxColumn.HeaderText = "IsSigned"
        Me.IsSignedDataGridViewCheckBoxColumn.Name = "IsSignedDataGridViewCheckBoxColumn"
        Me.IsSignedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsSignedDataGridViewCheckBoxColumn.Width = 50
        '
        'SignedByDataGridViewTextBoxColumn1
        '
        Me.SignedByDataGridViewTextBoxColumn1.DataPropertyName = "SignedBy"
        Me.SignedByDataGridViewTextBoxColumn1.HeaderText = "SignedBy"
        Me.SignedByDataGridViewTextBoxColumn1.Name = "SignedByDataGridViewTextBoxColumn1"
        Me.SignedByDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SignedByDataGridViewTextBoxColumn1.Width = 70
        '
        'AssignedToDataGridViewTextBoxColumn1
        '
        Me.AssignedToDataGridViewTextBoxColumn1.DataPropertyName = "AssignedTo"
        Me.AssignedToDataGridViewTextBoxColumn1.HeaderText = "AssignedTo"
        Me.AssignedToDataGridViewTextBoxColumn1.Name = "AssignedToDataGridViewTextBoxColumn1"
        Me.AssignedToDataGridViewTextBoxColumn1.ReadOnly = True
        Me.AssignedToDataGridViewTextBoxColumn1.Width = 70
        '
        'StatusDataGridViewTextBoxColumn1
        '
        Me.StatusDataGridViewTextBoxColumn1.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn1.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn1.Name = "StatusDataGridViewTextBoxColumn1"
        Me.StatusDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        Me.NameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn1.Width = 120
        '
        'CaseNumber2
        '
        Me.CaseNumber2.DataPropertyName = "CaseNumber"
        Me.CaseNumber2.HeaderText = "Case #"
        Me.CaseNumber2.Name = "CaseNumber2"
        Me.CaseNumber2.ReadOnly = True
        Me.CaseNumber2.Width = 50
        '
        'LastModifiedDataGridViewTextBoxColumn1
        '
        Me.LastModifiedDataGridViewTextBoxColumn1.DataPropertyName = "LastModified"
        Me.LastModifiedDataGridViewTextBoxColumn1.HeaderText = "LastModified"
        Me.LastModifiedDataGridViewTextBoxColumn1.Name = "LastModifiedDataGridViewTextBoxColumn1"
        Me.LastModifiedDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ModifieddateDataGridViewTextBoxColumn1
        '
        Me.ModifieddateDataGridViewTextBoxColumn1.DataPropertyName = "Modifieddate"
        Me.ModifieddateDataGridViewTextBoxColumn1.HeaderText = "Modifieddate"
        Me.ModifieddateDataGridViewTextBoxColumn1.Name = "ModifieddateDataGridViewTextBoxColumn1"
        Me.ModifieddateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DocumentPath2
        '
        Me.DocumentPath2.DataPropertyName = "DocumentPath"
        Me.DocumentPath2.HeaderText = "DocumentPath"
        Me.DocumentPath2.Name = "DocumentPath2"
        Me.DocumentPath2.ReadOnly = True
        '
        'PostedChangesDataGridViewTextBoxColumn
        '
        Me.PostedChangesDataGridViewTextBoxColumn.DataPropertyName = "PostedChanges"
        Me.PostedChangesDataGridViewTextBoxColumn.HeaderText = "PostedChanges"
        Me.PostedChangesDataGridViewTextBoxColumn.Name = "PostedChangesDataGridViewTextBoxColumn"
        Me.PostedChangesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ForeignID2
        '
        Me.ForeignID2.DataPropertyName = "ForeignID"
        Me.ForeignID2.HeaderText = "ForeignID"
        Me.ForeignID2.Name = "ForeignID2"
        Me.ForeignID2.ReadOnly = True
        '
        'RecordSpecific2
        '
        Me.RecordSpecific2.DataPropertyName = "RecordSpecific"
        Me.RecordSpecific2.HeaderText = "RecordSpecific"
        Me.RecordSpecific2.Name = "RecordSpecific2"
        Me.RecordSpecific2.ReadOnly = True
        '
        'Signature
        '
        Me.Signature.HeaderText = "Signature"
        Me.Signature.Name = "Signature"
        Me.Signature.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Signature.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Signature.Width = 60
        '
        'MonitorByChartBindingSource
        '
        Me.MonitorByChartBindingSource.DataMember = "MonitorByChart"
        Me.MonitorByChartBindingSource.DataSource = Me.MMDataDataSet2
        '
        'MMDataDataSet2
        '
        Me.MMDataDataSet2.DataSetName = "MMDataDataSet2"
        Me.MMDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMCentralMonitorDataGridView
        '
        Me.MMCentralMonitorDataGridView.AllowUserToAddRows = False
        Me.MMCentralMonitorDataGridView.AllowUserToResizeRows = False
        Me.MMCentralMonitorDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMCentralMonitorDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MMCentralMonitorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MMCentralMonitorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PostedChanges, Me.IsSigned, Me.DateOfService, Me.ChartNumber, Me.RecordType, Me.Description, Me.AssignedToDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.SignedByDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.CaseNumber, Me.DocumentPath, Me.ModifieddateDataGridViewTextBoxColumn, Me.LastModifiedDataGridViewTextBoxColumn, Me.ForeignID, Me.IDDataGridViewTextBoxColumn, Me.RecordSpecific})
        Me.MMCentralMonitorDataGridView.DataSource = Me.MMCentralMonitorBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MMCentralMonitorDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.MMCentralMonitorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MMCentralMonitorDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MMCentralMonitorDataGridView.Name = "MMCentralMonitorDataGridView"
        Me.MMCentralMonitorDataGridView.RowHeadersWidth = 30
        Me.MMCentralMonitorDataGridView.Size = New System.Drawing.Size(570, 728)
        Me.MMCentralMonitorDataGridView.TabIndex = 0
        '
        'PostedChanges
        '
        Me.PostedChanges.DataPropertyName = "PostedChanges"
        Me.PostedChanges.HeaderText = "Posted"
        Me.PostedChanges.Name = "PostedChanges"
        Me.PostedChanges.ReadOnly = True
        Me.PostedChanges.Width = 42
        '
        'IsSigned
        '
        Me.IsSigned.DataPropertyName = "IsSigned"
        Me.IsSigned.HeaderText = "Signed"
        Me.IsSigned.Name = "IsSigned"
        Me.IsSigned.Width = 42
        '
        'DateOfService
        '
        Me.DateOfService.DataPropertyName = "Date"
        Me.DateOfService.HeaderText = "Date"
        Me.DateOfService.Name = "DateOfService"
        Me.DateOfService.ReadOnly = True
        Me.DateOfService.Width = 60
        '
        'ChartNumber
        '
        Me.ChartNumber.DataPropertyName = "ChartNumber"
        Me.ChartNumber.HeaderText = "Chart #"
        Me.ChartNumber.Name = "ChartNumber"
        Me.ChartNumber.ReadOnly = True
        Me.ChartNumber.Width = 65
        '
        'RecordType
        '
        Me.RecordType.DataPropertyName = "RecordType"
        Me.RecordType.HeaderText = "Rec Type"
        Me.RecordType.Name = "RecordType"
        Me.RecordType.ReadOnly = True
        Me.RecordType.Width = 70
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        '
        'AssignedToDataGridViewTextBoxColumn
        '
        Me.AssignedToDataGridViewTextBoxColumn.DataPropertyName = "AssignedTo"
        Me.AssignedToDataGridViewTextBoxColumn.HeaderText = "AssignedTo"
        Me.AssignedToDataGridViewTextBoxColumn.Name = "AssignedToDataGridViewTextBoxColumn"
        Me.AssignedToDataGridViewTextBoxColumn.Width = 70
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Width = 85
        '
        'SignedByDataGridViewTextBoxColumn
        '
        Me.SignedByDataGridViewTextBoxColumn.DataPropertyName = "SignedBy"
        Me.SignedByDataGridViewTextBoxColumn.HeaderText = "SignedBy"
        Me.SignedByDataGridViewTextBoxColumn.Name = "SignedByDataGridViewTextBoxColumn"
        Me.SignedByDataGridViewTextBoxColumn.Width = 70
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CaseNumber
        '
        Me.CaseNumber.DataPropertyName = "CaseNumber"
        Me.CaseNumber.HeaderText = "Case #"
        Me.CaseNumber.Name = "CaseNumber"
        Me.CaseNumber.ReadOnly = True
        Me.CaseNumber.Width = 60
        '
        'DocumentPath
        '
        Me.DocumentPath.DataPropertyName = "DocumentPath"
        Me.DocumentPath.HeaderText = "DocumentPath"
        Me.DocumentPath.Name = "DocumentPath"
        Me.DocumentPath.ReadOnly = True
        Me.DocumentPath.Width = 50
        '
        'ModifieddateDataGridViewTextBoxColumn
        '
        Me.ModifieddateDataGridViewTextBoxColumn.DataPropertyName = "Modifieddate"
        Me.ModifieddateDataGridViewTextBoxColumn.HeaderText = "Modifieddate"
        Me.ModifieddateDataGridViewTextBoxColumn.Name = "ModifieddateDataGridViewTextBoxColumn"
        Me.ModifieddateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastModifiedDataGridViewTextBoxColumn
        '
        Me.LastModifiedDataGridViewTextBoxColumn.DataPropertyName = "LastModified"
        Me.LastModifiedDataGridViewTextBoxColumn.HeaderText = "LastModified"
        Me.LastModifiedDataGridViewTextBoxColumn.Name = "LastModifiedDataGridViewTextBoxColumn"
        Me.LastModifiedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ForeignID
        '
        Me.ForeignID.DataPropertyName = "ForeignID"
        Me.ForeignID.HeaderText = "ForeignID"
        Me.ForeignID.Name = "ForeignID"
        Me.ForeignID.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'RecordSpecific
        '
        Me.RecordSpecific.DataPropertyName = "RecordSpecific"
        Me.RecordSpecific.HeaderText = "RecordSpecific"
        Me.RecordSpecific.Name = "RecordSpecific"
        '
        'MMCentralMonitorBindingSource
        '
        Me.MMCentralMonitorBindingSource.DataMember = "MMCentralMonitor"
        Me.MMCentralMonitorBindingSource.DataSource = Me.MMDataDataSet1
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnAll)
        Me.SplitContainer3.Panel1.Controls.Add(Me.BTNLAB)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnLetter)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnRadiology)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnMessages)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnVisit)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(676, 728)
        Me.SplitContainer3.SplitterDistance = 25
        Me.SplitContainer3.TabIndex = 3
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAll.Location = New System.Drawing.Point(3, 495)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(20, 47)
        Me.btnAll.TabIndex = 144
        Me.btnAll.Text = "ALL"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'BTNLAB
        '
        Me.BTNLAB.BackColor = System.Drawing.Color.Thistle
        Me.BTNLAB.Location = New System.Drawing.Point(3, 220)
        Me.BTNLAB.Name = "BTNLAB"
        Me.BTNLAB.Size = New System.Drawing.Size(20, 59)
        Me.BTNLAB.TabIndex = 141
        Me.BTNLAB.Text = "LAB"
        Me.BTNLAB.UseVisualStyleBackColor = False
        '
        'btnLetter
        '
        Me.btnLetter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLetter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnLetter.Location = New System.Drawing.Point(3, 404)
        Me.btnLetter.Name = "btnLetter"
        Me.btnLetter.Size = New System.Drawing.Size(20, 89)
        Me.btnLetter.TabIndex = 142
        Me.btnLetter.Text = "LETTER"
        Me.btnLetter.UseVisualStyleBackColor = False
        '
        'btnRadiology
        '
        Me.btnRadiology.BackColor = System.Drawing.Color.LightGreen
        Me.btnRadiology.Location = New System.Drawing.Point(3, 89)
        Me.btnRadiology.Name = "btnRadiology"
        Me.btnRadiology.Size = New System.Drawing.Size(20, 128)
        Me.btnRadiology.TabIndex = 139
        Me.btnRadiology.Text = "RADIOLOGY"
        Me.btnRadiology.UseVisualStyleBackColor = False
        '
        'btnMessages
        '
        Me.btnMessages.BackColor = System.Drawing.Color.PowderBlue
        Me.btnMessages.Location = New System.Drawing.Point(3, 282)
        Me.btnMessages.Name = "btnMessages"
        Me.btnMessages.Size = New System.Drawing.Size(20, 119)
        Me.btnMessages.TabIndex = 143
        Me.btnMessages.Text = "MESSAGES"
        Me.btnMessages.UseVisualStyleBackColor = False
        '
        'btnVisit
        '
        Me.btnVisit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVisit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnVisit.Location = New System.Drawing.Point(3, 3)
        Me.btnVisit.Name = "btnVisit"
        Me.btnVisit.Size = New System.Drawing.Size(20, 84)
        Me.btnVisit.TabIndex = 137
        Me.btnVisit.Text = "VISIT"
        Me.btnVisit.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(647, 728)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(639, 702)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MMDataDataSet1_MMCHARTViewChart"
        ReportDataSource1.Value = Me.MMCHARTViewChartBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.Chart.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(633, 696)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomPercent = 85
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(639, 727)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(633, 721)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(639, 727)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(639, 727)
        Me.DataGridView1.TabIndex = 25
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.picImage)
        Me.TabPage4.Controls.Add(Me.cmdZoomByWidth)
        Me.TabPage4.Controls.Add(Me.cmdZoomOut)
        Me.TabPage4.Controls.Add(Me.cmdZoomIn)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.cmdBottom)
        Me.TabPage4.Controls.Add(Me.cmdNext)
        Me.TabPage4.Controls.Add(Me.cmdPrev)
        Me.TabPage4.Controls.Add(Me.cmdTop)
        Me.TabPage4.Controls.Add(Me.cmdGo)
        Me.TabPage4.Controls.Add(Me.txtPageNo)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.lblTotalPage)
        Me.TabPage4.Location = New System.Drawing.Point(4, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(639, 727)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdRotate270)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.cboFrameNo)
        Me.GroupBox1.Controls.Add(Me.btnZoom)
        Me.GroupBox1.Controls.Add(Me.btnUnZoom)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.cmdRotate90)
        Me.GroupBox1.Location = New System.Drawing.Point(133, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 38)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        '
        'cmdRotate270
        '
        Me.cmdRotate270.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRotate270.Location = New System.Drawing.Point(332, 10)
        Me.cmdRotate270.Name = "cmdRotate270"
        Me.cmdRotate270.Size = New System.Drawing.Size(68, 24)
        Me.cmdRotate270.TabIndex = 48
        Me.cmdRotate270.Text = "Rotate 270"
        '
        'btnPrevious
        '
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.Location = New System.Drawing.Point(12, 10)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(36, 24)
        Me.btnPrevious.TabIndex = 44
        '
        'cboFrameNo
        '
        Me.cboFrameNo.Location = New System.Drawing.Point(56, 10)
        Me.cboFrameNo.Name = "cboFrameNo"
        Me.cboFrameNo.Size = New System.Drawing.Size(49, 21)
        Me.cboFrameNo.TabIndex = 45
        '
        'btnZoom
        '
        Me.btnZoom.Image = CType(resources.GetObject("btnZoom.Image"), System.Drawing.Image)
        Me.btnZoom.Location = New System.Drawing.Point(215, 10)
        Me.btnZoom.Name = "btnZoom"
        Me.btnZoom.Size = New System.Drawing.Size(27, 24)
        Me.btnZoom.TabIndex = 46
        '
        'btnUnZoom
        '
        Me.btnUnZoom.Image = CType(resources.GetObject("btnUnZoom.Image"), System.Drawing.Image)
        Me.btnUnZoom.Location = New System.Drawing.Point(182, 10)
        Me.btnUnZoom.Name = "btnUnZoom"
        Me.btnUnZoom.Size = New System.Drawing.Size(27, 24)
        Me.btnUnZoom.TabIndex = 47
        '
        'btnNext
        '
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(111, 10)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(36, 24)
        Me.btnNext.TabIndex = 43
        '
        'cmdRotate90
        '
        Me.cmdRotate90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRotate90.Location = New System.Drawing.Point(258, 10)
        Me.cmdRotate90.Name = "cmdRotate90"
        Me.cmdRotate90.Size = New System.Drawing.Size(68, 24)
        Me.cmdRotate90.TabIndex = 0
        Me.cmdRotate90.Text = "Rotate 90"
        '
        'picImage
        '
        Me.picImage.Location = New System.Drawing.Point(3, 40)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(633, 634)
        Me.picImage.TabIndex = 57
        Me.picImage.TabStop = False
        '
        'cmdZoomByWidth
        '
        Me.cmdZoomByWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdZoomByWidth.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdZoomByWidth.Location = New System.Drawing.Point(560, 683)
        Me.cmdZoomByWidth.Name = "cmdZoomByWidth"
        Me.cmdZoomByWidth.Size = New System.Drawing.Size(76, 24)
        Me.cmdZoomByWidth.TabIndex = 42
        Me.cmdZoomByWidth.Text = "Fit By Width"
        Me.cmdZoomByWidth.Visible = False
        '
        'cmdZoomOut
        '
        Me.cmdZoomOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdZoomOut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdZoomOut.Location = New System.Drawing.Point(493, 683)
        Me.cmdZoomOut.Name = "cmdZoomOut"
        Me.cmdZoomOut.Size = New System.Drawing.Size(62, 24)
        Me.cmdZoomOut.TabIndex = 41
        Me.cmdZoomOut.Text = "Zoom Out"
        Me.cmdZoomOut.Visible = False
        '
        'cmdZoomIn
        '
        Me.cmdZoomIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdZoomIn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdZoomIn.Location = New System.Drawing.Point(435, 683)
        Me.cmdZoomIn.Name = "cmdZoomIn"
        Me.cmdZoomIn.Size = New System.Drawing.Size(53, 24)
        Me.cmdZoomIn.TabIndex = 40
        Me.cmdZoomIn.Text = "Zoom In"
        Me.cmdZoomIn.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 690)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "/"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Visible = False
        '
        'cmdBottom
        '
        Me.cmdBottom.Location = New System.Drawing.Point(245, 684)
        Me.cmdBottom.Name = "cmdBottom"
        Me.cmdBottom.Size = New System.Drawing.Size(29, 24)
        Me.cmdBottom.TabIndex = 36
        Me.cmdBottom.Text = "->|"
        Me.cmdBottom.Visible = False
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(215, 684)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(29, 24)
        Me.cmdNext.TabIndex = 35
        Me.cmdNext.Text = "->"
        Me.cmdNext.Visible = False
        '
        'cmdPrev
        '
        Me.cmdPrev.Location = New System.Drawing.Point(185, 684)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(29, 24)
        Me.cmdPrev.TabIndex = 34
        Me.cmdPrev.Text = "<-"
        Me.cmdPrev.Visible = False
        '
        'cmdTop
        '
        Me.cmdTop.Location = New System.Drawing.Point(155, 684)
        Me.cmdTop.Name = "cmdTop"
        Me.cmdTop.Size = New System.Drawing.Size(29, 24)
        Me.cmdTop.TabIndex = 33
        Me.cmdTop.Text = "|<-"
        Me.cmdTop.Visible = False
        '
        'cmdGo
        '
        Me.cmdGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGo.Location = New System.Drawing.Point(121, 684)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(33, 24)
        Me.cmdGo.TabIndex = 32
        Me.cmdGo.Text = "GO"
        Me.cmdGo.Visible = False
        '
        'txtPageNo
        '
        Me.txtPageNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPageNo.ForeColor = System.Drawing.Color.Red
        Me.txtPageNo.Location = New System.Drawing.Point(55, 686)
        Me.txtPageNo.Name = "txtPageNo"
        Me.txtPageNo.Size = New System.Drawing.Size(32, 20)
        Me.txtPageNo.TabIndex = 31
        Me.txtPageNo.Text = "1"
        Me.txtPageNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPageNo.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 690)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Page #"
        Me.Label2.Visible = False
        '
        'lblTotalPage
        '
        Me.lblTotalPage.AutoSize = True
        Me.lblTotalPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPage.Location = New System.Drawing.Point(100, 690)
        Me.lblTotalPage.Name = "lblTotalPage"
        Me.lblTotalPage.Size = New System.Drawing.Size(14, 13)
        Me.lblTotalPage.TabIndex = 29
        Me.lblTotalPage.Text = "0"
        Me.lblTotalPage.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblTotalPage.Visible = False
        '
        'MMCentralMonitorBindingNavigator
        '
        Me.MMCentralMonitorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMCentralMonitorBindingNavigator.BindingSource = Me.MMCentralMonitorBindingSource
        Me.MMCentralMonitorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMCentralMonitorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMCentralMonitorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MMCentralMonitorBindingNavigatorSaveItem, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.btnUpdateSignatures, Me.ToolStripSeparator4, Me.ToolStripLabel2, Me.txtFind, Me.ToolStripLabel3, Me.cmbFilter, Me.btnFillByChart, Me.txtChartNumber})
        Me.MMCentralMonitorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMCentralMonitorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMCentralMonitorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMCentralMonitorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMCentralMonitorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMCentralMonitorBindingNavigator.Name = "MMCentralMonitorBindingNavigator"
        Me.MMCentralMonitorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMCentralMonitorBindingNavigator.Size = New System.Drawing.Size(1250, 25)
        Me.MMCentralMonitorBindingNavigator.TabIndex = 1
        Me.MMCentralMonitorBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MMCentralMonitorBindingNavigatorSaveItem
        '
        Me.MMCentralMonitorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MMCentralMonitorBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMCentralMonitorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMCentralMonitorBindingNavigatorSaveItem.Name = "MMCentralMonitorBindingNavigatorSaveItem"
        Me.MMCentralMonitorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MMCentralMonitorBindingNavigatorSaveItem.Text = "Save Data"
        Me.MMCentralMonitorBindingNavigatorSaveItem.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripButton2.Text = "Monitor Unsigned"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnUpdateSignatures
        '
        Me.btnUpdateSignatures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUpdateSignatures.Image = CType(resources.GetObject("btnUpdateSignatures.Image"), System.Drawing.Image)
        Me.btnUpdateSignatures.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdateSignatures.Name = "btnUpdateSignatures"
        Me.btnUpdateSignatures.Size = New System.Drawing.Size(100, 22)
        Me.btnUpdateSignatures.Text = "Update Signatures"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(27, 22)
        Me.ToolStripLabel2.Text = "Find"
        '
        'txtFind
        '
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel3.Text = "Criteria"
        '
        'cmbFilter
        '
        Me.cmbFilter.Items.AddRange(New Object() {"ChartNumber", "Name", "RecordType", "SignedBy", "AssignedTo", "Status"})
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 25)
        Me.cmbFilter.Text = "RecordType"
        '
        'btnFillByChart
        '
        Me.btnFillByChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnFillByChart.Image = CType(resources.GetObject("btnFillByChart.Image"), System.Drawing.Image)
        Me.btnFillByChart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFillByChart.Name = "btnFillByChart"
        Me.btnFillByChart.Size = New System.Drawing.Size(92, 22)
        Me.btnFillByChart.Text = "Monitor By Chart"
        '
        'txtChartNumber
        '
        Me.txtChartNumber.Name = "txtChartNumber"
        Me.txtChartNumber.Size = New System.Drawing.Size(100, 25)
        '
        'ToolTip
        '
        Me.ToolTip.ShowAlways = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'MMCentralMonitorTableAdapter
        '
        Me.MMCentralMonitorTableAdapter.ClearBeforeFill = True
        '
        'VisitReportBindingSource
        '
        Me.VisitReportBindingSource.DataMember = "VisitReport"
        Me.VisitReportBindingSource.DataSource = Me.MMDataDataSet1
        '
        'VisitreportTableAdapter
        '
        Me.VisitreportTableAdapter.ClearBeforeFill = True
        '
        'MMChartRxBindingSource
        '
        Me.MMChartRxBindingSource.DataMember = "MMChartRx"
        Me.MMChartRxBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMChartRxTableAdapter
        '
        Me.MMChartRxTableAdapter.ClearBeforeFill = True
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
        'MMChartTVitalSignBindingSource
        '
        Me.MMChartTVitalSignBindingSource.DataMember = "MMChartTVitalSign"
        Me.MMChartTVitalSignBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMChartTVitalSignTableAdapter
        '
        Me.MMChartTVitalSignTableAdapter.ClearBeforeFill = True
        '
        'MMCHARTViewChartTableAdapter
        '
        Me.MMCHARTViewChartTableAdapter.ClearBeforeFill = True
        '
        'MonitorBindingSource
        '
        Me.MonitorBindingSource.DataMember = "Monitor"
        Me.MonitorBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MonitorTableAdapter
        '
        Me.MonitorTableAdapter.ClearBeforeFill = True
        '
        'UpdateSignaturesBindingSource
        '
        Me.UpdateSignaturesBindingSource.DataMember = "UpdateSignatures"
        Me.UpdateSignaturesBindingSource.DataSource = Me.MMDataDataSet1
        '
        'UpdateSignaturesTableAdapter
        '
        Me.UpdateSignaturesTableAdapter.ClearBeforeFill = True
        '
        'VisitReportPracticeBindingSource
        '
        Me.VisitReportPracticeBindingSource.DataMember = "VisitReportPractice"
        Me.VisitReportPracticeBindingSource.DataSource = Me.MMDataDataSet1
        '
        'VisitReportPracticeTableAdapter
        '
        Me.VisitReportPracticeTableAdapter.ClearBeforeFill = True
        '
        'LettersBindingSource
        '
        Me.LettersBindingSource.DataMember = "Letters"
        Me.LettersBindingSource.DataSource = Me.MMDataDataSet2
        '
        'LettersTableAdapter
        '
        Me.LettersTableAdapter.ClearBeforeFill = True
        '
        'MonitorByChartTableAdapter
        '
        Me.MonitorByChartTableAdapter.ClearBeforeFill = True
        '
        'MinitoringSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 753)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MMCentralMonitorBindingNavigator)
        Me.Menu = Me.MainMenu1
        Me.Name = "MinitoringSystem"
        Me.Text = "Monitoring System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MMCHARTViewChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.MonitorByChartDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonitorByChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCentralMonitorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCentralMonitorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCentralMonitorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMCentralMonitorBindingNavigator.ResumeLayout(False)
        Me.MMCentralMonitorBindingNavigator.PerformLayout()
        CType(Me.VisitReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartRxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartTVitalSignBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonitorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateSignaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitReportPracticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LettersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMCentralMonitorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMCentralMonitorTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMCentralMonitorTableAdapter
    Friend WithEvents MMCentralMonitorBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MMCentralMonitorBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MMCentralMonitorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents VisitReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartRxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMCHDxRxLtMtBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartTVitalSignBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VisitreportTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.VisitreportTableAdapter
    Friend WithEvents MMChartRxTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMChartRxTableAdapter
    Friend WithEvents MMCHDxRxLtMtTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter
    Friend WithEvents MMChartTVitalSignTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMChartTVitalSignTableAdapter
    Friend WithEvents MMCHARTViewChartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMCHARTViewChartTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMCHARTViewChartTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUpdateSignatures As System.Windows.Forms.ToolStripButton
    Friend WithEvents LettersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents LettersTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.LettersTableAdapter
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MonitorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonitorTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MonitorTableAdapter
    Friend WithEvents UpdateSignaturesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UpdateSignaturesTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.UpdateSignaturesTableAdapter
    Friend WithEvents MonitorByChartDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MonitorByChartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonitorByChartTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.MonitorByChartTableAdapter
    Friend WithEvents btnFillByChart As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtChartNumber As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents VisitReportPracticeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VisitReportPracticeTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.VisitReportPracticeTableAdapter
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents cmdBottom As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdPrev As System.Windows.Forms.Button
    Friend WithEvents cmdTop As System.Windows.Forms.Button
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents txtPageNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPage As System.Windows.Forms.Label
    Friend WithEvents cmdRotate90 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdZoomByWidth As System.Windows.Forms.Button
    Friend WithEvents cmdZoomOut As System.Windows.Forms.Button
    Friend WithEvents cmdZoomIn As System.Windows.Forms.Button
    Friend WithEvents cboFrameNo As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnUnZoom As System.Windows.Forms.Button
    Friend WithEvents btnZoom As System.Windows.Forms.Button
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRotate270 As System.Windows.Forms.Button
    Friend WithEvents PostedChanges As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IsSigned As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DateOfService As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChartNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecordType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssignedToDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SignedByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaseNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModifieddateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModifiedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ForeignID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecordSpecific As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateofService2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChartNumber2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecordType2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsSignedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SignedByDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssignedToDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaseNumber2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModifiedDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModifieddateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentPath2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostedChangesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ForeignID2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecordSpecific2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Signature As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnVisit As System.Windows.Forms.Button
    Friend WithEvents btnRadiology As System.Windows.Forms.Button
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents btnMessages As System.Windows.Forms.Button
    Friend WithEvents btnLetter As System.Windows.Forms.Button
    Friend WithEvents BTNLAB As System.Windows.Forms.Button
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
End Class
