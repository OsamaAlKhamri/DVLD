using BusinessLayer;

using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ctrlUserCard : UserControl
    {
        public ctrlUserCard()
        {
            InitializeComponent();
        }
        public void LoadUser(clsUser user)
        {
            lblUserID.Text = user.UserID.ToString();
            lblUserName.Text = user.UserName;
            lblIsActive.Text = user.IsActive ? "Yes" : "No";

            ctrlPersonDetailsInstance.LoadPersonInfo(user.Person.PersonID);
        }
        public void Clear()
        {
            lblUserID.Text = null;
            lblUserName.Text = null;
            lblIsActive.Text = null;

            ctrlPersonDetailsInstance.ResetPersonInfo();
        }
    }
}
