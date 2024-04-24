<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMUpdate
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
        Me.btnCheckForUpdate = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnCheckForUpdate
        '
        Me.btnCheckForUpdate.Location = New System.Drawing.Point(12, 12)
        Me.btnCheckForUpdate.Name = "btnCheckForUpdate"
        Me.btnCheckForUpdate.Size = New System.Drawing.Size(102, 24)
        Me.btnCheckForUpdate.TabIndex = 0
        Me.btnCheckForUpdate.Text = "Check for update"
        Me.btnCheckForUpdate.UseVisualStyleBackColor = True
        '
        'MMUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 51)
        Me.Controls.Add(Me.btnCheckForUpdate)
        Me.Name = "MMUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MMUpdate"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCheckForUpdate As System.Windows.Forms.Button
End Class
