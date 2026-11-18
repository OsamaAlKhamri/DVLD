using DataAccessLayer;

using System;
using System.Data;

namespace BusinessLayer
{
    public class clsDetainedLicense
    {
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public clsLicense LicenseInfo { get; set; }
        public clsUser CreatedByUserInfo { get; private set; }
        public clsUser ReleasedByUserInfo { get; private set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        private enum _enMode
        {
            AddNew,
            Update
        }

        private _enMode _Mode { get; set; }

        public clsDetainedLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = null;
            this.ReleasedByUserID = null;
            this.ReleaseApplicationID = null;
            this._Mode = _enMode.AddNew;
        }

        private clsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate,
            decimal FineFees, int CreatedByUserID, bool IsReleased,
            DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            this._Mode = _enMode.Update;
            _LoadComposedObjects();
        }
        private void _LoadComposedObjects()
        {
            this.LicenseInfo = clsLicense.FindByLicenseID(LicenseID);
            this.CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);
            if (ReleasedByUserID != null) 
                this.ReleasedByUserInfo = clsUser.FindByUserID(this.ReleasedByUserID.Value);
        }

        public static DataTable GetAll()
        {
            return DetainedLicensesDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            DetainID = DetainedLicensesDataAccess.AddNew(LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            return DetainID != -1;
        }

        private bool _Update()
        {
            int RowsEffected = DetainedLicensesDataAccess.Update(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
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
                        _LoadComposedObjects();
                        return true;
                    }

                    return false;
                case _enMode.Update:
                    return _Update();
            }
            return false;

        }

        public static clsDetainedLicense FindByDetainID(int DetainID)
        {
            int LicenseID = default;
            DateTime DetainDate = default;
            decimal FineFees = default;
            int CreatedByUserID = default;
            bool IsReleased = default;
            DateTime? ReleaseDate = default;
            int? ReleasedByUserID = default;
            int? ReleaseApplicationID = default;
            if (DetainedLicensesDataAccess.FindByDetainID(ref DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased,
                    ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }

            return null;
        }

        public static bool DeleteByDetainID(int DetainID)
        {
            int RowsEffected = DetainedLicensesDataAccess.DeleteByDetainID(DetainID);
            return Convert.ToBoolean(RowsEffected);
        }

        public static bool IsExistsDetainID(int DetainID)
        {
            return DetainedLicensesDataAccess.IsExistsDetainID(DetainID);
        }

        internal static bool isLicenseDetained(int licenseID)
        {
            return DetainedLicensesDataAccess.isLicenseDetained(licenseID);
        }

        internal static int GetDetainedLicenseIDByLicenseID(int licenseID)
        {
            return DetainedLicensesDataAccess.GetDetainedLicenseIDByLicenseID(licenseID);
        }
    }
}