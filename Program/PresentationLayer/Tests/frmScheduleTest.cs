using BusinessLayer;

using System;
using System.ComponentModel;
using System.Web.Hosting;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmScheduleTest : Form
    {
        private int _LDAppId = -1;

        clsTestType _TestType;
        private int _AppointmentId = -1;

        public frmScheduleTest(int LDAppId, clsTestType testType)
        {
            InitializeComponent();
            _LDAppId = LDAppId;
            _TestType = testType;
        }
        public frmScheduleTest(int LDAppId, clsTestType testType, int appointmentId)
        {
            InitializeComponent();
            _LDAppId = LDAppId;
            _TestType = testType;
            _AppointmentId = appointmentId;
        }
        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            sceduleTestCard1.TestTypeID = _TestType.ID;

            sceduleTestCard1.LoadScheduleInfo(_LDAppId, _AppointmentId);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmVisionTestAppointments_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = (DialogResult)this.sceduleTestCard1.Tag;
        }
    }
}
