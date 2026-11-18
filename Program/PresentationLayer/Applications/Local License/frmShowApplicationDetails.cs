using BusinessLayer;


using System;
using System.ComponentModel;
using System.Web.Hosting;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmShowApplicationDetails : Form
    {
        int _LDAppId = -1;
        public frmShowApplicationDetails(int LDAppId)
        {
            _LDAppId = LDAppId;
            InitializeComponent();
        }
        private void frmShowApplicationDetails_Load(object sender, EventArgs e)
        {
            localDrivingLicenseApplicationCard1.LoadDLApplication(_LDAppId);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
