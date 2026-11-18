using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

namespace DataAccessLayer
{
    public class TestsDataAccess
    {
        public static int AddNew(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int _TestID = -1;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Tests(TestAppointmentID, TestResult, Notes, CreatedByUserID) 
                Values ( @TestAppointmentID, @TestResult, @Notes, @CreatedByUserID );
                UPDATE TestAppointments 
                SET IsLocked=1 where TestAppointmentID = @TestAppointmentID;
                SELECT  SCOPE_IDENTITY ( ) ;  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            cmd.Parameters.AddWithValue("@Notes", String.IsNullOrEmpty(Notes) ? Convert.DBNull : Notes);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();
                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                    _TestID = _ParsedResult;
            }
            finally { conn.Close(); }
            return _TestID;
        }

        public static DataTable GetAll()
        {
            DataTable table = new DataTable(); SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Tests";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }

                reader.Close();
            }
            finally
            {
                conn.Close();
            }
            return table;

        }

        public static bool FindByTestID(ref int TestID, ref int TestAppointmentID, ref bool TestResult, 
            ref string Notes, ref int CreatedByUserID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Tests WHERE TestID = @TestID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestID", TestID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    TestID = (int)reader["TestID"];
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    Notes = Convert.IsDBNull(reader["Notes"]) ? null : (string)reader["Notes"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;
        }
        public static bool FindByTestAppointmentId(int appointmentId, ref int testId, ref bool 
            testResult, ref string notes, ref int createdByUserId)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Tests WHERE TestAppointmentID = @appointmentId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    testId = (int)reader["TestID"];
                    testResult = (bool)reader["TestResult"];
                    notes = Convert.IsDBNull(reader["Notes"]) ? null : (string)reader["Notes"];
                    createdByUserId = (int)reader["CreatedByUserID"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;

        }

        public static int DeleteByTestID(int TestID)
        {
            int RowsEffected; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "DELETE FROM Tests WHERE TestID = @TestID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestID", TestID);
            try
            {
                conn.Open();
                RowsEffected = cmd.ExecuteNonQuery();
            }
            catch
            {
                RowsEffected = 0;
            }
            finally
            {
                conn.Close();
            }
            return RowsEffected;

        }

        public static bool IsExistsTestID(int TestID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Tests WHERE TestID = @TestID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestID", TestID);
            try
            {
                conn.Open();
                isFound = cmd.ExecuteScalar() != null;
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }
            return isFound;

        }

        public static int Update(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int RowsEffected; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "UPDATE Tests SET TestAppointmentID = @TestAppointmentID, TestResult = @TestResult, Notes = @Notes, CreatedByUserID = @CreatedByUserID WHERE TestID = @TestID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestID", TestID);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            cmd.Parameters.AddWithValue("@Notes", String.IsNullOrEmpty(Notes) ? Convert.DBNull : Notes);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                conn.Open();
                RowsEffected = cmd.ExecuteNonQuery();
            }
            catch
            {
                RowsEffected = 0;
            }
            finally
            {
                conn.Close();
            }
            return RowsEffected;

        }

        public static bool GetLastTestByPersonAndTestTypeAndLicenseClass(int applicantPersonID, 
            int testTypeId, int licenseClassId, ref int testId, 
            ref int testAppointmentId, ref bool testResult, ref string notes, ref int createdByUserId)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"
                SELECT  top 1 Tests.TestID, 
	                Tests.TestAppointmentID, Tests.TestResult, 
	                Tests.Notes, Tests.CreatedByUserID, Applications.ApplicantPersonID
	                FROM            LocalDrivingLicenseApplications INNER JOIN
								                Tests INNER JOIN
								                TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID 
								                ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
								                INNER JOIN
								                Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
	                WHERE        (Applications.ApplicantPersonID = @applicantPersonID) 
			                AND (LocalDrivingLicenseApplications.LicenseClassID = @licenseClassId)
			                AND ( TestAppointments.TestTypeID=@testTypeId)
	                ORDER BY Tests.TestAppointmentID DESC

";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@applicantPersonID", applicantPersonID);
            cmd.Parameters.AddWithValue("@licenseClassId", licenseClassId);
            cmd.Parameters.AddWithValue("@testTypeId", testTypeId);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    testId = (int)reader["TestID"];
                    testAppointmentId = (int)reader["TestAppointmentId"];
                    testResult = (bool)reader["TestResult"];
                    notes = Convert.IsDBNull(reader["Notes"]) ? null : (string)reader["Notes"];
                    createdByUserId = (int)reader["CreatedByUserID"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;
        }
    }
}