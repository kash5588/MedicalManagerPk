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
        Me.components = New System.ComponentModel.Container
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.MMCHROSandGenCatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.MMCHROSandGenCatTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHROSandGenCatTableAdapter
        Me.TreeView2 = New System.Windows.Forms.TreeView
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HPITableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.HPITableAdapter
        CType(Me.MMCHROSandGenCatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.MMCHROSandGenCatBindingSource, "Category", True))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.Location = New System.Drawing.Point(60, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(146, 444)
        Me.TreeView1.TabIndex = 0
        '
        'MMCHROSandGenCatBindingSource
        '
        Me.MMCHROSandGenCatBindingSource.DataMember = "MMCHROSandGenCat"
        Me.MMCHROSandGenCatBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(212, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(252, 444)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'MMCHROSandGenCatTableAdapter
        '
        Me.MMCHROSandGenCatTableAdapter.ClearBeforeFill = True
        '
        'TreeView2
        '
        Me.TreeView2.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BindingSource1, "SubCategory", True))
        Me.TreeView2.Location = New System.Drawing.Point(470, 12)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(192, 444)
        Me.TreeView2.TabIndex = 2
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "HPI"
        Me.BindingSource1.DataSource = Me.MMDataDataSet1
        '
        'HPITableAdapter
        '
        Me.HPITableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 465)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MMCHROSandGenCatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMCHROSandGenCatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMCHROSandGenCatTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMCHROSandGenCatTableAdapter
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HPITableAdapter As MedicalManager.MMDataDataSet1TableAdapters.HPITableAdapter
End Class
