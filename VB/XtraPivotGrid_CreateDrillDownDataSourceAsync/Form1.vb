Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace XtraPivotGrid_CreateDrillDownDataSourceAsync
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            ' Binds the pivot grid to data.
            Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)
        End Sub

        Private Sub pivotGridControl1_CellClick(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles pivotGridControl1.CellClick
            Dim pivot As PivotGridControl = TryCast(sender, PivotGridControl)

            'Checks whether an asynchronous operation is in progress.
            If Not pivot.IsAsyncInProgress Then

                ' Gets the record set associated with the clicked cell.
                ' The delegate is passed to obtain this record set.
                pivot.CreateDrillDownDataSourceAsync(e.ColumnIndex, e.RowIndex, Sub(result) label1.Text = "RowCount = " & CType(result.Value, PivotDrillDownDataSource).RowCount)
            End If
                    ' The 'result' parameter of the delegate returns an AsyncOperationResult instance.
                    ' The AsyncOperationResult.Value property is used to obtain the record set, 
                    ' the PivotDrillDownDataSource.RowCount property is used to obtain the number 
                    ' of records in the data source.
        End Sub
    End Class
End Namespace