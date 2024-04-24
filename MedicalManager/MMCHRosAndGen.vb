Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration

Public Class MMCHRosAndGen

    Dim iReorderCount As Integer = 0
    Dim iProfileReorderCount As Integer = 0

    Private Sub MMCHRosAndGenBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMCHRosAndGenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMCHRosAndGenBindingSource.EndEdit()
        Me.MMCHRosAndGenTableAdapter.Update(Me.MMDataDataSet1.MMCHRosAndGen)

    End Sub

    Private Sub MMCHRosAndGen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'DprofilesDataSet.CCProfiles' table. You can move, or remove it, as needed.
            Me.CCProfilesTableAdapter.Fill(Me.DprofilesDataSet.CCProfiles)
            'TODO: This line of code loads data into the 'MMDataDataSet2.QIDs' table. You can move, or remove it, as needed.
            '  Me.QIDsTableAdapter.Fill(Me.MMDataDataSet2.QIDs)
            'TODO: This line of code loads data into the 'MMDataDataSet1.MMCHROSandGenCat' table. You can move, or remove it, as needed.
            Me.MMCHROSandGenCatTableAdapter.Fill(Me.MMDataDataSet1.MMCHROSandGenCat)
            'TODO: This line of code loads data into the 'MMDataDataSet1.MMCHRosAndGen' table. You can move, or remove it, as needed.
            LoadCategoryCB()

            TabControl1.SelectedIndex = 1
            TabControl1.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmdSaveQids_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveQids.Click
        Me.Validate()
        Me.QIDsBindingSource.EndEdit()
        Me.QIDsTableAdapter.Update(Me.MMDataDataSet2.QIDs)

    End Sub

    Private Sub TemplateNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemplateNameTextBox.TextChanged
        Me.QIDsTableAdapter.FillByTemplateName(Me.MMDataDataSet2.QIDs, TemplateNameTextBox.Text)
    End Sub

   

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Other..." Then
            cboOther.Visible = True
            Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, cboOther.Text)
        Else
            cboOther.Visible = False
            If ComboBox1.Text <> "" Then
                If ComboBox1.Text = "HPI" And ComboBox2.Text <> "" Then
                    Me.MMCHRosAndGenTableAdapter.FillByCatAndSub(Me.MMDataDataSet1.MMCHRosAndGen, ComboBox1.SelectedValue, ComboBox2.Text)
                Else
                    Dim cboText As String
                    cboText = ComboBox1.Text
                    If cboText = "PE-(Normals)" Then
                        cboText = "PE-(Normals"
                    End If
                    '' ''Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, cboText)
                    If cboText.Length > 12 Then
                        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, cboText.Substring(0, 11))
                    Else
                        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, cboText)
                    End If
                End If
            End If
        End If
        cboCategory.Text = ComboBox1.Text
        LoadProfile()
    End Sub

    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp
        ' If cmbFilter.Text <> "" Then
        Me.MMCHRosAndGenBindingSource.Filter = "Discription" & " like" & "'" & txtFind.Text & "%'"
        'End If
        Me.MMCHRosAndGenBindingSource.Sort = "Discription"
        MMCHRosAndGenDataGridView.DataSource = Me.MMCHRosAndGenBindingSource

    End Sub

    'Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    '    ' If cmbFilter.Text <> "" Then
    '    Me.MMCHRosAndGenBindingSource.Filter = "Discription" & " like" & "'" & txtFind.Text & "%'"
    '    'End If
    '    Me.MMCHROSandGenCatBindingSource.Sort = "Discription"
    '    MMCHRosAndGenDataGridView.DataSource = Me.MMCHRosAndGenBindingSource


    'End Sub

    'Private Sub txtFind_KeyUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

    'End Sub


    'Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged

    'End Sub

    Private Sub MMCHRosAndGenDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMCHRosAndGenDataGridView.DoubleClick
        Dim codes As String

        codes = CODESTextBox.Text
        If CODESTextBox.Text = "" Then
            CODESTextBox.Text = MMCHRosAndGenDataGridView.SelectedRows(0).Cells(0).Value.ToString()
        Else
            CODESTextBox.Text = codes + "," + MMCHRosAndGenDataGridView.SelectedRows(0).Cells(0).Value.ToString
        End If


        Dim newRow As DataRow = Me.MMDataDataSet2.QIDs.NewRow

        Select Case MMCHRosAndGenDataGridView.SelectedRows(0).Cells("CategoryDataGridViewTextBoxColumn").Value.ToString.Substring(0, 3)
            Case "PE-"
                newRow("QID") = MMCHRosAndGenDataGridView.SelectedRows(0).Cells(0).Value.ToString
                newRow("Description") = MMCHRosAndGenDataGridView.SelectedRows(0).Cells(4).Value.ToString
                newRow("ChiefComplaint") = CHIEF_COMPLAINTTextBox.Text
                newRow("TemplateName") = TemplateNameTextBox.Text
                newRow("SortOrder") = "3000"
                newRow("Category") = MMCHRosAndGenDataGridView.SelectedRows(0).Cells(1).Value.ToString
            Case "ROS"
                newRow("QID") = MMCHRosAndGenDataGridView.SelectedRows(0).Cells(0).Value.ToString
                newRow("Description") = MMCHRosAndGenDataGridView.SelectedRows(0).Cells(4).Value.ToString
                newRow("ChiefComplaint") = CHIEF_COMPLAINTTextBox.Text
                newRow("TemplateName") = TemplateNameTextBox.Text
                newRow("SortOrder") = "3000"
                newRow("Category") = MMCHRosAndGenDataGridView.SelectedRows(0).Cells(1).Value.ToString
            Case Else
                newRow("QID") = MMCHRosAndGenDataGridView.SelectedRows(0).Cells(0).Value.ToString
                newRow("Description") = MMCHRosAndGenDataGridView.SelectedRows(0).Cells(4).Value.ToString
                'newRow("ChiefComplaint") = CHIEF_COMPLAINTTextBox.Text
                newRow("TemplateName") = TemplateNameTextBox.Text
                newRow("SortOrder") = "9999"
                newRow("Category") = "TemplateSpecific"
                newRow("SubCategory") = MMCHRosAndGenDataGridView.SelectedRows(0).Cells("CategoryDataGridViewTextBoxColumn").Value.ToString
        End Select






        'Dim newRow As DataRow = Me.MMDataDataSet2.QIDs.NewRow
        'newRow("QID") = MMCHRosAndGenDataGridView.SelectedRows(0).Cells(0).Value.ToString
        'newRow("Description") = MMCHRosAndGenDataGridView.SelectedRows(0).Cells(4).Value.ToString
        'newRow("ChiefComplaint") = CHIEF_COMPLAINTTextBox.Text
        'newRow("TemplateName") = TemplateNameTextBox.Text
        'newRow("SortOrder") = "3000"
        'newRow("Category") = MMCHRosAndGenDataGridView.SelectedRows(0).Cells(1).Value.ToString





        Me.MMDataDataSet2.QIDs.Rows.Add(newRow)
        Me.QIDsTableAdapter.Update(Me.MMDataDataSet2.QIDs)
    End Sub

    Private Sub MMCHRosAndGenBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMCHRosAndGenBindingSource.AddingNew
        If ComboBox1.Text <> "" Then
            If ComboBox1.Text = "Other..." Then
                Me.MMDataDataSet1.MMCHRosAndGen.CategoryColumn.DefaultValue = cboOther.Text
                Me.MMDataDataSet1.MMCHRosAndGen.DetailOfItemColumn.DefaultValue = ""
            Else
                Me.MMDataDataSet1.MMCHRosAndGen.CategoryColumn.DefaultValue = ComboBox1.Text
                Me.MMDataDataSet1.MMCHRosAndGen.DetailOfItemColumn.DefaultValue = ""
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CCProfilesBindingSource.MoveNext()
        LoadProfile()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CCProfilesBindingSource.MovePrevious()
        LoadProfile()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CCProfilesBindingSource.MoveLast()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CCProfilesBindingSource.MoveFirst()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Validate()
        Me.CCProfilesBindingSource.EndEdit()
        Me.CCProfilesTableAdapter.Update(Me.DprofilesDataSet.CCProfiles)
    End Sub

    Private Function LoadProfile()
        Cursor.Current = Cursors.WaitCursor
        ClearGrid()
        If TemplateNameTextBox.Text <> "" Then

            Dim connstring As String = connString2

            Dim objCommand As New SqlCommand
            objCommand.CommandText = "SELECT QID from QIDS where TemplateName = '" & TemplateNameTextBox.Text & "'"
            objCommand.Connection = New SqlConnection(connstring)
            objCommand.Connection.Open()
            Dim localdr As SqlDataReader = objCommand.ExecuteReader()
            Dim i As Integer

            If localdr.HasRows = True Then
                If MMCHRosAndGenDataGridView.Rows.Count > 0 Then
                    While localdr.Read
                        If localdr.Item(0).ToString <> "" Then
                            For i = 0 To MMCHRosAndGenDataGridView.RowCount - 1
                                If localdr.Item(0).ToString = MMCHRosAndGenDataGridView.Rows(i).Cells("QidDataGridViewTextBoxColumn").Value.ToString.Trim Then
                                    'MMCHRosAndGenDataGridView.Rows(i).Cells("MyItem").Value = True
                                    'MMCHRosAndGenDataGridView.Columns("MyItem").DefaultCellStyle.BackColor = Color.WhiteSmoke
                                    MMCHRosAndGenDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.PowderBlue
                                End If
                            Next
                        End If
                    End While
                End If          '  If MMCHRosAndGenDataGridView.Rows.Count > 0 Then
            End If
            localdr.Close()
        End If    'If txtPhysicianCode.Text <> "" 
        Cursor.Current = Cursors.Default
    End Function

    Private Function ClearGrid()
        Dim i As Integer
        For i = 0 To MMCHRosAndGenDataGridView.RowCount - 1
            MMCHRosAndGenDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Empty
        Next
    End Function

    Private Sub LoadCategoryCB()

        Dim drCategory As DataRowView
        Dim dtRosGenCat As DataTable
        dtRosGenCat = Me.MMDataDataSet1.Tables("MMCHROSandGenCat")
        Dim dvCategory As New DataView(dtRosGenCat)
        dvCategory.Sort = "Category"


        ComboBox1.Items.Clear()

        'For Each drCategory In dtRosGenCat.Rows
        '    If drCategory("Category") <> "" And drCategory("Category").ToString.Length > 3 Then

        '        If drCategory("Category").ToString.Substring(0, 3) = "ROS" Or drCategory("Category").ToString.Substring(0, 3) = "PE-" Then

        '            ComboBox1.Items.Add(drCategory("Category"))
        '        End If
        '    End If

        'Next





        'changed it to dataview so that it could be sorted. 

        ' '' '' ''For Each drCategory In dvCategory
        ' '' '' ''    If drCategory("Category") <> "" And drCategory("Category").ToString.Length > 3 Then

        ' '' '' ''        If drCategory("Category").ToString.Substring(0, 3) = "ROS" Or drCategory("Category").ToString.Substring(0, 3) = "PE-" Then

        ' '' '' ''            ComboBox1.Items.Add(drCategory("Category"))
        ' '' '' ''        End If

        ' '' '' ''    End If

        ' '' '' ''Next



        'ComboBox1.Items.Add("Procedure Notes")

        'ComboBox1.Items.Add("Plan")

        For Each drCategory In dvCategory


            ComboBox1.Items.Add(drCategory("Category"))

        Next


        ComboBox1.Items.Add("Other...")




    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim connstring As String = connString2

        Dim objCommand As New SqlCommand
        objCommand.CommandText = "select category, Discription from mmchrosandgen where Discription like '%" & txtSearch.Text & "%'"
        objCommand.Connection = New SqlConnection(connstring)
        objCommand.Connection.Open()
        Dim localdr As SqlDataReader = objCommand.ExecuteReader()
        Dim i As Integer
        dgvSearch.Rows.Clear()

        If localdr.HasRows = True Then

            While localdr.Read
                If localdr.Item(0).ToString <> "" Then
                    Dim searcharray(1) As String
                    searcharray(0) = localdr.Item(0)
                    searcharray(1) = localdr.Item(1)
                    dgvSearch.Rows.Add(searcharray)
                End If
            End While

        End If
        localdr.Close()
    End Sub

    Private Sub cboOther_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOther.SelectedIndexChanged
        If ComboBox1.Text = "Other..." Then
            If cboOther.Text.Length > 12 Then
                Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, cboOther.Text.Substring(0, 11))
            Else
                Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, cboOther.Text)
            End If
        Else
            cboOther.Visible = False
        End If

    End Sub
    Private Sub btnReorder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReorder.CheckedChanged
        If btnReorder.Checked = True Then
            btnJump2.Visible = True
            txtJump2.Visible = True
            iReorderCount = 0
        Else
            btnJump2.Visible = False
            txtJump2.Visible = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub MMCHRosAndGenDataGridView_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MMCHRosAndGenDataGridView.CellMouseMove
        If btnReorder.Checked = True Then
            Me.Cursor = Cursors.Cross
        Else
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub MMCHRosAndGenDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MMCHRosAndGenDataGridView.CellClick
        If btnReorder.Checked = True Then
            If Me.MMCHRosAndGenDataGridView.Columns(e.ColumnIndex).Name = "ScreenLocation1" Then
                If Me.MMCHRosAndGenDataGridView.SelectedCells.Count = 1 Then
                    iReorderCount += 1
                    Me.MMCHRosAndGenDataGridView.Rows(e.RowIndex).Cells("ScreenLocation1").Value = iReorderCount
                End If
            End If
        End If
    End Sub

    Private Sub btnProfileReorder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProfileReorder.CheckedChanged
        If btnProfileReorder.Checked = True Then
            btnJump.Visible = True
            txtJump.Visible = True
            iProfileReorderCount = 0
        Else
            btnJump.Visible = False
            txtJump.Visible = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub QIDsDataGridView_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles QIDsDataGridView.CellMouseMove
        If btnProfileReorder.Checked = True Then
            Me.Cursor = Cursors.Cross
        Else
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub QIDsDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles QIDsDataGridView.CellClick
        If btnProfileReorder.Checked = True Then
            If Me.QIDsDataGridView.Columns(e.ColumnIndex).Name = "DataGridViewTextBoxColumn11" Then
                If Me.QIDsDataGridView.SelectedCells.Count = 1 Then
                    iProfileReorderCount += 5
                    Me.QIDsDataGridView.Rows(e.RowIndex).Cells("DataGridViewTextBoxColumn11").Value = iProfileReorderCount
                End If
            End If
        End If
    End Sub

    Private Sub btnJump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJump.Click
        iProfileReorderCount = txtJump.Text - 5
    End Sub

    Private Sub btnJump2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJump2.Click
        iReorderCount = txtJump2.Text - 1
    End Sub

 
    Private Sub btnPostNewItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPostNewItems.Click
        Dim MyArr
        Dim i As Long
        MyArr = Split(txtDescriptionList.Text, "|")
        For i = 0 To UBound(MyArr)
            Dim row As DataRow
            row = Me.MMDataDataSet1.Tables("MMCHRosAndGen").NewRow()
            row("Category") = cboCategory.Text
            row("ScreenLocation1") = txtScreenLocation.Text & ""
            row("SubCategory") = txtSubCategory.Text
            row("Discription") = MyArr(i).ToString.Trim
            row("Heading") = txtHeading.Text
            row("DetailofItem") = txtDetailofitem.Text
            row("Negative") = False
            row("Positive") = False
            row("AnswerType") = cboAnswerTypeforNewItem.Text
            Me.MMDataDataSet1.Tables("MMCHRosAndGen").Rows.Add(row)
        Next
        Me.Validate()
        Me.MMCHRosAndGenBindingSource.EndEdit()
        Me.MMCHRosAndGenTableAdapter.Update(Me.MMDataDataSet1.MMCHRosAndGen)
    End Sub

    
  
   
   
End Class