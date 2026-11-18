using DataAccessLayer;

using System;
using System.Data;

namespace BusinessLayer
{
    public class clsApplication
    {
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }

        public clsPerson ApplicantPersonInfo;
        public DateTime ApplicationDate { get; set; }
        public clsApplicationType.enApplicationType ApplicationTypeID { get; set; }

        public clsApplicationType ApplicationTypeInfo;
        public enApplicationStatus ApplicationStatus { set; get; }
        public DateTime LastStatusDate { get; set; }
        public Decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public clsUser CreatedByUserInfo;
        public string StatusText
        {
            get
            {
                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }

        }

        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };
        //public enum enApplicationType
        //{
        //    NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
        //    ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        //};
        private enum _enMode
        {
            AddNew,
            Update
        }

        private _enMode _Mode { get; set; }

        public clsApplication()
        {
            this.ApplicationID = default;
            this.ApplicantPersonID = default;
            this.ApplicationDate = default;
            this.ApplicationTypeID = default;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = default;
            this.PaidFees = default;
            this.CreatedByUserID = default;
            this._Mode = _enMode.AddNew;
        }

        protected clsApplication(int ApplicationID,
            int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, enApplicationStatus ApplicationStatus,
            DateTime LastStatusDate, Decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicantPersonInfo = clsPerson.FindByPersonID(ApplicantPersonID);
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = (clsApplicationType.enApplicationType)ApplicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.FindByApplicationTypeID(this.ApplicationTypeID);
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);
            this._Mode = _enMode.Update;
        }
        public static DataTable GetAll()
        {
            return ApplicationsDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            ApplicationID = ApplicationsDataAccess.AddNew(ApplicantPersonID,
                ApplicationDate, (int)ApplicationTypeID,
                (byte)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            return ApplicationID != -1;
        }

        private bool _Update()
        {
            int RowsEffected = ApplicationsDataAccess.Update(ApplicationID,
                ApplicantPersonID, ApplicationDate, (int)ApplicationTypeID,
                (byte)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            return Convert.ToBoolean(RowsEffected);
        }

        public virtual bool Save()
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

        public static clsApplication FindByApplicationID(int ApplicationID)
        {
            int ApplicantPersonID = default;
            DateTime ApplicationDate = default;
            int ApplicationTypeID = default;
            System.Byte ApplicationStatus = default;
            DateTime LastStatusDate = default;
            decimal PaidFees = default;
            int CreatedByUserID = default;
            if (ApplicationsDataAccess.FindByApplicationID(ref ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, (enApplicationStatus)ApplicationStatus,
                    LastStatusDate, PaidFees, CreatedByUserID);
            }

            return null;
        }

        public static bool Delete(int ApplicationID)
        {
            int RowsEffected = ApplicationsDataAccess.DeleteByApplicationID(ApplicationID);
            return Convert.ToBoolean(RowsEffected);
        }
        public bool Delete()
        {
            int RowsEffected = ApplicationsDataAccess.DeleteByApplicationID(this.ApplicationID);
            return Convert.ToBoolean(RowsEffected);
        }
        public static bool IsExistsApplicationID(int ApplicationID)
        {
            return ApplicationsDataAccess.IsExistsApplicationID(ApplicationID);
        }
        public static bool DoesPersonHaveActiveApplication(int personID, int applicationTypeID)
        {
            return ApplicationsDataAccess.DoesPersonHaveActiveApplication(personID, applicationTypeID);
        }
        public bool DoesPersonHaveActiveApplication(int applicationTypeID)
        {
            return DoesPersonHaveActiveApplication(this.ApplicantPersonID, applicationTypeID);
        }
        public static int GetActiveApplicationID(int PersonID, clsApplicationType.enApplicationType ApplicationTypeID)
        {
            return ApplicationsDataAccess.GetActiveApplicationID(PersonID, (int)ApplicationTypeID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int personID, clsApplicationType.enApplicationType applicationTypeID, int licenseClassID)
        {
            return ApplicationsDataAccess.GetActiveApplicationIDForLicenseClass(personID, (int)applicationTypeID, licenseClassID);
        }

        public int GetActiveApplicationID(clsApplicationType.enApplicationType applicationTypeID)
        {
            return GetActiveApplicationID(this.ApplicantPersonID, applicationTypeID);
        }

        public int GetApplicationLicenseID()
        {
            return clsLicense.GetDriverLicenseByApplicationID(ApplicationID)?.LicenseID ?? -1;
        }

        public static bool UpdateStatus(int applicationID, enApplicationStatus status)
        {
            clsApplication app = clsApplication.FindByApplicationID(applicationID);
            if (app != null)
            {
                app.ApplicationStatus = status;
                return app.Save();
            }

            return false;
        }
    }
}