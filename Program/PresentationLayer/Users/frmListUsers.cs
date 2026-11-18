using BusinessLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmListUsers : Form
    {
        clsFilter FilterInstance;
        public frmListUsers()
        {
            InitializeComponent();
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            List<clsField> Items = new List<clsField>();

            Items.Add(new clsField("None", clsValidating.enTypes.None, clsFilter.enColumnType.None));
            Items.Add(new clsField("User ID", clsValidating.enTypes.Integer, clsFilter.enColumnType.Number));
            Items.Add(new clsField("Person ID", clsValidating.enTypes.Integer, clsFilter.enColumnType.Number));
            Items.Add(new clsField("Full Name", clsValidating.enTypes.StringWithWhiteSpace, clsFilter.enColumnType.String));
            Items.Add(new clsField("User Name", clsValidating.enTypes.String, clsFilter.enColumnType.String));
            Items.Add(new clsField("Is Active", clsValidating.enTypes.Combo, clsFilter.enColumnType.Number));

            FilterInstance = new clsFilter(null);
            FilterInstance.RefreshDataView = () =>
            {
                FilterInstance.MainTable = clsUser.GetAllWithFullNameAndWithoutPasswords().DefaultView;
                dgvUsers.DataSource = FilterInstance.MainTable;
                FilterInstance.Filtering();
            };

            FilterInstance.RefreshDataView();

            comBoxFilter.DataSource = Items;
            comBoxFilter.DisplayMember = "Name";
            comBoxFilter.ValueMember = "ValidatingType";

            comBoxFilter.SelectedIndex = 0;
            comBoxStatuses.SelectedIndex = 0;
        }
        private void txtBoxFilterSearch_TextChanged(object sender, EventArgs e)
        {
            FilterInstance.CurrentValue = txtBoxFilterSearch.Text;
        }
        private void comBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsField field = (clsField)comBoxFilter.SelectedItem;
            FilterInstance.SelectedFiled =
                new clsFilter.Field(field.Name, field.FilterType, field.filterExactValue);
            ChangeSelection();
        }
        private void ChangeSelection()
        {
            switch (((clsField)comBoxFilter.SelectedItem).ValidatingType)
            {
                case clsValidating.enTypes.None:
                    txtBoxFilterSearch.Visible = false;
                    comBoxStatuses.Visible = false;
                    break;
                case clsValidating.enTypes.Combo:
                    comBoxStatuses.Visible = true;
                    txtBoxFilterSearch.Visible = false;
                    comBoxStatuses.Focus();
                    comBoxStatuses_SelectedIndexChanged(null, null);
                    break;
                default:
                    comBoxStatuses.Visible = false;
                    txtBoxFilterSearch.Visible = true;
                    foreach (Char ch in txtBoxFilterSearch.Text)
                    {
                        if (!clsValidating.IsAcceptableType(ch,
                            ((clsField)comBoxFilter.SelectedItem).ValidatingType))
                        {
                            txtBoxFilterSearch.Clear();
                        }
                    }
                    txtBoxFilterSearch.Focus();
                    txtBoxFilterSearch_TextChanged(null, null);
                    break;
            }
        }
        private void txtBoxFilterSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidating.IsAcceptableType(e.KeyChar, (clsValidating.enTypes)comBoxFilter.SelectedValue))
            {
                e.Handled = true;
            }
        }
        private void comBoxStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxStatuses.SelectedIndex == 0)
                FilterInstance.CurrentValue = null;
            else
                FilterInstance.CurrentValue = comBoxStatuses.SelectedIndex == 1;

            //MakeFiltering();
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            frm.ShowDialog();
            FilterInstance.RefreshDataView();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            FilterInstance.RefreshDataView();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are you sure do want to delete the user with ID = {userID} ?",
            "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (clsUser.DeleteByUserID(userID))
            {
                MessageBox.Show("User Deleted Successfully.", "Save", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                FilterInstance.RefreshDataView();
            }

            MessageBox.Show("Error: User Is not Deleted Successfully.", "Save Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            if (frm.ShowDialog() == DialogResult.OK) FilterInstance.RefreshDataView();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(null, null);
        }
        private void dgvUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUsers.Columns["Is Active"].MinimumWidth = 100;
            dgvUsers.AutoResizeColumns();
        }
        private void conMenUsersActions_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvUsers.CurrentCell == null)
            {
                e.Cancel = true;
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}