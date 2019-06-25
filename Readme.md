<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_CreateDrillDownDataSourceAsync/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_CreateDrillDownDataSourceAsync/Form1.vb))
<!-- default file list end -->
# How to Create the Underlying Data Source (Drill-Down) in an Asynchronous Operation

This example performs an asynchronous operation that creates a drill-down data source for the selected PivotGrid cell and gets the operation result - the underlying data source.

In this example, the PivotGrid control is bound to the [LinqServerModeSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.LinqServerModeSource) data source and operates in [server mode](https://docs.devexpress.com/WindowsForms/17856).

The [PivotGridControl.CellClick](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CellClick) event handler calls the [PivotGridControl.CreateDrillDownDataSourceAsync](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CreateDrillDownDataSourceAsync(Int32--Int32--Int32--List-String---AsyncCompletedHandler)) method to generate a drill-down data source for the selected cell. The method parameter specifies the number of records to return. The method also specifies the columns to add to the the data set.

The last item in the method's parameter list is the [AsyncCompletedHandler](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.AsyncCompletedHandler) delegate. The delegate is executed when the operation is complete. The delegate's <i>result</i> parameter is the [AsyncOperationResult](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.AsyncOperationResult) instance whose [Value](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.AsyncOperationResult.Value) property contains the result of the operation. 

The operation's result is casted to the [PivotDrillDownDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotDrillDownDataSource) and the [GridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl) displays the underlying records in the auxillary DrillDown form.

![screenshot](/images/screenshot.png)