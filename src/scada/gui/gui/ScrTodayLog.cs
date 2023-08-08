using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace final_ui
{
    public partial class ScrTodayLog : Form
    {
        SqlModify _modify;

        public ScrTodayLog()
        {
            InitializeComponent();
        }

        private void scrWRP_Load(object sender, EventArgs e)
        {
            _modify = new SqlModify();

            string _date = DateTime.Now.ToLongDateString();

            try
            {
                string _query = "SELECT * FROM Log WHERE Date = '" + _date + "'";
                rptLog.LocalReport.ReportPath = "itmReport.rdlc";
                //rptLog.LocalReport.ReportEmbeddedResource = "final-ui.itmReport.rdlc";
                ReportDataSource _reportDataSource = new ReportDataSource
                {
                    Name = "Log",
                    Value = _modify._read(_query)
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
            Application.Exit();
        }

        private void bttSignout_Click(object sender, EventArgs e)
        {
            new ScrLogin().Show();
            this.Close();
        }
    }
}
