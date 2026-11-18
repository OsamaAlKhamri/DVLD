using BusinessLayer;

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmChangePassword : Form
    {
        bool BlockValidating = false;
        int _UserID;
        public frmChangePassword(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }
        private void NullableOrEmpty_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidating.NullableOrEmpty_Validating(sender, e) && BlockValidating) e.Cancel = true;
        }
        private void SetUser(clsUser user)
        {
            ctrlUserCardInstance.LoadUser(user);
            txtBoxCurrentPassword.Text = user.Password;
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            Text = "Change Password Form";
            ActiveMain.AppendTitle("Change_Password");
            
            this.FormClosed += (s, ex) => ActiveMain.Undo();
            SetUser(clsUser.FindByUserID(_UserID));

            txtBoxCurrentPassword.Validating += (_sender, _e) =>
            {
                if (clsValidating.Similar_Validating(_sender, _e,
                (obj) => clsUser.FindByUserID(_UserID).Password == obj.ToString(), "This password is not similar to your password")
                && BlockValidating) _e.Cancel = true;
            };

            txtBoxConfirmNewPassword.Validating += (_sender, _e) =>
            {
                if (clsValidating.Similar_Validating(_sender, _e,
                (obj) => txtBoxNewPassword.Text == obj.ToString(), "The confirmation password is not similar to Password")
                && BlockValidating) _e.Cancel = true;
            };
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
            clsUser user = clsUser.FindByUserID(_UserID);
            user.Password = txtBoxNewPassword.Text;
            if (user.Save())
            {
                MessageBox.Show("User saved Successfully.", "Save", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                SetUser(user);
            }
            else MessageBox.Show("Error: Data Is not Saved Successfully.", "Save Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            BlockValidating = false;
        }
    }
}
