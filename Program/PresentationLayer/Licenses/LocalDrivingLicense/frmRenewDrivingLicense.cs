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

namespace PresentationLayer.Licenses.InternationalDrivingLicense
{
    public partial class frmRenewDrivingLicense : Form
    {
        private clsApplicationType _ApplicationType;

        private clsLicense _RenewalLicense;
        private int _OldLicenseID;
        public frmRenewDrivingLicense()
        {
            InitializeComponent();
        }
        private void frmRenewDrivingLicense_Load(object sender, EventArgs e)
        {
            lblFormTitle.Text = "Renew Driving License Application";
            ctrlLicenseCardWithFilter.OnLicenseSelected += OnLicenseSelected;
            _ApplicationType = clsApplicationType.
            FindByApplicationTypeID(clsApplicationType.enApplicationType.RenewDrivingLicense);

            _FillDefaultApplicationData();

            this.AcceptButton = ctrlLicenseCardWithFilter.btnFind;
        }
        private void frmRenewDrivingLicense_Activated(object sender, EventArgs e)
        {
            ctrlLicenseCardWithFilter.FocusLicenseID();
        }
        private void OnLicenseSelected(int licenseID)
        {
            _FillDefaultApplicationData();

            _OldLicenseID = licenseID;

            if (_OldLicenseID == -1)
            {
                return;
            }

            clsLicense license = ctrlLicenseCardWithFilter.SelectedLicense;

            lblOldLicenseID.Text = _OldLicenseID.ToString();

            if (license.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show($@"Selected License is not expired yet, 
                    it will expired on : {license.ExpirationDate.ToShortDateString()}.", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!license.IsActive)
            {
                MessageBox.Show("Selected License is not Active, Choose an Active License.", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblShowLicenseHistory.Enabled = true;
                return;
            }

            int defaultValidityLength = license.LicenseClassInfo.DefaultValidityLength;
            lblExiprationDate.Text = DateTime.Now.AddYears(defaultValidityLength).ToShortDateString();
            lblLicenseFees.Text = ((float)license.LicenseClassInfo.ClassFees).ToString();
            lblTotalFees.Text = (((float)license.LicenseClassInfo.ClassFees) + float.Parse(lblApplicationFees.Text)).ToString();
            txtBoxNotes.Text = license.Notes;
            btnIssue.Enabled = true;
            lblShowLicenseHistory.Enabled = true;
            txtBoxNotes.ReadOnly = false;
        }
        private void _FillDefaultApplicationData()
        {
            lblShowLicenseHistory.Enabled = false;
            lblShowLicenseInfo.Enabled = false;
            btnIssue.Enabled = false;
            txtBoxNotes.ReadOnly = true;
            _OldLicenseID = -1;
            _RenewalLicense = null;

            DateTime current = DateTime.Now;

            lblOldLicenseID.Text = "N/A";
            lblRLApplicationID.Text = "N/A";
            lblRenewedLicenseID.Text = "N/A";
            lblLicenseFees.Text = lblTotalFees.Text = "N/A";

            lblApplicationDate.Text = current.ToString("d");
            lblIssueDate.Text = current.ToString("d");
            lblExiprationDate.Text = current.AddYears(10).ToString("d");
            lblApplicationFees.Text = ((float)_ApplicationType.ApplicationFees).ToString();
            lblCreatedByUser.Text = ActiveUser.User.UserName;
        }
        private void _FillRenewalLicenseData()
        {
            if (_RenewalLicense == null) return;

            ctrlLicenseCardWithFilter.FilterEnabled = false;
            btnIssue.Enabled = false;
            lblShowLicenseHistory.Enabled = true;
            lblShowLicenseInfo.Enabled = true;
            txtBoxNotes.ReadOnly = true;

            lblRLApplicationID.Text = _RenewalLicense.ApplicationID.ToString();
            lblRenewedLicenseID.Text = _RenewalLicense.LicenseID.ToString();
            lblOldLicenseID.Text = _OldLicenseID.ToString();
            lblApplicationDate.Text = _RenewalLicense.ApplicationInfo.ApplicationDate.ToShortDateString();
            lblIssueDate.Text = _RenewalLicense.IssueDate.ToShortDateString();
            lblExiprationDate.Text = _RenewalLicense.ExpirationDate.ToShortDateString();
            lblCreatedByUser.Text = _RenewalLicense.userInfo.UserName;
            txtBoxNotes.Text = _RenewalLicense.Notes;
        }
        private bool _HandleIssueApplication()
        {

            clsLicense license = ctrlLicenseCardWithFilter.SelectedLicense;
            clsApplication application = new clsApplication();

            application.ApplicationStatus = clsApplication.enApplicationStatus.New;
            application.ApplicantPersonID = license.ApplicationInfo.ApplicantPersonID;
            application.ApplicationDate = DateTime.Now;
            application.LastStatusDate = application.ApplicationDate;
            application.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
            application.PaidFees = _ApplicationType.ApplicationFees;
            application.CreatedByUserID = ActiveUser.User.UserID;

            if (!application.Save())
            {
                ShowSaveErrorMessageBox();
                return false;
            }

            _RenewalLicense.ApplicationID = application.ApplicationID;
            return true;
        }
        private void ShowSaveErrorMessageBox()
        {
            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure do want to renew this driving license ?",
        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;



            _RenewalLicense = new clsLicense();


            if (!_HandleIssueApplication())
                return;

            clsLicense license = ctrlLicenseCardWithFilter.SelectedLicense;

            _RenewalLicense.DriverID = license.DriverID;
            _RenewalLicense.LicenseClass = license.LicenseClass;
            _RenewalLicense.IssueDate = DateTime.Now;
            int defaultValidityLength = license.LicenseClassInfo.DefaultValidityLength;
            _RenewalLicense.ExpirationDate = DateTime.Now.AddYears(defaultValidityLength);
            _RenewalLicense.Notes = txtBoxNotes.Text;
            _RenewalLicense.PaidFees = decimal.Parse(lblLicenseFees.Text);
            _RenewalLicense.IssueReason = clsLicense.enIssueReason.Renewal;
            _RenewalLicense.IsActive = true;
            _RenewalLicense.CreatedByUserID = ActiveUser.User.UserID;

            if (!_RenewalLicense.Save())
            {
                ShowSaveErrorMessageBox();
                clsApplication.Delete(_RenewalLicense.ApplicationID);
                return;
            }


            clsApplication.UpdateStatus(_RenewalLicense.ApplicationID, clsApplication.enApplicationStatus.Completed);

            _FillRenewalLicenseData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(ctrlLicenseCardWithFilter.SelectedLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowDriverLicenseDetails(_RenewalLicense.LicenseID);
            frm.ShowDialog();
        }
    }
}
