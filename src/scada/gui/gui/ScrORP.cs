using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace final_ui
{
    public partial class ScrORP : Form
    {
        SqlModify _modify;

        public ScrORP()
        {
            InitializeComponent();
        }

        private void scrGuest_Load(object sender, EventArgs e)
        {
            _modify = new SqlModify();

            try
            {
                rptLog.LocalReport.ReportPath = "itmORP.rdlc";
                //rptLog.LocalReport.ReportEmbeddedResource = "final-ui.itmReport.rdlc";
                ReportDataSource _reportDataSource = new ReportDataSource
                {
                    Name = "Report",
                    Value = _modify._getTable(ScrAdmin._columnAll, ScrAdmin._tableReport)
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
