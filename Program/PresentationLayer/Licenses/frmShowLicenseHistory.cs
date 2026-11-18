using BusinessLayer;


using System;
using System.ComponentModel;
using System.Data;
using System.Web.Hosting;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmShowLicenseHistory : Form
    {
        int _PersonID = -1;
        public frmShowLicenseHistory(int personID)
        {
            _PersonID = personID;
            InitializeComponent();
        }
        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            ActiveMain.AppendTitle("Show_License_History");
            Text = "Show License History Form";

            ctrlPersonCardWithFilter1.OnPersonSelected  += ctrlPersonCardWithFilter1_OnPersonSelected;
            if (_PersonID != -1)
            {
                ctrlPersonCardWithFilter1.FilterEnabled = false;
                ctrlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
            }
            else
            {
                ctrlPersonCardWithFilter1.Enabled = true;
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }
        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID == -1)
            {
                ctrlLicenseHistoryCard1.Clear();
            }
            else
                ctrlLicenseHistoryCard1.LoadDriverLicensesByPersonID(_PersonID);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmShowLicenseHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActiveMain.Undo();
        }
    }
}
