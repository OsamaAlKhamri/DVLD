using BusinessLayer;


using System;
using System.ComponentModel;
using System.Web.Hosting;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmShowDriverLicenseDetails : Form
    {
        int _LicenseID = -1;
        public frmShowDriverLicenseDetails(int licenseID)
        {
            _LicenseID = licenseID;
            InitializeComponent();
        }
        private void frmShowApplicationDetails_Load(object sender, EventArgs e)
        {
            ctrlLicenseCard1.LoadDriverLicenseInfo(_LicenseID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
