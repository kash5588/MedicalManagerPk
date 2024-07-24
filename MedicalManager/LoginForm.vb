Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class LoginForm
    Dim trycount As Integer

    Private Sub LoginForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        LoadPracticeName()
        UsernameTextBox.Text = "a"
        PasswordTextBox.Text = "a"
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Try
            Dim Users As New cUsersBLL
            'Permissions = Users.GetPermissions()
            Permissions = Users.GetPermissionsforApp(UsernameTextBox.Text, PasswordTextBox.Text)
            globalUser = UsernameTextBox.Text


            If Permissions = "N" Or Permissions = "" Then
                Me.Close()
                End
            Else
                Me.Close()
            End If

        Catch ex As SqlException
            System.Windows.Forms.MessageBox.Show(ex.ToString)

        Catch ex As System.Exception
            trycount = trycount + 1
            System.Windows.Forms.MessageBox.Show("Username and/or password is incorrect." & Environment.NewLine & Environment.NewLine & "                " & trycount & " failed attempt(s).")
            If trycount = 3 Then
                End
            End If
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub LoginForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Permissions = "" Then
            End
        End If
    End Sub

    Private Function LoadPracticeName()


        Dim strValue As String
        strValue = GetGeneralInfo("PracticeName")
        If strValue <> "" Then
            lblPracticeName.Text = strValue
            lblLicensedTo.Text = "Licenced To: " & strValue
        Else
            ' lblPracticeName.Text = "UNLICENSED"
            lblLicensedTo.Text = "UNLICENSED"
        End If

    End Function


End Class
