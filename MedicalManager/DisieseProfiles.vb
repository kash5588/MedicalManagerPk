
Imports System.Data

Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration

Public Class DesieseProfiles

    Private Sub CCProfilesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCProfilesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CCProfilesBindingSource.EndEdit()
        Me.CCProfilesTableAdapter.Update(Me.DprofilesDataSet.CCProfiles)

    End Sub

    Private Sub DisieseProfiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet2.QIDs' table. You can move, or remove it, as needed.
        Me.QIDsTableAdapter.Fill(Me.MMDataDataSet2.QIDs)
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMCHROSandGenCat' table. You can move, or remove it, as needed.
        Me.MMCHROSandGenCatTableAdapter1.FillByCat(Me.MMDataDataSet1.MMCHROSandGenCat)
        'TODO: This line of code loads data into the 'MMDataDataSet.MMCHROSandGenCat' table. You can move, or remove it, as needed.
        'Me.MMCHROSandGenCatTableAdapter.FillByCat(Me.MMDataDataSet1.MMCHROSandGenCat)
        'TODO: This line of code loads data into the 'DprofilesDataSet.CCProfiles' table. You can move, or remove it, as needed.
        Me.CCProfilesTableAdapter.Fill(Me.DprofilesDataSet.CCProfiles)
        '  Me.MMCHROSandGenCatTableAdapter.FillbyCat(Me.DprofilesDataSet1.CCProfiles)
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDx.CheckedChanged
        Dim connString As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT  Code1, Description FROM MMDX order by Description", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMDX")
        DataGridViewPr.DataSource = ds.Tables("MMDX")
        ds.Dispose()
        cn.Close()
    End Sub

    Private Sub RadioButtonPr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonPr.CheckedChanged
        Dim connString As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT     Code, Description from  MMCHProcedure", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHProcedure")
        DataGridViewPr.DataSource = ds.Tables("MMCHProcedure")
        ds.Dispose()
        cn.Close()
    End Sub






    'Private Sub DataGridViewPr_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewPr.DoubleClick

    '    If RadioButtonDx.Checked = True Then


    '        Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
    '        newRow("CHARTNUMBER") = ChartNumberTextBox.Text
    '        newRow("Date") = System.DateTime.Now.Date
    '        newRow("Type") = "DX"
    '        newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
    '        newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""

    '        Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

    '    ElseIf RadioButtonPr.Checked = True Then

    '        Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
    '        newRow("CHARTNUMBER") = ChartNumberTextBox.Text
    '        newRow("Date") = System.DateTime.Now.Date
    '        newRow("Type") = "Procedures"
    '        newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
    '        newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
    '        Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

    '    ElseIf RadioButtonLT.Checked = True Then

    '        Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
    '        newRow("CHARTNUMBER") = ChartNumberTextBox.Text
    '        newRow("Date") = System.DateTime.Now.Date
    '        newRow("Type") = "Lab Test"
    '        newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
    '        newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
    '        Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

    '    ElseIf RadioButtonMT.Checked = True Then

    '        Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
    '        newRow("CHARTNUMBER") = ChartNumberTextBox.Text
    '        newRow("Date") = System.DateTime.Now.Date
    '        newRow("Type") = "Medical Test"
    '        newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
    '        newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
    '        Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

    '    ElseIf RadioButtonTestImaging.Checked = True Then

    '        Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
    '        newRow("CHARTNUMBER") = ChartNumberTextBox.Text
    '        newRow("Date") = System.DateTime.Now.Date
    '        newRow("Type") = "Images"
    '        newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
    '        newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(2).Value & ""
    '        Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)


    '    End If



    'End Sub

    Private Sub RadioButtonMT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMT.CheckedChanged
        Dim connString As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT     id, TestType, TestName FROM   MMChartTestMedical", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMChartTestMedical")
        DataGridViewPr.DataSource = ds.Tables("MMChartTestMedical")
        ds.Dispose()
        cn.Close()
    End Sub

    Private Sub RadioButtonTestImaging_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonTestImaging.CheckedChanged
        Dim connString As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT     id, TestType, TestName FROM         MMChartTestImaging", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMChartTestImaging")
        DataGridViewPr.DataSource = ds.Tables("MMChartTestImaging")
        ds.Dispose()
        cn.Close()
    End Sub


    Private Sub Profile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Profile.CheckedChanged
        Dim connString As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT  qid,ScreenLocation,Category,SubCategory,Discription,Negative,Positive FROM   MMCHRosAndGen ", cn)
        ' Dim cmd As New SqlCommand("SELECT  qid,ScreenLocation,Category,SubCategory,Discription,Negative,Positive FROM   MMCHRosAndGen where qid In(" + TextBox15.Text + ")", cn)


        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")
        DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim connString As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT  qid,ScreenLocation,Category,SubCategory,Discription,Negative,Positive FROM   MMCHRosAndGen  where category='" + ComboBox1.Text + "'", cn)

        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")
        DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")


    End Sub

   

    Private Sub DataGridViewPr_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewPr.DoubleClick
        Dim codes As String
        codes = codesTextbox.Text
        If codesTextbox.Text = "" Then
            codesTextbox.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value.ToString()
        Else
            codesTextbox.Text = codes + "," + DataGridViewPr.SelectedRows(0).Cells(0).Value.ToString
        End If
        Dim newRow As DataRow = Me.MMDataDataSet2.QIDs.NewRow
        newRow("QID") = DataGridViewPr.SelectedRows(0).Cells(0).Value.ToString
        newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(4).Value.ToString
        newRow("ChiefComplaint") = CHIEF_COMPLAINTTextBox.Text
        newRow("TemplateName") = TemplateNameTextBox.Text
        newRow("SortOrder") = "3000"
        newRow("Category") = ComboBox1.Text

        Me.MMDataDataSet2.QIDs.Rows.Add(newRow)
        Me.QIDsTableAdapter.Update(Me.MMDataDataSet2.QIDs)
    End Sub

    
    Private Sub DataGridViewPr_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewPr.CellContentClick
        CCProfilesBindingSource.MoveNext()
    End Sub

End Class


'select Category from dbo.MMCHRO SandGenCat where substring(Category,1,3)in('ROS','PE-')