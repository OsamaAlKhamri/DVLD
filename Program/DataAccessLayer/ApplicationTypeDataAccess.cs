using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ApplicationTypeDataAccess
    {
        public static int AddNew(string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int _ApplicationTypeID = -1;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "INSERT INTO ApplicationTypes(ApplicationTypeTitle, ApplicationFees) Values ( @ApplicationTypeTitle, @ApplicationFees ); SELECT  SCOPE_IDENTITY ( ) ;  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();
                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                    _ApplicationTypeID = _ParsedResult;
            }
            finally { conn.Close(); }
            return _ApplicationTypeID;
        }

        public static DataTable GetAll()
        {
            DataTable table = new DataTable(); SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ApplicationTypes";
            SqlCommand cmd = new SqlCommand(query, conn);
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

        public static bool FindByApplicationTypeID(int ApplicationTypeID,
            ref string ApplicationTypeTitle, ref decimal ApplicationFees)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;
        }

        public static int Update(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int RowsEffected; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "UPDATE ApplicationTypes SET ApplicationTypeTitle = @ApplicationTypeTitle, ApplicationFees = @ApplicationFees WHERE ApplicationTypeID = @ApplicationTypeID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
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
    }
}