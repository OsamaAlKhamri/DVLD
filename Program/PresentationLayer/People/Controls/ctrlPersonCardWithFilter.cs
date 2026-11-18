using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAdd.Visible = _ShowAddPerson;
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

        //private int _PersonID = -1;
        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }
        public bool isSelected
        {
            get { return ctrlPersonCard1.isSelected; }
        }
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }
        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }
        public void LoadPersonInfo()
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            FindNow();
        }
        public void LoadPersonInfo(int personID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = personID.ToString();
            FindNow();
        }
        private void FindNow()
        {
            if (String.IsNullOrEmpty(txtFilterValue.Text)) return;

            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;

                case "National No.":
                    ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text);
                    break;

                default:
                    break;
            }

            if (OnPersonSelected != null)
                OnPersonSelected(ctrlPersonCard1.PersonID);
            FilterFocus();

        }
        public void ResetPersonInfoWithFilter()
        {
            _FilterEnabled = true;
            _ShowAddPerson = true;
            ctrlPersonCard1.ResetPersonInfo();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13)
            //{
            //    btnFind.PerformClick();
            //}
            bool isAcceptable = false;
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    isAcceptable = clsValidating.IsAcceptableType(e.KeyChar, clsValidating.enTypes.Integer);
                    break;
                case "National No.":
                    isAcceptable = clsValidating.IsAcceptableType(e.KeyChar, clsValidating.enTypes.String);
                    break;
            }

            if (!isAcceptable)
            {
                e.Handled = true;
            }
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            FindNow();
        }
        private void DataBackEvent(int personID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(personID);
        }
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FindNow();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();

        }
        private void txtFilterValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsValidating.NullableOrEmpty_Validating(sender, e);

            //if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtFilterValue,
            //        "This field is required!");
            //}
            //else
            //{
            //    //e.Cancel = false;
            //    errorProvider1.SetError(txtFilterValue, null);
            //}
        }
    }
}
