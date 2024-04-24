Imports System.IO

Public Class MMUpdate

    Private Sub MMUpdate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnCheckForUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckForUpdate.Click
        CheckForUpdate()
    End Sub


    Private Function CheckForUpdate()
        Dim result1 As DialogResult = Windows.Forms.DialogResult.No
        Dim strNewFile As String
        Dim strOldFile As String

        strNewFile = GetGeneralInfo("NewVersionPath")
        strOldFile = Application.ExecutablePath


        Dim dtNew As DateTime = File.GetLastWriteTime(strNewFile)
        Dim dtOld As DateTime = File.GetLastWriteTime(strOldFile)

        If dtNew > dtOld Then
            result1 = MessageBox.Show("Update Available- Version " & dtNew & Environment.NewLine & "Update now?", "New Updates", MessageBoxButtons.YesNo)
        Else
            MessageBox.Show("No version updates at this time.")
        End If

        If result1 = Windows.Forms.DialogResult.Yes Then
            Dim strMMUpdaterPath As String = GetGeneralInfo("MMUpdaterPath")
            Shell(strMMUpdaterPath, AppWinStyle.NormalNoFocus)
        End If

    End Function




End Class





'    Dim myBuildInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
'    Dim strFileVersionBefore As String
'    strFileVersionBefore = myBuildInfo.FileVersion
'    Dim strlastdot As Integer = strFileVersionBefore.LastIndexOf(".")
'    strlastdot += 1
'    Dim strstrFileVersionBefore As String = strFileVersionBefore.Substring(strlastdot, strFileVersionBefore.Length - strlastdot)
'    MessageBox.Show(strstrFileVersionBefore)
'    Dim newversion As String = CheckForUpdate()

'    If newversion < strstrFileVersionBefore Then
'        result1 = MessageBox.Show("Update Available- Version 1.0.0." & newversion & Environment.NewLine & "Update now?", "New Updates", MessageBoxButtons.YesNo)
'    Else
'        MessageBox.Show("No version updates at this time")
'    End If

'    If result1 = Windows.Forms.DialogResult.Yes Then
'        Dim strMMUpdaterPath As String = GetGeneralInfo("MMUpdaterPath")
'        Shell(strMMUpdaterPath, AppWinStyle.NormalNoFocus)
'    End If




'Private Function CheckForUpdate() As String
'    Dim strNewVersion As String = GetGeneralInfo("NewVersionPath")
'    Dim myBuildInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(strNewVersion)
'    Dim strFileVersionAfter As String
'    strFileVersionAfter = myBuildInfo.FileVersion
'    Dim strlastdot As Integer = strFileVersionAfter.LastIndexOf(".")
'    strlastdot += 1
'    Dim strstrFileVersionAfter As String = strFileVersionAfter.Substring(strlastdot, strFileVersionAfter.Length - strlastdot)
'    MessageBox.Show(strstrFileVersionAfter)
'    Return strstrFileVersionAfter
'End Function