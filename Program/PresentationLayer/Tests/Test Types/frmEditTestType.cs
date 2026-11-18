using BusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmEditTestType : Form
    {
        private clsTestType.enTestType _TestTypeId;

        private clsTestType _testType;
        private bool _BlockValidating = false;

        public frmEditTestType(clsTestType.enTestType testTypeID)
        {
            InitializeComponent();
            Tag = DialogResult.Cancel;
            _TestTypeId = testTypeID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            _LoadTestType();
        }
        private void _LoadTestType()
        {
            _testType = clsTestType.FindByTestTypeID(_TestTypeId);
            if(_testType == null)
            {
                MessageBox.Show("No Application Type with ID = " + _TestTypeId, "Application Type Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtBoxTitle.Text = _testType.TestTypeTitle;
            txtBoxDesc.Text = _testType.TestTypeDescription;
            txtBoxFees.Value = _testType.TestTypeFees;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _BlockValidating = true;
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over red icon(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _testType.TestTypeTitle = txtBoxTitle.Text;
            _testType.TestTypeDescription = txtBoxDesc.Text;
            _testType.TestTypeFees = txtBoxFees.Value;

            if (_testType.Save())
            {
                Tag = DialogResult.OK;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            _BlockValidating = false;

        }
        private void NullOrEmpty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (clsValidating.NullableOrEmpty_Validating(sender, e) && _BlockValidating)
            {
                e.Cancel = true;
            }
        }
        private void frmEditApplicationType_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = (DialogResult)Tag;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
