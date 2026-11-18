using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class LocalDrivingLicenseApplicationsDataAccess
    {
        public static int AddNew(int ApplicationID, int LicenseClassID)
        {
            int _LocalDrivingLicenseApplicationID = -1;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "INSERT INTO LocalDrivingLicenseApplications(ApplicationID, LicenseClassID) Values ( @ApplicationID, @LicenseClassID ); SELECT  SCOPE_IDENTITY ( ) ;  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();
                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                    _LocalDrivingLicenseApplicationID = _ParsedResult;
            }
            finally { conn.Close(); }
            return _LocalDrivingLicenseApplicationID;
        }
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable table = new DataTable();
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications_View ORDER BY ApplicationDate DESC";
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


        public static bool FindByLocalDrivingLicenseApplicationID(ref int LocalDrivingLicenseApplicationID,
            ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;
        }
        public static bool FindByApplicationID(int applicationID, ref int localDrivingLicenseApplicationID, ref int licenseClassID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    localDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    licenseClassID = (int)reader["LicenseClassID"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;
        }

        public static bool DeleteByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            bool isDeleted; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                conn.Open();
                isDeleted = cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                isDeleted = false;
            }
            finally
            {
                conn.Close();
            }
            return isDeleted;

        }

        public static bool IsExistsLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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

        public static int Update(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            int RowsEffected;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "UPDATE LocalDrivingLicenseApplications SET ApplicationID = @ApplicationID, LicenseClassID = @LicenseClassID WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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

        public static DataTable getPassedTests(int localApplicationId)
        {
            DataTable table = new DataTable();


            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = @"SELECT te.* FROM LocalDrivingLicenseApplications as l
                    INNER JOIN TestAppointments as t ON l.LocalDrivingLicenseApplicationID = t.LocalDrivingLicenseApplicationID
                    INNER JOIN Tests as te ON te.TestAppointmentID = t.TestAppointmentID
                    WHERE l.LocalDrivingLicenseApplicationID = @localApplicationId AND  te.TestResult = 1";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@localApplicationId", localApplicationId);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //if (reader.HasRows)
                    //{
                    table.Load(reader);
                    //}

                    reader.Close();
                }
                finally
                {
                    conn.Close();
                }
                return table;
            }
        }

        public static DataTable getAllAppointments(int localApplicationId)
        {
            DataTable table = new DataTable();


            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = @"SELECT t.TestAppointmentID, t.AppointmentDate, t.PaidFees, t.IsLocked FROM LocalDrivingLicenseApplications as l
                    INNER JOIN TestAppointments as t ON l.LocalDrivingLicenseApplicationID = t.LocalDrivingLicenseApplicationID
                    WHERE l.LocalDrivingLicenseApplicationID = @localApplicationId";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@localApplicationId", localApplicationId);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //if (reader.HasRows)
                    //{
                    table.Load(reader);
                    //}

                    reader.Close();
                }
                finally
                {
                    conn.Close();
                }
                return table;
            }

        }

        public static bool IsThereAnActiveScheduledTest(int localDrivingLicenseApplicationId, int testTypeId)
        {
            bool isThereActiveScheduledTest = false;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                            AND(TestAppointments.TestTypeID = @TestTypeID) and isLocked=0
                            ORDER BY TestAppointments.TestAppointmentID desc";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@localDrivingLicenseApplicationId", localDrivingLicenseApplicationId);
            cmd.Parameters.AddWithValue("@testTypeId", testTypeId);
            try
            {
                conn.Open();
                isThereActiveScheduledTest = cmd.ExecuteScalar() != null;
            }
            catch
            {
                isThereActiveScheduledTest = false;
            }
            finally
            {
                conn.Close();
            }
            return isThereActiveScheduledTest;
        }

        public static byte GetTotalTrialsPerTestType(int localDrivingLicenseApplicationID, int testTypeId)
        {
            byte totalTrialPerTest = 0;

            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"SELECT TotalTrialsPerTest = count(TestID)
                FROM LocalDrivingLicenseApplications as l INNER JOIN
                        TestAppointments ON l.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                        Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                WHERE
                    l.LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID 
                    AND TestAppointments.TestTypeID = @testTypeId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@testTypeId", testTypeId);
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();
                if (_result != null && byte.TryParse(_result.ToString(), out byte _ParsedResult))
                    totalTrialPerTest = _ParsedResult;
            }
            finally { conn.Close(); }

            return totalTrialPerTest;


        }

        public static bool DoesAttendTestType(int localDrivingLicenseApplicationID, int testTypeID)
        {
            bool DoesAttendTest = false;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                                INNER JOIN Tests ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                            AND(TestAppointments.TestTypeID = @TestTypeID)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@localDrivingLicenseApplicationId", localDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@testTypeId", testTypeID);
            try
            {
                conn.Open();
                DoesAttendTest = cmd.ExecuteScalar() != null;
            }
            catch
            {
                DoesAttendTest = false;
            }
            finally
            {
                conn.Close();
            }
            return DoesAttendTest;

        }

        public static bool DoesPassTestType(int localDrivingLicenseApplicationID, int testTypeID)
        {
            bool Result = false;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @" SELECT top 1 Tests.TestResult
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                                INNER JOIN Tests ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@localDrivingLicenseApplicationId", localDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@testTypeId", testTypeID);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
                {
                    Result = returnedResult;
                }
            }
            catch
            {
                Result = false;
            }
            finally
            {
                conn.Close();
            }
            return Result;
        }

    }
}