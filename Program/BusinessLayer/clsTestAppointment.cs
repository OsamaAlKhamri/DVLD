using DataAccessLayer;

using System;
using System.Data;

namespace BusinessLayer
{
    public class clsTestAppointment
    {
        public int TestAppointmentID { get; set; }
        public clsTestType.enTestType TestTypeID { get; set; }
        public clsTestType TestTypeInfo;

        public int TestID
        {
            get { return _GetTestID(); }

        }

        private int _GetTestID()
        {
            return TestAppointmentsDataAccess.GetTestID(TestAppointmentID);
        }

        public int LocalDrivingLicenseApplicationID { get; set; }


        private clsLocalDrivingLicenseApplication _localDrivingLicenseApplicationInfo;
        public clsLocalDrivingLicenseApplication LocalDrivingLicenseApplicationInfo
        {
            get
            {
                if (_localDrivingLicenseApplicationInfo == null)
                    _localDrivingLicenseApplicationInfo =
                        clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
                return _localDrivingLicenseApplicationInfo;
            }
            set { _localDrivingLicenseApplicationInfo = value; }
        }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }

        //public clsTest TestInfo
        //{
        //    get
        //    {
        //        return clsTest.FindByTestID
        //    }
        //}

        private enum _enMode
        {
            AddNew,
            Update
        }

        private _enMode _Mode { get; set; }
        public clsApplication RetakeTestAppInfo
        {
            get;
            set;
        }

        public clsTestAppointment()
        {
            this.TestAppointmentID = default;
            this.TestTypeID = default;
            this.LocalDrivingLicenseApplicationID = default;
            this.AppointmentDate = default;
            this.PaidFees = default;
            this.CreatedByUserID = default;
            this.IsLocked = default;
            this.RetakeTestApplicationID = -1;
            this._Mode = _enMode.AddNew;
        }

        private clsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID,
            DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int retakeTestApplicationID)
        {
            _Mode = _enMode.Update;
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = (clsTestType.enTestType)TestTypeID;
            this.TestTypeInfo = clsTestType.FindByTestTypeID((clsTestType.enTestType)TestTypeID);
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            RetakeTestApplicationID = retakeTestApplicationID;
            RetakeTestAppInfo = clsApplication.FindByApplicationID(retakeTestApplicationID);
        }

        public static DataTable GetAll()
        {
            return TestAppointmentsDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            TestAppointmentID = TestAppointmentsDataAccess.AddNew((int)TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate,
                PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            return TestAppointmentID != -1;
        }

        private bool _Update()
        {
            int RowsEffected = TestAppointmentsDataAccess.Update(TestAppointmentID, (int)TestTypeID,
                LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
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

        public static clsTestAppointment FindByTestAppointmentID(int TestAppointmentID)
        {
            int TestTypeID = default;
            int LocalDrivingLicenseApplicationID = default;
            DateTime AppointmentDate = default;
            decimal PaidFees = default;
            int CreatedByUserID = default;
            int RetakeTestApplicationID = -1;
            bool IsLocked = default;
            if (TestAppointmentsDataAccess.FindByTestAppointmentID(ref TestAppointmentID, ref TestTypeID,
                ref LocalDrivingLicenseApplicationID, ref AppointmentDate,
                ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
                    AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }

            return null;
        }

        public static bool DeleteByTestAppointmentID(int TestAppointmentID)
        {
            int RowsEffected = TestAppointmentsDataAccess.DeleteByTestAppointmentID(TestAppointmentID);
            return Convert.ToBoolean(RowsEffected);
        }

        public static bool IsExistsTestAppointmentID(int TestAppointmentID)
        {
            return TestAppointmentsDataAccess.IsExistsTestAppointmentID(TestAppointmentID);
        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int localApplicationId, clsTestType.enTestType testTypeId)
        {
            return TestAppointmentsDataAccess.GetApplicationTestAppointmentsPerTestType(localApplicationId, (int)testTypeId);
        }
        public DataTable GetApplicationTestAppointmentsPerTestType(clsTestType.enTestType testTypeId)
        {
            return GetApplicationTestAppointmentsPerTestType(
                this.LocalDrivingLicenseApplicationID, testTypeId);
        }




    }
}