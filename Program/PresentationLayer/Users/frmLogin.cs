using BusinessLayer;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActiveUser.User = clsUser.FindByUserNameAndPassword(txtBoxUserName.Text, txtBoxPassword.Text);
            if (ActiveUser.User is null)
            {
                MessageBox.Show("invalid username or password");
            }
            else if (ActiveUser.User.IsActive)
            {
                if (chkBoxRememberMe.Checked)
                {
                    StreamWriter sw = File.CreateText(Path.Combine(Directory.GetCurrentDirectory(), "RememberMe.txt"));
                    sw.WriteLine(txtBoxUserName.Text);
                    sw.WriteLine(txtBoxPassword.Text);
                    sw.Close();
                }
                else
                {
                    File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "RememberMe.txt"), null);
                    txtBoxUserName.Clear();
                    txtBoxPassword.Clear();

                }

                frmMain frmMain = new frmMain();
                ActiveMain.Main = frmMain;
                frmMain.Owner = this;
                frmMain.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("your account is deactivated. please contact your admin");
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "RememberMe.txt"));

            if (lines.Count() != 0)
            {
                txtBoxUserName.Text = lines[0];
                txtBoxPassword.Text = lines[1];
                chkBoxRememberMe.Checked = true;
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
