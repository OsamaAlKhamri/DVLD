using BusinessLayer;

using System;
using System.Data;
using System.Web.Configuration;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class frmEditApplicationType : Form
    {
        private clsApplicationType.enApplicationType _applicationTypeId;

        private clsApplicationType _applicationType;

        private bool _BlockValidating { get; set; } = false;

        public frmEditApplicationType(clsApplicationType.enApplicationType applicationTypeID)
        {
            InitializeComponent();
            Tag = DialogResult.Cancel;
            _applicationTypeId = applicationTypeID;
        }
        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            _LoadApplicationType();
        }
        private void _LoadApplicationType()
        {
            _applicationType = clsApplicationType.FindByApplicationTypeID(_applicationTypeId);
            if(_applicationType == null)
            {
                MessageBox.Show("No Application Type with ID = " + _applicationTypeId, "Application Type Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtBoxTitle.Text = _applicationType.ApplicationTypeTitle;
            txtBoxFees.Value = _applicationType.ApplicationFees;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _BlockValidating = true;
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over red icon(s)" ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _applicationType.ApplicationTypeTitle = txtBoxTitle.Text;
            _applicationType.ApplicationFees = txtBoxFees.Value;

            if (_applicationType.Save())
            {
                Tag = DialogResult.OK;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            _BlockValidating = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditApplicationType_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = (DialogResult)Tag;
        }

        private void txtBoxTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(clsValidating.NullableOrEmpty_Validating(sender, e) && _BlockValidating)
            {
                e.Cancel = true;
            }
        }
    }
}
