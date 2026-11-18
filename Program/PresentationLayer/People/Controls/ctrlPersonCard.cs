using BusinessLayer;
using PresentationLayer.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;

        private int _PersonID = -1;

        public bool isSelected
        {
            get { return _PersonID != -1; }
        }

        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }
        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        public void LoadPersonInfo(int personID)
        {
            _Person = clsPerson.FindByPersonID(personID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + personID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
        public void LoadPersonInfo(string nationalNo)
        {
            _Person = clsPerson.FindByNationalNo(nationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + nationalNo.ToString(), 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            lblEditPersonInfo.Enabled = true;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblGender.Text = _Person.Gendor == 0 ? "Male" : "Female";
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblCountry.Text = clsCountry.FindByCountryID(_Person.NationalityCountryID).CountryName;
            _LoadPersonImage();
        }
        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblEditPersonInfo.Enabled = false;
            lblPersonID.Text = null;
            lblName.Text = null;
            lblNationalNo.Text = null;
            lblDateOfBirth.Text = null;
            lblPhone.Text = null;
            lblEmail.Text = null;
            lblGender.Text = null;
            lblAddress.Text = null;
            lblCountry.Text = null;
            PicPersonImage.Image?.Dispose();
            PicPersonImage.Image = null;

        }
        private void _LoadPersonImage()
        {
            if (_Person.Gendor == 0)
                PicPersonImage.Image = Resources.Male_512;
            else
                PicPersonImage.Image = Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (String.IsNullOrEmpty(ImagePath) == false)
                if (File.Exists(ImagePath))
                    PicPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void lblEditPersonInfo_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();
            LoadPersonInfo(_PersonID);
        }
    }
}
