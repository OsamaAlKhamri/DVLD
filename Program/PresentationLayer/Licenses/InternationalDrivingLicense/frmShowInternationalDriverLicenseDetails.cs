using BusinessLayer;


using System;
using System.ComponentModel;
using System.Web.Hosting;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmShowInternationalDriverLicenseDetails : Form
    {
        int _InternationalLicenseID = -1;
        public frmShowInternationalDriverLicenseDetails(int internationalLicenseID)
        {
            _InternationalLicenseID = internationalLicenseID;
            InitializeComponent();
        }
        private void frmShowApplicationDetails_Load(object sender, EventArgs e)
        {
            ctrlInternationalLicenseCard1.LoadInternationalLicenseInfo(_InternationalLicenseID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
