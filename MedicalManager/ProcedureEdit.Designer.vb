<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcedureEdit
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
        Dim Label As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.TBAmount = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TBDesc = New System.Windows.Forms.TextBox()
        Me.TBCode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBId = New System.Windows.Forms.TextBox()
        Label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBAmount
        '
        Me.TBAmount.Location = New System.Drawing.Point(229, 113)
        Me.TBAmount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBAmount.Name = "TBAmount"
        Me.TBAmount.Size = New System.Drawing.Size(132, 23)
        Me.TBAmount.TabIndex = 0
        '
        'Label
        '
        Label.AutoSize = True
        Label.Location = New System.Drawing.Point(161, 116)
        Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label.Name = "Label"
        Label.Size = New System.Drawing.Size(60, 17)
        Label.TabIndex = 5
        Label.Text = "Amount:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Location = New System.Drawing.Point(202, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(6, 26)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(83, 17)
        Label1.TabIndex = 8
        Label1.Text = "Description:"
        '
        'TBDesc
        '
        Me.TBDesc.Location = New System.Drawing.Point(91, 23)
        Me.TBDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDesc.Name = "TBDesc"
        Me.TBDesc.Size = New System.Drawing.Size(257, 23)
        Me.TBDesc.TabIndex = 7
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(356, 26)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(64, 17)
        Label2.TabIndex = 10
        Label2.Text = "Dr Code:"
        '
        'TBCode
        '
        Me.TBCode.Location = New System.Drawing.Point(424, 23)
        Me.TBCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCode.Name = "TBCode"
        Me.TBCode.Size = New System.Drawing.Size(87, 23)
        Me.TBCode.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBCode)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.TBDesc)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 69)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'TBId
        '
        Me.TBId.Location = New System.Drawing.Point(13, 257)
        Me.TBId.Margin = New System.Windows.Forms.Padding(4)
        Me.TBId.Name = "TBId"
        Me.TBId.Size = New System.Drawing.Size(57, 23)
        Me.TBId.TabIndex = 9
        Me.TBId.Visible = False
        '
        'ProcedureEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 293)
        Me.Controls.Add(Me.TBId)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label)
        Me.Controls.Add(Me.TBAmount)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ProcedureEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProcedureEdit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBAmount As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TBDesc As TextBox
    Friend WithEvents TBCode As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBId As TextBox
End Class
