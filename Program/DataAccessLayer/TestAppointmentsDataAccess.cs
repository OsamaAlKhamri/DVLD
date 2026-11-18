using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class TestAppointmentsDataAccess
    {
        public static int AddNew(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, 
            decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int _TestAppointmentID = -1;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"INSERT INTO TestAppointments(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, 
                PaidFees, CreatedByUserID,isLocked, RetakeTestApplicationID) 
                Values ( @TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, 
                @CreatedByUserID, 0,@RetakeTestApplicationID ); SELECT  SCOPE_IDENTITY ( ) ;  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID == -1 ? Convert.DBNull : RetakeTestApplicationID);
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();
                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                    _TestAppointmentID = _ParsedResult;
            }
            finally { conn.Close(); }
            return _TestAppointmentID;
        }

        public static DataTable GetAll()
        {
            DataTable table = new DataTable(); SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM TestAppointments";
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

        public static bool FindByTestAppointmentID(ref int TestAppointmentID, ref int TestTypeID, 
            ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref decimal PaidFees, 
            ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                    RetakeTestApplicationID = Convert.IsDBNull(reader["RetakeTestApplicationID"])? -1 : 
                        (int)reader["RetakeTestApplicationID"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;
        }

        public static int DeleteByTestAppointmentID(int TestAppointmentID)
        {
            int RowsEffected; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "DELETE FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
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

        public static bool IsExistsTestAppointmentID(int TestAppointmentID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
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

        public static int Update(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, 
            DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int RowsEffected; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"UPDATE TestAppointments SET TestTypeID = @TestTypeID, 
                LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID, AppointmentDate = @AppointmentDate, 
                PaidFees = @PaidFees, CreatedByUserID = @CreatedByUserID, IsLocked = @IsLocked,
                RetakeTestApplicationID = @RetakeTestApplicationID WHERE TestAppointmentID = @TestAppointmentID";
                
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
            cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID == -1 ? Convert.DBNull : RetakeTestApplicationID);
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

        public static DataTable GetApplicationTestAppointmentsPerTestType(int localApplicationId, int TestTypeId)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = @"SELECT t.TestAppointmentID, t.AppointmentDate, t.PaidFees, t.IsLocked FROM LocalDrivingLicenseApplications as l
                    INNER JOIN TestAppointments as t ON l.LocalDrivingLicenseApplicationID = t.LocalDrivingLicenseApplicationID
                    WHERE l.LocalDrivingLicenseApplicationID = @localApplicationId AND t.TestTypeId=@TestTypeId
                    order by TestAppointmentID desc";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@localApplicationId", localApplicationId);
                cmd.Parameters.AddWithValue("@TestTypeId", TestTypeId);
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





        public static int GetTestID(int TestAppointmentID)
        {
            int testID = -1;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"SELECT Tests.TestID FROM Tests
                INNER JOIN TestAppointments
                ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                WHERE Tests.TestAppointmentID = @TestAppointmentID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();
                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                    testID = _ParsedResult;
            }
            finally { conn.Close(); }
            return testID;
        }
    }
}