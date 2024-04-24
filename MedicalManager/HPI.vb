Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration
Public Class HPI

    Dim adding As Boolean
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(10) As String

    Public Function ShowPicklist() As String()
        Dim st As String



        Dim aRet(10) As String
        ' On Error GoTo EH
        aRet(0) = "N"
        mbPicklistmode = True
        mbSelected = False
        Me.ShowDialog()


        If ComboBox1.Text <> "" Then
            ' If txtOnset.Text <> "" Then
            ' st = st + " HISTORY OF PRESENT ILLNESS : " + txtProblem.Text + " Onset: " + txtOnset.Text + ". " + "Severity level is " + txtSeverity.Text + ". Duration " + txtDuration.Text + ". The patient states the " + txtProblem.Text + " Location " + txtLocation.Text + " .It occurs " + cbFrequency.Text + ". Context: " + TextBox2.Text + ". Symptom is aggravated by " + TextBox3.Text + ". Relieving factors include " + txtReleivedBy.Text + ". He is also experiencing " + txtAssociatedSymptoms.Text + "."

            st = st + " HISTORY OF PRESENT ILLNESS : " + txtProblem.Text

            If txtOnset.Text <> "" Then
                st = st + " Onset: " + txtOnset.Text
            End If

            If txtSeverity.Text <> "" Then
                st = st + "Severity level is " + txtSeverity.Text
            End If


            If txtDuration.Text <> "" Then
                st = st + ". Duration " + txtDuration.Text
            End If


            If cbStatus.Text <> "" Then
                st = st + ". Status: " + cbStatus.Text
            End If


            If txtQuality.Text <> "" Then
                st = st + ". Quality: " + txtQuality.Text
            End If

            If txtTimeCourse.Text <> "" Then
                st = st + ". Time Course: " + txtTimeCourse.Text
            End If



            If txtLocation.Text <> "" Then
                st = st + ". The patient states the " + txtProblem.Text + " Location " + txtLocation.Text
            End If

            If cbFrequency.Text <> "" Then
                st = st + ". It occurs " + cbFrequency.Text
            End If

            If TextBox2.Text <> "" Then
                st = st + ". Context: " + TextBox2.Text
            End If

            If txtWhere.Text <> "" Then
                st = st + ". Where: " + txtWhere.Text
            End If

            If txtRadiation.Text <> "" Then
                st = st + ". Radiation: " + txtRadiation.Text
            End If

            If txtUsually.Text <> "" Then
                st = st + ". Usually: " + txtUsually.Text
            End If


            If TextBox3.Text <> "" Then
                st = st + ". Symptom is aggravated by " + TextBox3.Text
            End If

            If txtReleivedBy.Text <> "" Then
                st = st + ". Relieving factors include " + txtReleivedBy.Text
            End If

            If txtAssociatedSymptoms.Text <> "" Then
                st = st + ". The patient is also experiencing " + txtAssociatedSymptoms.Text
            End If

           


            If txtComments.Text <> "" Then
                st = st + ". Additional Comments: " + txtComments.Text
            End If



        End If

        'If snr <> "" Then
        '    snr = "NEGATIVE for " & snr & ControlChars.CrLf
        'End If
        'If spr <> "" Then
        '    spr = "POSITIVE for " & spr & ControlChars.CrLf
        'End If


        If mbSelected Then
            aRet(0) = "Y"
            aRet(1) = st
            aRet(2) = txtProblem.Text
            ' aRet(2) = dgProcedure.SelectedRows(0).Cells(1).Value


        End If
        ShowPicklist = aRet
        Me.Close()
        Exit Function

    End Function
    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub


    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        txtSeverity.Text = Button21.Text
    End Sub

    Private Sub HPI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub HPI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.HPI1' table. You can move, or remove it, as needed.
        Me.HPI1TableAdapter.Fill(Me.MMDataDataSet1.HPI1)
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMChartCC' table. You can move, or remove it, as needed.
        Me.MMChartCCTableAdapter.Fill(Me.MMDataDataSet1.MMChartCC)
        'TODO: This line of code loads data into the 'MMDataDataSet1.HPI' table. You can move, or remove it, as needed.

        If globalTemplate <> "" Then
            Me.HPITableAdapter.FillByCC(Me.MMDataDataSet1.HPI, globalTemplate)
            ComboBox1.Text = globalTemplate
            Me.Text = "History Of Present Illness" + "                                                           " + globalTemplate + "- " + globalChiefComplaint
        Else
            Me.HPITableAdapter.FillByCC(Me.MMDataDataSet1.HPI, ComboBox1.Text)
        End If

        'TODO: This line of code loads data into the 'MMDataDataSet.HPI' table. You can move, or remove it, as needed.
        ' Me.HPITableAdapter.Fill(Me.MMDataDataSet1.HPI)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtOnset.Text = txtOnset.Text & Button1.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtOnset.Text = txtOnset.Text & Button2.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtOnset.Text = txtOnset.Text & Button3.Text
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        txtOnset.Text = txtOnset.Text & " " & Button22.Text & " " & "ago "
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtOnset.Text = txtOnset.Text & Button4.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtOnset.Text = txtOnset.Text & Button5.Text
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        txtOnset.Text = txtOnset.Text & Button11.Text
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        txtOnset.Text = txtOnset.Text & Button7.Text
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        txtOnset.Text = txtOnset.Text & Button8.Text
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        txtOnset.Text = txtOnset.Text & Button9.Text
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        txtOnset.Text = txtOnset.Text & " " & Button23.Text & " " & "ago "
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        txtOnset.Text = txtOnset.Text & " " & Button24.Text & " " & "ago "
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        txtOnset.Text = txtOnset.Text & Button10.Text
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        txtOnset.Text = ""
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        txtOnset.Text = txtOnset.Text & " " & Button25.Text & " " & "ago "
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        txtOnset.Text = txtOnset.Text & " " & Button26.Text & " " & "ago "
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        txtOnset.Text = txtOnset.Text & " " & Button27.Text & " " & "ago "
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        txtSeverity.Text = Button12.Text
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        txtSeverity.Text = Button13.Text
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        txtSeverity.Text = Button14.Text
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        txtSeverity.Text = Button15.Text
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        txtSeverity.Text = Button16.Text
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        txtSeverity.Text = Button17.Text
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        txtSeverity.Text = Button18.Text
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        txtSeverity.Text = Button19.Text
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        txtSeverity.Text = Button20.Text
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        txtSeverity.Text = ""
    End Sub

    Private Sub HPIBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HPIBindingNavigatorSaveItem.Click
            Try
                  Me.Validate()
                  Me.HPIBindingSource.EndEdit()
                  Me.HPITableAdapter.Update(Me.MMDataDataSet1.HPI)
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        setuptv()
    End Sub

    Private Sub setuptv()
        Try
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            Dim connString3 As String = connString2
            Dim cn2 As New SqlConnection(connString3)

            cn.Open()
            cn2.Open()
            Dim cmd As New SqlCommand("SELECT HPI.ID, HPI.CC, HPI.Category, HPI.SubCategory, HPI.Description FROM HPI where CC=" & "'" & ComboBox1.Text & "' order by sortorder", cn)
            Dim cmd2 As New SqlCommand("SELECT   distinct  MMCHROSandGenCat.Category,MMCHROSandGenCat.SortOrder  FROM         HPI INNER JOIN  MMCHROSandGenCat ON HPI.Category = MMCHROSandGenCat.Category where HPI.CC=" & "'" & ComboBox1.Text & "' ORDER BY MMCHROSandGenCat.SortOrder", cn2)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            Dim dr2 As SqlDataReader = cmd2.ExecuteReader()

            Dim mNode As TreeNode
            tvwDB.Nodes.Clear()
            Dim i As Integer

            While dr2.Read
                mNode = tvwDB.Nodes.Add(dr2.Item(0).ToString, dr2.Item(0).ToString)
            End While

            dr2.Close()

            Do While dr.Read
                If tvwDB.Nodes.ContainsKey(dr("Category")) = True Then

                Else
                    tvwDB.Nodes.Add(dr("Category"), dr("Category"))
                End If
                tvwDB.Nodes(dr("Category")).Nodes.Add(dr("Description"), dr("Description"))
            Loop

            If tvwDB.Nodes.ContainsKey("A") = True Then
                tvwDB.Nodes("A").Nodes.Add("Test Risk factors")
            End If

            dr.Close()
            cn.Close()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub tvwDB_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvwDB.NodeMouseClick
        'Dim selectedNode As TreeNode
        'selectedNode = tvwDB.SelectedNode
        ' txtLocation.Text = tvwDB.SelectedNode.Text

    End Sub

    'Private Sub tvwDB_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwDB.AfterSelect
    '    On Error Resume Next
    '    Select Case tvwDB.SelectedNode.Parent.ToString



    '        Case "TreeNode: Chief Complaint"
    '            If txtProblem.Text = "" Then
    '                txtProblem.Text = tvwDB.SelectedNode.Text
    '            Else
    '                txtProblem.Text = txtProblem.Text + ", " + tvwDB.SelectedNode.Text
    '            End If

    '        Case "TreeNode: Location"
    '            If txtLocation.Text = "" Then
    '                txtLocation.Text = tvwDB.SelectedNode.Text
    '            Else
    '                txtLocation.Text = txtLocation.Text + ", " + tvwDB.SelectedNode.Text
    '            End If
    '        Case "TreeNode: Context"
    '            If TextBox2.Text = "" Then
    '                TextBox2.Text = tvwDB.SelectedNode.Text
    '            Else
    '                TextBox2.Text = TextBox2.Text + ", " + tvwDB.SelectedNode.Text
    '            End If

    '        Case "TreeNode: Aggravated by"
    '            If TextBox3.Text = "" Then
    '                TextBox3.Text = tvwDB.SelectedNode.Text
    '            Else
    '                TextBox3.Text = TextBox3.Text + ", " + tvwDB.SelectedNode.Text
    '            End If

    '        Case "TreeNode: Relieved by"
    '            If txtReleivedBy.Text = "" Then
    '                txtReleivedBy.Text = tvwDB.SelectedNode.Text
    '            Else

    '                txtReleivedBy.Text = txtReleivedBy.Text + ", " + tvwDB.SelectedNode.Text
    '            End If
    '        Case "TreeNode: Associated symptoms"
    '            If txtAssociatedSymptoms.Text = "" Then
    '                txtAssociatedSymptoms.Text = tvwDB.SelectedNode.Text
    '            Else

    '                txtAssociatedSymptoms.Text = txtAssociatedSymptoms.Text + ", " + tvwDB.SelectedNode.Text
    '            End If


    '        Case "TreeNode: Quality"
    '            If txtQuality.Text = "" Then
    '                txtQuality.Text = tvwDB.SelectedNode.Text
    '            Else

    '                txtQuality.Text = txtQuality.Text + ", " + tvwDB.SelectedNode.Text
    '            End If

    '        Case "TreeNode: Time Course"
    '            If txtTimeCourse.Text = "" Then
    '                txtTimeCourse.Text = tvwDB.SelectedNode.Text
    '            Else

    '                txtTimeCourse.Text = txtTimeCourse.Text + ", " + tvwDB.SelectedNode.Text
    '            End If



    '            '   txtAssociatedSymptoms.Text = txtAssociatedSymptoms.Text + "," + tvwDB.SelectedNode.Text



    '    End Select
    '    ' MsgBox(tvwDB.SelectedNode.Parent.ToString)
    'End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.HPITableAdapter.FillByCC(Me.MMDataDataSet1.HPI, ComboBox1.Text)
        setuptv()

    End Sub

    Private Sub btnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPost.Click
        RecurseNodes(tvwDB.Nodes)
    End Sub

    Private Function RecurseNodes(ByVal col As TreeNodeCollection)
        For Each node As TreeNode In col
            ' MsgBox(node.Text)
            'If node.Nodes.Count = 0 Then

            If node.Checked = True Then
                Try
                    Select Case node.Parent.ToString


                        Case "TreeNode: Chief Complaint"
                            If txtProblem.Text = "" Then
                                txtProblem.Text = node.Text
                            Else
                                txtProblem.Text = txtProblem.Text + ", " + node.Text
                            End If

                        Case "TreeNode: Location"
                            If txtLocation.Text = "" Then
                                txtLocation.Text = node.Text
                            Else
                                txtLocation.Text = txtLocation.Text + ", " + node.Text
                            End If

                        Case "TreeNode: Context"
                            If TextBox2.Text = "" Then
                                TextBox2.Text = node.Text
                            Else
                                TextBox2.Text = TextBox2.Text + ", " + node.Text
                            End If

                        Case "TreeNode: Aggravated by"
                            If TextBox3.Text = "" Then
                                TextBox3.Text = node.Text
                            Else
                                TextBox3.Text = TextBox3.Text + ", " + node.Text
                            End If

                        Case "TreeNode: Relieved by"
                            If txtReleivedBy.Text = "" Then
                                txtReleivedBy.Text = node.Text
                            Else

                                txtReleivedBy.Text = txtReleivedBy.Text + ", " + node.Text
                            End If
                        Case "TreeNode: Associated symptoms"
                            If txtAssociatedSymptoms.Text = "" Then
                                txtAssociatedSymptoms.Text = node.Text
                            Else

                                txtAssociatedSymptoms.Text = txtAssociatedSymptoms.Text + ", " + node.Text
                            End If

                        Case "TreeNode: Quality"
                            If txtQuality.Text = "" Then
                                txtQuality.Text = node.Text
                            Else

                                txtQuality.Text = txtQuality.Text + ", " + node.Text
                            End If

                        Case "TreeNode: Radiation"
                            If txtRadiation.Text = "" Then
                                txtRadiation.Text = node.Text
                            Else

                                txtRadiation.Text = txtRadiation.Text + ", " + node.Text
                            End If



                        Case "TreeNode: Time Course"
                            If txtTimeCourse.Text = "" Then
                                txtTimeCourse.Text = node.Text
                            Else

                                txtTimeCourse.Text = txtTimeCourse.Text + ", " + node.Text
                            End If


                        Case "TreeNode: Where"
                            If txtWhere.Text = "" Then
                                txtWhere.Text = node.Text
                            Else

                                txtWhere.Text = txtWhere.Text + ", " + node.Text
                            End If



                        Case "TreeNode: Usually"
                            If txtUsually.Text = "" Then
                                txtUsually.Text = node.Text
                            Else
                                txtUsually.Text = txtUsually.Text + ", " + node.Text
                            End If



                            'Case "TreeNode: Miscellaneous"
                            '    If txtComments.Text = "" Then
                            '        txtComments.Text = node.Text
                            '    Else
                            '        txtComments.Text = txtComments.Text + ", " + node.Text
                            '    End If



                        Case Else


                            If txtComments.Text = "" Then
                                txtComments.Text = node.Parent.Text & "- " & node.Text
                            Else
                                txtComments.Text = txtComments.Text + ", " + node.Parent.Text & "- " & node.Text
                            End If


                            'If txtComments.Text = "" Then
                            '    txtComments.Text = node.Text
                            'Else
                            '    txtComments.Text = txtComments.Text + ", " + node.Text
                            'End If



                    End Select
                Catch

                End Try
            End If
            RecurseNodes(node.Nodes)
            'End If
        Next node
    End Function

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub HPI_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

    End Sub
End Class



'Private Sub setuptv()
'    Try
'        Dim connString As String = connString2
'        Dim cn As New SqlConnection(connString)
'        Dim connString3 As String = connString2
'        Dim cn2 As New SqlConnection(connString3)

'        cn.Open()
'        cn2.Open()
'        Dim cmd As New SqlCommand("SELECT HPI.ID, HPI.CC, HPI.Category, HPI.SubCategory, HPI.Description FROM HPI where CC=" & "'" & ComboBox1.Text & "' order by sortorder", cn)
'        ' Dim cmd2 As New SqlCommand("SELECT distinct HPI.Category  as Category FROM HPI where CC=" & "'" & ComboBox1.Text & "' order by Category desc", cn2)
'        Dim cmd2 As New SqlCommand("SELECT   distinct  MMCHROSandGenCat.Category,MMCHROSandGenCat.SortOrder  FROM         HPI INNER JOIN  MMCHROSandGenCat ON HPI.Category = MMCHROSandGenCat.Category where HPI.CC=" & "'" & ComboBox1.Text & "' ORDER BY MMCHROSandGenCat.SortOrder", cn2)
'        Dim dr As SqlDataReader = cmd.ExecuteReader()
'        Dim dr2 As SqlDataReader = cmd2.ExecuteReader()

'        Dim mNode As TreeNode
'        tvwDB.Nodes.Clear()
'        Dim i As Integer

'        While dr2.Read
'            mNode = tvwDB.Nodes.Add(dr2.Item(0).ToString, dr2.Item(0).ToString)
'        End While

'        'mNode = tvwDB.Nodes.Add(1, "Chief Complaint")
'        'mNode = tvwDB.Nodes.Add(1, "Location")
'        'mNode = tvwDB.Nodes.Add(1, "Context")
'        'mNode = tvwDB.Nodes.Add(1, "Quality")
'        'mNode = tvwDB.Nodes.Add(1, "Radiation")
'        'mNode = tvwDB.Nodes.Add(1, "Aggravated by")
'        'mNode = tvwDB.Nodes.Add(1, "Relieved by")
'        'mNode = tvwDB.Nodes.Add(1, "Associated symptoms")
'        'mNode = tvwDB.Nodes.Add(1, "Time Course")
'        'mNode = tvwDB.Nodes.Add(1, "Where")
'        'mNode = tvwDB.Nodes.Add(1, "Usually")
'        'mNode = tvwDB.Nodes.Add(1, "Miscellaneous")
'        'mNode = tvwDB.Nodes.Add(1, "Risk Factors")
'        dr2.Close()

'        Do While dr.Read
'            'Console.WriteLine(dr("Category"))
'            'Console.WriteLine("       " & dr("Description"))

'            If tvwDB.Nodes.ContainsKey(dr("Category")) = True Then

'            Else
'                tvwDB.Nodes.Add(dr("Category"), dr("Category"))
'            End If


'            tvwDB.Nodes(dr("Category")).Nodes.Add(dr("Description"))

'            'Select Case dr("Category").ToString.ToLower
'            '    Case "chief complaint"
'            '        tvwDB.Nodes(0).Nodes.Add(dr("Description"))
'            '    Case "location"
'            '        tvwDB.Nodes(1).Nodes.Add(dr("Description"))
'            '    Case "context"
'            '        tvwDB.Nodes(2).Nodes.Add((dr("Description")))
'            '    Case "quality"
'            '        tvwDB.Nodes(3).Nodes.Add((dr("Description")))
'            '    Case "radiation"
'            '        tvwDB.Nodes(4).Nodes.Add((dr("Description")))
'            '    Case "aggravated by"
'            '        tvwDB.Nodes(5).Nodes.Add((dr("Description")))
'            '    Case "relieved by"
'            '        tvwDB.Nodes(6).Nodes.Add((dr("Description")))
'            '    Case "associated symptoms"
'            '        tvwDB.Nodes(7).Nodes.Add((dr("Description")))
'            '    Case "time course"
'            '        tvwDB.Nodes(8).Nodes.Add((dr("Description")))
'            '    Case "where"
'            '        tvwDB.Nodes(9).Nodes.Add((dr("Description")))
'            '    Case "usually"
'            '        tvwDB.Nodes(10).Nodes.Add((dr("Description")))
'            '    Case "miscellaneous"
'            '        tvwDB.Nodes(11).Nodes.Add((dr("Description")))
'            '    Case "risk factors"
'            '        tvwDB.Nodes(12).Nodes.Add((dr("Description")))
'            'End Select
'        Loop







'        dr.Close()
'        cn.Close()


'    Catch ex As System.Exception
'        System.Windows.Forms.MessageBox.Show(ex.Message)

'    End Try
'End Sub