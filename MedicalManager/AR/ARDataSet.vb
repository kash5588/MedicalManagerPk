Partial Class ARDataSet
    Partial Class BillingHeaderDataTable

        Private Sub BillingHeaderDataTable_BillingHeaderRowChanging(ByVal sender As System.Object, ByVal e As BillingHeaderRowChangeEvent) Handles Me.BillingHeaderRowChanging

        End Sub

    End Class

    Partial Class MMARCASEDataTable

        Private Sub MMARCASEDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CopayColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class MMARTRANSACTIONSDataTable

        Private Sub MMARTRANSACTIONSDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.AcceptAssignment1Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
