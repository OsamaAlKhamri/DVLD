using BusinessLayer;

using PresentationLayer.Licenses.InternationalDrivingLicense;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmListDrivers : Form
    {
        clsFilter FilterInstance;
        public frmListDrivers()
        {
            InitializeComponent();
        }
        private void frmManageInternationalDrivingLicenses_Load(object sender, EventArgs e)
        {
            List<clsField> items = new List<clsField>();

            items.Add(new clsField("None", clsValidating.enTypes.None, clsFilter.enColumnType.None));
            items.Add(new clsField("Driver Id", clsValidating.enTypes.Integer, clsFilter.enColumnType.Number));
            items.Add(new clsField("Person Id", clsValidating.enTypes.Integer, clsFilter.enColumnType.Number));
            items.Add(new clsField("National No.", clsValidating.enTypes.String, clsFilter.enColumnType.String));
            items.Add(new clsField("Full Name", clsValidating.enTypes.FullNaming, clsFilter.enColumnType.String));

            FilterInstance = new clsFilter(null);

            FilterInstance.RefreshDataView = () =>
            {
                DataTable dt = clsDriver.GetAll();
                dt.Columns[0].ColumnName = "Driver Id";
                dt.Columns[1].ColumnName = "Person Id";
                dt.Columns[2].ColumnName = "National No.";
                dt.Columns[3].ColumnName = "Full Name";
                dt.Columns[4].ColumnName = "Date";
                dt.Columns[5].ColumnName = "Active Licenses";

                FilterInstance.MainTable = dt.DefaultView;
                dgvDrivers.DataSource = FilterInstance.MainTable;
                FilterInstance.Filtering();
            };

            FilterInstance.RefreshDataView();

            comBoxFilter.DisplayMember = "Name";
            comBoxFilter.ValueMember = "ValidatingType";
            comBoxFilter.DataSource = items;

            comBoxFilter.SelectedIndex = 0;
        }
        private void _ChangeSelectedItem()
        {

            switch ((clsValidating.enTypes)comBoxFilter.SelectedValue)
            {
                case clsValidating.enTypes.None:
                    txtBoxFilterSearch.Visible = false;
                    break;
                default:
                    txtBoxFilterSearch.Visible = true;
                    txtBoxFilterSearch.Focus();
                    txtBoxFilterSearch_TextChanged(null, null);
                    break;
            }
        }
        private void txtBoxFilterSearch_TextChanged(object sender, EventArgs e)
        {
            FilterInstance.CurrentValue = txtBoxFilterSearch.Text;
        }
        private void comBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsField field = (clsField)comBoxFilter.SelectedItem;
            FilterInstance.SelectedFiled =
                new clsFilter.Field(field.Name, field.FilterType, field.filterExactValue);
            _ChangeSelectedItem();
        }
        private void txtBoxFilterSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidating.IsAcceptableType(e.KeyChar, (clsValidating.enTypes)comBoxFilter.SelectedValue))
            {
                e.Handled = true;
            }
        }
        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = (int)dgvDrivers.
                CurrentRow.Cells[1].Value;

            Form frm = new frmShowPersonDetails(personID);
            frm.ShowDialog();
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = (int)dgvDrivers.
                CurrentRow.Cells[1].Value;

            if (!clsPerson.IsExistsPersonID(personID))
            {
                MessageBox.Show("Error: History can`t Load Successfully.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowLicenseHistory frm = new frmShowLicenseHistory(personID);
            frm.ShowDialog();
        }
        private void issueInternationalLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the feature not implemented yet ):-");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvDrivers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDrivers.AutoResizeColumns();
        }
        private void conMenDriversActions_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDrivers.CurrentCell == null)
            {
                e.Cancel = true;
            }
        }

        private void dgvDrivers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
