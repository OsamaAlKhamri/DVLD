using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsApplicationType
    {
        public enApplicationType ApplicationTypeID { get; set; }
        public String ApplicationTypeTitle { get; set; }
        public Decimal ApplicationFees { get; set; }

        private enum _enMode
        {
            AddNew,
            Update
        }

        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        private _enMode _Mode { get; set; }

        public clsApplicationType()
        {
            this.ApplicationTypeID = default;
            this.ApplicationTypeTitle = default;
            this.ApplicationFees = default;
            this._Mode = _enMode.AddNew;
        }

        private clsApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = (enApplicationType)ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
            this._Mode = _enMode.Update;
        }

        public static DataTable GetAll()
        {
            return ApplicationTypeDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            ApplicationTypeID = (enApplicationType)ApplicationTypeDataAccess.AddNew(ApplicationTypeTitle, ApplicationFees);
            return (int)ApplicationTypeID != -1;
        }

        private bool _Update()
        {
            int RowsEffected = ApplicationTypeDataAccess.Update((int)ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
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
        public static clsApplicationType FindByApplicationTypeID(enApplicationType ApplicationTypeID)
        {
            string ApplicationTypeTitle = default;
            decimal ApplicationFees = default;
            if (ApplicationTypeDataAccess.FindByApplicationTypeID((int)ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationType((int)ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }

            return null;
        }
    }
}