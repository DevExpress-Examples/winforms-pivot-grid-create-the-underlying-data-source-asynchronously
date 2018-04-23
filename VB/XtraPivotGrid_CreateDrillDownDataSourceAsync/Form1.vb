Imports Microsoft.VisualBasic
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

        Private Sub pivotGridControl1_CellClick( _
        ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellEventArgs) _
        Handles pivotGridControl1.CellClick

            'Checks whether an asynchronous operation is in progress.
            If (Not pivotGridControl1.IsAsyncInProgress) Then

                ' Gets the record set associated with the clicked cell.
                ' The delegate is passed to obtain this record set.
                ' The 'result' parameter of the delegate returns an AsyncOperationResult instance.
                ' The AsyncOperationResult.Value property is used to obtain the record set, 
                ' the PivotDrillDownDataSource.RowCount property is used to obtain the number 
                ' of records in the data source.
                pivotGridControl1.CreateDrillDownDataSourceAsync( _
                e.ColumnIndex, e.RowIndex, Function(result) AnonymousMethod1(result))
            End If
        End Sub
		
		Private Function AnonymousMethod1(ByVal result As Object) As Boolean
			label1.Text = "RowCount = " & (CType(result.Value, PivotDrillDownDataSource)).RowCount
			Return True
		End Function
	End Class
End Namespace
