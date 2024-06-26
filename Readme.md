<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582675/21.1.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4567)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->

# Pivot Grid for WinForms - How to Create the Underlying Data Source (Drill-Down) Asynchronously

This example executes an asynchronous operation that creates a drill-down data source for the selected PivotGrid cell and gets the operation result - the underlying data source.

![screenshot](/images/screenshot.png)

## Files to look at

* [Form1.cs](./CS/XtraPivotGrid_CreateDrillDownDataSourceAsync/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_CreateDrillDownDataSourceAsync/Form1.vb))
<!-- default file list end -->

## Example Overview

In this example, the PivotGrid control is bound to the [LinqServerModeSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Linq.LinqServerModeSource) data source and operates in [server mode](https://docs.devexpress.com/WindowsForms/17856).

The [PivotGridControl.CellClick](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CellClick) event handler calls the  [PivotGridControl.CreateDrillDownDataSourceAsync](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CreateDrillDownDataSourceAsync(System.Int32-System.Int32-System.Collections.Generic.List-System.String-)?v=21.1) async method to generate a drill-down data source for the selected cell. The method parameter specifies the number of records to return. The method also specifies the columns to add to the the data set.

The [GridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl) displays the underlying records (the created [PivotDrillDownDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotDrillDownDataSource)) in the auxillary DrillDown form.

## Documentation

- [Asynchronous Mode](https://docs.devexpress.com/WindowsForms/9578/controls-and-libraries/pivot-grid/binding-to-data/asynchronous-mode)
- [Drill Down to the Underlying Data](https://docs.devexpress.com/WindowsForms/1882/controls-and-libraries/pivot-grid/data-shaping/summarization/summaries/obtaining-underlying-data-drill-down)

## More Examples

- [Pivot Grid for WinForms - How to Display Underlying (Drill-Down) Records](https://github.com/DevExpress-Examples/winforms-pivotgrid-how-to-display-underlying-data)
- [Pivot Grid for WPF - How to Display Underlying Records Asynchronously](https://github.com/DevExpress-Examples/wpf-pivotgrid-how-to-display-underlying-data-asynchronously)


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-grid-create-the-underlying-data-source-asynchronously&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-grid-create-the-underlying-data-source-asynchronously&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
