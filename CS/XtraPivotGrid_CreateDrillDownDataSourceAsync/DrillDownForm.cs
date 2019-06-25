using System.Windows.Forms;

namespace XtraPivotGrid_CreateDrillDownDataSourceAsync
{
    public partial class DrillDownForm : Form
    {
        public DrillDownForm()
        {
            InitializeComponent();
            gridControl1.DataSourceChanged += GridControl1_DataSourceChanged;
        }

        private void GridControl1_DataSourceChanged(object sender, System.EventArgs e)
        {
            ArrangeLayout();
        }

        public object DataSource
        {
            get
            {
                return this.gridControl1.DataSource;
            }
            set
            {
                this.gridControl1.DataSource = value;
            }
        }

        internal void ArrangeLayout()
        {
            gridView1.Columns["OrderDate"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["OrderDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["Country"].Group();
            gridView1.Columns["City"].Group();
            gridView1.Columns["ProductName"].Group();
            gridView1.ExpandAllGroups();
        }
    }
}
