using System;
using System.Windows.Forms;

namespace final_ui
{
    public partial class ScrAdmin : Form
    {
        public static string _tableReport = "Report";
        public static string _tableLog = "Log";
        public static string _tablePeople = "People";
        public static string _tableRole = "staticRole";
        public static string _columnAll = "*";
        public static string _columnRole = "role";
        SqlModify _modify;
        SqlUser _user;
        SqlLog _log;

        public ScrAdmin()
        {
            InitializeComponent();
        }

        private void scrAdmin_Load(object sender, EventArgs e)
        {
            _modify = new SqlModify();

            string id = ScrLogin._identification;
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            string status = "online";
            string role = "admin";

            _log = new SqlLog(id, date, time, status, role);
            _modify._timestamp(_log, _tableLog);

            try
            {
                dbvUser.DataSource = _modify._getTable(_columnAll, _tablePeople);

                txtRole.DataSource = _modify._getTable(_columnAll, _tableRole);
                txtRole.DisplayMember = _columnRole;
            }
            catch(Exception _exc)
            {
                MessageBox.Show("Error: " + _exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string id = this.txtId.Text;
            string name = this.txtName.Text;
            string account = this.txtAccount.Text;
            string password = this.txtPassword.Text;
            string role = this.txtRole.Text;

            _user = new SqlUser(id, name, account, password, role);

            if (_modify._insert(_user, _tablePeople))
            {
                dbvUser.DataSource = _modify._getTable(_columnAll, _tablePeople);
            }
            else
            {
                MessageBox.Show("Error: " + "Can't insert!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string id = this.txtId.Text;
            string name = this.txtName.Text;
            string account = this.txtAccount.Text;
            string password = this.txtPassword.Text;
            string role = this.txtRole.Text;

            _user = new SqlUser(id, name, account, password, role);

            if (_modify._change(_user, _tablePeople))
            {
                dbvUser.DataSource = _modify._getTable(_columnAll, _tablePeople);
            }
            else
            {
                MessageBox.Show("Error: " + "Can't change!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string _id = dbvUser.SelectedRows[0].Cells[0].Value.ToString();

            if (_modify._delete(_id, _tablePeople))
            {
                dbvUser.DataSource = _modify._getTable(_columnAll, _tablePeople);
            }
            else
            {
                MessageBox.Show("Error: " + "Can't delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            string id = ScrLogin._identification;
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            string status = "offline";
            string role = "admin";

            _log = new SqlLog(id, date, time, status, role);
            _modify._timestamp(_log, _tableLog);

            Application.Exit();
        }

        private void bttClrF_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtAccount.Clear();
            txtPassword.Clear();
            txtId.Focus();
        }

        private void btnVRP_Click(object sender, EventArgs e)
        {
            ScrAllLog _formReport = new ScrAllLog();
            _formReport.ShowDialog();
        }

        private void bttSignout_Click(object sender, EventArgs e)
        {
            string id = ScrLogin._identification;
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            string status = "offline";
            string role = "admin";

            _log = new SqlLog(id, date, time, status, role);
            _modify._timestamp(_log, _tableLog);

            new ScrLogin().Show();
            this.Close();
        }

        private void btnWRP_Click(object sender, EventArgs e)
        {
            ScrTodayLog _formReport = new ScrTodayLog();
            _formReport.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScrORP _formReport = new ScrORP();
            _formReport.ShowDialog();
        }
    }
}
