using BusinessLayer;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmListTestTypes : Form
    {
        public frmListTestTypes()
        {
            InitializeComponent();
        }
        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            _LoadTestTypes();
        }

        private void _LoadTestTypes()
        {
            DataTable dt = clsTestType.GetAll();
            dgvTestTypes.DataSource = dt;

            dgvTestTypes.Columns[0].HeaderText = "Id";
            dgvTestTypes.Columns[1].HeaderText = "Title";
            dgvTestTypes.Columns[2].HeaderText = "Description";
            dgvTestTypes.Columns[3].HeaderText = "Fees";

            dgvTestTypes.Columns[1].FillWeight = 100;
            dgvTestTypes.Columns[3].FillWeight = 50;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmEditTestType((clsTestType.enTestType)dgvTestTypes.CurrentRow.Cells[0].Value);
            if (frm.ShowDialog() == DialogResult.OK) _LoadTestTypes();
        }
        private void dgvTestTypes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTestTypes.AutoResizeColumns();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTestTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
