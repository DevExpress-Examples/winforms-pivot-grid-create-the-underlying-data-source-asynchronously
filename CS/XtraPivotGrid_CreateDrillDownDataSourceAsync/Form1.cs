using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace XtraPivotGrid_CreateDrillDownDataSourceAsync {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // Binds the pivot grid to data.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);
        }

        private void pivotGridControl1_CellClick(object sender, 
            DevExpress.XtraPivotGrid.PivotCellEventArgs e) {
			PivotGridControl pivot = sender as PivotGridControl;

            //Checks whether an asynchronous operation is in progress.
            if (!pivot.IsAsyncInProgress)

                // Gets the record set associated with the clicked cell.
                // The delegate is passed to obtain this record set.
                pivot.CreateDrillDownDataSourceAsync(e.ColumnIndex, e.RowIndex, result => {

                    // The 'result' parameter of the delegate returns an AsyncOperationResult instance.
                    // The AsyncOperationResult.Value property is used to obtain the record set, 
                    // the PivotDrillDownDataSource.RowCount property is used to obtain the number 
                    // of records in the data source.
                    label1.Text = "RowCount = " + ((PivotDrillDownDataSource)result.Value).RowCount;
                });
        }
    }
}