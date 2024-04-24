Public Class TemplateMaintenance

    Private Sub MMChiefComplaintsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MMChiefComplaintsBindingSource.EndEdit()
        Me.MMChiefComplaintsTableAdapter.Update(Me.MMDataDataSet2.MMChiefComplaints)
    End Sub

    Private Sub TemplateMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DprofilesDataSet.CCProfiles' table. You can move, or remove it, as needed.
        Me.CCProfilesTableAdapter.Fill(Me.DprofilesDataSet.CCProfiles)
        'TODO: This line of code loads data into the 'MMDataDataSet2.MMChiefComplaints' table. You can move, or remove it, as needed.
        Me.MMChiefComplaintsTableAdapter.Fill(Me.MMDataDataSet2.MMChiefComplaints)
    End Sub

    Private Sub btnAddTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTemplate.Click
        Me.CCProfilesBindingSource.AddNew()
        TemplateNameTextBox1.Focus()
    End Sub

    Private Sub btnAddChiefComplaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddChiefComplaint.Click
        Me.MMChiefComplaintsBindingSource.AddNew()
        TemplateNameTextBox.Focus()
    End Sub

    Private Sub CCProfilesBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles CCProfilesBindingSource.AddingNew
        Me.DprofilesDataSet.CCProfiles.CHIEF_COMPLAINTColumn.DefaultValue = ""
    End Sub

    Private Sub btnTemplateSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTemplateSave.Click
        Me.Validate()
        Me.CCProfilesBindingSource.EndEdit()
        Me.CCProfilesTableAdapter.Update(Me.DprofilesDataSet.CCProfiles)
    End Sub

    Private Sub btnSaveCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCC.Click
        Me.Validate()
        Me.MMChiefComplaintsBindingSource.EndEdit()
        Me.MMChiefComplaintsTableAdapter.Update(Me.MMDataDataSet2.MMChiefComplaints)
    End Sub
End Class