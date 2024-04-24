Imports System.Configuration
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Module CommonFunction
    'Function MDYToDMY(ByVal input As String) As String
    '    Return Regex.Replace(input, _
    '        "\b(?<month>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})\b", _
    '        "${day}-${month}-${year}")
    'End Function
    Public Permissions As String
    ' Public connString2 As String = "Data Source=MAINSERVER\SQLEXPRESS;Initial Catalog=MMData;User ID=sa;Password=abdullah"
    Public connString2 As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
    Public connStringDP As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.DprofilesConnectionString").ConnectionString
    Public globalTemplate As String
    Public globalChiefComplaint As String
    Public globalUser As String

    Public Function GetGeneralInfo(ByVal strKey As String) As String
        Dim strValue As String
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
End Module

'Dim oleDAGeneralInfo As New OleDbDataAdapter
'Dim dtGeneralInfo As New DataTable
'Dim row As DataRow
'Dim strTemp As String
'oleDAGeneralInfo.Fill(dtGeneralInfo, Dts.Variables("GeneralInfoRS").Value)
'For Each row In dtGeneralInfo.Rows

'Select Case row("GeneralInfoKey").ToString()

'Case "SMTP Server"

'Dts.Variables("User::SMTPServer").Value = row("GeneralInfoValue").ToString()

'Case "Email List"

'Dts.Variables("User::EmailList").Value = row("GeneralInfoValue").ToString()

'Case "ConnectionString"

'Dts.Variables("User::ConnectionString").Value = row("GeneralInfoValue").ToString()

'Case "ArchiveFolderPath"

'Dts.Variables("User::ArchivePath").Value = row("GeneralInfoValue").ToString()

'()

'End Select

'Next
