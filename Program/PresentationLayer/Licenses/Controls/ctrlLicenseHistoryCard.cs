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
    public partial class ctrlLicenseHistoryCard : UserControl
    {
        private int _DriverID = -1;
        private clsDriver _Driver;

        public ctrlLicenseHistoryCard()
        {
            InitializeComponent();
        }

        public void LoadDriverLicenses(int driverID)
        {

            _DriverID = driverID;

            _Driver = clsDriver.FindByDriverID(_DriverID);

            _LoadLocalLicenses();
            _LoadInternationalLicenses();
        }

        internal void Clear()
        {
            dgvLocal.DataSource = null;
            dgvInternational.DataSource = null;
        }

        internal void LoadDriverLicensesByPersonID(int personID)
        {
            _Driver = clsDriver.FindByPersonID(personID);

            if (_Driver != null)
            {
                _DriverID = clsDriver.FindByPersonID(personID).DriverID;
            }

            _LoadLocalLicenses();
            _LoadInternationalLicenses();
        }
        private void _LoadLocalLicenses()
        {
            DataTable licenseHistory = _Driver.GetLicenses();

            dgvLocal.DataSource = licenseHistory;
            dgvLocal.Columns[0].HeaderText = "Lic. ID";
            dgvLocal.Columns[1].HeaderText = "App. ID";
            dgvLocal.Columns[2].HeaderText = "Class Name";
            dgvLocal.Columns[3].HeaderText = "Issue Date";
            dgvLocal.Columns[4].HeaderText = "Expiration Date";
            dgvLocal.Columns[5].HeaderText = "Is Active";

        }
        private void _LoadInternationalLicenses()
        {
            DataTable licenseHistory = _Driver.GetInternationalLicenses();

            dgvInternational.DataSource = licenseHistory;
            dgvInternational.Columns[0].HeaderText = "Int. License ID";
            dgvInternational.Columns[1].HeaderText = "App. ID";
            dgvInternational.Columns[2].HeaderText = "L. License ID";
            dgvInternational.Columns[3].HeaderText = "Issue Date";
            dgvInternational.Columns[4].HeaderText = "Expiration Date";
            dgvInternational.Columns[5].HeaderText = "Is Active";
        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm;

            if (tabCtrlLicenseHistory.SelectedIndex == 0)
            {
                frm = new frmShowDriverLicenseDetails((int)dgvLocal.CurrentRow.Cells[0].Value);
            }
            else
            {
                frm = new frmShowInternationalDriverLicenseDetails((int)dgvInternational.CurrentRow.Cells[0].Value);
            }

            frm.ShowDialog();
        }

        private void conMenLicenseActions_Opening(object sender, CancelEventArgs e)
        {
            if (tabCtrlLicenseHistory.SelectedIndex == 0)
            {
                if (dgvLocal.CurrentCell == null)
                {
                    e.Cancel = true;
                }
                return;
            }
            if (dgvInternational.CurrentCell == null)
            {
                e.Cancel = true;
            }
        }

    }
}
