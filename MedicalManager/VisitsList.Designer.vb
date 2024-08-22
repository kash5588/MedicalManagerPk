<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisitsList
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MMChartVisitDataGridView = New System.Windows.Forms.DataGridView()
        Me.MMChartVisitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1()
        Me.MMChartVisitTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartVisitTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TBTokenNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBPhysicianName = New System.Windows.Forms.TextBox()
        Me.LBPhysicianName = New System.Windows.Forms.Label()
        Me.ChartNo = New System.Windows.Forms.TextBox()
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CaseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChartNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateVisit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicianName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TokenNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblPracticeName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.MMChartVisitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartVisitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.MMChartVisitDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(211, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 574)
        Me.Panel1.TabIndex = 0
        '
        'MMChartVisitDataGridView
        '
        Me.MMChartVisitDataGridView.AllowUserToAddRows = False
        Me.MMChartVisitDataGridView.AllowUserToDeleteRows = False
        Me.MMChartVisitDataGridView.AutoGenerateColumns = False
        Me.MMChartVisitDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MMChartVisitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MMChartVisitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CaseNumber, Me.FirstName, Me.LastName, Me.ChartNumber, Me.DateVisit, Me.VisitType, Me.PhysicianName, Me.TokenNo})
        Me.MMChartVisitDataGridView.DataSource = Me.MMChartVisitBindingSource
        Me.MMChartVisitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MMChartVisitDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MMChartVisitDataGridView.Name = "MMChartVisitDataGridView"
        Me.MMChartVisitDataGridView.ReadOnly = True
        Me.MMChartVisitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MMChartVisitDataGridView.Size = New System.Drawing.Size(626, 574)
        Me.MMChartVisitDataGridView.TabIndex = 0
        '
        'MMChartVisitBindingSource
        '
        Me.MMChartVisitBindingSource.DataMember = "MMChartVisit"
        Me.MMChartVisitBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMChartVisitTableAdapter
        '
        Me.MMChartVisitTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.lblPracticeName)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 95)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TBTokenNo)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TBPhysicianName)
        Me.Panel3.Controls.Add(Me.LBPhysicianName)
        Me.Panel3.Controls.Add(Me.ChartNo)
        Me.Panel3.Controls.Add(Me.txtCaseNo)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(1, 97)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 175)
        Me.Panel3.TabIndex = 1
        '
        'TBTokenNo
        '
        Me.TBTokenNo.Location = New System.Drawing.Point(68, 100)
        Me.TBTokenNo.Name = "TBTokenNo"
        Me.TBTokenNo.Size = New System.Drawing.Size(122, 21)
        Me.TBTokenNo.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "TokenNo"
        '
        'TBPhysicianName
        '
        Me.TBPhysicianName.Location = New System.Drawing.Point(68, 129)
        Me.TBPhysicianName.Name = "TBPhysicianName"
        Me.TBPhysicianName.Size = New System.Drawing.Size(122, 21)
        Me.TBPhysicianName.TabIndex = 14
        '
        'LBPhysicianName
        '
        Me.LBPhysicianName.AutoSize = True
        Me.LBPhysicianName.Location = New System.Drawing.Point(8, 132)
        Me.LBPhysicianName.Name = "LBPhysicianName"
        Me.LBPhysicianName.Size = New System.Drawing.Size(59, 15)
        Me.LBPhysicianName.TabIndex = 13
        Me.LBPhysicianName.Text = "Physician"
        '
        'ChartNo
        '
        Me.ChartNo.BackColor = System.Drawing.Color.White
        Me.ChartNo.Enabled = False
        Me.ChartNo.Location = New System.Drawing.Point(68, 13)
        Me.ChartNo.Name = "ChartNo"
        Me.ChartNo.Size = New System.Drawing.Size(122, 21)
        Me.ChartNo.TabIndex = 0
        '
        'txtCaseNo
        '
        Me.txtCaseNo.AcceptsReturn = True
        Me.txtCaseNo.BackColor = System.Drawing.Color.White
        Me.txtCaseNo.Enabled = False
        Me.txtCaseNo.Location = New System.Drawing.Point(68, 71)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(122, 21)
        Me.txtCaseNo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name"
        '
        'txtName
        '
        Me.txtName.AcceptsReturn = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(68, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(122, 21)
        Me.txtName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "CaseNo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ch No"
        '
        'CaseNumber
        '
        Me.CaseNumber.DataPropertyName = "CaseNumber"
        Me.CaseNumber.HeaderText = "CaseNumber"
        Me.CaseNumber.Name = "CaseNumber"
        Me.CaseNumber.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "FirstName"
        Me.FirstName.HeaderText = "FirstName"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Width = 120
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "LastName"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Width = 120
        '
        'ChartNumber
        '
        Me.ChartNumber.DataPropertyName = "ChartNumber"
        Me.ChartNumber.HeaderText = "ChartNumber"
        Me.ChartNumber.Name = "ChartNumber"
        Me.ChartNumber.ReadOnly = True
        '
        'DateVisit
        '
        Me.DateVisit.DataPropertyName = "Date"
        Me.DateVisit.HeaderText = "Date"
        Me.DateVisit.Name = "DateVisit"
        Me.DateVisit.ReadOnly = True
        '
        'VisitType
        '
        Me.VisitType.DataPropertyName = "VisitType"
        Me.VisitType.HeaderText = "VisitType"
        Me.VisitType.Name = "VisitType"
        Me.VisitType.ReadOnly = True
        '
        'PhysicianName
        '
        Me.PhysicianName.DataPropertyName = "AssignedProvider"
        Me.PhysicianName.HeaderText = "Physician"
        Me.PhysicianName.Name = "PhysicianName"
        Me.PhysicianName.ReadOnly = True
        Me.PhysicianName.Width = 150
        '
        'TokenNo
        '
        Me.TokenNo.DataPropertyName = "Extra1"
        Me.TokenNo.HeaderText = "TokenNo"
        Me.TokenNo.Name = "TokenNo"
        Me.TokenNo.ReadOnly = True
        '
        'lblPracticeName
        '
        Me.lblPracticeName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPracticeName.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblPracticeName.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPracticeName.ForeColor = System.Drawing.Color.White
        Me.lblPracticeName.Location = New System.Drawing.Point(0, 0)
        Me.lblPracticeName.Name = "lblPracticeName"
        Me.lblPracticeName.Size = New System.Drawing.Size(1200, 41)
        Me.lblPracticeName.TabIndex = 13
        Me.lblPracticeName.Text = "Visit List of Patients"
        Me.lblPracticeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VisitsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 741)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "VisitsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisitsList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.MMChartVisitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartVisitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MMDataDataSet1 As MMDataDataSet1
    Friend WithEvents MMChartVisitBindingSource As BindingSource
    Friend WithEvents MMChartVisitTableAdapter As MMDataDataSet1TableAdapters.MMChartVisitTableAdapter
    Friend WithEvents MMChartVisitDataGridView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TBPhysicianName As TextBox
    Friend WithEvents LBPhysicianName As Label
    Friend WithEvents ChartNo As TextBox
    Friend WithEvents txtCaseNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBTokenNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CaseNumber As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents ChartNumber As DataGridViewTextBoxColumn
    Friend WithEvents DateVisit As DataGridViewTextBoxColumn
    Friend WithEvents VisitType As DataGridViewTextBoxColumn
    Friend WithEvents PhysicianName As DataGridViewTextBoxColumn
    Friend WithEvents TokenNo As DataGridViewTextBoxColumn
    Friend WithEvents lblPracticeName As Label
End Class
