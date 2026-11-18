using BusinessLayer;

using System;
using System.ComponentModel;
using System.Windows.Forms;

using static BusinessLayer.clsLicense.enIssueReason;
using static BusinessLayer.clsApplicationType.enApplicationType;
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private clsApplicationType _ApplicationType;

        private clsDetainedLicense _DetainedLicense = null;
        private int _LicenseID = -1;

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicense(int licenseID)
        {
            InitializeComponent();
            _LicenseID = licenseID;
        }
        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            lblFormTitle.Text = "Release Detained License";
            //_ResetInfo();

            _ApplicationType = clsApplicationType.
                FindByApplicationTypeID(ReleaseDetainedDrivingLicsense);
            lblApplicationFees.Text = ((float)_ApplicationType.ApplicationFees).ToString();

            this.AcceptButton = ctrlLicenseCardWithFilter1.btnFind;

            ctrlLicenseCardWithFilter1.OnLicenseSelected += OnLicenseSelected;

            lblCreatedByUser.Text = ActiveUser.User.UserName;

            if(_LicenseID != -1)
            {
                ctrlLicenseCardWithFilter1.LoadLicenseInfo(_LicenseID);
                //OnLicenseSelected(licenseID);
                ctrlLicenseCardWithFilter1.FilterEnabled = false;

            }

        }
        private void frmReleaseDetainedLicense_Activated(object sender, EventArgs e)
        {
            ctrlLicenseCardWithFilter1.FocusLicenseID();
        }
        private void _ResetInfo()
        {
            lblShowLicenseHistory.Enabled = false;
            lblShowLicenseInfo.Enabled = false;
            btnRealse.Enabled = false;

            _LicenseID = -1;
            _DetainedLicense = null;


            lblApplicationID.Text = "N/A";
            lblDetainID.Text = "N/A";
            lblLicenseID.Text = "N/A";
            lblFineFees.Text = "N/A";
            lblTotalFees.Text = "N/A";
            lblDetainDate.Text = "N/A";
        }
        private void _FillDetainedLicenseData()
        {
            btnRealse.Enabled = true;
            lblShowLicenseHistory.Enabled = true;

            lblLicenseID.Text = ctrlLicenseCardWithFilter1.SelectedLicense.LicenseID.ToString();
            lblDetainDate.Text = _DetainedLicense.DetainDate.ToShortDateString();
            lblDetainID.Text = _DetainedLicense.DetainID.ToString();
            lblFineFees.Text = ((float)_DetainedLicense.FineFees).ToString();
            lblTotalFees.Text = ((float)(_DetainedLicense.FineFees + _ApplicationType.ApplicationFees)).ToString();
        }
        private bool _HandleIssueApplication()
        {
            clsLicense license = ctrlLicenseCardWithFilter1.SelectedLicense;
            clsApplication application = new clsApplication();

            application.ApplicationStatus = clsApplication.enApplicationStatus.New;
            application.ApplicantPersonID = license.ApplicationInfo.ApplicantPersonID;
            application.ApplicantPersonID = license.ApplicationInfo.ApplicantPersonID;
            application.ApplicationDate = DateTime.Now;
            application.LastStatusDate = application.ApplicationDate;
            application.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
            application.PaidFees = decimal.Parse(lblTotalFees.Text);
            application.CreatedByUserID = ActiveUser.User.UserID;

            if (!application.Save())
            {
                _ShowSaveErrorMessageBox();
                return false;
            }

            _DetainedLicense.ReleaseApplicationID = application.ApplicationID;
            return true;
        }
        private void _FillUpdatedDetainedLicenseData()
        {
            if (_DetainedLicense == null) return;

            ctrlLicenseCardWithFilter1.FilterEnabled = false;


            btnRealse.Enabled = false;
            lblShowLicenseInfo.Enabled = true;

            lblLicenseID.Text = _DetainedLicense.LicenseID.ToString();
            lblDetainID.Text = _DetainedLicense.DetainID.ToString();
            lblApplicationID.Text = _DetainedLicense.ReleaseApplicationID.ToString();

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

            clsLicense license = ctrlLicenseCardWithFilter1.SelectedLicense;

            int detainedLicenseID = license.GetDetainedLicenseID();
            if (detainedLicenseID == -1)
            {
                _ResetInfo();

                lblShowLicenseHistory.Enabled = true;
                MessageBox.Show("Selected License is not detained, Choose another one.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DetainedLicense = clsDetainedLicense.FindByDetainID(detainedLicenseID);
            _FillDetainedLicenseData();
        }
        private void btnRealse_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are you sure do want to release this License ?",
        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            if (!clsLicense.IsDetainedLicense(_LicenseID))
            {
                MessageBox.Show("Selected License is not detained, Choose another one.",
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_HandleIssueApplication() == false)
                return;

            _DetainedLicense.ReleaseDate = DateTime.Now;
            _DetainedLicense.IsReleased = true;
            _DetainedLicense.ReleasedByUserID = ActiveUser.User.UserID;

            if (_DetainedLicense.Save() == false)
            {
                clsApplication.Delete(_DetainedLicense.ReleaseApplicationID.Value);
                _ShowSaveErrorMessageBox();
                return;
            }

            clsApplication.UpdateStatus(_DetainedLicense.ReleaseApplicationID.Value,
                clsApplication.enApplicationStatus.Completed);

            _FillUpdatedDetainedLicenseData();
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

        private void grpPersonDetails_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

    }
}
