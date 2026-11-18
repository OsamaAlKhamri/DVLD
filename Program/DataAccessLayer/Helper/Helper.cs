using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsHelper
    {
        static public DataTable GetColumns(string tableName)
        {
            DataTable columnsTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                string query = "SELECT name='All' UNION ALL SELECT name FROM sys.columns WHERE object_id = OBJECT_ID(@tableName);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tableName", tableName);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        columnsTable.Load(reader);
                    }
                    reader.Close();
                }
                finally
                {
                    conn.Close();
                }

                return columnsTable;
            }

        }
    }
}
