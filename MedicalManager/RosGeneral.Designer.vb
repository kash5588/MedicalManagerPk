<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RosGeneral
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RosGeneral))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GradientNavigationButton11 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.GradientNavigationButton8 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GradientNavigationButton14 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.GradientNavigationButton13 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.GradientNavigationButton12 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.GradientNavigationButton10 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.GradientNavigationButton9 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.GradientNavigationButton7 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.GradientNavigationButton6 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.GradientNavigationButton5 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.GradientNavigationButton4 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.GradientNavigationButton3 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.GradientNavigationButton2 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.GradientNavigationButton1 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.MMCHRosAndGenDataGridView = New System.Windows.Forms.DataGridView
        Me.MMCHRosAndGenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.cmdROS = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.MMCHRosAndGenTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHRosAndGenTableAdapter
        Me.Heading = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Negative = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Positive = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SubCategory = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Discription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Describe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.detailtopost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HideC = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.MMCHRosAndGenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHRosAndGenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "gastrointestinal.bmp")
        Me.ImageList1.Images.SetKeyName(10, "bloodcells.jpg")
        '
        'GradientNavigationButton11
        '
        Me.GradientNavigationButton11.Location = New System.Drawing.Point(12, 481)
        Me.GradientNavigationButton11.Name = "GradientNavigationButton11"
        Me.GradientNavigationButton11.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton11.TabIndex = 10
        Me.GradientNavigationButton11.Text = "Metabolic | Endocrine"
        '
        'GradientNavigationButton8
        '
        Me.GradientNavigationButton8.Location = New System.Drawing.Point(12, 317)
        Me.GradientNavigationButton8.Name = "GradientNavigationButton8"
        Me.GradientNavigationButton8.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton8.TabIndex = 7
        Me.GradientNavigationButton8.Text = "Reproductive"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.GradientNavigationButton14)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton13)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton12)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton11)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton10)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton9)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton8)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton7)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton6)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton5)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton4)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton3)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton2)
        Me.Panel1.Controls.Add(Me.GradientNavigationButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(187, 720)
        Me.Panel1.TabIndex = 0
        '
        'GradientNavigationButton14
        '
        Me.GradientNavigationButton14.Image = CType(resources.GetObject("GradientNavigationButton14.Image"), System.Drawing.Image)
        Me.GradientNavigationButton14.ImageIndex = 6
        Me.GradientNavigationButton14.ImageList = Me.ImageList1
        Me.GradientNavigationButton14.Location = New System.Drawing.Point(12, 563)
        Me.GradientNavigationButton14.Name = "GradientNavigationButton14"
        Me.GradientNavigationButton14.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton14.TabIndex = 13
        Me.GradientNavigationButton14.Text = "Neuro | Psychiatric"
        '
        'GradientNavigationButton13
        '
        Me.GradientNavigationButton13.Image = CType(resources.GetObject("GradientNavigationButton13.Image"), System.Drawing.Image)
        Me.GradientNavigationButton13.ImageIndex = 3
        Me.GradientNavigationButton13.ImageList = Me.ImageList1
        Me.GradientNavigationButton13.Location = New System.Drawing.Point(12, 197)
        Me.GradientNavigationButton13.Name = "GradientNavigationButton13"
        Me.GradientNavigationButton13.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton13.TabIndex = 12
        Me.GradientNavigationButton13.Text = "Vascular"
        '
        'GradientNavigationButton12
        '
        Me.GradientNavigationButton12.Image = CType(resources.GetObject("GradientNavigationButton12.Image"), System.Drawing.Image)
        Me.GradientNavigationButton12.ImageIndex = 7
        Me.GradientNavigationButton12.ImageList = Me.ImageList1
        Me.GradientNavigationButton12.Location = New System.Drawing.Point(12, 522)
        Me.GradientNavigationButton12.Name = "GradientNavigationButton12"
        Me.GradientNavigationButton12.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton12.TabIndex = 11
        Me.GradientNavigationButton12.Text = "Immunological"
        '
        'GradientNavigationButton10
        '
        Me.GradientNavigationButton10.Image = CType(resources.GetObject("GradientNavigationButton10.Image"), System.Drawing.Image)
        Me.GradientNavigationButton10.ImageIndex = 8
        Me.GradientNavigationButton10.ImageList = Me.ImageList1
        Me.GradientNavigationButton10.Location = New System.Drawing.Point(12, 156)
        Me.GradientNavigationButton10.Name = "GradientNavigationButton10"
        Me.GradientNavigationButton10.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton10.TabIndex = 9
        Me.GradientNavigationButton10.Text = "Cardiovascular"
        '
        'GradientNavigationButton9
        '
        Me.GradientNavigationButton9.Image = CType(resources.GetObject("GradientNavigationButton9.Image"), System.Drawing.Image)
        Me.GradientNavigationButton9.ImageIndex = 10
        Me.GradientNavigationButton9.ImageList = Me.ImageList1
        Me.GradientNavigationButton9.Location = New System.Drawing.Point(12, 440)
        Me.GradientNavigationButton9.Name = "GradientNavigationButton9"
        Me.GradientNavigationButton9.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton9.TabIndex = 8
        Me.GradientNavigationButton9.Text = "Hematological"
        '
        'GradientNavigationButton7
        '
        Me.GradientNavigationButton7.Image = CType(resources.GetObject("GradientNavigationButton7.Image"), System.Drawing.Image)
        Me.GradientNavigationButton7.ImageIndex = 4
        Me.GradientNavigationButton7.ImageList = Me.ImageList1
        Me.GradientNavigationButton7.Location = New System.Drawing.Point(12, 112)
        Me.GradientNavigationButton7.Name = "GradientNavigationButton7"
        Me.GradientNavigationButton7.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton7.TabIndex = 6
        Me.GradientNavigationButton7.Text = "Respiratory"
        '
        'GradientNavigationButton6
        '
        Me.GradientNavigationButton6.Image = CType(resources.GetObject("GradientNavigationButton6.Image"), System.Drawing.Image)
        Me.GradientNavigationButton6.ImageIndex = 2
        Me.GradientNavigationButton6.ImageList = Me.ImageList1
        Me.GradientNavigationButton6.Location = New System.Drawing.Point(12, 399)
        Me.GradientNavigationButton6.Name = "GradientNavigationButton6"
        Me.GradientNavigationButton6.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton6.TabIndex = 5
        Me.GradientNavigationButton6.Text = "Musculoskeletal"
        '
        'GradientNavigationButton5
        '
        Me.GradientNavigationButton5.ImageList = Me.ImageList1
        Me.GradientNavigationButton5.Location = New System.Drawing.Point(12, 276)
        Me.GradientNavigationButton5.Name = "GradientNavigationButton5"
        Me.GradientNavigationButton5.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton5.TabIndex = 4
        Me.GradientNavigationButton5.Text = "Genitourinary"
        '
        'GradientNavigationButton4
        '
        Me.GradientNavigationButton4.Image = CType(resources.GetObject("GradientNavigationButton4.Image"), System.Drawing.Image)
        Me.GradientNavigationButton4.ImageIndex = 5
        Me.GradientNavigationButton4.ImageList = Me.ImageList1
        Me.GradientNavigationButton4.Location = New System.Drawing.Point(12, 71)
        Me.GradientNavigationButton4.Name = "GradientNavigationButton4"
        Me.GradientNavigationButton4.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton4.TabIndex = 3
        Me.GradientNavigationButton4.Text = "HEENT"
        '
        'GradientNavigationButton3
        '
        Me.GradientNavigationButton3.Location = New System.Drawing.Point(12, 358)
        Me.GradientNavigationButton3.Name = "GradientNavigationButton3"
        Me.GradientNavigationButton3.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton3.TabIndex = 2
        Me.GradientNavigationButton3.Text = "Dermatologic"
        '
        'GradientNavigationButton2
        '
        Me.GradientNavigationButton2.Image = CType(resources.GetObject("GradientNavigationButton2.Image"), System.Drawing.Image)
        Me.GradientNavigationButton2.ImageKey = "gastrointestinal.bmp"
        Me.GradientNavigationButton2.ImageList = Me.ImageList1
        Me.GradientNavigationButton2.Location = New System.Drawing.Point(12, 235)
        Me.GradientNavigationButton2.Name = "GradientNavigationButton2"
        Me.GradientNavigationButton2.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton2.TabIndex = 1
        Me.GradientNavigationButton2.Text = "Gastrointestinal"
        '
        'GradientNavigationButton1
        '
        Me.GradientNavigationButton1.Image = CType(resources.GetObject("GradientNavigationButton1.Image"), System.Drawing.Image)
        Me.GradientNavigationButton1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.GradientNavigationButton1.ImageIndex = 0
        Me.GradientNavigationButton1.ImageList = Me.ImageList1
        Me.GradientNavigationButton1.Location = New System.Drawing.Point(12, 30)
        Me.GradientNavigationButton1.Name = "GradientNavigationButton1"
        Me.GradientNavigationButton1.Size = New System.Drawing.Size(165, 35)
        Me.GradientNavigationButton1.TabIndex = 0
        Me.GradientNavigationButton1.Text = "Constitutional"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.MMCHRosAndGenDataGridView)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdROS)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1001, 720)
        Me.SplitContainer1.SplitterDistance = 187
        Me.SplitContainer1.TabIndex = 1
        '
        'MMCHRosAndGenDataGridView
        '
        Me.MMCHRosAndGenDataGridView.AllowUserToAddRows = False
        Me.MMCHRosAndGenDataGridView.AllowUserToDeleteRows = False
        Me.MMCHRosAndGenDataGridView.AutoGenerateColumns = False
        Me.MMCHRosAndGenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Heading, Me.Negative, Me.Positive, Me.SubCategory, Me.Discription, Me.Describe, Me.DataGridViewTextBoxColumn2, Me.Category, Me.DataGridViewTextBoxColumn1, Me.detailtopost, Me.HideC})
        Me.MMCHRosAndGenDataGridView.DataSource = Me.MMCHRosAndGenBindingSource
        Me.MMCHRosAndGenDataGridView.Location = New System.Drawing.Point(5, 5)
        Me.MMCHRosAndGenDataGridView.Name = "MMCHRosAndGenDataGridView"
        Me.MMCHRosAndGenDataGridView.Size = New System.Drawing.Size(797, 623)
        Me.MMCHRosAndGenDataGridView.TabIndex = 7
        '
        'MMCHRosAndGenBindingSource
        '
        Me.MMCHRosAndGenBindingSource.DataMember = "MMCHRosAndGen"
        Me.MMCHRosAndGenBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdROS
        '
        Me.cmdROS.Location = New System.Drawing.Point(694, 634)
        Me.cmdROS.Name = "cmdROS"
        Me.cmdROS.Size = New System.Drawing.Size(111, 81)
        Me.cmdROS.TabIndex = 6
        Me.cmdROS.Text = "Post ROS"
        Me.cmdROS.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 634)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(682, 81)
        Me.TextBox1.TabIndex = 5
        '
        'MMCHRosAndGenTableAdapter
        '
        Me.MMCHRosAndGenTableAdapter.ClearBeforeFill = True
        '
        'Heading
        '
        Me.Heading.DataPropertyName = "Heading"
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        Me.Heading.DefaultCellStyle = DataGridViewCellStyle1
        Me.Heading.HeaderText = "Heading"
        Me.Heading.Name = "Heading"
        Me.Heading.ReadOnly = True
        '
        'Negative
        '
        Me.Negative.DataPropertyName = "Negative"
        Me.Negative.HeaderText = "Negative"
        Me.Negative.Name = "Negative"
        Me.Negative.Width = 50
        '
        'Positive
        '
        Me.Positive.DataPropertyName = "Positive"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.NullValue = False
        Me.Positive.DefaultCellStyle = DataGridViewCellStyle2
        Me.Positive.HeaderText = "Positive"
        Me.Positive.Name = "Positive"
        Me.Positive.Width = 50
        '
        'SubCategory
        '
        Me.SubCategory.DataPropertyName = "SubCategory"
        Me.SubCategory.HeaderText = "Sub Category"
        Me.SubCategory.Name = "SubCategory"
        Me.SubCategory.ReadOnly = True
        Me.SubCategory.Visible = False
        '
        'Discription
        '
        Me.Discription.DataPropertyName = "Discription"
        Me.Discription.HeaderText = "Description"
        Me.Discription.Name = "Discription"
        Me.Discription.ReadOnly = True
        Me.Discription.Width = 190
        '
        'Describe
        '
        Me.Describe.DataPropertyName = "Describe"
        Me.Describe.HeaderText = "Describe"
        Me.Describe.Name = "Describe"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ScreenLocation"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Screen Location"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Category
        '
        Me.Category.DataPropertyName = "Category"
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "qid"
        Me.DataGridViewTextBoxColumn1.HeaderText = "qid"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'detailtopost
        '
        Me.detailtopost.DataPropertyName = "detailtopost"
        Me.detailtopost.HeaderText = "detailtopost"
        Me.detailtopost.Name = "detailtopost"
        Me.detailtopost.Visible = False
        '
        'HideC
        '
        Me.HideC.DataPropertyName = "HideC"
        Me.HideC.HeaderText = "HideC"
        Me.HideC.Name = "HideC"
        Me.HideC.Width = 50
        '
        'RosGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 720)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "RosGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ros General"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.MMCHRosAndGenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCHRosAndGenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GradientNavigationButton14 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton13 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton12 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton11 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton10 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton9 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton8 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton7 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GradientNavigationButton6 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton5 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton4 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton3 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton2 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton1 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmdROS As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MMCHRosAndGenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMCHRosAndGenTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMCHRosAndGenTableAdapter
    Friend WithEvents MMCHRosAndGenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Heading As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Negative As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Positive As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SubCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Discription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Describe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detailtopost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HideC As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
