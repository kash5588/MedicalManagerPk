<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulas
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
            Me.T1 = New System.Windows.Forms.TextBox
            Me.T2 = New System.Windows.Forms.TextBox
            Me.T3 = New System.Windows.Forms.TextBox
            Me.T4 = New System.Windows.Forms.TextBox
            Me.T5 = New System.Windows.Forms.TextBox
            Me.Button1 = New System.Windows.Forms.Button
            Me.ListBox1 = New System.Windows.Forms.ListBox
            Me.T6 = New System.Windows.Forms.TextBox
            Me.T7 = New System.Windows.Forms.TextBox
            Me.SuspendLayout()
            '
            'T1
            '
            Me.T1.Location = New System.Drawing.Point(12, 24)
            Me.T1.Name = "T1"
            Me.T1.Size = New System.Drawing.Size(100, 20)
            Me.T1.TabIndex = 0
            '
            'T2
            '
            Me.T2.Location = New System.Drawing.Point(129, 24)
            Me.T2.Name = "T2"
            Me.T2.Size = New System.Drawing.Size(100, 20)
            Me.T2.TabIndex = 1
            '
            'T3
            '
            Me.T3.Location = New System.Drawing.Point(247, 24)
            Me.T3.Name = "T3"
            Me.T3.Size = New System.Drawing.Size(100, 20)
            Me.T3.TabIndex = 2
            '
            'T4
            '
            Me.T4.Location = New System.Drawing.Point(353, 24)
            Me.T4.Name = "T4"
            Me.T4.Size = New System.Drawing.Size(100, 20)
            Me.T4.TabIndex = 3
            '
            'T5
            '
            Me.T5.Location = New System.Drawing.Point(459, 24)
            Me.T5.Name = "T5"
            Me.T5.Size = New System.Drawing.Size(100, 20)
            Me.T5.TabIndex = 4
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(12, 108)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(547, 23)
            Me.Button1.TabIndex = 6
            Me.Button1.Text = "Button1"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'ListBox1
            '
            Me.ListBox1.FormattingEnabled = True
            Me.ListBox1.Items.AddRange(New Object() {"T1.Text", "T2.Text", "T3.Text", "T4.Text", "T5.Text", "T6.Text", "=", "*", "/"})
            Me.ListBox1.Location = New System.Drawing.Point(247, 155)
            Me.ListBox1.Name = "ListBox1"
            Me.ListBox1.Size = New System.Drawing.Size(297, 95)
            Me.ListBox1.TabIndex = 7
            '
            'T6
            '
            Me.T6.Location = New System.Drawing.Point(12, 82)
            Me.T6.Name = "T6"
            Me.T6.Size = New System.Drawing.Size(547, 20)
            Me.T6.TabIndex = 5
            '
            'T7
            '
            Me.T7.Location = New System.Drawing.Point(19, 144)
            Me.T7.Name = "T7"
            Me.T7.Size = New System.Drawing.Size(209, 20)
            Me.T7.TabIndex = 8
            '
            'Formulas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(613, 259)
            Me.Controls.Add(Me.T7)
            Me.Controls.Add(Me.ListBox1)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.T6)
            Me.Controls.Add(Me.T5)
            Me.Controls.Add(Me.T4)
            Me.Controls.Add(Me.T3)
            Me.Controls.Add(Me.T2)
            Me.Controls.Add(Me.T1)
            Me.Location = New System.Drawing.Point(205, 85)
            Me.Name = "Formulas"
            Me.Text = "Formulas"
            Me.ResumeLayout(False)
            Me.PerformLayout()

      End Sub
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents T4 As System.Windows.Forms.TextBox
    Friend WithEvents T5 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents T6 As System.Windows.Forms.TextBox
    Friend WithEvents T7 As System.Windows.Forms.TextBox
End Class
