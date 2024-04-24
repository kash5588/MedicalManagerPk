Imports System.Text
Imports System.Data

Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class PhysicalExamination
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(2) As String
    Dim ChartNumber As String
    Dim Casenumber As String
    Dim strDate As String
    Dim rowIndex As String
    Dim ChCsDtArray(2) As String
    Dim sb As New StringBuilder
    Dim sbPE As New StringBuilder
    Private m_Rnd As New Random
    Dim CounterBulletPE As Integer
    Dim CounterBulletROS As Integer



    Private Sub PhysicalExamination_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub PhysicalExamination_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub PhysicalExamination_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DprofilesDataSet.CCProfiles' table. You can move, or remove it, as needed.
        Me.CCProfilesTableAdapter.Fill(Me.DprofilesDataSet.CCProfiles)
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMCHRosAndGen' table. You can move, or remove it, as needed.
        ' Me.MMCHRosAndGenTableAdapter.Fill(Me.MMDataDataSet1.MMCHRosAndGen)
        LoadComboBoxes2()
        LoadGlobalTemplate()
        '  RetrieveBodySketch()
    End Sub

    Public Function ShowPicklist(ByVal ChCsDtArray() As String) As String()

        ChartNumber = ChCsDtArray(0)
        Casenumber = ChCsDtArray(1)
        strDate = ChCsDtArray(2)

        Dim aRet(4) As String
        ' On Error GoTo EH
        aRet(0) = "N"
        mbPicklistmode = True
        mbSelected = False
        Me.ShowDialog()
        If mbSelected Then
            aRet(0) = "Y"
            aRet(1) = sbPE.tostring 'TextBox1.Text
            aRet(2) = sb.ToString
            aRet(3) = CounterBulletPE
            aRet(4) = CounterBulletROS


        End If
        sb = Nothing
        sbPE = Nothing
        ShowPicklist = aRet
        ' Me.Close()
        Exit Function

    End Function

    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub cmdPE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPE.Click
    
        If mbPicklistmode Then
            PicklistSelect()
        End If

        Dim i As Integer
        Dim sCategory As String = ""
        Dim sSubCategory As String = ""
        Dim sDescription As String = ""
        Dim sNeg As String = ""
        Dim sPos As String = ""

        'sbPE = New StringBuilder
        'sb = New StringBuilder

        Dim s As String

        For i = 0 To MMCHRosAndGenDataGridView.RowCount - 1
            If MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value.ToString.Length > 3 Then
                If MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value.ToString.Substring(0, 3) = "PE-" Then
                    If MMCHRosAndGenDataGridView.Rows(i).Cells("Negative").Value = True Or MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                        If sCategory <> MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value Then

                            sbPE.Append(Environment.NewLine)
                            sCategory = MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value
                            sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value & Environment.NewLine)
                            sbPE.Append("   ")

                            If sSubCategory <> MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & "" Then
                                sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ": ")
                                sSubCategory = MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ""
                            Else
                                sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ", ")
                            End If


                            If MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                                sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(+)")
                            Else
                                sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(-)")
                            End If
                        Else
                            If sSubCategory <> MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & "" Then
                                sbPE.Append(Environment.NewLine)
                                sbPE.Append("   ")
                                sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ": ")

                                If MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                                    sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(+)")
                                Else
                                    sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(-)")
                                End If

                                sSubCategory = MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ""
                            Else
                                sbPE.Append(",  ")
                                If MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                                    sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(+)")

                                Else
                                    sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(-)")

                                End If
                            End If
                        End If
                        BulletCount(i)
                    End If
                End If
            End If














            If MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value.ToString.Length > 3 Then
                If MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value.ToString.Substring(0, 3) = "ROS" Then
                    If MMCHRosAndGenDataGridView.Rows(i).Cells("Negative").Value = True Or MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                        If sCategory <> MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value Then

                            sb.Append(Environment.NewLine)
                            sCategory = MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value
                            sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value & Environment.NewLine)
                            sb.Append("   ")

                            If sSubCategory <> MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & "" Then
                                sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ": ")
                                sSubCategory = MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ""
                            Else
                                sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ", ")
                            End If


                            If MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                                sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(+)")
                            Else
                                sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(-)")
                            End If
                        Else
                            If sSubCategory <> MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & "" Then
                                sb.Append(Environment.NewLine)
                                sb.Append("   ")
                                sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ": ")

                                If MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                                    sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(+)")
                                Else
                                    sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(-)")
                                End If

                                sSubCategory = MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ""
                            Else
                                sb.Append(",  ")
                                If MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                                    sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(+)")

                                Else
                                    sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(-)")

                                End If
                            End If
                        End If
                        BulletCount(i)
                    End If
                End If
            End If

        Next

        sbPE.Replace("   :", "   ")
        sbPE.Replace("   ,", "   ")
        sb.Replace("   :", "   ")
        sb.Replace("   ,", "   ")
        TextBox1.Text = sbPE.ToString      ' & Environment.NewLine & sb.ToString
    End Sub

    Private Function BulletCount(ByVal i As Integer)

        Dim strDescription As String = MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value
        Try
            Select Case strDescription.Substring(0, 3)
                Case "PE-"
                    CounterBulletPE += 1
                    PEBulletsCount.Text = CounterBulletPE
                Case "ROS"
                    CounterBulletROS += 1
                    ROSBulletsCount.Text = CounterBulletROS
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function



    Private Function ROSPE()

        'If mbPicklistmode Then
        '    PicklistSelect()
        'End If

        Dim i As Integer
        Dim sCategory As String = ""
        Dim sSubCategory As String = ""
        Dim sDescription As String = ""
        Dim sNeg As String = ""
        Dim sPos As String = ""

        'sbPE = New StringBuilder
        'sb = New StringBuilder

        Dim s As String

        For i = 0 To MMCHRosAndGenDataGridView.RowCount - 1
            If MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value.ToString.Length > 3 Then
                If MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value.ToString.Substring(0, 3) = "PE-" Then
                    If MMCHRosAndGenDataGridView.Rows(i).Cells("Negative").Value = True Or MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                        If sCategory <> MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value Then

                            sbPE.Append(Environment.NewLine)
                            sCategory = MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value
                            sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value & Environment.NewLine)
                            sbPE.Append("   ")

                            If sSubCategory <> MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & "" Then
                                sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ": ")
                                sSubCategory = MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ""
                            Else
                                sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ", ")
                            End If


                            If MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                                sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(+)")
                            Else
                                sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(-)")
                            End If
                        Else
                            If sSubCategory <> MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & "" Then
                                sbPE.Append(Environment.NewLine)
                                sbPE.Append("   ")
                                sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ": ")

                                If MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                                    sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(+)")
                                Else
                                    sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(-)")
                                End If

                                sSubCategory = MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ""
                            Else
                                sbPE.Append(",  ")
                                If MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                                    sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(+)")

                                Else
                                    sbPE.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(-)")

                                End If
                            End If
                        End If
                    End If
                End If
            End If



            If MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value.ToString.Length > 3 Then
                If MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value.ToString.Substring(0, 3) = "ROS" Then
                    If MMCHRosAndGenDataGridView.Rows(i).Cells("Negative").Value = True Or MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                        If sCategory <> MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value Then

                            sb.Append(Environment.NewLine)
                            sCategory = MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value
                            sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value & Environment.NewLine)
                            sb.Append("   ")

                            If sSubCategory <> MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & "" Then
                                sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ": ")
                                sSubCategory = MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ""
                            Else
                                sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ", ")
                            End If


                            If MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                                sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(+)")
                            Else
                                sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(-)")
                            End If
                        Else
                            If sSubCategory <> MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & "" Then
                                sb.Append(Environment.NewLine)
                                sb.Append("   ")
                                sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ": ")

                                If MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                                    sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(+)")
                                Else
                                    sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(-)")
                                End If

                                sSubCategory = MMCHRosAndGenDataGridView.Rows(i).Cells("SubCategory").Value & ""
                            Else
                                sb.Append(",  ")
                                If MMCHRosAndGenDataGridView.Rows(i).Cells("Positive").Value = True Then
                                    sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(+)")

                                Else
                                    sb.Append(MMCHRosAndGenDataGridView.Rows(i).Cells("Discription").Value & " " & MMCHRosAndGenDataGridView.Rows(i).Cells("detailtopost").Value & "(-)")

                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Next

        sbPE.Replace("   :", "   ")
        sbPE.Replace("   ,", "   ")
        sb.Replace("   :", "   ")
        sb.Replace("   ,", "   ")
        TextBox1.Text = sbPE.ToString
    End Function


    Private Sub GradientNavigationButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton4.Click
        MMCHRosAndGenDataGridView.EndEdit()
        ROSPE()



        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        Dim cmd As New SqlCommand("SELECT Category, Describe, DetailOfItem, Discription, Heading, HideC, Negative, Positive, ScreenLocation, SubCategory, detailtopost, qid FROM MMCHRosAndGen WHERE Category ='PE-ENT'", cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()









        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-ENT")
        MMCHRosAndGenDataGridView.Refresh()
        'Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        'dv.RowFilter = " Category = 'PE-ENT'"
        'MMCHRosAndGenDataGridView.DataSource = dv
    End Sub

    Private Sub GradientNavigationButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton1.Click
        MMCHRosAndGenDataGridView.EndEdit()
        ROSPE()
        'Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-(Normals)")
        'MMCHRosAndGenDataGridView.Refresh()



        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        Dim cmd As New SqlCommand("SELECT Category, Describe, DetailOfItem, Discription, Heading, HideC, Negative, Positive, ScreenLocation, SubCategory, detailtopost, qid FROM MMCHRosAndGen WHERE Category ='PE-(Normals)'", cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()



    End Sub

    Private Sub GradientNavigationButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton2.Click
        MMCHRosAndGenDataGridView.EndEdit()
        ROSPE()

        'MMCHRosAndGenDataGridView.DataSource = Nothing
        'Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-GI")
        'MMCHRosAndGenDataGridView.Refresh()
        'MMCHRosAndGenDataGridView.Parent.Refresh()


        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        Dim cmd As New SqlCommand("SELECT Category, Describe, DetailOfItem, Discription, Heading, HideC, Negative, Positive, ScreenLocation, SubCategory, detailtopost, qid FROM MMCHRosAndGen WHERE Category ='PE-GI'", cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()

        'Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        'dv.RowFilter = " Category = 'PE-GI'"
        'MMCHRosAndGenDataGridView.DataSource = dv
    End Sub

    Private Sub GradientNavigationButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton3.Click
        MMCHRosAndGenDataGridView.EndEdit()
        ROSPE()
        'Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-Skin")
        'MMCHRosAndGenDataGridView.Refresh()




        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        Dim cmd As New SqlCommand("SELECT Category, Describe, DetailOfItem, Discription, Heading, HideC, Negative, Positive, ScreenLocation, SubCategory, detailtopost, qid FROM MMCHRosAndGen WHERE Category ='PE-Skin'", cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()



        'Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        'dv.RowFilter = " Category = 'PE-Skin'"
        'MMCHRosAndGenDataGridView.DataSource = dv
    End Sub

    Private Sub GradientNavigationButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton5.Click
        MMCHRosAndGenDataGridView.EndEdit()
        ROSPE()
        'Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-GU")
        'MMCHRosAndGenDataGridView.Refresh()




        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        Dim cmd As New SqlCommand("SELECT Category, Describe, DetailOfItem, Discription, Heading, HideC, Negative, Positive, ScreenLocation, SubCategory, detailtopost, qid FROM MMCHRosAndGen WHERE Category ='PE-GU'", cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()






        'Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        'dv.RowFilter = " Category = 'PE-GU'"
        'MMCHRosAndGenDataGridView.DataSource = dv
    End Sub

    Private Sub GradientNavigationButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton6.Click
        MMCHRosAndGenDataGridView.EndEdit()
        ROSPE()
        'Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-MS")
        'MMCHRosAndGenDataGridView.Refresh()




        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        Dim cmd As New SqlCommand("SELECT Category, Describe, DetailOfItem, Discription, Heading, HideC, Negative, Positive, ScreenLocation, SubCategory, detailtopost, qid FROM MMCHRosAndGen WHERE Category ='PE-MS'", cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()









        'Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        'dv.RowFilter = " Category = 'PE-MS'"
        'MMCHRosAndGenDataGridView.DataSource = dv
    End Sub

    Private Sub GradientNavigationButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton7.Click
        MMCHRosAndGenDataGridView.EndEdit()
        ROSPE()
        'Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-Respiratory")
        'MMCHRosAndGenDataGridView.Refresh()




        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        Dim cmd As New SqlCommand("SELECT Category, Describe, DetailOfItem, Discription, Heading, HideC, Negative, Positive, ScreenLocation, SubCategory, detailtopost, qid FROM MMCHRosAndGen WHERE Category ='PE-Respiratory'", cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()






        'Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        'dv.RowFilter = " Category = 'PE-Respiratory'"
        'MMCHRosAndGenDataGridView.DataSource = dv
    End Sub

    Private Sub GradientNavigationButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton8.Click
        MMCHRosAndGenDataGridView.EndEdit()
        ROSPE()
        'Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-Female")
        'MMCHRosAndGenDataGridView.Refresh()







        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        Dim cmd As New SqlCommand("SELECT Category, Describe, DetailOfItem, Discription, Heading, HideC, Negative, Positive, ScreenLocation, SubCategory, detailtopost, qid FROM MMCHRosAndGen WHERE Category ='PE-Female'", cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()








        'Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        'dv.RowFilter = " Category = 'PE-Female'"
        'MMCHRosAndGenDataGridView.DataSource = dv
    End Sub

    Private Sub GradientNavigationButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton9.Click
        MMCHRosAndGenDataGridView.EndEdit()
        ROSPE()
        'Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-lymphatic")
        'MMCHRosAndGenDataGridView.Refresh()




        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        Dim cmd As New SqlCommand("SELECT Category, Describe, DetailOfItem, Discription, Heading, HideC, Negative, Positive, ScreenLocation, SubCategory, detailtopost, qid FROM MMCHRosAndGen WHERE Category ='PE-lymphatic'", cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()





        'Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        'dv.RowFilter = " Category = 'PE-lymphatic'"
        'MMCHRosAndGenDataGridView.DataSource = dv
    End Sub

    Private Sub GradientNavigationButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton10.Click
        MMCHRosAndGenDataGridView.EndEdit()
        ROSPE()
        'Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-CVS")





        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        Dim cmd As New SqlCommand("SELECT Category, Describe, DetailOfItem, Discription, Heading, HideC, Negative, Positive, ScreenLocation, SubCategory, detailtopost, qid FROM MMCHRosAndGen WHERE Category ='PE-CVS'", cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()









        'Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        'dv.RowFilter = " Category = 'PE-CVS'"
        'MMCHRosAndGenDataGridView.DataSource = dv

    End Sub

    Private Sub GradientNavigationButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton14.Click
        MMCHRosAndGenDataGridView.EndEdit()
        ROSPE()





        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        Dim cmd As New SqlCommand("SELECT Category, Describe, DetailOfItem, Discription, Heading, HideC, Negative, Positive, ScreenLocation, SubCategory, detailtopost, qid FROM MMCHRosAndGen WHERE Category ='PE-Neurological'", cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()







        'Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-Neurological")
        'MMCHRosAndGenDataGridView.Refresh()
        'Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        'dv.RowFilter = " Category = 'PE-PSYCH'"
        'MMCHRosAndGenDataGridView.DataSource = dv
    End Sub

    'Private Sub TemplateNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemplateNameComboBox.SelectedIndexChanged

    '    Dim i As Integer = 0

    '    'MMCHRosAndGenDataGridView.DataSource = Nothing

    '    Try

    '        Dim itemFound As Integer = Me.CCProfilesBindingSource.Find("TemplateName", TemplateNameComboBox.Text)
    '        Me.CCProfilesBindingSource.Position = itemFound

    '        Dim connString As String = connString2
    '        Dim cn As New SqlConnection(connString)
    '        cn.Open()
    '        Dim strCodes, strTemplateName As String

    '        strTemplateName = DprofilesDataSet.Tables(0).Rows(Me.CCProfilesBindingSource.Position)("TemplateName")
    '        ' strCodes = DprofilesDataSet.Tables(0).Rows(Me.CCProfilesBindingSource.Position)("Codes")
    '        ' strCodes = "799,800,801,802,803,804,805,806,807,808,809"
    '        'Dim cmd As New SqlCommand("SELECT Category,SubCategory,Discription,Negative,Positive,qid,ScreenLocation FROM   MMCHRosAndGen where qid In(" + strCodes + ")", cn)

    '        'Dim cmd As New SqlCommand("SELECT MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive, MMCHRosAndGen.qid, MMCHRosAndGen.ScreenLocation, QIDs.TemplateName  From        MMCHRosAndGen INNER JOIN   QIDs ON MMCHRosAndGen.qid = QIDs.QID WHERE     MMCHRosAndGen.qid IN (" + strCodes + ")  AND QIDs.TemplateName = '" + TemplateNameComboBox.Text + "' ORDER BY MMCHRosAndGen.ScreenLocation,QIDs.SortOrder", cn)
    '        ' Dim cmd As New SqlCommand("SELECT     MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive, QIDs.TemplateName, MMCHROSandGenCat.SortOrder, QIDs.SortOrder AS QIDSortOrder FROM MMCHRosAndGen INNER JOIN QIDs ON MMCHRosAndGen.qid = QIDs.QID INNER JOIN MMCHROSandGenCat ON MMCHRosAndGen.Category = MMCHROSandGenCat.Category WHERE MMCHRosAndGen.qid IN (" + strCodes + ")  AND QIDs.TemplateName = '" + TemplateNameComboBox.Text + "' ORDER BY MMCHROSandGenCat.SortOrder, QIDs.SortOrder", cn)
    '        ' Dim cmd As New SqlCommand("SELECT MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription as Discription, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive,   QIDs.TemplateName, MMCHROSandGenCat.SortOrder, QIDs.SortOrder AS QIDSortOrder, QIDs.QID, QIDs.ID, detailofitem, DetailtoPost FROM  MMCHRosAndGen INNER JOIN QIDs ON MMCHRosAndGen.qid = QIDs.QID INNER JOIN MMCHROSandGenCat ON MMCHRosAndGen.Category = MMCHROSandGenCat.Category WHERE     QIDs.TemplateName = '" + TemplateNameComboBox.Text + "' ORDER BY MMCHROSandGenCat.SortOrder, QIDSortOrder", cn)
    '        Dim cmd As New SqlCommand("SELECT MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription as Discription, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive,   QIDs.TemplateName, MMCHROSandGenCat.SortOrder, QIDs.SortOrder AS QIDSortOrder, QIDs.QID, QIDs.ID, detailofitem, DetailtoPost FROM  MMCHRosAndGen INNER JOIN QIDs ON MMCHRosAndGen.qid = QIDs.QID INNER JOIN MMCHROSandGenCat ON MMCHRosAndGen.Category = MMCHROSandGenCat.Category WHERE     QIDs.TemplateName = '" + TemplateNameComboBox.Text + "' ORDER BY MMCHROSandGenCat.SortOrder, QIDSortOrder", cn)


    '        Dim da As New SqlDataAdapter
    '        Dim tbl As New DataTable
    '        Dim ds As New DataSet
    '        da.SelectCommand = cmd
    '        da.Fill(ds, "MMCHRosAndGen")
    '        ' DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
    '        MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")


    '        '----------------------------------------------------------------------------
    '        'MMCHRosAndGenDataGridView.Columns("TemplateName").Visible = False
    '        'MMCHRosAndGenDataGridView.Columns("SortOrder").Visible = False
    '        'MMCHRosAndGenDataGridView.Columns("QIDSortOrder").Visible = False
    '        'MMCHRosAndGenDataGridView.Columns("QID").Visible = False
    '        'MMCHRosAndGenDataGridView.Columns("ID").Visible = False
    '        'MMCHRosAndGenDataGridView.Columns("detailofitem").Visible = False
    '        ''----------------------------------------------------------------------------

    '        ''IfMMCHRosAndGenDataGridView.Columns.Contains("DetailButton") Then

    '        ''Else

    '        'MMCHRosAndGenDataGridView.Columns(0).Width = 90
    '        'MMCHRosAndGenDataGridView.Columns(1).Width = 0
    '        'MMCHRosAndGenDataGridView.Columns(2).Width = 115
    '        'MMCHRosAndGenDataGridView.Columns(3).Width = 40
    '        'MMCHRosAndGenDataGridView.Columns(4).Width = 40
    '        'MMCHRosAndGenDataGridView.Columns(3).DefaultCellStyle.BackColor = Color.LightCyan
    '        'MMCHRosAndGenDataGridView.Columns(4).DefaultCellStyle.BackColor = Color.LightPink


    '        'Dim detailcolumn As New DataGridViewButtonColumn()
    '        'detailcolumn.Name = "DetailButton"
    '        'detailcolumn.HeaderText = ""
    '        'MMCHRosAndGenDataGridView1.Columns.Add(detailcolumn)
    '        'detailcolumn.Width = 25
    '        'Dim font As New Font(MMCHRosAndGenDataGridView1.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Bold)
    '        'detailcolumn.DefaultCellStyle.Font = font
    '        '' detailcolumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


    '        'Dim tempcolumn As New DataGridViewTextBoxColumn()
    '        'tempcolumn.Name = "Temp"
    '        'MMCHRosAndGenDataGridView1.Columns.Add(tempcolumn)
    '        'tempcolumn.Width = 200
    '        'End If




    '        'TabControl3.SelectedIndex = 2
    '        'TabControl1.SelectedIndex = 2
    '        ds.Dispose()

    '        'For i = 0 ToMMCHRosAndGenDataGridView.RowCount - 1
    '        '    IfMMCHRosAndGenDataGridView.Rows(i).Cells("DetailOfItem").Value <> "" Then
    '        '       MMCHRosAndGenDataGridView.Rows(i).Cells("DetailButton").Value = "***"
    '        '    End If
    '        'Next




    '    Catch ex As System.Exception
    '        MessageBox.Show(ex.Message, "Load Profile", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '    End Try
    'End Sub

    Private Function LoadComboBoxes2()

        Dim dr As DataRow
        Dim dt As DataTable
        Dim drCCProfiles As DataRow
        Dim dtCCProfiles As DataTable

        dtCCProfiles = Me.DprofilesDataSet.Tables("CCProfiles")
        dt = Me.MMDataDataSet1.Tables("MMCombo")



        'TemplateNameComboBox.Items.Clear()
        'For Each drCCProfiles In dtCCProfiles.Rows
        '    If drCCProfiles("TemplateName") <> "" Then
        '        TemplateNameComboBox.Items.Add(drCCProfiles("TemplateName"))
        '    End If
        'Next

    End Function

    ''Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    ''End Sub

    'Private Sub btnSketch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSketch.Click
    '    'Dim arrayRet(3) As String
    '    ChCsDtArray(0) = ChartNumber
    '    ChCsDtArray(1) = Casenumber
    '    ChCsDtArray(2) = strDate
    '    BodySketch.ShowBodySketch(ChCsDtArray)
    '    RetrieveBodySketch()
    'End Sub

    Private Sub MMCHRosAndGenDataGridView_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MMCHRosAndGenDataGridView.CellContentClick
        CheckedListBox1.Items.Clear()
        Try

            ' If e.ColumnIndex = MMCHRosAndGenDataGridView1.Columns("DetailButton").Index Then

            If MMCHRosAndGenDataGridView.Rows(e.RowIndex).Cells("DetailOfItem").Value <> "" Then
                rowIndex = e.RowIndex
                Dim arrActions() As String
                Dim item As String
                Dim ItemsToSplit As String = MMCHRosAndGenDataGridView.Rows(e.RowIndex).Cells("DetailOfItem").Value
                arrActions = ItemsToSplit.Split(",")

                For Each item In arrActions
                    CheckedListBox1.Items.Add(item)
                Next
            End If
        Catch
        End Try
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Dim i As Integer
        Dim ii As Integer
        Dim itemsSB As String
        Dim itemsToAdd As String

        Try
            For i = 0 To CheckedListBox1.Items.Count - 1
                itemsSB = itemsSB + CheckedListBox1.Items(i).ToString
            Next
            If MMCHRosAndGenDataGridView.Rows(rowIndex).Cells("DetailOfItem").Value.ToString.Replace(",", "") = itemsSB Then
                If MMCHRosAndGenDataGridView.Rows(rowIndex).Cells("DetailtoPost").Value <> "" Then
                    MMCHRosAndGenDataGridView.Rows(rowIndex).Cells("DetailtoPost").Value = MMCHRosAndGenDataGridView.Rows(rowIndex).Cells("DetailtoPost").Value & ", " & CheckedListBox1.SelectedItem.ToString
                Else
                    MMCHRosAndGenDataGridView.Rows(rowIndex).Cells("DetailtoPost").Value = CheckedListBox1.SelectedItem.ToString
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Public Function RetrieveBodySketch()
    '    Try

    '        If Not (PictureBoxBodySketch.Image Is Nothing) Then
    '            PictureBoxBodySketch.Image.Dispose()
    '            PictureBoxBodySketch.Image = Nothing
    '        End If

    '        Dim originalimage As System.Drawing.Image
    '        Dim thumb As System.Drawing.Image
    '        Dim inp As New IntPtr()

    '        originalimage = Image.FromFile("C:\BodySketches\" & ChartNumber & Casenumber & ".jpeg")

    '        thumb = originalimage.GetThumbnailImage(161, 181, Nothing, inp)
    '        Me.PictureBoxBodySketch.Image = thumb

    '    Catch ex As System.Exception

    '    End Try

    'End Function

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    'Me.MMCHRosAndGenTableAdapter.FillByROSPE(Me.MMDataDataSet1.MMCHRosAndGen)
    'Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
    'dv.RowFilter = ""
    'MMCHRosAndGenDataGridView.DataSource = dv
    'End Sub




    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        '    Dim i As Integer = 0
        '    On Error Resume Next
        '    'MMCHRosAndGenDataGridView.DataSource = Nothing

        '    '   Try

        '    Dim itemFound As Integer = Me.CCProfilesBindingSource.Find("TemplateName", DataGridView1.Rows(i).Cells("TemplateName").Value)
        '    Me.CCProfilesBindingSource.Position = itemFound

        '    Dim connString As String = connString2
        '    Dim cn As New SqlConnection(connString)
        '    cn.Open()
        '    Dim strCodes, strTemplateName As String

        '    strTemplateName = DprofilesDataSet.Tables(0).Rows(Me.CCProfilesBindingSource.Position)("TemplateName")
        '    ' strCodes = DprofilesDataSet.Tables(0).Rows(Me.CCProfilesBindingSource.Position)("Codes")
        '    ' strCodes = "799,800,801,802,803,804,805,806,807,808,809"
        '    'Dim cmd As New SqlCommand("SELECT Category,SubCategory,Discription,Negative,Positive,qid,ScreenLocation FROM   MMCHRosAndGen where qid In(" + strCodes + ")", cn)

        '    'Dim cmd As New SqlCommand("SELECT MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive, MMCHRosAndGen.qid, MMCHRosAndGen.ScreenLocation, QIDs.TemplateName  From        MMCHRosAndGen INNER JOIN   QIDs ON MMCHRosAndGen.qid = QIDs.QID WHERE     MMCHRosAndGen.qid IN (" + strCodes + ")  AND QIDs.TemplateName = '" + TemplateNameComboBox.Text + "' ORDER BY MMCHRosAndGen.ScreenLocation,QIDs.SortOrder", cn)
        '    ' Dim cmd As New SqlCommand("SELECT     MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive, QIDs.TemplateName, MMCHROSandGenCat.SortOrder, QIDs.SortOrder AS QIDSortOrder FROM MMCHRosAndGen INNER JOIN QIDs ON MMCHRosAndGen.qid = QIDs.QID INNER JOIN MMCHROSandGenCat ON MMCHRosAndGen.Category = MMCHROSandGenCat.Category WHERE MMCHRosAndGen.qid IN (" + strCodes + ")  AND QIDs.TemplateName = '" + TemplateNameComboBox.Text + "' ORDER BY MMCHROSandGenCat.SortOrder, QIDs.SortOrder", cn)
        '    ' Dim cmd As New SqlCommand("SELECT MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription as Discription, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive,   QIDs.TemplateName, MMCHROSandGenCat.SortOrder, QIDs.SortOrder AS QIDSortOrder, QIDs.QID, QIDs.ID, detailofitem, DetailtoPost FROM  MMCHRosAndGen INNER JOIN QIDs ON MMCHRosAndGen.qid = QIDs.QID INNER JOIN MMCHROSandGenCat ON MMCHRosAndGen.Category = MMCHROSandGenCat.Category WHERE     QIDs.TemplateName = '" + TemplateNameComboBox.Text + "' ORDER BY MMCHROSandGenCat.SortOrder, QIDSortOrder", cn)
        '    Dim cmd As New SqlCommand("SELECT MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription as Discription, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive,   QIDs.TemplateName, MMCHROSandGenCat.SortOrder, QIDs.SortOrder AS QIDSortOrder, QIDs.QID, QIDs.ID, detailofitem, DetailtoPost FROM  MMCHRosAndGen INNER JOIN QIDs ON MMCHRosAndGen.qid = QIDs.QID INNER JOIN MMCHROSandGenCat ON MMCHRosAndGen.Category = MMCHROSandGenCat.Category WHERE     QIDs.TemplateName = '" + DataGridView1.Rows(i).Cells("TemplateName").Value + "' ORDER BY MMCHROSandGenCat.SortOrder, QIDSortOrder", cn)


        '    Dim da As New SqlDataAdapter
        '    Dim tbl As New DataTable
        '    Dim ds As New DataSet
        '    da.SelectCommand = cmd
        '    da.Fill(ds, "MMCHRosAndGen")
        '    ' DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
        '    MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")


        '    '----------------------------------------------------------------------------
        '    'MMCHRosAndGenDataGridView.Columns("TemplateName").Visible = False
        '    'MMCHRosAndGenDataGridView.Columns("SortOrder").Visible = False
        '    'MMCHRosAndGenDataGridView.Columns("QIDSortOrder").Visible = False
        '    'MMCHRosAndGenDataGridView.Columns("QID").Visible = False
        '    'MMCHRosAndGenDataGridView.Columns("ID").Visible = False
        '    'MMCHRosAndGenDataGridView.Columns("detailofitem").Visible = False
        '    ''----------------------------------------------------------------------------

        '    ''IfMMCHRosAndGenDataGridView.Columns.Contains("DetailButton") Then

        '    ''Else

        '    'MMCHRosAndGenDataGridView.Columns(0).Width = 90
        '    'MMCHRosAndGenDataGridView.Columns(1).Width = 0
        '    'MMCHRosAndGenDataGridView.Columns(2).Width = 115
        '    'MMCHRosAndGenDataGridView.Columns(3).Width = 40
        '    'MMCHRosAndGenDataGridView.Columns(4).Width = 40
        '    'MMCHRosAndGenDataGridView.Columns(3).DefaultCellStyle.BackColor = Color.LightCyan
        '    'MMCHRosAndGenDataGridView.Columns(4).DefaultCellStyle.BackColor = Color.LightPink


        '    'Dim detailcolumn As New DataGridViewButtonColumn()
        '    'detailcolumn.Name = "DetailButton"
        '    'detailcolumn.HeaderText = ""
        '    'MMCHRosAndGenDataGridView1.Columns.Add(detailcolumn)
        '    'detailcolumn.Width = 25
        '    'Dim font As New Font(MMCHRosAndGenDataGridView1.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Bold)
        '    'detailcolumn.DefaultCellStyle.Font = font
        '    '' detailcolumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        '    'Dim tempcolumn As New DataGridViewTextBoxColumn()
        '    'tempcolumn.Name = "Temp"
        '    'MMCHRosAndGenDataGridView1.Columns.Add(tempcolumn)
        '    'tempcolumn.Width = 200
        '    'End If




        '    'TabControl3.SelectedIndex = 2
        '    'TabControl1.SelectedIndex = 2
        '    ds.Dispose()

        '    'For i = 0 ToMMCHRosAndGenDataGridView.RowCount - 1
        '    '    IfMMCHRosAndGenDataGridView.Rows(i).Cells("DetailOfItem").Value <> "" Then
        '    '       MMCHRosAndGenDataGridView.Rows(i).Cells("DetailButton").Value = "***"
        '    '    End If
        '    'Next




        '    'Catch ex As System.Exception
        '    '    MessageBox.Show(ex.Message, "Load Profile", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    'End Try
        '







        If DataGridView1.SelectedRows.Count Then

            Dim i As Integer = 0
            Try
                ' Dim itemFound As Integer = Me.CCProfilesBindingSource.Find("TemplateName", TemplateNameComboBox.Text)
                ' Me.CCProfilesBindingSource.Position = itemFound

                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                Dim strTemplateName As String

                strTemplateName = DataGridView1.SelectedRows(0).Cells("TemplateNameDataGridViewTextBoxColumn").Value
                Dim cmd As New SqlCommand("SELECT MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription as Discription, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive,   QIDs.TemplateName, MMCHROSandGenCat.SortOrder, QIDs.SortOrder AS QIDSortOrder, QIDs.QID, QIDs.ID, detailofitem, DetailtoPost FROM  MMCHRosAndGen INNER JOIN QIDs ON MMCHRosAndGen.qid = QIDs.QID INNER JOIN MMCHROSandGenCat ON MMCHRosAndGen.Category = MMCHROSandGenCat.Category WHERE     QIDs.TemplateName = '" + strTemplateName + "' ORDER BY MMCHROSandGenCat.SortOrder, QIDSortOrder", cn)

                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMCHRosAndGen")

                MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
                ds.Dispose()

                ApplyColorToGrid()


            Catch ex As System.Exception
                MessageBox.Show(ex.Message, "Load Profile", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If
    End Sub


    Private Function ApplyColorToGrid()

        Try
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            Dim strTemplateName As String
            Dim i As Integer
            Dim ii As Integer = 0
            Dim mycolor As Color

            cn.Open()

            Dim db As DBAccess = New DBAccess()
            Dim localdr As SqlClient.SqlDataReader

            If DataGridView1.SelectedRows.Count Then
                strTemplateName = DataGridView1.SelectedRows(0).Cells("TemplateNameDataGridViewTextBoxColumn").Value
            Else
                strTemplateName = globalTemplate
            End If

            ' Dim cmd As New SqlCommand("SELECT distinct MMCHRosAndGen.Category FROM  MMCHRosAndGen INNER JOIN QIDs ON MMCHRosAndGen.qid = QIDs.QID INNER JOIN MMCHROSandGenCat ON MMCHRosAndGen.Category = MMCHROSandGenCat.Category WHERE     QIDs.TemplateName = '" + strTemplateName + "'", cn)


            localdr = db.ExecuteReader("SELECT distinct MMCHRosAndGen.Category FROM  MMCHRosAndGen INNER JOIN QIDs ON MMCHRosAndGen.qid = QIDs.QID INNER JOIN MMCHROSandGenCat ON MMCHRosAndGen.Category = MMCHROSandGenCat.Category WHERE     QIDs.TemplateName = '" + strTemplateName + "'")

            mycolor = RandomRGBColor()
            If localdr.HasRows = True Then
                While localdr.Read
                    If localdr.Item(0).ToString <> "" Then

                        For i = 0 To MMCHRosAndGenDataGridView.RowCount - 1
                            If localdr.Item(0).ToString = MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Value Then

                                MMCHRosAndGenDataGridView.Rows(i).Cells("Category").Style.BackColor = mycolor
                            End If
                        Next
                        ii += 1
                        mycolor = RandomRGBColor()
                    End If
                End While
            End If
            localdr.Close()


        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "Color Code", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Function


    Public Function RandomRGBColor() As Color
        Return Color.FromArgb(255, m_Rnd.Next(128) + 127, m_Rnd.Next(128) + 127, m_Rnd.Next(128) + 127)
    End Function

    Private Sub MMCHRosAndGenDataGridView_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMCHRosAndGenDataGridView.Sorted
        ApplyColorToGrid()
    End Sub

    Private Sub chkPanelMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkPanelMove_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPanelMove.CheckedChanged
        If chkPanelMove.Checked = True Then
            Me.SplitContainer1.SplitterDistance = 660
            TabControl1.Width = 660
            DataGridView1.Width = 650
        Else
            Me.SplitContainer1.SplitterDistance = 295
            TabControl1.Width = 295
            DataGridView1.Width = 286
        End If
    End Sub

    Private Function LoadGlobalTemplate()
        If globalTemplate <> "" Then

            '   If DataGridView1.SelectedRows.Count Then

            Dim i As Integer = 0
            Try

                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                Dim strTemplateName As String

                ' strTemplateName = DataGridView1.SelectedRows(0).Cells("TemplateNameDataGridViewTextBoxColumn").Value
                Dim cmd As New SqlCommand("SELECT MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription as Discription, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive,   QIDs.TemplateName, MMCHROSandGenCat.SortOrder, QIDs.SortOrder AS QIDSortOrder, QIDs.QID, QIDs.ID, detailofitem, DetailtoPost FROM  MMCHRosAndGen INNER JOIN QIDs ON MMCHRosAndGen.qid = QIDs.QID INNER JOIN MMCHROSandGenCat ON MMCHRosAndGen.Category = MMCHROSandGenCat.Category WHERE     QIDs.TemplateName = '" + globalTemplate + "' ORDER BY MMCHROSandGenCat.SortOrder, QIDSortOrder", cn)

                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMCHRosAndGen")

                MMCHRosAndGenDataGridView.DataSource = ds.Tables("MMCHRosAndGen")
                ds.Dispose()

                ApplyColorToGrid()
                Me.Text = Me.Text + "    " + globalTemplate + "- " + globalChiefComplaint

            Catch ex As System.Exception
                MessageBox.Show(ex.Message, "Load Profile", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            'End If
        End If
    End Function
End Class