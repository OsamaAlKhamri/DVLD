using BusinessLayer;

using System;
using System.Data;
using System.Windows.Forms;
using static BusinessLayer.clsApplicationType;

namespace PresentationLayer
{

    public partial class frmListApplicationTypes : Form
    {

        public frmListApplicationTypes()
        {
            InitializeComponent();
        }
        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {
            _LoadApplicationTypes();
        }

        private void _LoadApplicationTypes()
        {
            DataTable dt = clsApplicationType.GetAll();
            dt.Columns[0].ColumnName = "Id";
            dt.Columns[1].ColumnName = "Title";
            dt.Columns[2].ColumnName = "Fees";
            dgvApplicationTypes.DataSource = dt;
            dgvApplicationTypes.Columns["Fees"].FillWeight = 50;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvApplicationTypes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvApplicationTypes.AutoResizeColumns();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditApplicationType((enApplicationType)Enum.Parse(typeof(enApplicationType),dgvApplicationTypes.CurrentRow.Cells[0].Value.ToString()));

            frm.ShowDialog();
        }
    }
}
