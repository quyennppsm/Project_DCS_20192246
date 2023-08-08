using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace final_ui
{
    public partial class ScrLogin : Form
    {
        SqlLog _log;
        public static string _identification;
        SqlModify _modify;

        public ScrLogin()
        {
            InitializeComponent();
        }

        private void scrLogin_Load(object sender, EventArgs e)
        {
            _modify = new SqlModify();

            try
            {
                txtRole.DataSource = _modify._getTable(ScrAdmin._columnAll, ScrAdmin._tableRole);
                txtRole.DisplayMember = ScrAdmin._columnRole;
            }
            catch (Exception _exc)
            {
                MessageBox.Show("Error: " + _exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            string _userAccount;
            string _userPassword;
            string _userRole;

            _userAccount = txtUsername.Text;
            _userPassword = txtPassword.Text;
            _userRole = txtRole.Text;

            try
            {
                string _query = "SELECT * FROM People WHERE account = '"+_userAccount+
                    "' AND password = '" +_userPassword+"' AND role = '"+_userRole+"'";

                DataTable _dataTable = new DataTable();
                SqlDataAdapter _sqlAdapter;

                using (SqlConnection _sqlConnection = SqlConnect._getConnection())
                {
                    _sqlConnection.Open();

                    _sqlAdapter = new SqlDataAdapter(_query, _sqlConnection);
                    _sqlAdapter.Fill(_dataTable);

                    _sqlConnection.Close();

                    if (_dataTable.Rows.Count > 0)
                    {
                        _identification = _dataTable.Rows[0].ItemArray[0].ToString();
                        MessageBox.Show("ID: " + _identification + " login success!");

                        if (_userRole == "admin")
                        {
                            new ScrAdmin().Show();
                            this.Hide();
                        }
                        if (_userRole == "operator")
                        {
                            new ScrOperator().Show();
                            this.Hide();
                        }
                        if (_userRole == "guest")
                        {
                            _modify = new SqlModify();

                            string id = ScrLogin._identification;
                            string date = DateTime.Now.ToLongDateString();
                            string time = DateTime.Now.ToLongTimeString();
                            string status = "online";
                            string role = "guest";

                            _log = new SqlLog(id, date, time, status, role);
                            _modify._timestamp(_log, ScrAdmin._tableLog);

                            ScrAllLog _formReport = new ScrAllLog();
                            _formReport.ShowDialog();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong information!");
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }
            }
            catch(Exception _exc)
            {
                MessageBox.Show("Error: " + _exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttClrF_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
}
