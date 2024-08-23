Imports Ascend.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class VisitsList
    Public aRet(10) As String

    Private Sub MMChartVisitBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MMChartVisitBindingSource.EndEdit()
        Me.MMChartVisitTableAdapter.Update(Me.MMDataDataSet1.MMChartVisit)

    End Sub

    Private Sub VisitsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.MMChartVisitTableAdapter.Fill(Me.MMDataDataSet1.MMChartVisit)

    End Sub

    Private Sub MMChartVisitDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles MMChartVisitDataGridView.SelectionChanged
        Try
            If MMChartVisitDataGridView.SelectedRows.Count Then

                aRet(0) = "Y"
                aRet(1) = MMChartVisitDataGridView.SelectedRows(0).Cells("ChartNumber").Value & "" 'chartnumber
                aRet(2) = MMChartVisitDataGridView.SelectedRows(0).Cells("LastName").Value & ""  'last name
                aRet(3) = MMChartVisitDataGridView.SelectedRows(0).Cells("FirstName").Value & ""   'first name
                aRet(10) = MMChartVisitDataGridView.SelectedRows(0).Cells("CaseNumber").Value & ""   'CaseNumber

                ChartNo.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("ChartNumber").Value
                txtName.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("FirstName").Value & " " & Me.MMChartVisitDataGridView.SelectedRows(0).Cells("LastName").Value
                txtCaseNo.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("CaseNumber").Value & ""
                TBTokenNo.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("TokenNo").Value & ""
                TBPhysicianName.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("PhysicianName").Value & ""
                'LoadPicture()

                Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, aRet(1), System.DateTime.Now.Date())
                If DgVitals.Rows.Count > 0 Then
                    PanelVitals.Visible = True
                Else
                    PanelVitals.Visible = False
                End If
                Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, aRet(1), System.DateTime.Now.Date())
                If DgMedicine.Rows.Count > 0 Then
                    PanelMadication.Visible = True
                Else
                    PanelMadication.Visible = False
                End If
            End If
            If MMChartVisitDataGridView.SelectedRows.Count = 0 Then
                clearTextBox()
            End If




        Catch
        End Try
    End Sub

    Private Sub clearTextBox()
        ChartNo.Text = ""
        txtName.Text = ""
        TBTokenNo.Text = ""
        TBPhysicianName.Text = ""
        txtCaseNo.Text = ""
    End Sub

    Private Sub btnVitals_Click(sender As Object, e As EventArgs) Handles btnVitals.Click


        If MMChartVisitDataGridView.SelectedRows.Count Then

            VitalSigns.ShowVitalSigns(aRet)
        End If



    End Sub

    Private Sub BtnMedication_Click(sender As Object, e As EventArgs) Handles BtnMedication.Click
        If MMChartVisitDataGridView.SelectedRows.Count Then
            Prescription.ShowPrescriptions(aRet)
        End If
    End Sub


End Class