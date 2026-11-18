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
    public partial class ctrlLicenseCard : UserControl
    {
        private int _LicenseID;
        public int LicenseID
        {
            get
            {
                return _LicenseID;
            }
        }
        private clsLicense _License;
        public bool IsSelected
        {
            get
            {
                return _LicenseID != -1;
            }
        }
        public clsLicense License
        {
            get
            {
                return _License;
            }
        }
        public ctrlLicenseCard()
        {
            InitializeComponent();
        }
        public bool LoadDriverLicenseInfo(int licenseID)
        {
            _LicenseID = licenseID;
            _License = clsLicense.FindByLicenseID(_LicenseID);

            if (_License == null)
            {
                MessageBox.Show("Couldn`t Find License with License ID = " +
                    _LicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetInfo();
                return false;
            }

            _FillInfo();
            return true;

        }
        private void _FillInfo()
        {
            lblLicenseType.Text = _License.LicenseClassInfo.ClassName;
            lblName.Text = _License.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblGender.Text = _License.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();
            lblLicenseID.Text = _LicenseID.ToString();
            lblIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblExiprationDate.Text = _License.ExpirationDate.ToShortDateString();
            lblIssueReason.Text = _License.IssueReasonText;
            lblNotes.Text = _License.Notes;
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";

            lblDriverID.Text = _License.DriverID.ToString();
            lblIsDetained.Text = _License.IsDetainedLicense() ? "Yes" : "No";
            _HandlePersonImage();

        }
        private void _HandlePersonImage()
        {
            if (_License?.DriverInfo.PersonInfo.Gendor == 1)
                pbPersonImage.Image = Resources.Female_512;
            else
                pbPersonImage.Image = Resources.Male_512;

            string ImagePath = _License?.DriverInfo.PersonInfo.ImagePath;
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
            _License = null;
            _LicenseID = -1;
            lblLicenseType.Text = "";
            lblName.Text = "";
            lblNationalNo.Text = "";
            lblGender.Text = "";
            lblDateOfBirth.Text = "";
            lblLicenseID.Text = "";
            lblIssueDate.Text = "";
            lblExiprationDate.Text = "";
            lblIssueReason.Text = "";
            lblNotes.Text = "";
            lblIsActive.Text = "";
            lblDriverID.Text = "";
            lblIsDetained.Text = "";
            pbPersonImage.Image?.Dispose();
            pbPersonImage.Image = null;
        }

        private void grpDriverLicenseDetails_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pbPersonImage_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblIssueReason_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void lblNationalNo_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void lblExiprationDate_Click(object sender, EventArgs e)
        {

        }

        private void lblNotes_Click(object sender, EventArgs e)
        {

        }

        private void lblIssueDate_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void lblIsDetained_Click(object sender, EventArgs e)
        {

        }

        private void lblIsActive_Click(object sender, EventArgs e)
        {

        }

        private void lblDriverID_Click(object sender, EventArgs e)
        {

        }

        private void lblLicenseID_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {

        }

        private void lblApplicationID_Click(object sender, EventArgs e)
        {

        }
    }
}
