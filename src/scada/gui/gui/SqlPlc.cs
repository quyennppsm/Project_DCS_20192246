using System.Data;
using System.Data.SqlClient;

namespace final_ui
{
    class SqlPlc
    {
        SqlCommand _sqlCommand;

        public SqlPlc()
        {
        }

        public bool _update(SqlReport _report, string _table)
        {
            SqlConnection _sqlConnection = SqlConnect._getConnection();
            string _query = "UPDATE " + _table +
                " SET name = @name, status = @status, sigma = @sigma, session = @session, cycle = @cycle" +
                " WHERE id = @id AND name = @name";
            try
            {
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand(_query, _sqlConnection);
                _sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = _report.Id;
                _sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = _report.Name;
                _sqlCommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = _report.Status;
                _sqlCommand.Parameters.Add("@sigma", SqlDbType.NVarChar).Value = _report.Sigma;
                _sqlCommand.Parameters.Add("@session", SqlDbType.NVarChar).Value = _report.Session;
                _sqlCommand.Parameters.Add("@cycle", SqlDbType.NVarChar).Value = _report.Cycle;
                _sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return true;
        }
    }
}
