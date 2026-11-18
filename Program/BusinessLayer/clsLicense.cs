using DataAccessLayer;

using System;
using System.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class clsLicense
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public clsApplication ApplicationInfo { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverInfo { get; set; }
        public int LicenseClass { get; set; }
        public clsLicenseClass LicenseClassInfo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser userInfo { get; set; }

        private enum _enMode
        {
            AddNew,
            Update
        }
        public enum enIssueReason
        {
            FirstTime = 1,
            ReplacementForDamaged,
            ReplacementForLost,
            Renewal,
        }
        public string IssueReasonText
        {
            get
            {
                return GetIssueReasonText(IssueReason);
            }
        }
        private _enMode _Mode { get; set; }

        public clsLicense()
        {
            this.LicenseID = default;
            this.ApplicationID = default;
            this.DriverID = default;
            this.LicenseClass = default;
            this.IssueDate = default;
            this.ExpirationDate = default;
            this.Notes = default;
            this.PaidFees = default;
            this.IsActive = true;
            this.IssueReason = default;
            this.CreatedByUserID = default;
            this._Mode = _enMode.AddNew;
        }

        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees,
            bool IsActive, enIssueReason IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.FindByApplicationID(this.ApplicationID);
            this.DriverID = DriverID;
            this.DriverInfo = clsDriver.FindByDriverID(this.DriverID);
            this.LicenseClass = LicenseClass;
            this.LicenseClassInfo = clsLicenseClass.FindByLicenseClassID(this.LicenseClass);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this.userInfo = clsUser.FindByUserID(this.CreatedByUserID);
            this._Mode = _enMode.Update;
        }

        public static string GetIssueReasonText(enIssueReason issueReason)
        {
            switch (issueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.ReplacementForDamaged:
                    return "Replacement For Damaged Leicense";
                case enIssueReason.ReplacementForLost:
                    return "Replacement For Lost Leicense";
                case enIssueReason.Renewal:
                    return "Renew Leicense";
                default:
                    break;
            }
            return null;
        }
        public static DataTable GetAll()
        {
            return LicensesDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            LicenseID = LicensesDataAccess.AddNew(ApplicationID,
                DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees,
                IsActive, (byte)IssueReason, CreatedByUserID);
            return LicenseID != -1;
        }

        private bool _Update()
        {
            int RowsEffected = LicensesDataAccess.Update(LicenseID, ApplicationID, DriverID,
                LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, (byte)IssueReason, CreatedByUserID);
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
                        this.LicenseClassInfo = clsLicenseClass.FindByLicenseClassID(this.LicenseClass);
                        this.userInfo = clsUser.FindByUserID(this.CreatedByUserID);
                        return true;
                    }

                    return false;
                case _enMode.Update:
                    return _Update();
            }
            return false;

        }

        public static clsLicense FindByLicenseID(int LicenseID)
        {
            int ApplicationID = default;
            int DriverID = default;
            int LicenseClass = default;
            DateTime IssueDate = default;
            DateTime ExpirationDate = default;
            string Notes = default;
            decimal PaidFees = default;
            bool IsActive = default;
            byte IssueReason = 1;
            int CreatedByUserID = default;
            if (LicensesDataAccess.FindByLicenseID(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass,
                ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass,
                    IssueDate, ExpirationDate, Notes, PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            }

            return null;
        }

        public static bool DeleteByLicenseID(int LicenseID)
        {
            int RowsEffected = LicensesDataAccess.DeleteByLicenseID(LicenseID);
            return Convert.ToBoolean(RowsEffected);
        }

        public static bool IsExistsLicenseID(int LicenseID)
        {
            return LicensesDataAccess.IsExistsLicenseID(LicenseID);
        }

        public static bool IsLicenseExistByPersonID(int personID, int licenseClassID)
        {
            return (GetActiveLicenseIDByPersonID(personID, licenseClassID) != -1);
        }

        public static int GetActiveLicenseIDByPersonID(int personID, int licenseClassID)
        {
            return LicensesDataAccess.GetActiveLicenseIDByPersonID(personID, licenseClassID);

        }
        private bool _UpdateActiveStatus(bool isActive)
        {
            int rowEffected = LicensesDataAccess.UpdateActiveStatus(LicenseID, isActive);
            return Convert.ToBoolean(rowEffected);

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
        public bool IsDetainedLicense()
        {
            return clsDetainedLicense.isLicenseDetained(this.LicenseID);
        }
        public int GetDetainedLicenseID()
        {
            return clsDetainedLicense.GetDetainedLicenseIDByLicenseID(this.LicenseID);
        }
        public static bool IsDetainedLicense(int licenseID)
        {
            return clsDetainedLicense.isLicenseDetained(licenseID);
        }
        public static DataTable GetDriverLicenses(int driverID)
        {
            return LicensesDataAccess.GetDriverLicenses(driverID);
        }

        public static clsLicense GetDriverLicenseByApplicationID(int applicationID)
        {
            int LicenseID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = default;
            DateTime ExpirationDate = default;
            string Notes = default;
            decimal PaidFees = default;
            bool IsActive = true;
            byte IssueReason = 1;
            int CreatedByUserID = -1;
            if (LicensesDataAccess.GetDriverLicenseByApplicationID(applicationID, ref LicenseID, ref DriverID, ref LicenseClass,
                ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicense(LicenseID, applicationID, DriverID, LicenseClass,
                    IssueDate, ExpirationDate, Notes, PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            }

            return null;

        }
        public static bool IsActiveLicense(int licenseID)
        {
            return LicensesDataAccess.IsActiveLicense(licenseID);
        }
        public static bool UpdateActivation(int licenseId, bool value)
        {
            clsLicense license = clsLicense.FindByLicenseID(licenseId);
            if (license != null)
            {
                license.IsActive = value;
                return license.Save();
            }
            return false;
        }
    }
}