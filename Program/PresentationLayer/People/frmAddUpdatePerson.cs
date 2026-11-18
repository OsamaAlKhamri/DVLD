using BusinessLayer;

using Guna.UI2.AnimatorNS;

using PresentationLayer.Properties;

using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmAddUpdatePerson : Form
    {
        private clsPerson _Person;
        private int _PersonID;
        enMode _Mode;
        public event Action<int> DataBack;
        enum enMode
        {
            AddNew, Update
        }

        bool BlockValidating = false;
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            this.Tag = DialogResult.Cancel;
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            this.Tag = DialogResult.Cancel;
            _Mode = enMode.AddNew;
        }
        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update) _LoadData();
        }
        private void _FillCountriesInComboBox()
        {
            comBoxCountry.DisplayMember = "CountryName";
            comBoxCountry.ValueMember = "CountryID";
            comBoxCountry.DataSource = clsCountry.GetAll();
        }
        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();
            if (_Mode == enMode.AddNew)
            {
                ActiveMain.AppendTitle("/Add Person");
                //lblFormTitle.Text = "Add New Person";
                Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                ActiveMain.AppendTitle("/Update Person");
                //lblFormTitle.Text = "Update Person";
                Text = "Update Person";
            }
            if (rbFemale.Checked)
            {
                PicPersonImage.Image = Resources.Female;
            }
            else
            {
                PicPersonImage.Image = Resources.Male;
            }

            lblRemove.Visible = false;
            lblSetImage.Visible = true;

            dtPicDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtPicDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            dtPicDateOfBirth.Value = dtPicDateOfBirth.MaxDate;

            comBoxCountry.SelectedValue = clsCountry.FindByCountryName("Yemen").CountryID;

            txtBoxFirst.Text = "";
            txtBoxLast.Text = "";
            txtBoxThird.Text = "";
            txtBoxLast.Text = "";
            txtBoxNationalNo.Text = "";
            rbMale.Checked = true;
            txtBoxPhone.Text = "";
            txtBoxEmail.Text = "";
            txtBoxAddress.Text = "";

        }
        private void _LoadData()
        {

            _Person = clsPerson.FindByPersonID(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show($"No Person with ID = {_PersonID}", "Person Not Found");
                this.Close();
                return;
            }
            lblPersonID.Text = _Person.PersonID.ToString();
            txtBoxFirst.Text = _Person.FirstName;
            txtBoxSecond.Text = _Person.SecondName;
            txtBoxThird.Text = _Person.ThirdName;
            txtBoxLast.Text = _Person.LastName;
            txtBoxNationalNo.Text = _Person.NationalNo;
            rbMale.Checked = _Person.Gendor == 0 ? true : false;
            rbFemale.Checked = !rbMale.Checked;
            dtPicDateOfBirth.Value = _Person.DateOfBirth;
            txtBoxPhone.Text = _Person.Phone;
            txtBoxEmail.Text = _Person.Email;
            txtBoxAddress.Text = _Person.Address;
            comBoxCountry.SelectedValue = _Person.NationalityCountryID;
            if (!String.IsNullOrEmpty(_Person.ImagePath))
            {
                PicPersonImage.ImageLocation = _Person.ImagePath;
                PicPersonImage.LoadAsync(PicPersonImage.ImageLocation);
                lblSetImage.Visible = false;
                lblRemove.Visible = true;
            }
            else if (_Person.ImagePath == null)
            {
                lblSetImage.Visible = true;
                lblRemove.Visible = false;
            }
        }
        private void ChangeVisibilityOfSetAndRemove(bool flag)
        {
            lblSetImage.Visible = flag;
            lblRemove.Visible = !flag;
        }
        private void lblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicPersonImage.ImageLocation = openFileDialog.FileName;
                PicPersonImage.Load(PicPersonImage.ImageLocation);
                ChangeVisibilityOfSetAndRemove(false);
            }
        }
        private void lblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PicPersonImage.Image.Dispose();
            PicPersonImage.ImageLocation = null;
            PicPersonImage.Image = null;
            lblRemove.Visible = false;
            lblSetImage.Visible = true;
            SetDefaultImage();
        }
        private void SetDefaultImage()
        {
            if (lblSetImage.Visible)
            {
                if (rbFemale.Checked)
                {
                    PicPersonImage.Image = Resources.Female;
                }
                else
                {
                    PicPersonImage.Image = Resources.Male;
                }
            }
        }
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctrl = sender as Control;
            if (!clsValidating.IsAcceptableType(e.KeyChar,
                (clsValidating.enTypes)Enum.Parse(typeof(clsValidating.enTypes),
                ctrl.Tag.ToString())))
            {
                e.Handled = true;
            }
        }
        private void NullableOrEmpty_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidating.NullableOrEmpty_Validating(sender, e) && BlockValidating) e.Cancel = true;
        }
        private void Email_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidating.isNullOrEmpty(txtBoxEmail.Text))
            {
                if (!clsValidating.Email_Validating(sender, e) && BlockValidating) e.Cancel = true;
            }
        }
        private void txtBoxNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (_Mode == enMode.Update &&
                _Person.NationalNo.ToLower() == txtBoxNationalNo.Text.ToLower())
            {
                clsValidating.Clear_Validating(sender as Control);
                return;
            }

            if (clsValidating.IsExists_Validating(sender, e,
                (statement) => clsPerson.FindByNationalNo(statement.ToString()) != null)
                && BlockValidating) e.Cancel = true;

        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            SetDefaultImage();
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            SetDefaultImage();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool _ManuplateImage()
        {
            if (PicPersonImage.ImageLocation != _Person.ImagePath)
            {
                if (_Person.ImagePath != null)
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch
                    {

                    }
                }
                if (PicPersonImage.ImageLocation != null)
                {
                    string imagePath = PicPersonImage.ImageLocation.ToString();
                    if (clsUtil.CopyImageToImageFolder(ref imagePath))
                    {
                        PicPersonImage.ImageLocation = imagePath;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            BlockValidating = true;
            if (!ValidateChildren())
            {
                BlockValidating = false;
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_ManuplateImage()) return;

            _Person.FirstName = txtBoxFirst.Text.Trim();
            _Person.SecondName = txtBoxSecond.Text.Trim();
            _Person.ThirdName = txtBoxThird.Text.Trim();
            _Person.LastName = txtBoxLast.Text.Trim();
            _Person.NationalNo = txtBoxNationalNo.Text.Trim();
            _Person.DateOfBirth = dtPicDateOfBirth.Value;
            _Person.Email = txtBoxEmail.Text.Trim();
            _Person.Phone = txtBoxPhone.Text.Trim();
            _Person.Address = txtBoxAddress.Text.Trim();
            _Person.NationalityCountryID = (int)comBoxCountry.SelectedValue;
            _Person.Gendor = rbMale.Checked ? (Byte)0 : (Byte)1;

            if (PicPersonImage.ImageLocation != null)
                _Person.ImagePath = PicPersonImage.ImageLocation;
            else
                _Person.ImagePath = null;

            if (_Person.Save())
            {

                if (_Person.PersonID == ActiveUser.User.PersonID)
                {
                    ActiveUser.User = clsUser.FindByPersonID(_Person.PersonID);
                }

                lblPersonID.Text = _Person.PersonID.ToString();
                _PersonID = _Person.PersonID;
                _Mode = enMode.Update;
                this.Tag = DialogResult.OK;
                ActiveMain.Undo();
                ActiveMain.AppendTitle("/Update Person");
                //lblFormTitle.Text = "Update Person";
                Text = "Update Person";
                MessageBox.Show("Person saved Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(_Person.PersonID);
            }
            else MessageBox.Show("Error: Data Is not Saved Successfully.", 
                "Save Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        private void frmAddPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = (DialogResult)Tag;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUpdatePerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActiveMain.Undo();
        }

        private void frmAddUpdatePerson_Activated(object sender, EventArgs e)
        {
            txtBoxFirst.Focus();

        }
    }
}