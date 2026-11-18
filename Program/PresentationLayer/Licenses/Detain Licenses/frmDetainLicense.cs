using BusinessLayer;

using System;
using System.ComponentModel;
using System.Windows.Forms;

using static BusinessLayer.clsLicense.enIssueReason;
using static BusinessLayer.clsApplicationType.enApplicationType;
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmDetainLicense : Form
    {
        private bool _BlockValidating = false;

        private clsDetainedLicense _DetainedLicense = null;
        private int _LicenseID = -1;

        public frmDetainLicense()
        {
            InitializeComponent();
        }
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            _ResetInfo();
            lblFormTitle.Text = "Detain License";
            this.AcceptButton = ctrlLicenseCardWithFilter1.btnFind;
            ctrlLicenseCardWithFilter1.OnLicenseSelected += OnLicenseSelected;
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedByUser.Text = ActiveUser.User.UserName;
        }
        private void frmDetainLicense_Activated(object sender, EventArgs e)
        {
            ctrlLicenseCardWithFilter1.FocusLicenseID();
        }
        private void _ResetInfo()
        {
            lblShowLicenseHistory.Enabled = false;
            lblShowLicenseInfo.Enabled = false;
            btnDetain.Enabled = false;

            txtBoxFineFees.ReadOnly = true;

            _LicenseID = -1;

            lblDetainID.Text = "N/A";
            lblLicenseID.Text = "N/A";

            txtBoxFineFees.Text = null;
        }
        private void _FillDetainedLicenseData()
        {
            if (_DetainedLicense == null) return;

            ctrlLicenseCardWithFilter1.FilterEnabled = false;

            btnDetain.Enabled = false;
            lblShowLicenseInfo.Enabled = true;
            txtBoxFineFees.Enabled = false;

            lblLicenseID.Text = _DetainedLicense.LicenseID.ToString();
            lblDetainID.Text = _DetainedLicense.DetainID.ToString();

            lblDetainDate.Text = _DetainedLicense.DetainDate.ToShortDateString();

            ctrlLicenseCardWithFilter1.LoadLicenseInfo(_DetainedLicense.LicenseID);
        }
        private void _ShowSaveErrorMessageBox()
        {
            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void OnLicenseSelected(int licenseID)
        {

            ctrlLicenseCardWithFilter1.FocusLicenseID();
            _LicenseID = licenseID;

            if (_LicenseID == -1)
            {
                _ResetInfo();
                return;
            }

            clsLicense license = clsLicense.FindByLicenseID(_LicenseID);

            if (license.IsDetainedLicense())
            {
                _ResetInfo();
                lblShowLicenseHistory.Enabled = true;
                MessageBox.Show("Selected license is already detained, Choose another one.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblLicenseID.Text = ctrlLicenseCardWithFilter1.SelectedLicense.LicenseID.ToString();
                btnDetain.Enabled = true;
                txtBoxFineFees.ReadOnly = false;
                lblShowLicenseHistory.Enabled = true;
            }
        }
        private void btnDetain_Click(object sender, EventArgs e)
        {
            _BlockValidating = true;

            if (!ValidateChildren())
            {
                MessageBox.Show(" Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _BlockValidating = false;
                return;
            }

            _BlockValidating = false;
            if (MessageBox.Show($"Are you sure do want to Detain this license ?",
        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            if (clsLicense.IsDetainedLicense(_LicenseID))
            {
                MessageBox.Show("Selected license is already detained, Choose another one.",
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DetainedLicense = new clsDetainedLicense();

            _DetainedLicense.LicenseID = _LicenseID;
            _DetainedLicense.DetainDate = DateTime.Now;
            _DetainedLicense.FineFees = Convert.ToDecimal(txtBoxFineFees.Text);
            _DetainedLicense.CreatedByUserID = ActiveUser.User.UserID;

            if (!_DetainedLicense.Save())
            {
                _ShowSaveErrorMessageBox();
                return;
            }

            _FillDetainedLicenseData();
            MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(
                ctrlLicenseCardWithFilter1.SelectedLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowDriverLicenseDetails(_DetainedLicense.LicenseID);
            frm.ShowDialog();
        }
        private void txtBoxFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidating.IsAcceptableType(e.KeyChar, clsValidating.enTypes.Dec))
            {
                e.Handled = true;
            }
        }
        private void txtBoxFineFees_Validating(object sender, CancelEventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
