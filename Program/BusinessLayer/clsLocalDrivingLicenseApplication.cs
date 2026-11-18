using DataAccessLayer;

using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace BusinessLayer
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLicenseClass LicenseClassInfo;
        public string PersonFullName
        {
            get
            {
                return clsPerson.FindByPersonID(ApplicantPersonID).FullName;
            }
        }

        private enum _enMode
        {
            AddNew,
            Update
        }
        private _enMode _Mode { get; set; }

        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID = -1;

            _Mode = _enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID,
            int ApplicationID,
            int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, enApplicationStatus ApplicationStatus,
            DateTime LastStatusDate, Decimal PaidFees,
            int CreatedByUserID, int LicenseClassID) :
                base(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClass.FindByLicenseClassID(LicenseClassID);
            this._Mode = _enMode.Update;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return LocalDrivingLicenseApplicationsDataAccess.GetAllLocalDrivingLicenseApplications();
        }
        private bool _AddNew()
        {
            LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationsDataAccess.AddNew(ApplicationID,
                LicenseClassID);
            return LocalDrivingLicenseApplicationID != -1;
        }

        private bool _Update()
        {
            int RowsEffected = LocalDrivingLicenseApplicationsDataAccess.Update(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            return Convert.ToBoolean(RowsEffected);
        }

        public override bool Save()
        {
            if (base.Save() == false) return false;

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

        public static clsLocalDrivingLicenseApplication FindByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;
            if (LocalDrivingLicenseApplicationsDataAccess.
                FindByLocalDrivingLicenseApplicationID(ref LocalDrivingLicenseApplicationID,
                ref ApplicationID, ref LicenseClassID))
            {

                clsApplication application = clsApplication.FindByApplicationID(ApplicationID);


                return new clsLocalDrivingLicenseApplication(
                    LocalDrivingLicenseApplicationID,
                    ApplicationID, application.ApplicantPersonID, application.ApplicationDate, (int)application.ApplicationTypeID,
                    application.ApplicationStatus, application.LastStatusDate,
                    application.PaidFees, application.CreatedByUserID,
                    LicenseClassID);
            }

            return null;
        }
        public static new clsLocalDrivingLicenseApplication
            FindByApplicationID(int applicationID)
        {
            int localDrivingLicenseApplicationID = -1;
            int licenseClassID = -1;

            clsApplication application = clsApplication.FindByApplicationID(applicationID);

            if (application != null)
            {
                if (LocalDrivingLicenseApplicationsDataAccess.
                    FindByApplicationID(applicationID, ref localDrivingLicenseApplicationID, ref licenseClassID))
                {
                    return new clsLocalDrivingLicenseApplication(
                        localDrivingLicenseApplicationID,
                        applicationID, application.ApplicantPersonID, application.ApplicationDate, (int)application.ApplicationTypeID,
                        application.ApplicationStatus, application.LastStatusDate,
                        application.PaidFees, application.CreatedByUserID,
                        licenseClassID);
                }
            }

            return null;
        }
        public bool DeleteByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            bool IsLocalDrivingApplicationDeleted = false;
            bool IsBaseApplicationDeleted = false;

            IsLocalDrivingApplicationDeleted = LocalDrivingLicenseApplicationsDataAccess.
                DeleteByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);

            if (!IsLocalDrivingApplicationDeleted) return false;

            IsBaseApplicationDeleted = base.Delete();
            return IsBaseApplicationDeleted;
        }
        public static bool IsExistsLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return LocalDrivingLicenseApplicationsDataAccess.IsExistsLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
        }
        public static DataTable getAllAppointments(int localApplicationId)
        {
            return LocalDrivingLicenseApplicationsDataAccess.getAllAppointments(localApplicationId);
        }
        public static DataTable getPassedTests(int localApplicationId)
        {
            return LocalDrivingLicenseApplicationsDataAccess.getPassedTests(localApplicationId);
        }
        public DataTable getPassedTests()
        {
            return getPassedTests(this.LocalDrivingLicenseApplicationID);
        }
        public clsTest GetLastTestPerTestType(clsTestType.enTestType testTypeId)
        {
            return clsTest.GetLastTestByPersonAndTestTypeAndLicenseClass(
                this.ApplicantPersonID, (int)testTypeId, LicenseClassID);
        }
        public bool IsThereAnActiveScheduledTest(clsTestType.enTestType testTypeId)
        {
            return IsThereAnActiveScheduledTest(this.LocalDrivingLicenseApplicationID, testTypeId);
        }
        public static bool IsThereAnActiveScheduledTest(int localDrivingLicenseApplicationID, clsTestType.enTestType testTypeId)
        {
            return LocalDrivingLicenseApplicationsDataAccess.IsThereAnActiveScheduledTest(localDrivingLicenseApplicationID, (int)testTypeId);
        }
        public static byte GetTotalTrialsPerTestType(int localDrivingLicenseApplicationID, clsTestType.enTestType testTypeId)
        {
            return LocalDrivingLicenseApplicationsDataAccess.GetTotalTrialsPerTestType(localDrivingLicenseApplicationID, (int)testTypeId);
        }
        public byte GetTotalTrialsPerTestType(clsTestType.enTestType testTypeId)
        {
            return GetTotalTrialsPerTestType(this.LocalDrivingLicenseApplicationID, testTypeId);
        }
        public static bool DoesAttendTestType(int localDrivingLicenseApplicationID, clsTestType.enTestType testTypeID)
        {
            return LocalDrivingLicenseApplicationsDataAccess.DoesAttendTestType(localDrivingLicenseApplicationID, (int)testTypeID);
        }
        public bool DoesAttendTestType(clsTestType.enTestType testTypeID)
        {
            return DoesAttendTestType(this.LocalDrivingLicenseApplicationID, testTypeID);
        }
        public static bool DoesPassTestType(int localDrivingLicenseApplicationID, clsTestType.enTestType testTypeID)
        {
            return LocalDrivingLicenseApplicationsDataAccess.DoesPassTestType(localDrivingLicenseApplicationID, (int)testTypeID);
        }
        public bool DoesPassTestType(clsTestType.enTestType testTypeID)
        {
            return LocalDrivingLicenseApplicationsDataAccess.DoesPassTestType(this.LocalDrivingLicenseApplicationID, (int)testTypeID);
        }
    }
}