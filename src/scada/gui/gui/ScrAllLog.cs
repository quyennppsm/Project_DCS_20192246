using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace final_ui
{
    public partial class ScrAllLog : Form
    {
        SqlModify _modify;
        SqlLog _report;

        public ScrAllLog()
        {
            InitializeComponent();
        }

        private void scrGuest_Load(object sender, EventArgs e)
        {
            _modify = new SqlModify();

            try
            {
                rptLog.LocalReport.ReportPath = "itmReport.rdlc";
                //rptLog.LocalReport.ReportEmbeddedResource = "final-ui.itmReport.rdlc";
                ReportDataSource _reportDataSource = new ReportDataSource
                {
                    Name = "Log",
                    Value = _modify._getTable(ScrAdmin._columnAll, ScrAdmin._tableLog)
                };
                rptLog.LocalReport.DataSources.Add(_reportDataSource);

                this.rptLog.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            _modify = new SqlModify();

            string id = ScrLogin._identification;
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            string status = "offline";
            string role = "guest";

            _report = new SqlLog(id, date, time, status, role);
            _modify._timestamp(_report, ScrAdmin._tableLog);

            Application.Exit();
        }

        private void bttSignout_Click(object sender, EventArgs e)
        {
            _modify = new SqlModify();

            string id = ScrLogin._identification;
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            string status = "offline";
            string role = "guest";

            _report = new SqlLog(id, date, time, status, role);
            _modify._timestamp(_report, ScrAdmin._tableLog);

            new ScrLogin().Show();
            this.Close();
        }
    }
}
