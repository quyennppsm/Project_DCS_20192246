using System.Data.SqlClient;

namespace final_ui
{
    class SqlConnect
    {
        private static string _stringConnection = @"Data Source=IMPERIA\SQLEXPRESS;Initial Catalog=Account;Integrated Security=True";
        public static SqlConnection _getConnection()
        {
            return new SqlConnection(_stringConnection);
        }
    }
}