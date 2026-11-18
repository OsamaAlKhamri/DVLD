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

using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmListDetainedLicenses : Form
    {
        clsFilter FilterInstance;
        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }
        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            List<clsField> items = new List<clsField>();

            items.Add(new clsField("None", clsValidating.enTypes.None, clsFilter.enColumnType.None));
            items.Add(new clsField("Detain Id", clsValidating.enTypes.Integer, clsFilter.enColumnType.Number));
            items.Add(new clsField("Is Released", clsValidating.enTypes.Combo, clsFilter.enColumnType.Number));
            items.Add(new clsField("National No.", clsValidating.enTypes.String, clsFilter.enColumnType.String));
            items.Add(new clsField("Full Name", clsValidating.enTypes.FullNaming, clsFilter.enColumnType.String));
            items.Add(new clsField("Release Application Id", clsValidating.enTypes.Integer, clsFilter.enColumnType.Number));

            FilterInstance = new clsFilter(null);

            FilterInstance.RefreshDataView = () =>
            {
                DataTable dt = clsDetainedLicense.GetAll();
                dt.Columns[0].ColumnName = "Detain Id";
                dt.Columns[1].ColumnName = "License ID";
                dt.Columns[2].ColumnName = "Detain Date";
                dt.Columns[3].ColumnName = "Is Released";
                dt.Columns[4].ColumnName = "Fine Fees";
                dt.Columns[5].ColumnName = "Release Date";
                dt.Columns[6].ColumnName = "National No.";
                dt.Columns[7].ColumnName = "Full Name";
                dt.Columns[8].ColumnName = "Release Application Id";
                FilterInstance.MainTable = dt.DefaultView;
                dgvDetainedLicenses.DataSource = FilterInstance.MainTable;
                FilterInstance.Filtering();

                comBoxIsReleased.SelectedIndex = 0;

            };

            FilterInstance.RefreshDataView();

            comBoxFilter.DisplayMember = "Name";
            comBoxFilter.ValueMember = "ValidatingType";
            comBoxFilter.DataSource = items;

            comBoxFilter.SelectedIndex = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void comBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsField field = (clsField)comBoxFilter.SelectedItem;
            FilterInstance.SelectedFiled =
                new clsFilter.Field(field.Name, field.FilterType, field.filterExactValue);
            _ChangeSelectedItem();
        }
        private void _ChangeSelectedItem()
        {

            switch ((clsValidating.enTypes)comBoxFilter.SelectedValue)
            {
                case clsValidating.enTypes.None:
                    txtBoxFilterSearch.Visible = comBoxIsReleased.Visible = false;
                    break;
                case clsValidating.enTypes.Combo:
                    txtBoxFilterSearch.Visible = false;
                    comBoxIsReleased.Visible = true;
                    comBoxIsReleased_SelectedIndexChanged(null, null);
                    break;
                default:
                    comBoxIsReleased.Visible = false;
                    txtBoxFilterSearch.Visible = true;
                    foreach (Char ch in txtBoxFilterSearch.Text)
                        if (!clsValidating.IsAcceptableType(ch,
                            ((clsField)comBoxFilter.SelectedItem).ValidatingType))
                            txtBoxFilterSearch.Clear();
                    txtBoxFilterSearch_TextChanged(null, null);
                    break;
            }
        }
        private void comBoxIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxIsReleased.SelectedIndex == 0)
                FilterInstance.CurrentValue = null;
            else
                FilterInstance.CurrentValue = comBoxIsReleased.SelectedIndex == 1 ? 1 : 0;
        }
        private void txtBoxFilterSearch_TextChanged(object sender, EventArgs e)
        {
            FilterInstance.CurrentValue = txtBoxFilterSearch.Text;
        }
        private void txtBoxFilterSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidating.IsAcceptableType(e.KeyChar, (clsValidating.enTypes)comBoxFilter.SelectedValue))
            {
                e.Handled = true;
            }
        }
        private void dgvDetainedLicenses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDetainedLicenses.AutoResizeColumns();
        }
        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            FilterInstance.RefreshDataView();
        }
        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            FilterInstance.RefreshDataView();
        }
        private void conMenManageDetainedLicenseActions_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDetainedLicenses.CurrentCell == null)
            {
                e.Cancel = true;
            }
            bool isReleased = (bool)_GetCurrentSelectedRow()["Is Released"].Value;
            if (isReleased)
            {
                releaseLicenseToolStripMenuItem.Enabled = false;
            }
        }
        private void conMenManageDetainedLicenseActions_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            releaseLicenseToolStripMenuItem.Enabled = true;
        }
        private DataGridViewCellCollection _GetCurrentSelectedRow()
        {
            return dgvDetainedLicenses.CurrentRow.Cells;
        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = (int)_GetCurrentSelectedRow()[1].Value;

            frmShowDriverLicenseDetails frm = new frmShowDriverLicenseDetails(licenseID);
            frm.ShowDialog();
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int licenseID = (int)_GetCurrentSelectedRow()[1].Value;

            clsLicense license = clsLicense.FindByLicenseID(licenseID);

            if (license == null)
            {
                MessageBox.Show("Error: History can`t Load Successfully.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowLicenseHistory frm = new frmShowLicenseHistory(license.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseID = (int)_GetCurrentSelectedRow()[1].Value;

            Form frm = new frmReleaseDetainedLicense(licenseID);
            frm.ShowDialog();
            FilterInstance.RefreshDataView();
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonDetails(dgvDetainedLicenses.CurrentRow.Cells[6].Value.ToString());
            frm.ShowDialog();
        }
    }
}
