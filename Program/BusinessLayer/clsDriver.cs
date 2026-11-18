using DataAccessLayer;

using System;
using System.Data;

namespace BusinessLayer
{
    public class clsDriver
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }

        public clsPerson PersonInfo;
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        private enum _enMode
        {
            AddNew,
            Update
        }

        private _enMode _Mode { get; set; }

        public clsDriver()
        {
            this.DriverID = default;
            this.PersonID = default;
            this.CreatedByUserID = default;
            this.CreatedDate = DateTime.Now;
            this._Mode = _enMode.AddNew;
        }

        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.FindByPersonID(this.PersonID);
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            this._Mode = _enMode.Update;
        }

        public static DataTable GetAll()
        {
            return DriversDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            DriverID = DriversDataAccess.AddNew(PersonID, CreatedByUserID, CreatedDate);
            return DriverID != -1;
        }

        private bool _Update()
        {
            int RowsEffected = DriversDataAccess.Update(DriverID, PersonID, CreatedByUserID, CreatedDate);
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
                        return true;
                    }

                    return false;
                case _enMode.Update:
                    return _Update();
            }
            return false;

        }

        public static clsDriver FindByDriverID(int DriverID)
        {
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;
            if (DriversDataAccess.FindByDriverID(ref DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }

            return null;
        }
        public static clsDriver FindByPersonID(int personID)
        {
            int driverId = -1;
            int createdByUserID = -1;
            DateTime createdDate = DateTime.Now;
            if (DriversDataAccess.FindByPersonID(personID, ref driverId, ref createdByUserID, ref createdDate))
            {
                return new clsDriver(driverId, personID, createdByUserID, createdDate);
            }
            return null;
        }

        public static bool DeleteByDriverID(int DriverID)
        {
            int RowsEffected = DriversDataAccess.DeleteByDriverID(DriverID);
            return Convert.ToBoolean(RowsEffected);
        }

        public static bool IsExistsDriverID(int DriverID)
        {
            return DriversDataAccess.IsExistsDriverID(DriverID);
        }

        public static DataTable GetLicenses(int driverID)
        {
            return clsLicense.GetDriverLicenses(driverID);
        }
        public DataTable GetLicenses()
        {
            return clsLicense.GetDriverLicenses(this.DriverID);
        }

        public DataTable GetInternationalLicenses()
        {
            return InternationalLicensesDataAccess.GetLicensesByDriverID(this.DriverID);
        }
        public static DataTable GetInternationalLicenses(int driverID)
        {
            return InternationalLicensesDataAccess.GetLicensesByDriverID(driverID);
        }
    }
}