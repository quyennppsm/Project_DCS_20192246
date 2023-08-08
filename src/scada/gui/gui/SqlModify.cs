using System.Data;
using System.Data.SqlClient;

namespace final_ui
{
    class SqlModify
    {
        SqlDataAdapter _sqlAdapter;
        SqlCommand _sqlCommand;

        public SqlModify()
        {
        }

        public DataTable _getTable(string _column, string _table)
        {
            DataTable _dataTable = new DataTable();
            string _query = "SELECT " + _column + " FROM " + _table;

            using (SqlConnection _sqlConnection = SqlConnect._getConnection())
            {
                _sqlConnection.Open();

                _sqlAdapter = new SqlDataAdapter(_query, _sqlConnection);
                _sqlAdapter.Fill(_dataTable);

                _sqlConnection.Close();
            }
            return _dataTable;
        }

        public DataTable _getTimer(string _column, string _table)
        {
            DataTable _dataTable = new DataTable();
            string _query = "SELECT " + _column + " FROM " + _table;

            using (SqlConnection _sqlConnection = SqlConnect._getConnection())
            {
                _sqlConnection.Open();

                _sqlAdapter = new SqlDataAdapter(_query, _sqlConnection);
                _sqlAdapter.Fill(_dataTable);

                _sqlConnection.Close();
            }
            return _dataTable;
        }

        public bool _insert(SqlUser _user, string _table)
        {
            SqlConnection _sqlConnection = SqlConnect._getConnection();
            string _query = "INSERT INTO " + _table + 
                " VALUES (@id, @name, @account, @password, @role)";

            try
            {
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand(_query, _sqlConnection);
                _sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = _user.Id;
                _sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = _user.Name;
                _sqlCommand.Parameters.Add("@account", SqlDbType.NVarChar).Value = _user.Account;
                _sqlCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = _user.Password;
                _sqlCommand.Parameters.Add("@role", SqlDbType.NVarChar).Value = _user.Role;
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

        public bool _timestamp(SqlLog _log, string _table)
        {
            SqlConnection _sqlConnection = SqlConnect._getConnection();
            string _query = "INSERT INTO " + _table +
                " VALUES (@id, @date, @time, @status, @role)";

            try
            {
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand(_query, _sqlConnection);
                _sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = _log.Id;
                _sqlCommand.Parameters.Add("@date", SqlDbType.NVarChar).Value = _log.Date;
                _sqlCommand.Parameters.Add("@time", SqlDbType.NVarChar).Value = _log.Time;
                _sqlCommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = _log.Status;
                _sqlCommand.Parameters.Add("@role", SqlDbType.NVarChar).Value = _log.Role;
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

        public bool _field(SqlReport _report, string _table)
        {
            SqlConnection _sqlConnection = SqlConnect._getConnection();
            string _query = "INSERT INTO " + _table +
                " VALUES (@id, @name, @status, @sigma, @session)";

            try
            {
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand(_query, _sqlConnection);
                _sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = _report.Id;
                _sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = _report.Name;
                _sqlCommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = _report.Status;
                _sqlCommand.Parameters.Add("@sigma", SqlDbType.NVarChar).Value = _report.Sigma;
                _sqlCommand.Parameters.Add("@session", SqlDbType.NVarChar).Value = _report.Session;
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

        public bool _cpu(SqlReport _report, string _table)
        {
            SqlConnection _sqlConnection = SqlConnect._getConnection();
            //string _query = "INSERT INTO " + _table +
            //    " VALUES (@id, @name, @status, @sigma, @session)";
            string _query = "UPDATE " + _table +
                " SET status = @status, sigma = @sigma, session = @session" +
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

        public bool _change(SqlUser _user, string _table)
        {
            SqlConnection _sqlConnection = SqlConnect._getConnection();
            string _query = "UPDATE " + _table + 
                " SET name = @name, account = @account, password = @password, role = @role WHERE id = @id";

            try
            {
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand(_query, _sqlConnection);
                _sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = _user.Id;
                _sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = _user.Name;
                _sqlCommand.Parameters.Add("@account", SqlDbType.NVarChar).Value = _user.Account;
                _sqlCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = _user.Password;
                _sqlCommand.Parameters.Add("@role", SqlDbType.NVarChar).Value = _user.Role;
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

        public bool _plc(SqlReport _report, string _table)
        {
            SqlConnection _sqlConnection = SqlConnect._getConnection();
            string _query = "UPDATE " + _table +
                " SET status = @status, sigma = @sigma, session = @session," + 
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

        public bool _delete(string _id, string _table)
        {
            SqlConnection _sqlConnection = SqlConnect._getConnection();
            string _query = "DELETE " + _table +
                " WHERE id = @id";

            try
            {
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand(_query, _sqlConnection);
                _sqlCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = _id;
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

        public DataTable _read(string _query)
        {
            DataTable _read = new DataTable();

            using (SqlConnection _sqlConnection = SqlConnect._getConnection())
            {
                _sqlConnection.Open();

                _sqlAdapter = new SqlDataAdapter(_query, _sqlConnection);
                _sqlAdapter.Fill(_read);

                _sqlConnection.Close();
            }
            return _read;
        }
    }
}
