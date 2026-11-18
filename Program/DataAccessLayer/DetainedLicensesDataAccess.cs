using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DetainedLicensesDataAccess
    {
        public static int AddNew(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int _DetainID = -1;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "INSERT INTO DetainedLicenses(LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID) Values ( @LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID ); SELECT  SCOPE_IDENTITY ( ) ;  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate ?? Convert.DBNull);
            cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID ?? Convert.DBNull);
            cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID ?? Convert.DBNull);
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();
                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                    _DetainID = _ParsedResult;
            }
            finally { conn.Close(); }
            return _DetainID;
        }

        public static DataTable GetAll()
        {
            DataTable table = new DataTable(); SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses_View";
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

        public static bool FindByDetainID(ref int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate, ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@DetainID", DetainID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    DetainID = (int)reader["DetainID"];
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseDate = Convert.IsDBNull(reader["ReleaseDate"]) ? null : (DateTime?)reader["ReleaseDate"];
                    ReleasedByUserID = Convert.IsDBNull(reader["ReleasedByUserID"]) ? null : (int?)reader["ReleasedByUserID"];
                    ReleaseApplicationID = Convert.IsDBNull(reader["ReleaseApplicationID"]) ? null : (int?)reader["ReleaseApplicationID"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;
        }

        public static int DeleteByDetainID(int DetainID)
        {
            int RowsEffected; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "DELETE FROM DetainedLicenses WHERE DetainID = @DetainID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@DetainID", DetainID);
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

        public static bool IsExistsDetainID(int DetainID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@DetainID", DetainID);
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

        public static int Update(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            int RowsEffected; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "UPDATE DetainedLicenses SET LicenseID = @LicenseID, DetainDate = @DetainDate, FineFees = @FineFees, CreatedByUserID = @CreatedByUserID, IsReleased = @IsReleased, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID WHERE DetainID = @DetainID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@DetainID", DetainID);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate ?? Convert.DBNull);
            cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID ?? Convert.DBNull);
            cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID ?? Convert.DBNull);
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

        public static bool isLicenseDetained(int licenseID)
        {
            bool isLicenseDetained = false;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT TOP 1 Found=1 FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0 ORDER BY DetainDate DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", licenseID);
            try
            {
                conn.Open();
                isLicenseDetained = cmd.ExecuteScalar() != null;
            }
            catch
            {
                isLicenseDetained = false;
            }
            finally
            {
                conn.Close();
            }
            return isLicenseDetained;

        }

        public static int GetDetainedLicenseIDByLicenseID(int licenseID)
        {
            int DetainedLicenseID = -1;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT TOP 1 DetainID FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0 ORDER BY DetainDate DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", licenseID);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null) int.TryParse(result.ToString(), out DetainedLicenseID);
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }
            return DetainedLicenseID;
        }
    }
}