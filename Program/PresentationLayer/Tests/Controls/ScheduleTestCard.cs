using BusinessLayer;

using PresentationLayer.Properties;

using System;
using System.Windows.Forms;

using static BusinessLayer.clsTestType;
using static BusinessLayer.clsTestType.enTestType;
namespace PresentationLayer
{
    public partial class SceduleTestCard : UserControl
    {

        enum _enMode
        {
            New, Update
        }
        enum _enCreationMode
        {
            FirstTimeSchedule, RetakeTestSchedule
        }

        _enMode _Mode = _enMode.New;
        _enCreationMode _CreationMode = _enCreationMode.FirstTimeSchedule;

        private clsTestAppointment _TestAppointment;

        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private int _TestAppointmentID;

        public clsTestType.enTestType TestTypeID
        {
            get { return _TestTypeID; }
            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
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
        public SceduleTestCard()
        {
            InitializeComponent();
            this.Tag = DialogResult.Cancel;
        }
        private void SceduleTestCard_Load(object sender, EventArgs e)
        {
        }
        public void LoadScheduleInfo(int localDrivingLicenseApplicationID, int testAppointmentId = -1)
        {
            if (testAppointmentId == -1)
                _Mode = _enMode.New;
            else
                _Mode = _enMode.Update;

            _TestAppointmentID = testAppointmentId;
            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(localDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            if (_LocalDrivingLicenseApplication.DoesAttendTestType(_TestTypeID))

                _CreationMode = _enCreationMode.RetakeTestSchedule;
            else
                _CreationMode = _enCreationMode.FirstTimeSchedule;



            if (_CreationMode == _enCreationMode.RetakeTestSchedule)
            {
                lblFormTitle.Text = "Schedule Retake Test";
                gbRetakeTestInfo.Enabled = true;
                lblRTestAppId.Text = "0";
                lblRAppFees.Text = ((float)clsApplicationType.FindByApplicationTypeID(
                    clsApplicationType.enApplicationType.RetakeTest).ApplicationFees).ToString();
            }
            else
            {
                gbRetakeTestInfo.Enabled = false;
                lblFormTitle.Text = "Schedule Test";
                lblRAppFees.Text = "0";
                lblRTestAppId.Text = "N/A";
            }



            lblDLAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblName.Text = _LocalDrivingLicenseApplication.PersonFullName;

            lblTrial.Text = _LocalDrivingLicenseApplication.GetTotalTrialsPerTestType(_TestTypeID).ToString();

            if (_Mode == _enMode.New)
            {
                lblFees.Text = ((float)clsTestType.FindByTestTypeID(_TestTypeID).TestTypeFees).ToString();
                dtpTestDate.MinDate = DateTime.Now;
                lblRTestAppId.Text = "N/A";

                _TestAppointment = new clsTestAppointment();
            }

            else
            {

                if (!_LoadTestAppointmentData())
                    return;
            }



            lblTotalFees.Text = (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRAppFees.Text)).ToString();


            if (!_HandleActiveTestAppointmentConstraint())
                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

            if (!_HandlePrviousTestConstraint())
                return;

        }
        private bool _LoadTestAppointmentData()
        {
            _TestAppointment = clsTestAppointment.FindByTestAppointmentID(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + _TestAppointmentID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            lblFees.Text = ((float)_TestAppointment.PaidFees).ToString();

            //we compare the current date with the appointment date to set the min date.
            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dtpTestDate.MinDate = DateTime.Now;
            else
                dtpTestDate.MinDate = _TestAppointment.AppointmentDate;

            dtpTestDate.Value = _TestAppointment.AppointmentDate;

            if (_TestAppointment.RetakeTestApplicationID == -1)
            {
                lblRAppFees.Text = "0";
                lblRTestAppId.Text = "N/A";
            }
            else
            {
                lblRAppFees.Text = ((float)_TestAppointment.RetakeTestAppInfo.PaidFees).ToString();
                gbRetakeTestInfo.Enabled = true;
                lblFormTitle.Text = "Schedule Retake Test";
                lblRTestAppId.Text = _TestAppointment.RetakeTestApplicationID.ToString();

            }
            return true;
        }
        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == _enMode.New && clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_LocalDrivingLicenseApplicationID, _TestTypeID))
            {
                lblUserMessage.Text = "Person Already have an active appointment for this test";
                btnSave.Enabled = false;
                dtpTestDate.Enabled = false;
                return false;
            }

            return true;
        }
        private bool _HandleAppointmentLockedConstraint()
        {
            if (_TestAppointment.IsLocked)
            {
                lblUserMessage.Visible = true;
                lblUserMessage.Text = "Person already sat for the test, appointment locked.";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
                return false;

            }
            else
                lblUserMessage.Visible = false;

            return true;
        }
        private bool _HandlePrviousTestConstraint()
        {
            //we need to make sure that this person passed the prvious required test before apply to the new test.
            //person cannno apply for written test unless s/he passes the vision test.
            //person cannot apply for street test unless s/he passes the written test.

            switch (TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    //in this case no required prvious test to pass.
                    lblUserMessage.Visible = false;

                    return true;

                case clsTestType.enTestType.WrittenTest:
                    //Written Test, you cannot sechdule it before person passes the vision test.
                    //we check if pass visiontest 1.
                    if (!_LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest))
                    {
                        lblUserMessage.Text = "Cannot Sechule, Vision Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                    }


                    return true;

                case clsTestType.enTestType.StreetTest:

                    //Street Test, you cannot sechdule it before person passes the written test.
                    //we check if pass Written 2.
                    if (!_LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest))
                    {
                        lblUserMessage.Text = "Cannot Sechule, Written Test should be passed first";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpTestDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        btnSave.Enabled = true;
                        dtpTestDate.Enabled = true;
                    }


                    return true;

            }
            return true;

        }
        private bool _HandleRetakeApplication()
        {
            if (_Mode == _enMode.New && _CreationMode == _enCreationMode.RetakeTestSchedule)
            {

                clsApplication retakedApp = new clsApplication();

                retakedApp.ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
                retakedApp.ApplicationTypeID = clsApplicationType.enApplicationType.RetakeTest;

                retakedApp.ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;

                retakedApp.ApplicationDate = dtpTestDate.Value;
                retakedApp.LastStatusDate = retakedApp.ApplicationDate;

                retakedApp.ApplicationStatus = clsApplication.enApplicationStatus.Completed;

                retakedApp.CreatedByUserID = ActiveUser.User.UserID;

                retakedApp.PaidFees = clsApplicationType.FindByApplicationTypeID(clsApplicationType.enApplicationType.RetakeTest).ApplicationFees;

                if (!retakedApp.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Failed to Create application", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _TestAppointment.RetakeTestApplicationID = retakedApp.ApplicationID;
            }

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
            _TestAppointment.AppointmentDate = dtpTestDate.Value;
            _TestAppointment.PaidFees = Convert.ToDecimal(lblTotalFees.Text);
            _TestAppointment.CreatedByUserID = ActiveUser.User.UserID;

            if (_TestAppointment.Save())
            {
                _Mode = _enMode.Update;
                this.Tag = DialogResult.OK;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((Form)Parent).Close();
                Tag = DialogResult.OK;


            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

    }
}
