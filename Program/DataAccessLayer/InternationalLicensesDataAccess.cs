using System;
using System.Data;
using System.Data.SqlClient;

using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class InternationalLicensesDataAccess
    {
        public static int AddNew(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int _InternationalLicenseID = -1;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "INSERT INTO InternationalLicenses(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID) Values ( @ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID ); SELECT  SCOPE_IDENTITY ( ) ;  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();
                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                    _InternationalLicenseID = _ParsedResult;
            }
            finally { conn.Close(); }
            return _InternationalLicenseID;
        }

        public static DataTable GetAllInternationalDrivingLicenses()
        {
            DataTable table = new DataTable(); SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT [InternationalLicenseID]
                  ,[ApplicationID]
                  ,[DriverID]
                  ,[IssuedUsingLocalLicenseID]
                  ,[IssueDate]
                  ,[ExpirationDate]
                  ,[IsActive] FROM [dbo].[InternationalLicenses]";

            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
            return table;

        }

        public static bool FindByInternationalLicenseID(ref int InternationalLicenseID, ref int ApplicationID,
            ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate,
            ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    InternationalLicenseID = (int)reader["InternationalLicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;
        }

        public static int DeleteByInternationalLicenseID(int InternationalLicenseID)
        {
            int RowsEffected; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "DELETE FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
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

        public static bool IsExistsInternationalLicenseID(int InternationalLicenseID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
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

        public static int Update(int InternationalLicenseID, int ApplicationID, int DriverID,
            int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int RowsEffected; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "UPDATE InternationalLicenses SET ApplicationID = @ApplicationID, DriverID = @DriverID, IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID, IssueDate = @IssueDate, ExpirationDate = @ExpirationDate, IsActive = @IsActive, CreatedByUserID = @CreatedByUserID WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
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
        public static int UpdateActiveStatus(int internationalLicenseID, bool isActive)
        {
            int RowsEffected; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "UPDATE InternationalLicenses SET IsActive = @IsActiveWHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);
            cmd.Parameters.AddWithValue("@IsActive", isActive);
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

        public static DataTable GetLicensesByDriverID(int driverID)
        {
            DataTable table = new DataTable();
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"SELECT InternationalLicenseID, ApplicationID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive FROM InternationalLicenses
                WHERE DriverID = @DriverID
				ORDER BY IsActive DESC, IssueDate DESC";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@DriverID", driverID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);

                reader.Close();
            }
            finally
            {
                conn.Close();
            }
            return table;
        }

        public static int GetActiveInternationlLicenseIDByLocalLicenseID(int localLicenseID)
        {
            int internationalLicenseID = -1;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM InternationalLicenses \r\nWHERE IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID\r\n";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", localLicenseID);
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();
                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                    internationalLicenseID = _ParsedResult;
            }
            finally { conn.Close(); }
            return internationalLicenseID;
        }

        public static bool GetActiveInternationlLicenseByLocalLicenseID(int IssuedUsingLocalLicenseID,
            ref int internationalLicenseID, ref int applicationID, ref int driverID,
            ref DateTime issueDate, ref DateTime expirationDate, ref bool isActive, ref int createdByUserID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID AND IsActive = 1 ORDER BY IssueDate DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    internationalLicenseID = (int)reader["InternationalLicenseID"];
                    applicationID = (int)reader["ApplicationID"];
                    driverID = (int)reader["DriverID"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    isActive = (bool)reader["IsActive"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;

        }

        public static int GetActiveInternationalLicenseIDInLicenseClass(int driverID, int licenseClass)
        {
            int internationalLicenseID = -1;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"
                SELECT InternationalLicenses.InternationalLicenseID FROM InternationalLicenses
                INNER JOIN Licenses as L
                ON L.LicenseID = InternationalLicenses.IssuedUsingLocalLicenseID 
                WHERE L.LicenseClass = @LicenseClass AND InternationalLicenses.DriverID = @DriverID
                ORDER BY InternationalLicenses.IssueDate DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseClass", licenseClass);
            cmd.Parameters.AddWithValue("@driverID", driverID);
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();
                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                    internationalLicenseID = _ParsedResult;
            }
            finally { conn.Close(); }
            return internationalLicenseID;
        }
    }
}