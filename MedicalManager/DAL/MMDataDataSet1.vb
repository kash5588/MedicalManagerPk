Partial Class MMDataDataSet1
    Partial Class MMComboDataTable

    End Class

    Partial Class MMCentralMonitorDataTable

        Private Sub MMCentralMonitorDataTable_MMCentralMonitorRowChanging(ByVal sender As System.Object, ByVal e As MMCentralMonitorRowChangeEvent) Handles Me.MMCentralMonitorRowChanging

        End Sub

    End Class

    Partial Class VisitSummaryDataTable

    End Class

    Partial Class MMDRUGDataTable

    End Class

    Partial Class MMPhysionDataTable

        Private Sub MMPhysionDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.FaxColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

      Partial Class MMChartMessagesDataTable

            Private Sub MMChartMessagesDataTable_MMChartMessagesRowChanging(ByVal sender As System.Object, ByVal e As MMChartMessagesRowChangeEvent) Handles Me.MMChartMessagesRowChanging

            End Sub

      End Class

      Partial Class MMPATIENTDataTable

      End Class

End Class
