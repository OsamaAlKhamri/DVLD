using BusinessLayer;

using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmAddEditUser : Form
    {
        private enum _enMode { AddNew, Update }
        private _enMode _Mode;

        int _UserID;
        int _PersonID = -1;
        clsUser _User;

        public event Action<clsUser> Updating;
        bool BlockValidating = false;
        public frmAddEditUser(int userID)
        {
            InitializeComponent();
            _UserID = userID;
            _Mode = _UserID == -1 ? _enMode.AddNew : _enMode.Update;
        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetData();

            AcceptButton = ctrlPersonCardWithFilterInstance.btnFind;
            this.FormClosed += (s, ex) => ActiveMain.Undo();

            txtBoxConfirmPassword.Validating += (_sender, _e) =>
             {
                 if (clsValidating.Similar_Validating(_sender, _e,
                 (obj) => txtBoxPassword.Text == obj.ToString(), "The confirmation password is not similar to Password")
                 && BlockValidating) _e.Cancel = true;
             };
            if (_Mode == _enMode.AddNew)
            {
                ctrlPersonCardWithFilterInstance.OnPersonSelected += _OnPersonSelected;
                ActiveMain.AppendTitle("Add_User");
                tabPageUser.Enabled = false;
            }
            else
            {
                ActiveMain.AppendTitle("Update_User");
                ctrlPersonCardWithFilterInstance.FilterEnabled = false;
                btnSave.Enabled = tabPageUser.Enabled = true;
                LoadUser();
            }
        }
        private void _ResetData()
        {
            _PersonID = -1;
            lblUserID.Text = "N/A";
            btnSave.Enabled = false;
            tabPageUser.Enabled = false;

            ctrlPersonCardWithFilterInstance.ResetPersonInfoWithFilter();
        }
        private void _OnPersonSelected(int personId)
        {
            if (personId == -1)
            {
                _ResetData();
                return;
            }
            _PersonID = personId;

            btnSave.Enabled = true;
            tabPageUser.Enabled = true;
        }
        private void LoadUser()
        {
            _User = clsUser.FindByUserID(_UserID);
            if (_User == null)
            {
                MessageBox.Show("No User with User ID = " + _UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _PersonID = _User.PersonID;
            ctrlPersonCardWithFilterInstance.LoadPersonInfo(_PersonID);

            lblUserID.Text = _User.UserID.ToString();
            txtBoxUserName.Text = _User.UserName;
            txtBoxPassword.Text = _User.Password;
            txtBoxConfirmPassword.Text = _User.Password;
            chkActive.Checked = _User.IsActive;
        }
        private void NullableOrEmpty_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidating.NullableOrEmpty_Validating(sender, e) && BlockValidating) e.Cancel = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (_Mode == _enMode.AddNew)
            {
                _User = new clsUser();
            }

            _User.PersonID = _PersonID;
            _User.UserName = txtBoxUserName.Text;
            _User.Password = txtBoxPassword.Text;
            _User.IsActive = chkActive.Checked;

            if (_User.Save())
            {
                this.Text = "Update User Form";
                ActiveMain.Undo();
                ActiveMain.AppendTitle("/Update User");
                lblUserID.Text = _User.UserID.ToString();
                _UserID = _User.UserID;
                _Mode = _enMode.Update;
                this.Tag = DialogResult.OK;

                if (_User.UserID == ActiveUser.User.UserID) ActiveUser.User = _User;

                MessageBox.Show("User saved Successfully.", "Save", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ctrlPersonCardWithFilterInstance.FilterEnabled = false;

                Updating?.Invoke(_User);
            }
            else MessageBox.Show("Error: Data Is not Saved Successfully.", "Save Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            BlockValidating = false;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_PersonID == -1)
            {
                MessageBox.Show("you must select person first.Choose person...");
            }
            else if (_User?.PersonID != _PersonID && clsUser.FindByPersonID(_PersonID) != null)
            {
                MessageBox.Show("Selected person already has a user.Choose another one ...");
            }
            else
            {
                tabCtrlAddUser.SelectedIndex++;
            }
        }
        private void frmAddEditUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilterInstance.FilterFocus();
        }
    }
}
