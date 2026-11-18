using BusinessLayer;


using System;
using System.ComponentModel;
using System.Data;
using System.Web.Hosting;
using System.Windows.Forms;

using static BusinessLayer.clsTestType;
using static BusinessLayer.clsTestType.enTestType;

using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmIssueDrivingLicenseForFirstTime : Form
    {
        private int _LocalDrivingLicenseApplicationID;
        private int _DriverID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication = null;
        private int _LicenseID = -1;
        public frmIssueDrivingLicenseForFirstTime(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
        }
        private void frmIssueDrivingLicenseForFirstTime_Load(object sender, EventArgs e)
        {
            if (!localDrivingLicenseApplicationCard1.LoadDLApplication(_LocalDrivingLicenseApplicationID))
            {
                btnIssue.Enabled = false;
                txtBoxNotes.Enabled = false;
                return;
            }
            _LocalDrivingLicenseApplication = localDrivingLicenseApplicationCard1.selectedLocalDrivingLicenseApplication;

            btnIssue.Enabled = !clsLicense.IsLicenseExistByPersonID(_LocalDrivingLicenseApplication.ApplicantPersonID,
                _LocalDrivingLicenseApplication.LicenseClassID);
        }
        private bool _HandleIssueDriver(clsLocalDrivingLicenseApplication localDrivingLicenseApplication)
        {
            clsDriver driver = new clsDriver();

            driver.PersonID = localDrivingLicenseApplication.ApplicantPersonID;
            driver.CreatedByUserID = ActiveUser.User.UserID;
            driver.CreatedDate = DateTime.Now;
            driver.Save();
            _DriverID = driver.DriverID;

            if (_DriverID == -1)
            {
                ShowSaveErrorMessageBox();
                return false;
            }
            return true;
        }
        private bool _HandleIssueLicense()
        {
            clsLicense license = new clsLicense();
            license.DriverID = _DriverID;
            license.ApplicationID = _LocalDrivingLicenseApplication.ApplicationID;
            license.LicenseClass = _LocalDrivingLicenseApplication.LicenseClassID;
            license.PaidFees = _LocalDrivingLicenseApplication.PaidFees;
            license.IssueReason = clsLicense.enIssueReason.FirstTime;
            license.IssueDate = DateTime.Now;
            license.ExpirationDate = license.IssueDate.AddYears(10);
            license.IsActive = true;
            license.CreatedByUserID = ActiveUser.User.UserID;
            license.Notes = txtBoxNotes.Text;

            if (!license.Save())
            {
                ShowSaveErrorMessageBox();
                return false;
            }
            return true;
        }
        private void ShowSaveErrorMessageBox() =>
            MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure do want to issue this driving license ?",
        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (!_HandleIssueDriver(localDrivingLicenseApplicationCard1.selectedLocalDrivingLicenseApplication)) return;

            if (!_HandleIssueLicense())
            {
                clsDriver.DeleteByDriverID(_DriverID);
                return;
            }

            _LocalDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.Completed;

            if (!_LocalDrivingLicenseApplication.Save())
            {
                clsLicense.DeleteByLicenseID(_LicenseID);
                clsDriver.DeleteByDriverID(_DriverID);
                ShowSaveErrorMessageBox();
                return;
            }

            MessageBox.Show($"Driving License Issued Successfully. ID = {_LicenseID}", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmIssueDrivingLicenseForFirstTime_Load(null, null);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
