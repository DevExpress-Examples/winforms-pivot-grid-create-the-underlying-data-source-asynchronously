namespace XtraPivotGrid_CreateDrillDownDataSourceAsync {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.linqServerModeSource1 = new DevExpress.Data.Linq.LinqServerModeSource();
            this.fieldCity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fldMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.linqServerModeSource1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCity,
            this.fieldCountry,
            this.fldYear,
            this.fieldExtendedPrice,
            this.fldMonth});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(648, 368);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // linqServerModeSource1
            // 
            this.linqServerModeSource1.DefaultSorting = "OrderID ASC";
            this.linqServerModeSource1.ElementType = typeof(XtraPivotGrid_CreateDrillDownDataSourceAsync.Invoice);
            this.linqServerModeSource1.KeyExpression = "OrderID";
            // 
            // fieldCity
            // 
            this.fieldCity.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCity.AreaIndex = 1;
            this.fieldCity.Caption = "City";
            dataSourceColumnBinding1.ColumnName = "City";
            this.fieldCity.DataBinding = dataSourceColumnBinding1;
            this.fieldCity.Name = "fieldCity";
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.Caption = "Country";
            dataSourceColumnBinding2.ColumnName = "Country";
            this.fieldCountry.DataBinding = dataSourceColumnBinding2;
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fldYear
            // 
            this.fldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fldYear.AreaIndex = 0;
            this.fldYear.Caption = "Year";
            dataSourceColumnBinding3.ColumnName = "OrderDate";
            dataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fldYear.DataBinding = dataSourceColumnBinding3;
            this.fldYear.Name = "fldYear";
            this.fldYear.UnboundFieldName = "fldYear";
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Extended Price";
            dataSourceColumnBinding4.ColumnName = "ExtendedPrice";
            this.fieldExtendedPrice.DataBinding = dataSourceColumnBinding4;
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fldMonth
            // 
            this.fldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fldMonth.AreaIndex = 1;
            this.fldMonth.Caption = "Month";
            dataSourceColumnBinding5.ColumnName = "OrderDate";
            dataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fldMonth.DataBinding = dataSourceColumnBinding5;
            this.fldMonth.Name = "fldMonth";
            this.fldMonth.UnboundFieldName = "fldMonth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 368);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateDrillDownDataSourceAsync Example";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqServerModeSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry;
        private DevExpress.XtraPivotGrid.PivotGridField fldYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fldMonth;
        private DevExpress.Data.Linq.LinqServerModeSource linqServerModeSource1;
    }
}

