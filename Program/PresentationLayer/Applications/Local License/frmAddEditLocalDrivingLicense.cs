using BusinessLayer;

using System;
using System.ComponentModel;
using System.Web.Hosting;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmAddEditLocalDrivingLicense : Form
    {
        static private clsApplicationType _ApplicationType;
        static private clsApplicationType ApplicationType
        {
            get
            {
                if (_ApplicationType == null)
                {
                    _ApplicationType = clsApplicationType.FindByApplicationTypeID(clsApplicationType.enApplicationType.NewDrivingLicense);
                }
                return _ApplicationType;
            }
            set
            {
                _ApplicationType = value;
            }
        }
        private enum _enMode { AddNew, Update }
        _enMode _Mode;
        private int _DrivingLicenseID;
        
        private int _SelectedPersonID;

        private clsLocalDrivingLicenseApplication _Application;
        public frmAddEditLocalDrivingLicense()
        {
            InitializeComponent();
            _Mode = _enMode.AddNew;
        }
        public frmAddEditLocalDrivingLicense(int drivingLicenseID)
        {
            InitializeComponent();
            _DrivingLicenseID = drivingLicenseID;
            _Mode = _enMode.Update;
        }
        private void frmAddEditLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == _enMode.Update)
            {
                _LoadApplication();
            }
        }
        private void _LoadApplication()
        {
            ctrlPersonCardWithFilterInstance.FilterEnabled = false;
            _Application = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(_DrivingLicenseID);

            if (_Application == null)
            {
                MessageBox.Show("No Application with ID = " + _DrivingLicenseID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            ctrlPersonCardWithFilterInstance.LoadPersonInfo(_Application.ApplicantPersonID);
            ctrlPersonCardWithFilterInstance.FilterEnabled = ctrlPersonCardWithFilterInstance.ShowAddPerson = false;

            lblAppID.Text = _Application.ApplicationID.ToString();
            lblAppFees.Text = _Application.PaidFees.ToString();
            lblAppDate.Text = _Application.ApplicationDate.ToString("d");
            lblCreatedBy.Text = _Application.CreatedByUserInfo.UserName;

        }
        private void _ResetDefualtValues()
        {
            _FillLicenseVClasses();

            if (_Mode == _enMode.AddNew)
            {

                lblFormTitle.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _Application = new clsLocalDrivingLicenseApplication();
                ctrlPersonCardWithFilterInstance.FilterFocus();
                //tpApplicationInfo.Enabled = false;

                comBoxLicenseClass.SelectedIndex = 2;
                lblAppFees.Text = ApplicationType.ApplicationFees.ToString();
                lblAppDate.Text = DateTime.Now.ToShortDateString();
                lblCreatedBy.Text = ActiveUser.User.UserName;
            }
            else
            {
                lblFormTitle.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";

                //tpApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
            }

        }
        private void _FillLicenseVClasses()
        {
            comBoxLicenseClass.ValueMember = "LicenseClassID";
            comBoxLicenseClass.DisplayMember = "ClassName";
            comBoxLicenseClass.DataSource = clsLicenseClass.GetAll();
        }
        private bool _IsSelected() => ctrlPersonCardWithFilterInstance.isSelected;
        private void _EnableApplicationTab(bool value = true)
        {
            if (lblAppDate.Enabled == value) return;
            lblAppDate.Enabled = value;
            lblAppFees.Enabled = value;
            lblAppID.Enabled = value;
            lblCreatedBy.Enabled = value;
            comBoxLicenseClass.Enabled = value;
        }
        private void ctrlPersonCardWithFilterInstance_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
        }
        private void tabCtrlAddLocalLicense_Selecting(object sender,
            TabControlCancelEventArgs e)
        {
            _EnableApplicationTab(_IsSelected());
        }
        private void btnNextTab_Click(object sender, EventArgs e)
        {
            if (_IsSelected())
            {
                _EnableApplicationTab();
                tabCtrlAddLocalLicense.SelectedIndex = 1;
            }
            else
            {
                _EnableApplicationTab(false);
                MessageBox.Show("Please select person firstly");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int activeApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(
            _SelectedPersonID, clsApplicationType.enApplicationType.NewDrivingLicense, (int)comBoxLicenseClass.SelectedValue);
            
            if (activeApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id="
                    + activeApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comBoxLicenseClass.Focus();
                return;
            }


            if(clsLicense.IsLicenseExistByPersonID(_SelectedPersonID, (int)comBoxLicenseClass.SelectedValue))
            {
                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_Mode == _enMode.AddNew)
            {
                _Application.ApplicantPersonID = ctrlPersonCardWithFilterInstance.PersonID;
                _Application.ApplicationDate = DateTime.Parse(lblAppDate.Text);
                _Application.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
                _Application.ApplicationStatus = clsApplication.enApplicationStatus.New;
                _Application.PaidFees = Decimal.Parse(lblAppFees.Text);
                _Application.CreatedByUserID = ActiveUser.User.UserID;
            }

            _Application.LastStatusDate = DateTime.Today;
            _Application.LicenseClassID = (int)comBoxLicenseClass.SelectedValue;

            if (_Application.Save())
            {
                lblAppID.Text = _Application.LocalDrivingLicenseApplicationID.ToString();

                //change form mode to update.
                _Mode = _enMode.Update;


                lblFormTitle.Text = "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
