Imports System.Windows.Forms

Namespace XtraPivotGrid_CreateDrillDownDataSourceAsync
	Partial Public Class DrillDownForm
		Inherits Form

		Public Sub New()
			InitializeComponent()
			AddHandler gridControl1.DataSourceChanged, AddressOf GridControl1_DataSourceChanged
		End Sub

		Private Sub GridControl1_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs)
			ArrangeLayout()
		End Sub

		Public Property DataSource() As Object
			Get
				Return Me.gridControl1.DataSource
			End Get
			Set(ByVal value As Object)
				Me.gridControl1.DataSource = value
			End Set
		End Property

		Friend Sub ArrangeLayout()
			gridView1.Columns("OrderDate").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
			gridView1.Columns("OrderDate").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			gridView1.Columns("Country").Group()
			gridView1.Columns("City").Group()
			gridView1.Columns("ProductName").Group()
			gridView1.ExpandAllGroups()
		End Sub
	End Class
End Namespace
