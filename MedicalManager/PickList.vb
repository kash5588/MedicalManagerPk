Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data

Public Class PickList

    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(15) As String
    Dim myBindingSource As New BindingSource()

    Private Sub PickList_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtFind.Focus()
    End Sub


    Private Sub PatientPickList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMPhysion' table. You can move, or remove it, as needed.
        Me.MMPhysionTableAdapter.Fill(Me.MMDataDataSet1.MMPhysion)
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMPATIENT' table. You can move, or remove it, as needed.
        Me.MMPATIENTTableAdapter.Fill(Me.MMDataDataSet1.MMPATIENT)
        LoadLetterBody()
    End Sub

    Public Function LoadLetterBody() As String()
        Try

            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()

            Dim cmd As New SqlCommand("SELECT Category,SubCategory,Discription as Description FROM MMCHRosAndGen where Category = 'Letter Body' OR Category = 'Consents' order by category, subcategory", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            ' myBindingSource = New BindingSource()
            myBindingSource.DataSource = ds
            myBindingSource.DataMember = ds.Tables(0).TableName
            LetterBodyDataGridView.DataSource = myBindingSource
            Me.LetterBodyDataGridView.Columns(0).Width = 65
            Me.LetterBodyDataGridView.Columns(1).Width = 180
            Me.LetterBodyDataGridView.Columns(2).Width = 630
            ds.Dispose()
            cn.Close()
        Catch
        End Try
    End Function

    Public Function PatientShowPicklist() As String()
        Try
            TabControl1.TabPages(1).Enabled = False
            TabControl1.TabPages(2).Enabled = False
            TabControl1.SelectedIndex = 0
            cmbFilter.Text = "ChartNumber"

            Dim aRet(15) As String
            ' On Error GoTo EH
            aRet(0) = "N"
            mbPicklistmode = True
            mbSelected = False
            Me.ShowDialog()
            If mbSelected Then
                aRet(0) = "Y"
                aRet(1) = MMPATIENTDataGridView.SelectedRows(0).Cells("ChartNumberDataGridViewTextBoxColumn").Value & ""
                aRet(2) = MMPATIENTDataGridView.SelectedRows(0).Cells("LastNameDataGridViewTextBoxColumn").Value & ""
                aRet(3) = MMPATIENTDataGridView.SelectedRows(0).Cells("FirstNameDataGridViewTextBoxColumn").Value & ""
                aRet(4) = MMPATIENTDataGridView.SelectedRows(0).Cells("MiddleInitialDataGridViewTextBoxColumn").Value & ""
                aRet(5) = MMPATIENTDataGridView.SelectedRows(0).Cells("HomeePhoneDataGridViewTextBoxColumn").Value & ""
                aRet(6) = MMPATIENTDataGridView.SelectedRows(0).Cells("CellPhoneDataGridViewTextBoxColumn").Value & ""
                aRet(7) = MMPATIENTDataGridView.SelectedRows(0).Cells("DateofBirthDataGridViewTextBoxColumn").Value & ""

                aRet(8) = MMPATIENTDataGridView.SelectedRows(0).Cells("Street1DataGridViewTextBoxColumn").Value & ""
                aRet(9) = MMPATIENTDataGridView.SelectedRows(0).Cells("Street2DataGridViewTextBoxColumn").Value & ""
                aRet(10) = MMPATIENTDataGridView.SelectedRows(0).Cells("CityDataGridViewTextBoxColumn").Value & ""
                aRet(11) = MMPATIENTDataGridView.SelectedRows(0).Cells("StateDataGridViewTextBoxColumn").Value & ""
                aRet(12) = MMPATIENTDataGridView.SelectedRows(0).Cells("ZipCodeDataGridViewTextBoxColumn").Value & ""

            End If
            PatientShowPicklist = aRet
            Me.Close()
            Exit Function
        Catch
        End Try
    End Function

    Public Function PhysicianShowPicklist() As String()
        Try
            TabControl1.TabPages(0).Enabled = False
            TabControl1.TabPages(2).Enabled = False
            TabControl1.SelectedIndex = 1
            Dim aRet(15) As String
            ' On Error GoTo EH
            aRet(0) = "N"
            mbPicklistmode = True
            mbSelected = False
            Me.ShowDialog()
            If mbSelected Then
                aRet(0) = "Y"
                aRet(1) = MMPhysionDataGridView.SelectedRows(0).Cells("PhysicianCode").Value & ""
                aRet(2) = MMPhysionDataGridView.SelectedRows(0).Cells("PhysicianLastName").Value & ""
                aRet(3) = MMPhysionDataGridView.SelectedRows(0).Cells("PhysicianFirstName").Value & ""
                aRet(4) = MMPhysionDataGridView.SelectedRows(0).Cells("PhysicianMiddleInitial").Value & ""

                aRet(5) = MMPhysionDataGridView.SelectedRows(0).Cells("PhysicianStreet1").Value & ""
                aRet(6) = MMPhysionDataGridView.SelectedRows(0).Cells("PhysicianStreet2").Value & ""
                aRet(7) = MMPhysionDataGridView.SelectedRows(0).Cells("PhysicianCity").Value & ""
                aRet(8) = MMPhysionDataGridView.SelectedRows(0).Cells("PhysicianState").Value & ""
                aRet(9) = MMPhysionDataGridView.SelectedRows(0).Cells("PhysicianZip").Value & ""

            End If
            PhysicianShowPicklist = aRet
            Me.Close()
            Exit Function
        Catch
        End Try
    End Function

    Public Function LetterBodyShowPicklist() As String()
        Try
            TabControl1.TabPages(0).Enabled = False
            TabControl1.TabPages(1).Enabled = False
            TabControl1.SelectedIndex = 2
            cmbFilter.Text = "SubCategory"
            Dim aRet(15) As String
            ' On Error GoTo EH
            aRet(0) = "N"
            mbPicklistmode = True
            mbSelected = False
            Me.ShowDialog()
            If mbSelected Then
                aRet(0) = "Y"
                aRet(1) = LetterBodyDataGridView.SelectedRows(0).Cells("Description").Value & ""
                aRet(2) = LetterBodyDataGridView.SelectedRows(0).Cells("Category").Value & ""
            End If
            LetterBodyShowPicklist = aRet
            Me.Close()
            Exit Function
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Function



    Private Sub LetterBodyDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LetterBodyDataGridView.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub

    Private Sub MMPATIENTDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMPATIENTDataGridView.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub

    Private Sub MMPhysionDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMPhysionDataGridView.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub

    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

        If TabControl1.SelectedIndex = 0 Then

            If cmbFilter.Text <> "" Then
                Me.MMPATIENTBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
            End If
            Me.MMPATIENTBindingSource.Sort = "ChartNumber"
            MMPATIENTDataGridView.DataSource = Me.MMPATIENTBindingSource

        ElseIf TabControl1.SelectedIndex = 2 Then

            If cmbFilter.Text <> "" Then
                myBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
            End If
            Me.myBindingSource.Sort = "SubCategory"
            LetterBodyDataGridView.DataSource = Me.myBindingSource
        End If


    End Sub


End Class