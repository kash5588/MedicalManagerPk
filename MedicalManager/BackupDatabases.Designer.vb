<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupDatabases
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
        Me.btnBackup = New System.Windows.Forms.Button
        Me.lblPercentComplete = New System.Windows.Forms.Label
        Me.txtServerPath = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSqlScript = New System.Windows.Forms.TextBox
        Me.btnRun = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.proRestoreDatabase = New System.Windows.Forms.ProgressBar
        Me.txtServerName = New System.Windows.Forms.ComboBox
        Me.btnLoadServers = New System.Windows.Forms.Button
        Me.txtDatabaseName = New System.Windows.Forms.ComboBox
        Me.btnLoadDatabases = New System.Windows.Forms.Button
        Me.brnBrowse = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnBackup
        '
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.Color.Red
        Me.btnBackup.Location = New System.Drawing.Point(441, 86)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(127, 22)
        Me.btnBackup.TabIndex = 0
        Me.btnBackup.Text = "Backup Database"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'lblPercentComplete
        '
        Me.lblPercentComplete.AutoSize = True
        Me.lblPercentComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentComplete.ForeColor = System.Drawing.Color.Red
        Me.lblPercentComplete.Location = New System.Drawing.Point(206, 95)
        Me.lblPercentComplete.Name = "lblPercentComplete"
        Me.lblPercentComplete.Size = New System.Drawing.Size(0, 13)
        Me.lblPercentComplete.TabIndex = 1
        '
        'txtServerPath
        '
        Me.txtServerPath.Location = New System.Drawing.Point(87, 62)
        Me.txtServerPath.Name = "txtServerPath"
        Me.txtServerPath.Size = New System.Drawing.Size(447, 20)
        Me.txtServerPath.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Server Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Database Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Backup Path"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(560, 10)
        Me.Label5.TabIndex = 8
        '
        'txtSqlScript
        '
        Me.txtSqlScript.ForeColor = System.Drawing.Color.Red
        Me.txtSqlScript.Location = New System.Drawing.Point(8, 193)
        Me.txtSqlScript.Multiline = True
        Me.txtSqlScript.Name = "txtSqlScript"
        Me.txtSqlScript.Size = New System.Drawing.Size(560, 172)
        Me.txtSqlScript.TabIndex = 9
        '
        'btnRun
        '
        Me.btnRun.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRun.Location = New System.Drawing.Point(444, 367)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(124, 22)
        Me.btnRun.TabIndex = 10
        Me.btnRun.Text = "Run Script"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(12, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(303, 26)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "All scripts must be pre-approved by MedicalManager" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Failure to do so may have ser" & _
            "ious implications." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblUser
        '
        Me.lblUser.ForeColor = System.Drawing.Color.Red
        Me.lblUser.Location = New System.Drawing.Point(336, 174)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(232, 16)
        Me.lblUser.TabIndex = 12
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'proRestoreDatabase
        '
        Me.proRestoreDatabase.Location = New System.Drawing.Point(8, 112)
        Me.proRestoreDatabase.Name = "proRestoreDatabase"
        Me.proRestoreDatabase.Size = New System.Drawing.Size(560, 22)
        Me.proRestoreDatabase.TabIndex = 13
        '
        'txtServerName
        '
        Me.txtServerName.FormattingEnabled = True
        Me.txtServerName.Location = New System.Drawing.Point(87, 9)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(387, 21)
        Me.txtServerName.TabIndex = 14
        '
        'btnLoadServers
        '
        Me.btnLoadServers.Location = New System.Drawing.Point(474, 8)
        Me.btnLoadServers.Name = "btnLoadServers"
        Me.btnLoadServers.Size = New System.Drawing.Size(94, 22)
        Me.btnLoadServers.TabIndex = 15
        Me.btnLoadServers.Text = "Load Servers"
        Me.btnLoadServers.UseVisualStyleBackColor = True
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.FormattingEnabled = True
        Me.txtDatabaseName.Location = New System.Drawing.Point(87, 35)
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.Size = New System.Drawing.Size(387, 21)
        Me.txtDatabaseName.TabIndex = 16
        '
        'btnLoadDatabases
        '
        Me.btnLoadDatabases.Location = New System.Drawing.Point(474, 34)
        Me.btnLoadDatabases.Name = "btnLoadDatabases"
        Me.btnLoadDatabases.Size = New System.Drawing.Size(94, 22)
        Me.btnLoadDatabases.TabIndex = 17
        Me.btnLoadDatabases.Text = "Load Databases"
        Me.btnLoadDatabases.UseVisualStyleBackColor = True
        '
        'brnBrowse
        '
        Me.brnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnBrowse.Location = New System.Drawing.Point(535, 62)
        Me.brnBrowse.Name = "brnBrowse"
        Me.brnBrowse.Size = New System.Drawing.Size(33, 20)
        Me.brnBrowse.TabIndex = 18
        Me.brnBrowse.Text = "..."
        Me.brnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.brnBrowse.UseVisualStyleBackColor = True
        '
        'BackupDatabases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 392)
        Me.Controls.Add(Me.brnBrowse)
        Me.Controls.Add(Me.btnLoadDatabases)
        Me.Controls.Add(Me.txtDatabaseName)
        Me.Controls.Add(Me.btnLoadServers)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.proRestoreDatabase)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.txtSqlScript)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtServerPath)
        Me.Controls.Add(Me.lblPercentComplete)
        Me.Controls.Add(Me.btnBackup)
        Me.Name = "BackupDatabases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Databases"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents lblPercentComplete As System.Windows.Forms.Label
    Friend WithEvents txtServerPath As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSqlScript As System.Windows.Forms.TextBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents proRestoreDatabase As System.Windows.Forms.ProgressBar
    Friend WithEvents txtServerName As System.Windows.Forms.ComboBox
    Friend WithEvents btnLoadServers As System.Windows.Forms.Button
    Friend WithEvents txtDatabaseName As System.Windows.Forms.ComboBox
    Friend WithEvents btnLoadDatabases As System.Windows.Forms.Button
    Friend WithEvents brnBrowse As System.Windows.Forms.Button
End Class
