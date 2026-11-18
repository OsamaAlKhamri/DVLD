using BusinessLayer;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmListPeople : Form
    {
        clsFilter FilterInstance;
        public frmListPeople()
        {
            InitializeComponent();
        }
        private void frmPeople_Load(object sender, EventArgs e)
        {
            List<clsField> Items = new List<clsField>();

            Items.Add(new clsField("None", clsValidating.enTypes.None, clsFilter.enColumnType.None));
            Items.Add(new clsField("Person ID", clsValidating.enTypes.Integer, clsFilter.enColumnType.Number));
            Items.Add(new clsField("National No", clsValidating.enTypes.String, clsFilter.enColumnType.String));
            Items.Add(new clsField("First Name", clsValidating.enTypes.StringWithWhiteSpace, clsFilter.enColumnType.String));
            Items.Add(new clsField("Second Name", clsValidating.enTypes.StringWithWhiteSpace, clsFilter.enColumnType.String));
            Items.Add(new clsField("Third Name", clsValidating.enTypes.StringWithWhiteSpace, clsFilter.enColumnType.String));
            Items.Add(new clsField("Last Name", clsValidating.enTypes.StringWithWhiteSpace, clsFilter.enColumnType.String));
            Items.Add(new clsField("Nationality", clsValidating.enTypes.Combo, clsFilter.enColumnType.String));
            Items.Add(new clsField("Gender", clsValidating.enTypes.Combo, clsFilter.enColumnType.String, true));
            Items.Add(new clsField("Phone", clsValidating.enTypes.Phone, clsFilter.enColumnType.String));
            Items.Add(new clsField("Email", clsValidating.enTypes.Email, clsFilter.enColumnType.String));

            FilterInstance = new clsFilter(null);
            FilterInstance.RefreshDataView = () =>
            {
                FilterInstance.MainTable = clsPerson.GetAllWithoutImagePath().DefaultView;

                dgvPeople.DataSource = FilterInstance.MainTable;
                FilterInstance.Filtering();
            };
            FilterInstance.RefreshDataView();

            comBoxFilter.DisplayMember = "Name";
            comBoxFilter.ValueMember = "ValidatingType";
            comBoxFilter.DataSource = Items;

            comBoxFilter.SelectedIndex = 0;
        }
        private void ChangeSelection()
        {
            switch ((clsValidating.enTypes)comBoxFilter.SelectedValue)
            {
                case clsValidating.enTypes.None:
                    txtBoxFilterSearch.Visible = comBoxPublic.Visible = false;
                    break;
                case clsValidating.enTypes.Combo:
                    txtBoxFilterSearch.Visible = false;
                    comBoxPublic.Visible = true;

                    clsField combo = (clsField)comBoxFilter.SelectedItem;
                    if (combo.Name == "Gender")
                    {
                        comBoxPublic.DataSource = new List<string>(new[] { "All", "Male", "Female" });
                        comBoxPublic.SelectedIndexChanged -= comBoxCountries_SelectedIndexChanged;
                        comBoxPublic.SelectedIndexChanged += comBoxGendors_SelectedIndexChanged;
                        comBoxGendors_SelectedIndexChanged(null, null);
                    }
                    else
                    {
                        comBoxPublic.DataSource = clsCountry.GetAll().Select().Select(row => row["Country Name"]).ToList();
                        comBoxPublic.SelectedItem = "Yemen";
                        comBoxPublic.SelectedIndexChanged -= comBoxGendors_SelectedIndexChanged;
                        comBoxPublic.SelectedIndexChanged += comBoxCountries_SelectedIndexChanged;

                        comBoxCountries_SelectedIndexChanged(null, null);
                    }
                    comBoxPublic.Focus();
                    break;
                default:
                    comBoxPublic.Visible = false;
                    txtBoxFilterSearch.Visible = true;
                    foreach (Char ch in txtBoxFilterSearch.Text)
                        if (!clsValidating.IsAcceptableType(ch,
                            ((clsField)comBoxFilter.SelectedItem).ValidatingType))
                            txtBoxFilterSearch.Clear();
                    txtBoxFilterSearch.Focus();
                    txtBoxFilterSearch_TextChanged(null, null);
                    break;
            }
        }
        private void conMenPeopleActions_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvPeople.CurrentCell == null)
            {
                e.Cancel = true;
            }
        }
        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            if (frm.ShowDialog() == DialogResult.OK) FilterInstance.RefreshDataView();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToolStripMenuItem_Click(null, null);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            if (frm.ShowDialog() == DialogResult.OK) FilterInstance.RefreshDataView();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are you sure do want to delete the person with ID = {personID} ?",
            "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsPerson person = clsPerson.FindByPersonID(personID);
            if (clsPerson.DeleteByPersonID(person.PersonID))
            {
                if (person.ImagePath != null)
                {
                    File.Delete(person.ImagePath);
                }
                MessageBox.Show("Deleted successfully.");
                FilterInstance.RefreshDataView();
            }
            else
            {
                MessageBox.Show("Failed.");
            }
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
        private void txtBoxFilterSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidating.IsAcceptableType(e.KeyChar, (clsValidating.enTypes)comBoxFilter.SelectedValue))
            {
                e.Handled = true;
            }
        }
        private void comBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInstance.CurrentValue = comBoxPublic.SelectedValue;
        }
        private void comBoxGendors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxPublic.SelectedIndex == 0)
                FilterInstance.CurrentValue = null;
            else
                FilterInstance.CurrentValue = comBoxPublic.SelectedValue;
        }
        private void dgvPeople_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form frm = new frmShowPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void dgvPeople_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPeople.AutoResizeColumns();
        }

        
    }
}
