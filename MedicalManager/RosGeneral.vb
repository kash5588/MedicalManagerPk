Imports System.Text

Public Class RosGeneral
    Dim aRet(2) As String
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean

    Private Sub RosGeneral_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '  Me.MMCHRosAndGenTableAdapter.Fill(Me.MMDataDataSet1.MMCHRosAndGen)
    End Sub

    Private Sub MMCHRosAndGenBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MMCHRosAndGenBindingSource.EndEdit()
        Me.MMCHRosAndGenTableAdapter.Update(Me.MMDataDataSet1.MMCHRosAndGen)

    End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.MMCHRosAndGenTableAdapter.Fill(Me.MMDataDataSet1.MMCHRosAndGen, CategoryToolStripTextBox.Text)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub GradientNavigationButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton4.Click

        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-HEENT2")
    End Sub

    Private Sub GradientNavigationButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton1.Click
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-CONST")
    End Sub

    Private Sub GradientNavigationButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton2.Click
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-GI")
    End Sub


    Private Sub GradientNavigationButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton5.Click
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-GU")
    End Sub

    Private Sub GradientNavigationButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton6.Click
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Musc/Skel")
    End Sub

    Private Sub GradientNavigationButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton7.Click
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Resp")
    End Sub

    Private Sub GradientNavigationButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton8.Click
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Female Reproductive")
    End Sub

    Private Sub GradientNavigationButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton9.Click
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Hematological")
    End Sub

    Private Sub GradientNavigationButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton10.Click
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-CVS")
    End Sub

    Private Sub GradientNavigationButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton11.Click
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Endocrine")
    End Sub

    Private Sub GradientNavigationButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton12.Click
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Immunological")
    End Sub

    Private Sub GradientNavigationButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton13.Click
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "")
    End Sub

    Private Sub GradientNavigationButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton14.Click
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Psychiatric")
    End Sub


    Private Sub cmdROS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdROS.Click

        Dim i As Integer
        Dim sCategory As String = ""
        Dim sSubCategory As String = ""
        Dim sDescription As String = ""
        Dim sNeg As String = ""
        Dim sPos As String = ""
        Dim sb As StringBuilder = New StringBuilder

        If mbPicklistmode Then
            PicklistSelect()
        End If
        Dim s As String

        For i = 0 To MMCHRosAndGenDataGridView.RowCount - 1
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

        sb.Replace("   :", "   ")
        sb.Replace("   ,", "   ")
        TextBox1.Text = TextBox1.Text & sb.ToString

    End Sub

    Private Sub MMCHRosAndGenDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MMCHRosAndGenDataGridView.CellContentClick

    End Sub

    Private Sub MMCHRosAndGenDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MMCHRosAndGenDataGridView.CellFormatting
        ' If MMDataDataSet1.MMCHRosAndGen.Rows(e.RowIndex)("Heading") = System.DBNull.Value Then
        If Not String.IsNullOrEmpty(MMDataDataSet1.MMCHRosAndGen.Rows(e.RowIndex)("Heading")) Then

            'If MMDataDataSet1.MMCHRosAndGen.Rows(e.RowIndex)("Heading").ToString <>  Then
            If e.ColumnIndex = 4 Then
                e.CellStyle.ForeColor = Drawing.Color.Blue
                ' e.CellStyle.Font = Drawing.FontStyle.Bold
                e.CellStyle.BackColor = Drawing.Color.Red
            End If
        End If
    End Sub


    Public Function ShowPicklist() As String()

        Dim aRet(2) As String
        ' On Error GoTo EH
        aRet(0) = "N"
        mbPicklistmode = True
        mbSelected = False
        Me.ShowDialog()
        If mbSelected Then
            aRet(0) = "Y"
            aRet(1) = TextBox1.Text


        End If
        ShowPicklist = aRet
        Me.Close()
        Exit Function

    End Function

    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub



End Class