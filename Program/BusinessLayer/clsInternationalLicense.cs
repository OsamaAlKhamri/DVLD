using DataAccessLayer;

using System;
using System.Data;

namespace BusinessLayer
{
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public clsApplication ApplicationInfo { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverInfo { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public clsLicense LocalLicenseInfo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsUser UserInfo { get; set; }


        private enum _enMode
        {
            AddNew,
            Update
        }

        private _enMode _Mode { get; set; }

        public clsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now.AddYears(10);
            this.IsActive = true;
            this.CreatedByUserID = -1;
            this._Mode = _enMode.AddNew;
        }

        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.FindByApplicationID(this.ApplicationID);
            this.DriverID = DriverID;
            this.DriverInfo = clsDriver.FindByDriverID(this.DriverID);
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.LocalLicenseInfo = clsLicense.FindByLicenseID(IssuedUsingLocalLicenseID);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this.UserInfo = clsUser.FindByUserID(this.CreatedByUserID);
            this._Mode = _enMode.Update;
        }

        public static DataTable GetAllInternationalDrivingLicenses()
        {
            return InternationalLicensesDataAccess.GetAllInternationalDrivingLicenses();
        }

        private bool _AddNew()
        {
            InternationalLicenseID = InternationalLicensesDataAccess.AddNew(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            return InternationalLicenseID != -1;
        }

        private bool _Update()
        {
            int RowsEffected = InternationalLicensesDataAccess.Update(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            return Convert.ToBoolean(RowsEffected);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case _enMode.AddNew:
                    if (_AddNew())
                    {
                        _Mode = _enMode.Update;
                        this.ApplicationInfo = clsApplication.FindByApplicationID(this.ApplicationID);
                        this.DriverInfo = clsDriver.FindByDriverID(this.DriverID);
                        this.LocalLicenseInfo = clsLicense.FindByLicenseID(IssuedUsingLocalLicenseID);
                        this.UserInfo = clsUser.FindByUserID(this.CreatedByUserID);

                        return true;
                    }

                    return false;
                case _enMode.Update:
                    return _Update();
            }
            return false;

        }

        public static clsInternationalLicense FindByInternationalLicenseID(int InternationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = default;
            bool IsActive = true;
            int CreatedByUserID = -1;

            if (InternationalLicensesDataAccess.FindByInternationalLicenseID(ref InternationalLicenseID, ref ApplicationID,
                ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }

            return null;
        }

        public static bool DeleteByInternationalLicenseID(int InternationalLicenseID)
        {
            int RowsEffected = InternationalLicensesDataAccess.DeleteByInternationalLicenseID(InternationalLicenseID);
            return Convert.ToBoolean(RowsEffected);
        }
        private bool _UpdateActiveStatus(bool isActive)
        {
            int rowEffected = InternationalLicensesDataAccess.UpdateActiveStatus(InternationalLicenseID, isActive);
            return Convert.ToBoolean(rowEffected);

        }
        public static bool IsExistsInternationalLicenseID(int InternationalLicenseID)
        {
            return InternationalLicensesDataAccess.IsExistsInternationalLicenseID(InternationalLicenseID);
        }
        public bool IsActiveLicense()
        {
            if (this.ExpirationDate.CompareTo(DateTime.Now) < 0 && this.IsActive == true)
            {
                this.IsActive = false;
                this._UpdateActiveStatus(false);
                return false;
            }
            return true;
        }

        public DataTable GetLicensesByDriverID()
        {
            return InternationalLicensesDataAccess.GetLicensesByDriverID(this.DriverID);
        }
        public static DataTable GetLicensesByDriverID(int driverID)
        {
            return InternationalLicensesDataAccess.GetLicensesByDriverID(driverID);
        }

        public static clsInternationalLicense GetActiveInternationlLicenseByLocalLicenseID(int localLicenseID)
        {
            int InternationalLicenseID = -1;
            int ApplicationID = -1;
            int DriverID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = default;
            bool IsActive = true;
            int CreatedByUserID = -1;

            if (InternationalLicensesDataAccess.GetActiveInternationlLicenseByLocalLicenseID(localLicenseID,
                ref InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                if (ExpirationDate.CompareTo(DateTime.Now) < 0) return null;
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, localLicenseID, IssueDate,
                    ExpirationDate, IsActive, CreatedByUserID);
            }

            return null;

        }
        public static int GetActiveInternationlLicenseIDByLocalLicenseID(int licenseID)
        {
            return InternationalLicensesDataAccess.GetActiveInternationlLicenseIDByLocalLicenseID(licenseID);
        }

        public static int GetActiveInternationalLicenseIDInLicenseClass(int driverID, int licenseClass)
        {
            return InternationalLicensesDataAccess.GetActiveInternationalLicenseIDInLicenseClass(driverID, licenseClass);
        }
    }
}