using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class UsersDataAccess
    {
        public static int AddNew(int PersonID, string UserName, string Password, bool IsActive)
        {
            int _UserID = -1;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "INSERT INTO Users(PersonID, UserName, Password, IsActive) Values ( @PersonID, @UserName, @Password, @IsActive ); SELECT  SCOPE_IDENTITY ( ) ;  ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                conn.Open();
                object _result = cmd.ExecuteScalar();
                if (_result != null && int.TryParse(_result.ToString(), out int _ParsedResult))
                    _UserID = _ParsedResult;
            }
            finally { conn.Close(); }
            return _UserID;
        }
        public static DataTable GetAll()
        {
            DataTable table = new DataTable(); SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT 'User ID'= UserID, 'Person ID' = PersonID, 'User Name'= UserName, Password, 'Is Active' = IsActive FROM Users\r\n";
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
        public static DataTable GetAllWithFullNameAndWithoutPasswords()
        {
            DataTable table = new DataTable();
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = @"SELECT 'User ID'= UserID, 'Person ID' = Users.PersonID,
            'Full Name' = FirstName + ' ' + SecondName + ' ' +
			CASE 
			When ThirdName is null then ''
			When ThirdName is not null then ThirdName + ' '
			END
			+ LastName,
            'User Name'= UserName, 'Is Active' = IsActive 
            FROM Users INNER JOIN People ON People.PersonID = Users.PersonID
";
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
        public static bool FindByUserID(ref int UserID, ref int PersonID,
            ref string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;
        }
        public static bool FindByPersonID(ref int PersonID, ref int UserID,
            ref string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users WHERE PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;
        }
        public static bool FindByUserNameAndPassword(ref string UserName, ref string Password,
            ref int UserID, ref int PersonID, ref bool IsActive)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                else isFound = false; reader.Close();
            }
            catch { isFound = false; }
            finally { conn.Close(); }
            return isFound;

        }
        public static int DeleteByUserID(int UserID)
        {
            int RowsEffected; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "DELETE FROM Users WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", UserID);
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
        public static bool IsExistsUserID(int UserID)
        {
            bool isFound;
            SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", UserID);
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
        public static int Update(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            int RowsEffected; SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString);
            string query = "UPDATE Users SET PersonID = @PersonID, UserName = @UserName, Password = @Password, IsActive = @IsActive WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
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