using BusinessLayer;

using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmShowUser : Form
    {
        private int _UserID;
        public frmShowUser(int PersonID)
        {
            InitializeComponent();
            _UserID = PersonID;
        }
        private void frmShowPerson_Load(object sender, EventArgs e)
        {
            this.FormClosed += (s, ex) => ActiveMain.Undo();
            
            ActiveMain.AppendTitle("Show_User");
            Text = "Show User Infomation Form";

            clsUser user = clsUser.FindByUserID(_UserID);

            if (user != null)
            {
                ctrlUserCardInstance.LoadUser(user);
            }
            else MessageBox.Show("No Person with PersonID = " + _UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
