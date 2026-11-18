using BusinessLayer;

using System;
using System.ComponentModel;
using System.Windows.Forms;

using static BusinessLayer.clsLicense.enIssueReason;
using static BusinessLayer.clsApplicationType.enApplicationType;
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmIssueReplacementForDamagedOrLostLicense : Form
    {
        private clsApplicationType _ApplicationType;

        private clsLicense _ReplacedLicense = null;
        private int _LocalLicenseID = -1;

        clsLicense.enIssueReason _ReplacementMode = ReplacementForDamaged;
        public frmIssueReplacementForDamagedOrLostLicense()
        {
            InitializeComponent();
        }
        private void frmIssueReplacementForDamagedOrLostLicense_Load(object sender, EventArgs e)
        {
            this.AcceptButton = ctrlLicenseCardWithFilter1.btnFind;
            ctrlLicenseCardWithFilter1.OnLicenseSelected += OnLicenseSelected;
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedByUser.Text = ActiveUser.User.UserName;

            _HandleReplacementMode();
        }
        private void frmIssueReplacementForDamagedOrLostLicense_Activated(object sender, EventArgs e)
        {
            ctrlLicenseCardWithFilter1.FocusLicenseID();
        }
        private void _HandleReplacementMode()
        {
            lblFormTitle.Text = clsLicense.GetIssueReasonText(_ReplacementMode);
            _ApplicationType = clsApplicationType.FindByApplicationTypeID(
                _ReplacementMode == ReplacementForDamaged ?
                ReplaceDamagedDrivingLicense : ReplaceLostDrivingLicense);
            lblFees.Text = ((float)_ApplicationType.ApplicationFees).ToString();
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
            application.PaidFees = _ApplicationType.ApplicationFees;
            application.CreatedByUserID = ActiveUser.User.UserID;

            if (!application.Save())
            {
                _ShowSaveErrorMessageBox();
                return false;
            }

            _ReplacedLicense.ApplicationID = application.ApplicationID;
            return true;
        }
        private void _ResetInfo()
        {
            lblShowLicenseHistory.Enabled = false;
            lblShowLicenseInfo.Enabled = false;
            btnIssue.Enabled = false;

            _LocalLicenseID = -1;

            lblOldLicenseID.Text = "N/A";
        }
        private void _FillLicenseData()
        {
            if (_ReplacedLicense == null) return;

            ctrlLicenseCardWithFilter1.FilterEnabled = gbreplacementFor.Enabled = false;

            btnIssue.Enabled = false;
            lblShowLicenseInfo.Enabled = true;

            lblReplacedLicenseID.Text = _ReplacedLicense.LicenseID.ToString();
            lblLRApplicationID.Text = _ReplacedLicense.ApplicationID.ToString();

            lblApplicationDate.Text = _ReplacedLicense.ApplicationInfo.ApplicationDate.ToShortDateString();

            ctrlLicenseCardWithFilter1.LoadLicenseInfo(_LocalLicenseID);
        }
        private void _ShowSaveErrorMessageBox()
        {
            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void OnLicenseSelected(int licenseID)
        {
            ctrlLicenseCardWithFilter1.FocusLicenseID();
            _LocalLicenseID = licenseID;

            if (_LocalLicenseID == -1)
            {
                _ResetInfo();
            }

            clsLicense license = clsLicense.FindByLicenseID(_LocalLicenseID);

            if (!clsLicense.IsActiveLicense(_LocalLicenseID))
            {
                _ResetInfo();
                lblShowLicenseHistory.Enabled = false;
                MessageBox.Show("Selected license is not acive, please choose an active license.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblOldLicenseID.Text = ctrlLicenseCardWithFilter1.SelectedLicense.LicenseID.ToString();
                btnIssue.Enabled = true;
                lblShowLicenseHistory.Enabled = true;
            }

        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure do want to issue a Replacement for the license ?",
        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            if (!clsLicense.IsActiveLicense(_LocalLicenseID))
            {
                MessageBox.Show("Selected license is not acive, please choose an active license.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ReplacedLicense = new clsLicense();


            if (!_HandleIssueApplication())
                return;

            clsLicense license = ctrlLicenseCardWithFilter1.SelectedLicense;

            _ReplacedLicense.DriverID = license.DriverID;
            _ReplacedLicense.LicenseClass = license.LicenseClass;
            _ReplacedLicense.IssueDate = DateTime.Now;
            _ReplacedLicense.ExpirationDate = license.ExpirationDate;
            _ReplacedLicense.IssueReason = rbDamagedLicense.Checked ? ReplacementForDamaged : ReplacementForLost;
            _ReplacedLicense.Notes = license.Notes;
            _ReplacedLicense.IsActive = true;
            _ReplacedLicense.PaidFees = _ApplicationType.ApplicationFees;
            _ReplacedLicense.CreatedByUserID = ActiveUser.User.UserID;

            if (!_ReplacedLicense.Save())
            {
                _ShowSaveErrorMessageBox();
                clsApplication.Delete(_ReplacedLicense.ApplicationID);
                return;
            }

            clsApplication.UpdateStatus(_ReplacedLicense.ApplicationID,
                clsApplication.enApplicationStatus.Completed);

            if (!clsLicense.UpdateActivation(_LocalLicenseID, false))
            {
                clsLicense.DeleteByLicenseID(_ReplacedLicense.LicenseID);
                clsApplication.Delete(_ReplacedLicense.ApplicationID);
                _ShowSaveErrorMessageBox();
                return;
            }


            _FillLicenseData();
        }
        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(
                ctrlLicenseCardWithFilter1.SelectedLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowDriverLicenseDetails(_ReplacedLicense.LicenseID);
            frm.ShowDialog();
        }
        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            _ReplacementMode = ReplacementForDamaged;
            _HandleReplacementMode();
        }
        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            _ReplacementMode = ReplacementForLost;
            _HandleReplacementMode();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ctrlLicenseCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void grpPersonDetails_Click(object sender, EventArgs e)
        {

        }

        private void lblApplicationDate_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
