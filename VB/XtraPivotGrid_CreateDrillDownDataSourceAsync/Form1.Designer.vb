Namespace XtraPivotGrid_CreateDrillDownDataSourceAsync
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.linqServerModeSource1 = New DevExpress.Data.Linq.LinqServerModeSource()
            Me.fieldCity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fldMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linqServerModeSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.DataSource = Me.linqServerModeSource1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCity, Me.fieldCountry, Me.fldYear, Me.fieldExtendedPrice, Me.fldMonth})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(648, 368)
            Me.pivotGridControl1.TabIndex = 0
            '
            'linqServerModeSource1
            '
            Me.linqServerModeSource1.DefaultSorting = "OrderID ASC"
            Me.linqServerModeSource1.ElementType = GetType(XtraPivotGrid_CreateDrillDownDataSourceAsync.Invoice)
            Me.linqServerModeSource1.KeyExpression = "OrderID"
            '
            'fieldCity
            '
            Me.fieldCity.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCity.AreaIndex = 1
            Me.fieldCity.Caption = "City"
            DataSourceColumnBinding1.ColumnName = "City"
            Me.fieldCity.DataBinding = DataSourceColumnBinding1
            Me.fieldCity.Name = "fieldCity"
            '
            'fieldCountry
            '
            Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCountry.AreaIndex = 0
            Me.fieldCountry.Caption = "Country"
            DataSourceColumnBinding2.ColumnName = "Country"
            Me.fieldCountry.DataBinding = DataSourceColumnBinding2
            Me.fieldCountry.Name = "fieldCountry"
            '
            'fldYear
            '
            Me.fldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fldYear.AreaIndex = 0
            Me.fldYear.Caption = "Year"
            DataSourceColumnBinding3.ColumnName = "OrderDate"
            DataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fldYear.DataBinding = DataSourceColumnBinding3
            Me.fldYear.Name = "fldYear"
            Me.fldYear.UnboundFieldName = "fldYear"
            '
            'fieldExtendedPrice
            '
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            DataSourceColumnBinding4.ColumnName = "ExtendedPrice"
            Me.fieldExtendedPrice.DataBinding = DataSourceColumnBinding4
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            '
            'fldMonth
            '
            Me.fldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fldMonth.AreaIndex = 1
            Me.fldMonth.Caption = "Month"
            DataSourceColumnBinding5.ColumnName = "OrderDate"
            DataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fldMonth.DataBinding = DataSourceColumnBinding5
            Me.fldMonth.Name = "fldMonth"
            Me.fldMonth.UnboundFieldName = "fldMonth"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(648, 368)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "CreateDrillDownDataSourceAsync Example"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linqServerModeSource1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldCity As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField
		Private fldYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fldMonth As DevExpress.XtraPivotGrid.PivotGridField
		Private linqServerModeSource1 As DevExpress.Data.Linq.LinqServerModeSource
	End Class
End Namespace

