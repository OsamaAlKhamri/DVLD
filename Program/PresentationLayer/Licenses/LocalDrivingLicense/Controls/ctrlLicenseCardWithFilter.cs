using BusinessLayer;

using PresentationLayer.Properties;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class ctrlLicenseCardWithFilter : UserControl
    {
        private int _LocalLicenseID;
        private bool _BlockValidating = false;

        public event Action<int> OnLicenseSelected;


        public clsLicense SelectedLicense
        {
            get
            {
                return ctrlLicenseCard1.License;
            }
        }


        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }
        public ctrlLicenseCardWithFilter()
        {
            InitializeComponent();
        }
        public void LoadLicenseInfo(int LicenseID)
        {
            txtBoxLiceneID.Text = LicenseID.ToString();
            ctrlLicenseCard1.LoadDriverLicenseInfo(LicenseID);
            _LocalLicenseID = ctrlLicenseCard1.LicenseID;
            if (OnLicenseSelected != null && FilterEnabled)
                OnLicenseSelected(_LocalLicenseID);

        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            FocusLicenseID();
            _BlockValidating = true;

            if (!ValidateChildren())
            {
                MessageBox.Show(" Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _BlockValidating = false;
                return;
            }

            _LocalLicenseID = int.Parse(txtBoxLiceneID.Text);
            LoadLicenseInfo(_LocalLicenseID) ;

            _BlockValidating = false;
        }
        public void FocusLicenseID()
        {
            txtBoxLiceneID.Focus();
        }
        private void txtBoxLiceneID_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidating.NullableOrEmpty_Validating(sender, e) && _BlockValidating) e.Cancel = true;
        }
        private void txtBoxLiceneID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidating.IsAcceptableType(e.KeyChar, clsValidating.enTypes.Integer))
            {
                e.Handled = true;
            }
        }

    }
}
