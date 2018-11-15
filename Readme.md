<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_CreateDrillDownDataSourceAsync/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_CreateDrillDownDataSourceAsync/Form1.vb))
<!-- default file list end -->
# How to use asynchronous operations that return the result


<p>This example shows how to use asynchronous operations that return the result. <br />
In this example, the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridPivotGridControl_CellClicktopic"><u>PivotGridControl.CellClick</u></a> event is handled to generate a drill-down data source for a specific cell using the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridPivotGridControl_CreateDrillDownDataSourceAsynctopic"><u>PivotGridControl.CreateDrillDownDataSourceAsync</u></a> method. The <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridAsyncCompletedHandlertopic"><u>AsyncCompletedHandler</u></a> delegate is passed as a method parameter. The referenced method is executed after the operation is completed, allowing to obtain the result via the <i>result</i> parameter of the delegate. This parameter returns an <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridAsyncOperationResultMembersTopicAll"><u>AsyncOperationResult</u></a> instance.<br />
The <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridAsyncOperationResult_Valuetopic"><u>AsyncOperationResult.Value</u></a> property is used to obtain a record set associated with the clicked cell. Then, the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPivotGridPivotDrillDownDataSource_RowCounttopic"><u>PivotDrillDownDataSource.RowCount</u></a> property is used to determine the number of records in the data source for this cell.</p>

<br/>


