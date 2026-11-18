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
    public partial class frmListInternationalDrivingLicenses : Form
    {
        clsFilter FilterInstance;
        public frmListInternationalDrivingLicenses()
        {
            InitializeComponent();
        }
        private void frmManageInternationalDrivingLicenses_Load(object sender, EventArgs e)
        {
            List<clsField> items = new List<clsField>();

            items.Add(new clsField("None", clsValidating.enTypes.None, clsFilter.enColumnType.None));
            items.Add(new clsField("Int. License Id", clsValidating.enTypes.Integer, clsFilter.enColumnType.Number));
            items.Add(new clsField("Application Id", clsValidating.enTypes.Integer, clsFilter.enColumnType.Number));
            items.Add(new clsField("Driver Id", clsValidating.enTypes.Integer, clsFilter.enColumnType.Number));
            items.Add(new clsField("L. License Id", clsValidating.enTypes.Integer, clsFilter.enColumnType.Number));
            items.Add(new clsField("Is Active", clsValidating.enTypes.Combo, clsFilter.enColumnType.Number));

            FilterInstance = new clsFilter(null);

            FilterInstance.RefreshDataView = () =>
            {
                DataTable dt = clsInternationalLicense.GetAllInternationalDrivingLicenses();
                dt.Columns[0].ColumnName = "Int. License Id";
                dt.Columns[1].ColumnName = "Application Id";
                dt.Columns[2].ColumnName = "Driver Id";
                dt.Columns[3].ColumnName = "L. License Id";
                dt.Columns[4].ColumnName = "Issue Date";
                dt.Columns[5].ColumnName = "Expiration Date";
                dt.Columns[6].ColumnName = "Is Active";

                FilterInstance.MainTable = dt.DefaultView;
                dgvInternationalDrivingLicenses.DataSource = FilterInstance.MainTable;
                FilterInstance.Filtering();
            };

            FilterInstance.RefreshDataView();

            comBoxFilter.DisplayMember = "Name";
            comBoxFilter.ValueMember = "ValidatingType";
            comBoxFilter.DataSource = items;

            comBoxFilter.SelectedIndex = 0;
            comBoxIsActive.SelectedIndex = 0;
        }
        private void _ChangeSelectedItem()
        {

            switch ((clsValidating.enTypes)comBoxFilter.SelectedValue)
            {
                case clsValidating.enTypes.None:
                    txtBoxFilterSearch.Visible = comBoxIsActive.Visible = false;
                    break;
                case clsValidating.enTypes.Combo:
                    txtBoxFilterSearch.Visible = false;
                    comBoxIsActive.Visible = true;
                    comBoxIsActive_SelectedIndexChanged(null, null);
                    break;
                default:
                    comBoxIsActive.Visible = false;
                    txtBoxFilterSearch.Visible = true;
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
        private void comBoxIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxIsActive.SelectedIndex == 0)
                FilterInstance.CurrentValue = null;
            else
                FilterInstance.CurrentValue = comBoxIsActive.SelectedItem.ToString() != "Yes"
                    ? 0 : 1;

        }
        private void btnAddInternationalLicense_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewInternationalDrivingLicense();
            frm.ShowDialog();
            FilterInstance.RefreshDataView();
        }
        private void txtBoxFilterSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidating.IsAcceptableType(e.KeyChar, (clsValidating.enTypes)comBoxFilter.SelectedValue))
            {
                e.Handled = true;
            }
        }
        private void dgvInternationalDrivingLicenses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInternationalDrivingLicenses.Columns[6].MinimumWidth = 100;

            dgvInternationalDrivingLicenses.AutoResizeColumns();
        }
        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int internationalLicenseID = (int)dgvInternationalDrivingLicenses.
                CurrentRow.Cells[0].Value;

            clsInternationalLicense license = clsInternationalLicense.
                FindByInternationalLicenseID(internationalLicenseID);

            if (license == null)
            {
                MessageBox.Show("No International Driver License with License ID = " +
                    internationalLicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FilterInstance.RefreshDataView();
                return;
            }

            Form frm = new frmShowPersonDetails(license.DriverInfo.PersonInfo.PersonID);
            frm.ShowDialog();
        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowInternationalDriverLicenseDetails
                ((int)dgvInternationalDrivingLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int internationalDrivingLicenseID = (int)dgvInternationalDrivingLicenses.CurrentRow.Cells[0].Value;

            clsInternationalLicense internationalDrivingLicenseApplication =
                clsInternationalLicense.
                FindByInternationalLicenseID(internationalDrivingLicenseID);

            if (internationalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: History can`t Load Successfully.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowLicenseHistory frm = new frmShowLicenseHistory(internationalDrivingLicenseApplication.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
