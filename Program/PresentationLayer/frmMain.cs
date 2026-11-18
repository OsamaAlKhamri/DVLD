using Guna.UI2.WinForms;

using PresentationLayer.Licenses.InternationalDrivingLicense;
using PresentationLayer.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmMain : Form
    {
        Guna2Button CurrentPressedButton;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ActiveUser.UpdateActiveUser = LoadProfileInfo;
            CurrentPressedButton = btnDashboard;
            LoadProfileInfo();
            btnDashboard_Click(null, null);
        }
        private void frmMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (pnlSidebar.Visible == true)
            {
                pnlSidebar.Visible = false;
            }
        }
        void LoadProfileInfo()
        {
            if (!ActiveUser.User.IsActive)
            {
                MessageBox.Show("You are deactivated. You are logging out now.contact with your admin ...");
                logoutToolStripMenuItem_Click(null, null);
            }
            else if (ActiveUser.User == null)
            {
                MessageBox.Show("There are an error in your login. Retry again or contact with your admin ...");
                logoutToolStripMenuItem_Click(null, null);
            }
            Action updateProfile = () =>
            {
                lblFormTitle.Text = "Welcome Back " + ActiveUser.User.UserName;
            };

            if (lblFormTitle.InvokeRequired)
                lblFormTitle.Invoke(updateProfile);
            else updateProfile();

            picBoxProfile.Image?.Dispose();
            picBoxProfile.Image = null;

            if (ActiveUser.User.Person.ImagePath != null)
            {
                picBoxProfile.Image = clsImage.LoadImageToMemory(ActiveUser.User.Person.ImagePath);
            }
            else
            {
                picBoxProfile.Image = ActiveUser.User.Person.Gendor == 0 ? Resources.Male : Resources.Female;
            }

        }
        
        private void _HandleTheMainPanel(Form frm, object btn)
        {
            _HandleUI(btn);

            //btnCollapseSideBar_Click(null, null);

            pnlParent.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Size = new Size(1446, 642);
            pnlParent.Controls.Add(frm);
            frm.Show();
        }
        void _HandleUI(object button)
        {
            Guna2Button btn = button as Guna2Button;
            if (CurrentPressedButton != null)
            {
                CurrentPressedButton.FillColor = Color.Transparent;
            //CurrentPressedButton.ForeColor = Color.White;
            }
            CurrentPressedButton = btn;
            CurrentPressedButton.FillColor = Color.FromArgb(217, 242, 117);
            //CurrentPressedButton.FillColor = Color.FromArgb(222, 227, 62);
            //CurrentPressedButton.ForeColor = Color.Black;
            CurrentPressedButton.BorderRadius = 16;
        }


        // Applications
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _HandleUI(btnDashboard);
            lblFormTitle.Text = "Hi, " + ActiveUser.User.UserName;
            lblFormDesc.Text = "Let`s check your work Today";
        }
        private void btnApplications_Click(object sender, EventArgs e)
        {
            pnlApplications.Visible = !pnlApplications.Visible;

            if (pnlApplications.Visible == false)
            {
                btnApplications.FillColor = Color.Transparent;
                btnApplications.Image = Resources.right_arrow;
            }
            else
            {
                //btnApplications.FillColor = Color.DarkGray;
                //btnApplications.FillColor = Color.FromArgb(200, 195, 169, 129);
                btnApplications.FillColor = Color.LightGray;
                btnApplications.Image = Resources.down_arrow;
            }
        }
            // Driving Licenses Services
        private void btnDrivingLicensesServices_Click(object sender, EventArgs e)
        {
            pnlDrivingLicenses.Visible = !pnlDrivingLicenses.Visible;

            if (pnlDrivingLicenses.Visible == false)
            {
                btnDrivingLicensesServices.FillColor = Color.Transparent;
                btnDrivingLicensesServices.Image = Resources.right_arrow;
            }
            else
            {
                btnDrivingLicensesServices.FillColor = Color.LightGray;
                btnDrivingLicensesServices.Image = Resources.down_arrow;
            }
        }
        private void btnAddNewLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            _HandleUI(sender);
            frmAddEditLocalDrivingLicense frm = new frmAddEditLocalDrivingLicense();
            frm.ShowDialog();
        }
        private void btnManageLocalLicense_Click(object sender, EventArgs e)
        {
            lblFormTitle.Text = "Local Driving Licenses";
            lblFormDesc.Text = "List all Local Driving Licenses";
            _HandleTheMainPanel(new frmListLocalDrivingLicenses(), sender);
        }
        private void btnManageInternationalLicense_Click(object sender, EventArgs e)
        {
            lblFormTitle.Text = "International Driving Licenses";
            lblFormDesc.Text = "List all International Driving Licenses";

            _HandleTheMainPanel(new frmListInternationalDrivingLicenses(), sender);
        }
        private void btnDetainLicences_Click(object sender, EventArgs e)
        {
            pnlDetainLicense.Visible = !pnlDetainLicense.Visible;

            if (pnlDetainLicense.Visible == false)
            {
                btnDetainLicenses.FillColor = Color.Transparent;
                btnDetainLicenses.Image = Resources.right_arrow;
            }
            else
            {
                btnDetainLicenses.FillColor = Color.LightGray;
                btnDetainLicenses.Image = Resources.down_arrow;
            }
        }
        private void btnManageAppTypes_Click(object sender, EventArgs e)
        {
            lblFormTitle.Text = "Application Types";
            lblFormDesc.Text = "Manage all Application Types in the system";

            _HandleTheMainPanel(new frmListApplicationTypes(), sender);
        }
        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {
            lblFormTitle.Text = "Test Types";
            lblFormDesc.Text = "Manage all Test Types in the system";

            _HandleTheMainPanel(new frmListTestTypes(), sender);
        }
        private void btnDrivers_Click(object sender, EventArgs e)
        {
            lblFormTitle.Text = "Drivers";
            lblFormDesc.Text = "List all Drivers in the system";

            _HandleTheMainPanel(new frmListDrivers(), sender);
        }
        private void btnPeople_Click(object sender, EventArgs e)
        {
            lblFormTitle.Text = "People";
            lblFormDesc.Text = "List all people in the system";

            _HandleTheMainPanel(new frmListPeople(), sender);
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            lblFormTitle.Text = "Users";
            lblFormDesc.Text = "List all users in the system";
            _HandleTheMainPanel(new frmListUsers(), sender);
        }
        private void pnlProfile_Click(object sender, EventArgs e)
        {
            //menuStripAccountSettings.Visible = true;
        }
        private void pnlProfile_Leave(object sender, EventArgs e)
        {
            //menuStripAccountSettings.Visible = false;

        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ActiveUser.UpdateActiveUser -= LoadProfileInfo;
        }

        //panels
        private void pnlApplications_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlApplications.Visible == false)
            {
                btnApplications.FillColor = Color.Transparent;
            }
        }
        
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        private void currentuserinfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowUser((int)ActiveUser.User.UserID);
            frm.ShowDialog();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword((int)ActiveUser.User.UserID);
            frm.ShowDialog();
        }
        private void btnNewInternationalLicense_Click(object sender, EventArgs e)
        {
            frmNewInternationalDrivingLicense frm = new frmNewInternationalDrivingLicense();
            frm.ShowDialog();

        }

        private void pnlParent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRepalcementFordamagedOrLostDrivingLicense_Click(object sender, EventArgs e)
        {
            _HandleUI(sender);
            Form frm = new frmIssueReplacementForDamagedOrLostLicense();
            frm.ShowDialog();
        }

        private void conMenSettings_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStripAccountSettings_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            _HandleUI(sender);
            Form frm = new frmRenewDrivingLicense();
            frm.AutoSize = true;
            frm.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnManageDetainedLicenses_Click(object sender, EventArgs e)
        {
            lblFormTitle.Text = "Detained Licenses";
            lblFormDesc.Text = "List all Detained Driving Licenses";
            _HandleTheMainPanel(new frmListDetainedLicenses(), sender);
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            _HandleUI(sender);
            Form frm = new frmDetainLicense();
            frm.Show();
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            _HandleUI(sender);
            Form frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();

        }
    }
}
