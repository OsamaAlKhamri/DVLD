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
    public partial class frmNewInternationalDrivingLicense : Form
    {
        private bool _BlockValidating = false;

        private clsApplicationType _ApplicationType;

        private clsInternationalLicense _InternationalLicense;
        private int _LocalLicenseID;
        //private clsLicense _License = null;
        public frmNewInternationalDrivingLicense()
        {
            InitializeComponent();
        }
        private void frmNewInternationalDrivingLicense_Load(object sender, EventArgs e)
        {
            lblFormTitle.Text = "International License Application";
            ctrlLicenseCardWithFilter1.OnLicenseSelected += OnLicenseSelected;
            _ApplicationType = clsApplicationType.
            FindByApplicationTypeID(clsApplicationType.enApplicationType.NewInternationalLicense);

            _FillDefaultApplicationData();

            this.AcceptButton = ctrlLicenseCardWithFilter1.btnFind;
        }
        private void frmNewInternationalDrivingLicense_Activated(object sender, EventArgs e)
        {
            ctrlLicenseCardWithFilter1.FocusLicenseID();
        }
        private void OnLicenseSelected(int licenseID)
        {
            _FillDefaultApplicationData();

            _LocalLicenseID = licenseID;

            if (_LocalLicenseID == -1)
            {
                return;
            }

            clsLicense license = ctrlLicenseCardWithFilter1.SelectedLicense;

            lblLocalLicenseID.Text = _LocalLicenseID.ToString();

            if (license.LicenseClass != 3)
            {
                MessageBox.Show("Selected License should be class 3, Select another one.", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int internationalLicenseID = clsInternationalLicense.
                GetActiveInternationalLicenseIDInLicenseClass(license.DriverID, license.LicenseClass);
            if (internationalLicenseID != -1)
            {
                _InternationalLicense = clsInternationalLicense.FindByInternationalLicenseID(internationalLicenseID);
                _FillInternationalLicenseData();
                lblShowLicenseHistory.Enabled = true;
                MessageBox.Show("Person already have an active international license with ID = " +
                    internationalLicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnIssue.Enabled = true;
            }
        }
        private void _FillDefaultApplicationData()
        {
            lblShowLicenseHistory.Enabled = false;
            lblShowLicenseInfo.Enabled = false;
            btnIssue.Enabled = false;
            _LocalLicenseID = -1;
            _InternationalLicense = null;
            //_License = null;

            DateTime current = DateTime.Now;

            lblLocalLicenseID.Text = "N/A";
            lblInternationalApplicationID.Text = "N/A";
            lblInternationalLicenseID.Text = "N/A";

            lblApplicationDate.Text = current.ToString("d");
            lblIssueDate.Text = current.ToString("d");
            lblExiprationDate.Text = current.AddYears(1).ToString("d");
            lblFees.Text = ((float)_ApplicationType.ApplicationFees).ToString();
            lblCreatedByUser.Text = ActiveUser.User.UserName;
        }
        private void _FillInternationalLicenseData()
        {
            if (_InternationalLicense == null) return;

            lblShowLicenseHistory.Enabled = true;
            lblShowLicenseInfo.Enabled = true;

            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblLocalLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblInternationalApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblApplicationDate.Text = _InternationalLicense.ApplicationInfo.ApplicationDate.ToShortDateString();
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
            lblExiprationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();
            lblCreatedByUser.Text = _InternationalLicense.UserInfo.UserName;
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
                ShowSaveErrorMessageBox();
                return false;
            }

            _InternationalLicense.ApplicationID = application.ApplicationID;
            return true;
        }
        private void ShowSaveErrorMessageBox()
        {
            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure do want to issue an international driving license ?",
        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            _InternationalLicense = clsInternationalLicense.GetActiveInternationlLicenseByLocalLicenseID(_LocalLicenseID);
            if (_InternationalLicense != null)
            {
                _FillInternationalLicenseData();
                MessageBox.Show("Person already have an active international license with ID = " +
                    _InternationalLicense.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _InternationalLicense = new clsInternationalLicense();


            if (!_HandleIssueApplication())
                return;

            clsLicense license = ctrlLicenseCardWithFilter1.SelectedLicense;


            _InternationalLicense.IssuedUsingLocalLicenseID = license.LicenseID;
            _InternationalLicense.DriverID = license.DriverID;
            _InternationalLicense.CreatedByUserID = ActiveUser.User.UserID;
            _InternationalLicense.IssueDate = DateTime.Now;
            _InternationalLicense.ExpirationDate = _InternationalLicense.IssueDate.AddYears(1);
            _InternationalLicense.IsActive = true;
            _InternationalLicense.CreatedByUserID = ActiveUser.User.UserID;

            if (!_InternationalLicense.Save())
            {
                ShowSaveErrorMessageBox();
                clsApplication.Delete(_InternationalLicense.ApplicationID);
                return;
            }


            clsApplication.UpdateStatus(_InternationalLicense.ApplicationID, clsApplication.enApplicationStatus.Completed);

            _FillInternationalLicenseData();
            ctrlLicenseCardWithFilter1.FilterEnabled = false;
            btnIssue.Enabled = false;
            lblShowLicenseInfo.Enabled = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(ctrlLicenseCardWithFilter1.SelectedLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowInternationalDriverLicenseDetails(_InternationalLicense.InternationalLicenseID);
            frm.ShowDialog();
        }

        private void lblExiprationDate_Click(object sender, EventArgs e)
        {

        }
    }
}
