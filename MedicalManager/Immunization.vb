Public Class Immunization

    Dim strChartNumber As String
    Dim aRet(4) As String
    Dim bRet(4) As String
    Dim objCurrentPatient As New CurrentPat

    Private Sub Immunization_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then
                Me.MMChartImmunizationsBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If


            If Me.MMDataDataSet2.MMChartImmunizations.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        Me.MMChartImmunizationsTableAdapter.Update(Me.MMDataDataSet2.MMChartImmunizations)

                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet2.MMChartImmunizations.RejectChanges()

                    Case Else
                        e.Cancel = True

                End Select
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Immunizations form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try

    End Sub

    Private Sub Immunization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MMChartImmunizationsTableAdapter.FillByChart(Me.MMDataDataSet2.MMChartImmunizations, strChartNumber)
        LoadImmunizationList()
    End Sub



    Private Sub MMChartImmunizationsBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMChartImmunizationsBindingSource.AddingNew
        Me.MMDataDataSet2.MMChartImmunizations.ChartNumberColumn.DefaultValue = aRet(1)
        Me.MMDataDataSet2.MMChartImmunizations.DateColumn.DefaultValue = System.DateTime.Today
    End Sub

    Private Function LoadImmunizationList()
        Dim db As DBAccess = New DBAccess()
        Dim localdr As SqlClient.SqlDataReader

        localdr = db.ExecuteReader("SELECT Immunization from MMImmunization")
        If localdr.HasRows = True Then
            While localdr.Read
                If localdr.Item(0).ToString <> "" Then
                    ImmunizationComboBox.Items.Add(localdr.Item(0))
                End If
            End While
        End If
        localdr.Close()
    End Function

    Public Function ShowImmunizations(ByVal dRet() As String) As String()
        aRet = dRet
        strChartNumber = dRet(1)
        Me.Show()
    End Function

    Private Sub MMChartImmunizationsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartImmunizationsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMChartImmunizationsBindingSource.EndEdit()
        Me.MMChartImmunizationsTableAdapter.Update(Me.MMDataDataSet2.MMChartImmunizations)
    End Sub
End Class