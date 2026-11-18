using BusinessLayer;

using System;
using System.ComponentModel;
using System.Web.Hosting;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmTakeTest : Form
    {
        private int _AppointmentId = -1;
        private clsTestType.enTestType _TestTypeId;

        private int _TestID = -1;
        private clsTest _Test;
        public frmTakeTest(int appointmentId, clsTestType.enTestType testTypeId)
        {
            InitializeComponent();
            _TestTypeId = testTypeId;
            _AppointmentId = appointmentId;
        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlSceduledTestCard1.TestTypeId = _TestTypeId;
            ctrlSceduledTestCard1.LoadScheduledTestInfo(_AppointmentId);
            if (ctrlSceduledTestCard1.testAppointmentId == -1)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
            _TestID = ctrlSceduledTestCard1.TestID;
            if (_TestID != -1)
            {
                _Test = clsTest.FindByTestID(_TestID);

                if (_Test.TestResult)
                    rbPass.Checked = true;
                else
                    rbFail.Checked = true;
                txtBoxNotes.Text = _Test.Notes;

                lblLockResult.Visible = true;
                rbFail.Enabled = false;
                rbPass.Enabled = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
            "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            if (_Test == null)
            {
                _Test = new clsTest();
            }

            _Test.TestAppointmentID = _AppointmentId;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = txtBoxNotes.Text;
            _Test.CreatedByUserID = ActiveUser.User.UserID;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
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
