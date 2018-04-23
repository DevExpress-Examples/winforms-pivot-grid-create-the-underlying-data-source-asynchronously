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
            Me.components = New System.ComponentModel.Container()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New XtraPivotGrid_CreateDrillDownDataSourceAsync.nwindDataSet()
            Me.fieldCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.salesPersonTableAdapter = New XtraPivotGrid_CreateDrillDownDataSourceAsync.nwindDataSetTableAdapters.SalesPersonTableAdapter()
            Me.label1 = New System.Windows.Forms.Label()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataSource = Me.salesPersonBindingSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCountry1, Me.fieldProductName1, Me.fieldCategoryName1, Me.fieldExtendedPrice1, Me.fieldSalesPerson1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(675, 329)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' salesPersonBindingSource
            ' 
            Me.salesPersonBindingSource.DataMember = "SalesPerson"
            Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldCountry1
            ' 
            Me.fieldCountry1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCountry1.AreaIndex = 0
            Me.fieldCountry1.Caption = "Country"
            Me.fieldCountry1.FieldName = "Country"
            Me.fieldCountry1.Name = "fieldCountry1"
            ' 
            ' fieldProductName1
            ' 
            Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName1.AreaIndex = 1
            Me.fieldProductName1.Caption = "Product Name"
            Me.fieldProductName1.FieldName = "ProductName"
            Me.fieldProductName1.Name = "fieldProductName1"
            ' 
            ' fieldCategoryName1
            ' 
            Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName1.AreaIndex = 0
            Me.fieldCategoryName1.Caption = "Category Name"
            Me.fieldCategoryName1.FieldName = "CategoryName"
            Me.fieldCategoryName1.Name = "fieldCategoryName1"
            ' 
            ' fieldExtendedPrice1
            ' 
            Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice1.AreaIndex = 0
            Me.fieldExtendedPrice1.Caption = "Extended Price"
            Me.fieldExtendedPrice1.FieldName = "Extended Price"
            Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
            ' 
            ' fieldSalesPerson1
            ' 
            Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesPerson1.AreaIndex = 1
            Me.fieldSalesPerson1.Caption = "Sales Person"
            Me.fieldSalesPerson1.FieldName = "Sales Person"
            Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
            ' 
            ' salesPersonTableAdapter
            ' 
            Me.salesPersonTableAdapter.ClearBeforeFill = True
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(225)))), (CInt((CByte(226)))), (CInt((CByte(231)))))
            Me.label1.Location = New System.Drawing.Point(201, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(57, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "RowCount"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(675, 329)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private nwindDataSet As nwindDataSet
        Private salesPersonBindingSource As System.Windows.Forms.BindingSource
        Private salesPersonTableAdapter As XtraPivotGrid_CreateDrillDownDataSourceAsync.nwindDataSetTableAdapters.SalesPersonTableAdapter
        Private fieldCountry1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
        Private label1 As System.Windows.Forms.Label
    End Class
End Namespace

