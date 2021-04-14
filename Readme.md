<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_CreateDrillDownDataSourceAsync/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_CreateDrillDownDataSourceAsync/Form1.vb))
<!-- default file list end -->
# How to Create the Underlying Data Source (Drill-Down) Asynchronously

This example performs an asynchronous operation that creates a drill-down data source for the selected PivotGrid cell and gets the operation result - the underlying data source.

In this example, the PivotGrid control is bound to the [LinqServerModeSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.LinqServerModeSource) data source and operates in [server mode](https://docs.devexpress.com/WindowsForms/17856).

The [PivotGridControl.CellClick](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CellClick) event handler calls the  [PivotGridControl.CreateDrillDownDataSourceAsync](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CreateDrillDownDataSourceAsync(System.Int32-System.Int32-System.Collections.Generic.List-System.String-)?v=21.1) async method to generate a drill-down data source for the selected cell. The method parameter specifies the number of records to return. The method also specifies the columns to add to the the data set.

The [GridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl) displays the underlying records (the created [PivotDrillDownDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotDrillDownDataSource)) in the auxillary DrillDown form.

![screenshot](/images/screenshot.png)
