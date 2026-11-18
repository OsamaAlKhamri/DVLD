using BusinessLayer;

using PresentationLayer.Properties;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class ctrlInternationalLicenseCard : UserControl
    {
        private int _InternationalLicenseID;
        private clsInternationalLicense _InternationalLicense;
        public clsInternationalLicense InternationalLicense
        {
            get
            {
                return _InternationalLicense;
            }
        }
        public ctrlInternationalLicenseCard()
        {
            InitializeComponent();
        }
        public bool LoadInternationalLicenseInfo(int internationalLicenseID)
        {
            _InternationalLicenseID = internationalLicenseID;
            _InternationalLicense = clsInternationalLicense.FindByInternationalLicenseID(_InternationalLicenseID);

            if (_InternationalLicense == null)
            {
                ResetInfo();
                MessageBox.Show("No International Driver License with License ID = " +
                    _InternationalLicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            _FillInfo();
            return true;

        }
        private void _FillInfo()
        {
            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();

            lblName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            lblGender.Text = _InternationalLicense.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblDateOfBirth.Text = _InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
            lblExiprationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();
            lblIsActive.Text = _InternationalLicense.IsActiveLicense() ? "Yes" : "No";

            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            _HandlePersonImage();

        }
        private void _HandlePersonImage()
        {
            if (_InternationalLicense?.DriverInfo.PersonInfo.Gendor == 1)
                pbPersonImage.Image = Resources.Female_512;
            else
                pbPersonImage.Image = Resources.Male_512;

            string ImagePath = _InternationalLicense?.DriverInfo.PersonInfo.ImagePath;
            if (String.IsNullOrEmpty(ImagePath) == false)
            {
                if (File.Exists(ImagePath))
                {
                    pbPersonImage.ImageLocation = ImagePath;
                    pbPersonImage.LoadAsync(ImagePath);
                }
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ResetInfo()
        {
            _InternationalLicense = null;
            _InternationalLicenseID = -1;
            lblName.Text = "";
            lblNationalNo.Text = "";
            lblGender.Text = "";
            lblDateOfBirth.Text = "";
            lblLicenseID.Text = "";
            lblInternationalLicenseID.Text = "";
            lblApplicationID.Text = "";
            lblIssueDate.Text = "";
            lblExiprationDate.Text = "";
            lblIsActive.Text = "";
            lblDriverID.Text = "";
            pbPersonImage.Image?.Dispose();
            pbPersonImage.Image = null;
        }
    }
}
