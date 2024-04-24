Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Smo

Public Class BackupDatabases

    Dim strBackupServer As String
    Dim strMMDataBackupPath As String
    Dim strMMDataBackupName As String

    Private Sub BackupDatabases_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
        strBackupServer = GetGeneralInfo("BackupServer")
        Dim prestrMMDataBackupPath As String = GetGeneralInfo("MMDataBackupPath")
        strMMDataBackupName = GetGeneralInfo("MMDataBackupName")
        strMMDataBackupPath = prestrMMDataBackupPath.Replace(".bak", "") & DateTime.Now.Month & DateTime.Now.Day & DateTime.Now.Year & ".bak"

        txtServerName.Text = strBackupServer
        txtDatabaseName.Text = strMMDataBackupName
        txtServerPath.Text = strMMDataBackupPath

        lblUser.Text = "Script executed by: " & globalUser
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        Try
            lblPercentComplete.Text = ""
            btnBackup.Enabled = False
            DoBackup()
            btnBackup.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ProgressEventHandler(ByVal sender As Object, ByVal e As PercentCompleteEventArgs)
        lblPercentComplete.Text = e.Percent.ToString + "% backup complete"
        Me.proRestoreDatabase.Value = e.Percent

    End Sub

    Private Function GetGeneralInfo(ByVal strKey As String) As String
        Dim strValue As String = ""
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("SELECT GeneralInfoValue FROM GeneralInfo WHERE GeneralInfoKey = '" & strKey.ToString & "'", cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            strValue = dr.Item(0).ToString
        End While
        cn.Close()
        Return strValue
    End Function

    Private Function DoBackup()
        Try

            'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            'Dim svr As Server = New Server(strBackupServer)
            'Dim bkp As Backup = New Backup()
            'bkp.Devices.AddDevice(strMMDataBackupPath, DeviceType.File)
            'bkp.Database = strMMDataBackupName
            'bkp.Action = BackupActionType.Database
            'bkp.Initialize = True
            'bkp.PercentCompleteNotification = 10
            'Me.proRestoreDatabase.Minimum = 0
            'Me.proRestoreDatabase.Value = 10
            'Me.proRestoreDatabase.Maximum = 100


            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim svr As Server = New Server(txtServerName.Text)
            Dim bkp As Backup = New Backup()
            bkp.Devices.AddDevice(txtServerPath.Text, DeviceType.File)
            bkp.Database = txtDatabaseName.Text
            bkp.Action = BackupActionType.Database
            bkp.Initialize = True
            bkp.PercentCompleteNotification = 10
            Me.proRestoreDatabase.Minimum = 0
            Me.proRestoreDatabase.Value = 10
            Me.proRestoreDatabase.Maximum = 100


            AddHandler bkp.PercentComplete, AddressOf ProgressEventHandler
            bkp.SqlBackup(svr)
            Me.Cursor = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click

        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String

        Try
            If txtSqlScript.Text <> "" Then
                sAction = "RunScript"
                pieces = Permissions.Split(",")
                IndexOf = Array.IndexOf(pieces, sAction)
                If IndexOf <> -1 Then
                Else
                    MessageBox.Show("User not authorized to run scripts.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                RunSqlScript()

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Function RunSqlScript()

        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        Dim cmd As New SqlCommand
        Dim strScript As String
        Dim intRowsAffected As Integer

        Try
            strScript = txtSqlScript.Text
            If strScript.ToString.ToLower.Contains("delete") = True Or strScript.ToString.ToLower.Contains("drop") = True Or strScript.ToString.ToLower.Contains("truncate") = True Then
                MessageBox.Show("Illegal Script", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                cn.Open()
                cmd = New SqlCommand(strScript, cn)
                intRowsAffected = cmd.ExecuteNonQuery()
                MessageBox.Show("Rows affected: " & intRowsAffected)
                cn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error running script")
        End Try
    End Function

    Private Sub btnLoadServers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadServers.Click
        LoadServers()
    End Sub

    Private Sub btnLoadDatabases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadDatabases.Click
        LoadDatabases()
    End Sub

    Private Function LoadDatabases()
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.txtDatabaseName.Items.Clear()
            Dim server As New Server(txtServerName.Text)

            For Each database As Database In server.Databases
                Me.txtDatabaseName.Items.Add(database.Name)
            Next
        Catch ex As Exception
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Private Sub LoadServers()

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim servers As New DataTable()
            servers = SmoApplication.EnumAvailableSqlServers(True)
            Me.txtServerName.Items.Clear()
            For Each server As DataRow In servers.Rows
                Me.txtServerName.Items.Add(server.Item("Name"))
            Next
        Catch ex As Exception
            Return
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub brnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnBrowse.Click
        Dim objOpenFileDialog As New OpenFileDialog

        With objOpenFileDialog
            .Filter = "BAK File (*.bak)|*.bak"
            .FilterIndex = 1
            .Title = "Open File Dialog"
            .InitialDirectory = "C:\Program Files\Microsoft Sql Server\"
        End With

        If objOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim allText As String
            Try
                txtServerPath.Text = objOpenFileDialog.FileName
            Catch fileException As Exception
                Throw fileException
            End Try
        End If

        objOpenFileDialog.Dispose()
        objOpenFileDialog = Nothing
    End Sub
End Class



'RESTORE DATABASE DBName FROM DISK='d:\files\Backups\DBName.bak' WITH REPLACE





