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
    public partial class frmListLocalDrivingLicenses : Form
    {
        clsFilter FilterInstance;
        public frmListLocalDrivingLicenses()
        {
            InitializeComponent();
        }
        private void frmManageLocalDrivingLicences_Load(object sender, EventArgs e)
        {
            List<clsField> items = new List<clsField>();

            items.Add(new clsField("None", clsValidating.enTypes.None, clsFilter.enColumnType.None));
            items.Add(new clsField("Id", clsValidating.enTypes.Integer, clsFilter.enColumnType.Number));
            items.Add(new clsField("Class Name", clsValidating.enTypes.Combo, clsFilter.enColumnType.String));
            items.Add(new clsField("National No", clsValidating.enTypes.String, clsFilter.enColumnType.String));
            items.Add(new clsField("Full Name", clsValidating.enTypes.FullNaming, clsFilter.enColumnType.String));
            items.Add(new clsField("Status", clsValidating.enTypes.Combo, clsFilter.enColumnType.String));

            FilterInstance = new clsFilter(null);

            FilterInstance.RefreshDataView = () =>
            {
                DataTable dt = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
                dt.Columns[0].ColumnName = "Id";
                dt.Columns[1].ColumnName = "Class Name";
                dt.Columns[2].ColumnName = "National No";
                dt.Columns[3].ColumnName = "Full Name";
                dt.Columns[4].ColumnName = "Application Date";
                dt.Columns[5].ColumnName = "Passed Tests";
                dt.Columns[6].ColumnName = "Status";

                FilterInstance.MainTable = dt.DefaultView;
                dgvLocalDrivingLicenses.DataSource = FilterInstance.MainTable;
                FilterInstance.Filtering();
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
                    txtBoxFilterSearch.Visible = comBoxPublic.Visible = false;
                    break;
                case clsValidating.enTypes.Combo:
                    txtBoxFilterSearch.Visible = false;
                    comBoxPublic.Visible = true;

                    clsField combo = (clsField)comBoxFilter.SelectedItem;
                    if (combo.Name == "Status")
                    {
                        comBoxPublic.DataSource = new List<string>(new[] { "All", "New", "Completed", "Cancelled" });
                        comBoxPublic.SelectedIndexChanged += comBoxStatuses_SelectedIndexChanged;
                        comBoxPublic.SelectedIndexChanged -= comBoxClasses_SelectedIndexChanged;

                        comBoxStatuses_SelectedIndexChanged(null, null);
                    }
                    else
                    {
                        comBoxPublic.DataSource = clsLicenseClass.GetAll().Select()
                            .Select(row => row["ClassName"]).ToList();
                        comBoxPublic.SelectedIndex = 0;
                        comBoxPublic.SelectedIndexChanged -= comBoxStatuses_SelectedIndexChanged;
                        comBoxPublic.SelectedIndexChanged += comBoxClasses_SelectedIndexChanged;

                        comBoxClasses_SelectedIndexChanged(null, null);
                    }
                    break;
                default:
                    comBoxPublic.Visible = false;
                    txtBoxFilterSearch.Visible = true;
                    foreach (Char ch in txtBoxFilterSearch.Text)
                        if (!clsValidating.IsAcceptableType(ch,
                            ((clsField)comBoxFilter.SelectedItem).ValidatingType))
                            txtBoxFilterSearch.Clear();
                    txtBoxFilterSearch_TextChanged(null, null);
                    break;
            }
        }
        private void comBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInstance.CurrentValue = comBoxPublic.SelectedValue;
        }
        private void comBoxStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxPublic.SelectedIndex == 0)
                FilterInstance.CurrentValue = null;
            else
                FilterInstance.CurrentValue = comBoxPublic.SelectedValue;
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
        private void dgvLocalDrivingLicenses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvLocalDrivingLicenses.AutoResizeColumns();
        }
        private void btnAddLocalLicense_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicense frm = new frmAddEditLocalDrivingLicense();
            frm.ShowDialog();
            FilterInstance.RefreshDataView();
        }
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int localLicenseId = (int)_GetCurrentSelectedRow()[0].Value;

            clsLocalDrivingLicenseApplication application = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(localLicenseId);

            if (application is null)
            {
                MessageBox.Show("No Application with ID = " + localLicenseId, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (application.ApplicationStatus == clsApplication.enApplicationStatus.Cancelled)
            {
                MessageBox.Show("This application already cancelled.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (application.ApplicationStatus == clsApplication.enApplicationStatus.Completed)
            {
                MessageBox.Show("This application completed. you can not cancel it.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            application.ApplicationStatus = clsApplication.enApplicationStatus.Cancelled;

            if (application.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FilterInstance.RefreshDataView();
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestAppointments frm = new frmTestAppointments(
                (int)_GetCurrentSelectedRow()[0].Value);
            frm.ShowDialog();
            FilterInstance.RefreshDataView();
        }
        private void _HandleLocalDrivingLicenseActions(clsApplication.enApplicationStatus appStatus, int passedTests)
        {
            Action<bool> EnableAllToolStripItems = (bool flag) =>
            {
                editToolStripMenuItem.Enabled = flag;
                deleteToolStripMenuItem.Enabled = flag;
                cancelToolStripMenuItem.Enabled = flag;
                scheduleTestsToolStripMenuItem.Enabled = flag;
                issueDrivingLicenseToolStripMenuItem.Enabled = flag;
                showLicenseToolStripMenuItem.Enabled = flag;
            };

            switch (appStatus)
            {
                case clsApplication.enApplicationStatus.Cancelled:
                    EnableAllToolStripItems(false);
                    break;
                case clsApplication.enApplicationStatus.Completed:
                    EnableAllToolStripItems(false);
                    showLicenseToolStripMenuItem.Enabled = true;
                    showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
                    break;
                case clsApplication.enApplicationStatus.New:
                    EnableAllToolStripItems(true);
                    showLicenseToolStripMenuItem.Enabled = false;
                    if (passedTests != 3)
                    {
                        issueDrivingLicenseToolStripMenuItem.Enabled = false;
                    }
                    break;

            }
        }
        private void scheduleTestsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            int OpenedTest = (int)_GetCurrentSelectedRow()[5].Value;
            if (OpenedTest >= 3) return;
            scheduleTestsToolStripMenuItem.DropDownItems[OpenedTest].Enabled = true;
        }
        private void scheduleTestsToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            scheduleStreetTestToolStripMenuItem.Enabled =
                scheduleWrittenTestToolStripMenuItem.Enabled =
                scheduleVisionTestToolStripMenuItem.Enabled = false;

            //int OpenedTest = (int)dgvLocalDrivingLicenses.CurrentRow.Cells[5].Value;
            //if (OpenedTest >= 3) return;

            //scheduleTestsToolStripMenuItem.DropDownItems[OpenedTest].Enabled = false;

        }
        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestAppointments frm = new frmTestAppointments(
                (int)_GetCurrentSelectedRow()[0].Value, clsTestType.enTestType.WrittenTest);
            frm.ShowDialog();
            FilterInstance.RefreshDataView();
        }
        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestAppointments frm = new frmTestAppointments(
                (int)_GetCurrentSelectedRow()[0].Value, clsTestType.enTestType.StreetTest);
            frm.ShowDialog();
            FilterInstance.RefreshDataView();
        }
        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowApplicationDetails frm = new frmShowApplicationDetails(
                (int)_GetCurrentSelectedRow()[0].Value);
            frm.ShowDialog();
            FilterInstance.RefreshDataView();

        }
        private void conMenManageLocalLicenseActions_Opening(object sender, CancelEventArgs e)
        {
            string status = _GetCurrentSelectedRow()["Status"].Value.ToString();
            int passedTests = (int)_GetCurrentSelectedRow()["Passed Tests"].Value;
            _HandleLocalDrivingLicenseActions((clsApplication.enApplicationStatus)
                Enum.Parse(typeof(clsApplication.enApplicationStatus), status), passedTests);
        }
        private DataGridViewCellCollection _GetCurrentSelectedRow()
        {
            return dgvLocalDrivingLicenses.CurrentRow.Cells;
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicense frm = new frmAddEditLocalDrivingLicense((int)_GetCurrentSelectedRow()[0].Value);
            frm.ShowDialog();
            FilterInstance.RefreshDataView();

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsLocalDrivingLicenseApplication.Delete((int)_GetCurrentSelectedRow()[0].Value))
            {
                MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FilterInstance.RefreshDataView();
            }
            else
            {
                MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void issueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmIssueDrivingLicenseForFirstTime frm = new frmIssueDrivingLicenseForFirstTime((int)_GetCurrentSelectedRow()[0].Value);
            frm.ShowDialog();
            FilterInstance.RefreshDataView();

        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localDrivingLicenseID = (int)_GetCurrentSelectedRow()[0].Value;

            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.
                FindByLocalDrivingLicenseApplicationID(localDrivingLicenseID);

            int licenseID = localDrivingLicenseApplication.GetApplicationLicenseID();
            frmShowDriverLicenseDetails frm = new frmShowDriverLicenseDetails(licenseID);
            frm.ShowDialog();
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localDrivingLicenseID = (int)_GetCurrentSelectedRow()[0].Value;

            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.
                FindByLocalDrivingLicenseApplicationID(localDrivingLicenseID);

            if (localDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: History can`t Load Successfully.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowLicenseHistory frm = new frmShowLicenseHistory(localDrivingLicenseApplication.ApplicantPersonID);
            frm.ShowDialog();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
