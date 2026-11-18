using BusinessLayer;


using System;
using System.ComponentModel;
using System.Data;
using System.Web.Hosting;
using System.Windows.Forms;

using static BusinessLayer.clsTestType;
using static BusinessLayer.clsTestType.enTestType;

using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmTestAppointments : Form
    {
        private clsTestType _TestType;
        private int _LDAppId;
        public frmTestAppointments(int LDAppId, enTestType testType = VisionTest)
        {
            InitializeComponent();
            _TestType = clsTestType.FindByTestTypeID(testType);
            _LDAppId = LDAppId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVisionTestAppointments_Load(object sender, EventArgs e)
        {
            switch (_TestType.ID)
            {
                case VisionTest:
                    lblFormTitle.Text = "Vision Test Appointments";
                    break;
                case WrittenTest:
                    lblFormTitle.Text = "Written Test Appointments";
                    break;
                case StreetTest:
                    lblFormTitle.Text = "Street Test Appointments";
                    break;
                default:
                    MessageBox.Show($"Error in loading the test appointments!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    return;
            }
            _LoadLDAppInfo();
        }
        private void _LoadLDAppInfo()
        {

            if (localDrivingLicenseApplicationCard1.LoadDLApplication(_LDAppId))
            {
                DataTable dt = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LDAppId, _TestType.ID);

                if (dt != null)
                {
                    dt.Columns[0].ColumnName = "Appointment Id";
                    dt.Columns[1].ColumnName = "Appointment Date";
                    dt.Columns[2].ColumnName = "Paid Fees";
                    dt.Columns[3].ColumnName = "Is Locked";
                }

                dgvAppointments.DataSource = dt;
            }
        }
        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(_LDAppId);

            if(localDrivingLicenseApplication.IsThereAnActiveScheduledTest(_TestType.ID))
            {
                MessageBox.Show($"You already have an active appointment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            clsTest lastTest = localDrivingLicenseApplication.GetLastTestPerTestType(_TestType.ID);

            frmScheduleTest frm;

            if (lastTest == null)
            {
                frm = new frmScheduleTest(_LDAppId, _TestType);
            }
            else
            {
                if (lastTest.TestResult)
                {
                    MessageBox.Show($"You already passed this exam!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                frm = new frmScheduleTest(lastTest.AppointmentInfo.LocalDrivingLicenseApplicationID, _TestType);
            }
            
            if (frm.ShowDialog() != DialogResult.Cancel)
            {
                _LoadLDAppInfo();
            }
        }
        private void dgvAppointments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAppointments.AutoResizeColumns();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleTest frm = new frmScheduleTest(_LDAppId, _TestType, (int)dgvAppointments.CurrentRow.Cells[0].Value);
            if (frm.ShowDialog() != DialogResult.Cancel)
            {
                _LoadLDAppInfo();
            }

        }
        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest frm = new frmTakeTest((int)dgvAppointments.CurrentRow.Cells[0].Value, _TestType.ID);
            if(frm.ShowDialog() == DialogResult.OK) _LoadLDAppInfo();


        }

    }
}
