using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class conAutoFilter : UserControl
    {
        public EventHandler<EventArgs> Filtered;
        private Type _ClassType;
        public conAutoFilter()
        {
            InitializeComponent();
        }
        public void LoadType(Type type)
        {
            _ClassType = type;
        }
        bool _CheckLikeInRowInColumn(DataRow row, string col, string word)
        {
            return row[col.ToString()].ToString().ToLower().Contains(word);
        }
        bool _CheckLikeInRow(DataRow row, string word)
        {
            foreach (object col in row.Table.Columns)
            {
                if (row[col.ToString()].ToString().ToLower().Contains(word))
                {
                    return true;
                }
            }
            return false;
        }
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable records = _ClassType.GetMethod("GetAll").Invoke(null, null) as DataTable;
            if (string.IsNullOrEmpty(txtBoxSearch.Text))
            {
            }
            else if (comboBoxFilter.SelectedIndex is 0)
            {
                IEnumerable<DataRow> tab = records.Select().Where(record => _CheckLikeInRow(record, txtBoxSearch.Text.ToLower()));
                if (tab.Count() != 0)
                    records = tab.CopyToDataTable();
                else
                    records.Rows.Clear();
            }
            else
            {
                IEnumerable<DataRow> tab = records.Select().Where(record => _CheckLikeInRowInColumn(record,
                    comboBoxFilter.SelectedValue.ToString(), txtBoxSearch.Text.ToLower()));
                if (tab.Count() != 0)
                    records = tab.CopyToDataTable();
                else
                    records.Rows.Clear();
            }
            Filtered.Invoke(records, new EventArgs());
        }
        private void conAutoFilter_Load(object sender, EventArgs e)
        {
            if (_ClassType != null)
            {
                comboBoxFilter.DataSource = _ClassType.GetMethod("GetColumns").Invoke(null, null) as DataTable;
                comboBoxFilter.DisplayMember = "name";
                comboBoxFilter.ValueMember = "name";
                comboBoxFilter.SelectedIndex = 0;
            }
        }
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxSearch_TextChanged(null, null);
        }
        public void InvokeFiltering()
        {
            txtBoxSearch_TextChanged(null, null);
        }
    }
}
