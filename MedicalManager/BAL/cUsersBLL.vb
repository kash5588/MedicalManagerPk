
Imports MedicalManager.MMDataDataSet2TableAdapters




<System.ComponentModel.DataObject()> _
Public Class cUsersBLL

    Private _UesrsAdapter As MMUsersTableAdapter = Nothing
    Protected ReadOnly Property Adapter() As MMUsersTableAdapter
        Get
            If _UesrsAdapter Is Nothing Then
                _UesrsAdapter = New MMUsersTableAdapter()
            End If

            Return _UesrsAdapter
        End Get
    End Property

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetCategories() As MMDataDataSet2.MMUsersDataTable
        Return Adapter.GetData()
    End Function

   
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetDataByNetworkUsername(ByVal NetUser As String) As MMDataDataSet2.MMUsersDataTable
        Return Adapter.GetDataByNetWorkUserId(NetUser)

    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
  Public Function GetDataByNetWorkUserIdAndPassword(ByVal NetUser As String, ByVal Password As String) As MMDataDataSet2.MMUsersDataTable
        Return Adapter.GetDataByNetWorkUserIdAndPassword(NetUser, Password)
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
   Public Function GetDataByUserIDAndPassword(ByVal NetUser As String, ByVal Password As String) As MMDataDataSet2.MMUsersDataTable
        Return Adapter.GetDataByNetworkUserIDAndPassword(NetUser, Password)
    End Function



    Public Function userIsAuthorized(ByVal ProcedureName As String) As Boolean


        Dim Permissions As String
        Dim Procedure As String
        Dim pieces() As String
        Dim IndexOf As Integer

        'Dim objUsers As Users
        'objUsers = New Users

        'Users objUsers=new Users()

        Dim dtUser As MMDataDataSet2.MMUsersDataTable = New MMDataDataSet2.MMUsersDataTable

        dtUser = GetDataByNetworkUsername(System.Environment.UserName)

        Permissions = Convert.ToString(dtUser.Rows(0)("Permissions"))
        Procedure = Convert.ToString(dtUser.Rows(0)("procedure_Name"))
        pieces = Procedure.Split("‰")
        IndexOf = Array.IndexOf(pieces, ProcedureName)

        If Permissions = "Y" And IndexOf <> -1 Then
            Return True
        Else : Return False
        End If
    End Function


    Public Function GetPermissions(ByVal password As String) As String


        Dim Permissions As String
        Dim Procedure As String
        Dim pieces() As String
        Dim IndexOf As Integer

        'Dim objUsers As Users
        'objUsers = New Users

        'Users objUsers=new Users()

        Dim dtUser As MMDataDataSet2.MMUsersDataTable = New MMDataDataSet2.MMUsersDataTable

        'dtUser = GetDataByNetworkUsername(System.Environment.UserName)


        dtUser = GetDataByUserIDAndPassword(System.Environment.UserName, password)
        If dtUser.Rows.Count = 0 Then
            MessageBox.Show("Incorrect username and/or password", "Re-enter username and password", MessageBoxButtons.OK)
            Return "N"
        Else

            Permissions = Convert.ToString(dtUser.Rows(0)("Permissions"))
            Procedure = Convert.ToString(dtUser.Rows(0)("procedure_Name"))
            'pieces = Procedure.Split(",")
            'IndexOf = Array.IndexOf(pieces, ProcedureName)

            If Permissions = "Y" Then
                If Procedure <> "" Then

                    Return Procedure
                    ' Return "N"

                Else
                    MessageBox.Show("You do not have permissions.", "", MessageBoxButtons.OK)
                    Return "N"
                End If
            End If
        End If
    End Function

    Public Function GetPermissionsforApp(ByVal UserName As String, ByVal Password As String) As String


        Dim Permissions As String
        Dim Procedure As String
        Dim pieces() As String
        Dim IndexOf As Integer

        'Dim objUsers As Users
        'objUsers = New Users

        'Users objUsers=new Users()

        Dim dtUser As MMDataDataSet2.MMUsersDataTable = New MMDataDataSet2.MMUsersDataTable
        dtUser = GetDataByNetWorkUserIdAndPassword(UserName, Password)
        ' dtUser = GetDataByNetworkUsername(System.Environment.UserName)

        Permissions = Convert.ToString(dtUser.Rows(0)("Permissions"))
        Procedure = Convert.ToString(dtUser.Rows(0)("procedure_Name"))
        'pieces = Procedure.Split(",")
        'IndexOf = Array.IndexOf(pieces, ProcedureName)

        If Permissions = "Y" Then
            If Procedure <> "" Then

                Return Procedure
                ' Return "N"

            Else
                Return "N"
            End If


        End If
    End Function


End Class