using BusinessLayer;

using PresentationLayer.Properties;

using System;
using System.Windows.Forms;

using static BusinessLayer.clsTestType;
using static BusinessLayer.clsTestType.enTestType;
namespace PresentationLayer
{
    public partial class ctrlSceduledTestCard : UserControl
    {
        public int testAppointmentId = -1;

        private clsTestType.enTestType _testTypeId;
        public clsTestType.enTestType TestTypeId
        {
            get { return _testTypeId; }
            set
            {
                _testTypeId = value;
                switch (_testTypeId)
                {

                    case clsTestType.enTestType.VisionTest:
                        {
                            gbTestType.Text = "Vision Test";
                            break;
                        }

                    case clsTestType.enTestType.WrittenTest:
                        {
                            gbTestType.Text = "Written Test";
                            break;
                        }
                    case clsTestType.enTestType.StreetTest:
                        {
                            gbTestType.Text = "Street Test";
                            break;


                        }
                }
            }
        }

        public clsTestAppointment _TestAppointment;
        private int _TestID = -1;
        public int TestID
        {
            get
            {
                return _TestID;
            }
        }

        public ctrlSceduledTestCard()
        {
            InitializeComponent();
        }
        public void LoadScheduledTestInfo(int testAppointmentId)
        {
            this.testAppointmentId = testAppointmentId;
            _TestAppointment = clsTestAppointment.FindByTestAppointmentID(testAppointmentId);
            if (_TestAppointment == null)
            {
                MessageBox.Show("No Test Appointment with ID = " + testAppointmentId.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_TestAppointment.LocalDrivingLicenseApplicationInfo == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " +
                    _TestAppointment.LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _TestID = _TestAppointment.TestID;

            lblDLAppID.Text = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = _TestAppointment.LocalDrivingLicenseApplicationInfo.LicenseClassInfo.ClassName;
            lblName.Text = _TestAppointment.LocalDrivingLicenseApplicationInfo.PersonFullName;


            lblDate.Text = _TestAppointment.AppointmentDate.ToShortDateString();

            lblTrial.Text = _TestAppointment.LocalDrivingLicenseApplicationInfo.
                GetTotalTrialsPerTestType(_TestAppointment.TestTypeID).ToString();

            lblFees.Text = ((float)_TestAppointment.PaidFees).ToString();

            lblTestId.Text = (_TestID == -1) ? "Not Taken Yet" : _TestAppointment.TestID.ToString();

        }
    }
}
