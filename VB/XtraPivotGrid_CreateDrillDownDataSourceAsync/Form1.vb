﻿Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Collections.Generic

Namespace XtraPivotGrid_CreateDrillDownDataSourceAsync
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Private dForm As DrillDownForm
		Public Sub New()
			InitializeComponent()
			AddHandler Me.Load, AddressOf Form1_Load
			' This line of code is generated by Data Source Configuration Wizard
			linqServerModeSource1.QueryableSource = (New XtraPivotGrid_CreateDrillDownDataSourceAsync.DataClasses1DataContext()).Invoices
		End Sub
		Private Sub pivotGridControl1_CellClick(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles pivotGridControl1.CellClick
			Dim pivot As PivotGridControl = TryCast(sender, PivotGridControl)
			If dForm.IsDisposed Then
				LoadDrillDownForm()
			End If

			'Check whether an asynchronous operation is in progress.
			If Not pivot.IsAsyncInProgress Then

				' Get the record set associated with the clicked cell.
				pivot.CreateDrillDownDataSourceAsync(e.ColumnIndex, e.RowIndex, 25, New List(Of String) From {"ProductName", "Quantity"}, Sub(result)
					' The 'result' parameter of the delegate returns an AsyncOperationResult instance.
					' The AsyncOperationResult.Value property contains a record set.
					dForm.DataSource = CType(result.Value, PivotDrillDownDataSource)
				End Sub)
			End If
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			LoadDrillDownForm()
		End Sub

		Private Sub LoadDrillDownForm()
			dForm = New DrillDownForm()
			dForm.Show()
		End Sub
	End Class
End Namespace