using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsTest
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        
        public clsTestAppointment AppointmentInfo { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        private enum _enMode
        {
            AddNew,
            Update
        }

        private _enMode _Mode { get; set; }

        public clsTest()
        {
            this.TestID = default;
            this.TestAppointmentID = default;
            this.TestResult = default;
            this.Notes = default;
            this.CreatedByUserID = default;
            this._Mode = _enMode.AddNew;
        }

        private clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.AppointmentInfo = clsTestAppointment.FindByTestAppointmentID(TestAppointmentID);
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            this._Mode = _enMode.Update;
        }

        public static DataTable GetAll()
        {
            return TestsDataAccess.GetAll();
        }

        private bool _AddNew()
        {
            TestID = TestsDataAccess.AddNew(TestAppointmentID, TestResult, Notes, CreatedByUserID);
            return TestID != -1;
        }

        private bool _Update()
        {
            int RowsEffected = TestsDataAccess.Update(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
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

        public static clsTest FindByTestID(int TestID)
        {
            int TestAppointmentID = default;
            bool TestResult = default;
            string Notes = default;
            int CreatedByUserID = default;
            if (TestsDataAccess.FindByTestID(ref TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }

            return null;
        }

        public static clsTest FindByTestAppointmentId(int appointmentId)
        {
            int testId = default;
            bool testResult = default;
            string notes = default;
            int createdByUserID = default;
            if (TestsDataAccess.FindByTestAppointmentId(appointmentId, ref testId, ref testResult, ref notes, ref createdByUserID))
            {
                return new clsTest(testId, appointmentId, testResult, notes, createdByUserID);
            }
            return null;
        }


        public static bool DeleteByTestID(int TestID)
        {
            int RowsEffected = TestsDataAccess.DeleteByTestID(TestID);
            return Convert.ToBoolean(RowsEffected);
        }

        public static bool IsExistsTestID(int TestID)
        {
            return TestsDataAccess.IsExistsTestID(TestID);
        }
        public static clsTest GetLastTestByPersonAndTestTypeAndLicenseClass(int applicantPersonID, 
            int testTypeId, int licenseClassID)
        {
            int testId = default, testAppointmentId = default, createdByUserId = default;
            string notes = default;
            bool testResult = default;
            if(TestsDataAccess.GetLastTestByPersonAndTestTypeAndLicenseClass(
                applicantPersonID, (int)testTypeId, licenseClassID,
                ref testId, ref testAppointmentId, ref testResult, ref notes, ref createdByUserId))
            {
                return new clsTest(testId, testAppointmentId, testResult, notes, createdByUserId);
            }
            else { return null; }
        }
    }
}