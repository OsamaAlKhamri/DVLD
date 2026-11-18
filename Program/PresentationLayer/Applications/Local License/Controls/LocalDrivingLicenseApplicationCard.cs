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

namespace PresentationLayer
{
    public partial class LocalDrivingLicenseApplicationCard : UserControl
    {
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        private int _LocalDrivingLicenseApplicationId = -1;

        public clsLocalDrivingLicenseApplication selectedLocalDrivingLicenseApplication
        {
            get { return _LocalDrivingLicenseApplication; }
        }
        public LocalDrivingLicenseApplicationCard()
        {
            InitializeComponent();
        }

        private void _ResetDLApplicationInfo()
        {
            lblDLAppID.Text = string.Empty;
            lblLicenseType.Text = string.Empty;
            lblPassedTests.Text = String.Empty;
            applicationCard1.ResetApplicationInfo();
        }

        public bool LoadDLApplication(int localDrivingLicenseApplicationId)
        {
            _LocalDrivingLicenseApplicationId = localDrivingLicenseApplicationId;

            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.
                FindByLocalDrivingLicenseApplicationID(localDrivingLicenseApplicationId);

            if (_LocalDrivingLicenseApplication == null)
            {
                _ResetDLApplicationInfo();
                MessageBox.Show($"No Application with Id = {localDrivingLicenseApplicationId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            applicationCard1.LoadApplication(_LocalDrivingLicenseApplication.ApplicationID);
            _FillLDApplicationInfo();
            return true;
        }

        private void _FillLDApplicationInfo()
        {
            lblShowLicenseInfo.Enabled = clsLicense.IsLicenseExistByPersonID(_LocalDrivingLicenseApplication.ApplicantPersonID,
                (int)_LocalDrivingLicenseApplication.LicenseClassID);

            lblDLAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseType.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblPassedTests.Text = _LocalDrivingLicenseApplication.getPassedTests().Rows.Count.ToString() + "/3";
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
