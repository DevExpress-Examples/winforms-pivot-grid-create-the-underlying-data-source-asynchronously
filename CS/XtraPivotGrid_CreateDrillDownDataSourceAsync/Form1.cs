﻿using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;

namespace XtraPivotGrid_CreateDrillDownDataSourceAsync {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        DrillDownForm dForm;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            // This line of code is generated by Data Source Configuration Wizard
            linqServerModeSource1.QueryableSource = new XtraPivotGrid_CreateDrillDownDataSourceAsync.DataClasses1DataContext().Invoices;
        }
        private void pivotGridControl1_CellClick(object sender, 
            DevExpress.XtraPivotGrid.PivotCellEventArgs e) {
			PivotGridControl pivot = sender as PivotGridControl;
            if (dForm.IsDisposed) LoadDrillDownForm();

            //Check whether an asynchronous operation is in progress.
            if (!pivot.IsAsyncInProgress)

                // Get the record set associated with the clicked cell.
                pivot.CreateDrillDownDataSourceAsync(e.ColumnIndex, e.RowIndex, 25, new List<string> { "ProductName","Quantity" }, result => {
                    // The 'result' parameter of the delegate returns an AsyncOperationResult instance.
                    // The AsyncOperationResult.Value property contains a record set.
                    dForm.DataSource = (PivotDrillDownDataSource)result.Value;
                });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDrillDownForm();
        }

        private void LoadDrillDownForm()
        {
            dForm = new DrillDownForm();
            dForm.Show();
        }
    }
}