using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using S7.Net;

namespace final_ui
{
    public partial class ScrOperator : Form
    {
        // Register S7-1200
        public static Plc _S71200 = new Plc(CpuType.S71200, "192.168.0.17", 0, 1);
        objCtrl _Object = new objCtrl();
        SqlReport _report;
        SqlModify _modify;
        SqlLog _log;
        SqlPlc _sqlPlc = new SqlPlc();

        // Counters
        public static bool _counter;
        public static string _SRice;
        public static string _SMalt;
        public static string _SFilter;
        public static string _SHops;
        public static string _SSettling;
        public static string _SCaustic;
        public static string _SAcid;
        public static string _SWater;
        public static string _SRinse;
        public static double _ZRice;
        public static double _ZMalt;
        public static double _ZFilter;
        public static double _ZHops;
        public static double _ZSettling;
        public static double _ZCaustic;
        public static double _ZAcid;
        public static double _ZWater;
        public static double _ZRinse;
        public static double _TRice = 0;
        public static double _TMalt = 0;
        public static double _TFilter = 0;
        public static double _THops = 0;
        public static double _TSettling = 0;
        public static double _TCaustic = 0;
        public static double _TAcid = 0;
        public static double _TWater = 0;
        public static double _TRinse = 0;
        public static double _CCaustic;
        public static double _CAcid;

        // Buttons
        public static bool _Run = false;
        public static bool _Start = false;
        public static bool _Mode = false;
        public static bool[] _Step = new bool[] { false, false, false, false, false, false, false };
        public static bool _Rice = false;
        public static bool _Malt = false;
        public static bool _Filter = false;
        public static bool _Hops = false;
        public static bool _Settling = false;
        public static bool _Clean_Rice = false;
        public static bool _Clean_Malt = false;
        public static bool _Clean_Filter = false;
        public static bool _Clean_Hops = false;
        public static bool _Clean_Settling = false;

        // Status
        public static bool _Online;
        public static bool _Offline;
        public static bool _Idle;
        public static bool _Busy;
        public static bool _Manual;
        public static bool _Automatic;

        // Sensors
        public static bool _SHCaustic;
        public static bool _SLCaustic;
        public static bool _SHAcid;
        public static bool _SLAcid;
        public static bool _SHWater;
        public static bool _SLWater;
        public static bool _SHRinse;
        public static bool _SLRinse;

        // Valves
        public static bool _VCSCaustic;
        public static bool _VCSAcid;
        public static bool _VCSWater;
        public static bool _VCSRinse;

        public static bool _VSCaustic;
        public static bool _VSAcid;
        public static bool _VSWater;

        public static bool _VCRCaustic;
        public static bool _VCRAcid;
        public static bool _VCRWater;
        public static bool _VCRRinse;
        public static bool _VCRDrain;

        // Pumps
        public static bool _PCS;
        public static bool _PCR;
        public static bool _PSCaustic;
        public static bool _PSAcid;
        public static bool _PSWater;

        // Pipes
        public static bool _p1;
        public static bool _p2;
        public static bool _p3;
        public static bool _p4;
        public static bool _p5;
        public static bool _p6;
        public static bool _p7;
        public static bool _p8;
        public static bool _p9;
        public static bool _p10;
        public static bool _p11;
        public static bool _p12;

        public static bool _p13;
        public static bool _p14;
        public static bool _p15;
        public static bool _p16;
        public static bool _p17;
        public static bool _p18;
        public static bool _p19;
        public static bool _p20;
        public static bool _p21;
        public static bool _p22;
        public static bool _p23;
        public static bool _p24;
        public static bool _p25;
        public static bool _p26;
        public static bool _p27;
        public static bool _p28;
        public static bool _p29;
        public static bool _p30;
        public static bool _p31;
        public static bool _p32;
        public static bool _p33;
        public static bool _p34;
        public static bool _p35;

        public static bool _ps1;
        public static bool _ps2;
        public static bool _ps3;
        public static bool _ps4;
        public static bool _ps5;
        public static bool _ps6;
        public static bool _ps7;
        public static bool _ps8;
        public static bool _ps9;
        public static bool _ps10;
        public static bool _ps11;
        public static bool _ps12;
        public static bool _ps13;
        public static bool _ps14;
        public static bool _ps15;
        public static bool _ps16;
        public static bool _ps17;
        public static bool _ps18;
        public static bool _ps19;

        // Current Tank
        public static bool _SHCurrent;
        public static bool _SLCurrent;
        public static bool _VSCurrent;
        public static bool _VRCurrent;
        public static bool _Motor;
        public static bool _pcs1;
        public static bool _pcs2;
        public static bool _pcr1;
        public static bool _pcr2;

        public ScrOperator()
        {
            InitializeComponent();
        }

        private void scrOperator_Load(object sender, EventArgs e)
        {
            _modify = new SqlModify();
            _log = new SqlLog();

            string id = ScrLogin._identification;
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            string status = "online";
            string role = "operator";

            _log = new SqlLog(id, date, time, status, role);
            _modify._timestamp(_log, ScrAdmin._tableLog);

            _modify = new SqlModify();
            DataTable _dbReport = new DataTable();
            _dbReport = _modify._getTable(ScrAdmin._columnAll, ScrAdmin._tableReport);

            _ZRice = Convert.ToDouble(_dbReport.Rows[0].ItemArray[3]);
            _ZMalt = Convert.ToDouble(_dbReport.Rows[1].ItemArray[3]);
            _ZFilter = Convert.ToDouble(_dbReport.Rows[2].ItemArray[3]);
            _ZHops = Convert.ToDouble(_dbReport.Rows[3].ItemArray[3]);
            _ZSettling = Convert.ToDouble(_dbReport.Rows[4].ItemArray[3]);
            _ZCaustic = Convert.ToDouble(_dbReport.Rows[5].ItemArray[3]);
            _ZAcid = Convert.ToDouble(_dbReport.Rows[6].ItemArray[3]);
            _ZWater = Convert.ToDouble(_dbReport.Rows[7].ItemArray[3]);
            _ZRinse = Convert.ToDouble(_dbReport.Rows[8].ItemArray[3]);

            _CCaustic = Convert.ToDouble(_dbReport.Rows[5].ItemArray[5]);
            _CAcid = Convert.ToDouble(_dbReport.Rows[6].ItemArray[5]);

            _SRice = Convert.ToString(_dbReport.Rows[0].ItemArray[2]);
            _SMalt = Convert.ToString(_dbReport.Rows[1].ItemArray[2]);
            _SFilter = Convert.ToString(_dbReport.Rows[2].ItemArray[2]);
            _SHops = Convert.ToString(_dbReport.Rows[3].ItemArray[2]);
            _SSettling = Convert.ToString(_dbReport.Rows[4].ItemArray[2]);

            _S71200.Open();
            if (_S71200.IsConnected)
            {
                updatePLC.Enabled = true;
                updatePLC.Interval = 50;
                updateOBJ.Enabled = true;
                updateOBJ.Interval = 50;
                updateCounter.Enabled = true;
                updateCounter.Interval = 10;
                lblConnection.Text = "Connected";
                lblConnection.ForeColor = Color.Green;
            }
            else
            {
                lblConnection.Text = "No Connection!";
                lblConnection.ForeColor = Color.Red;
            }
            
            // Labels
            lblOnline.Text = "Online";
            lblOffline.Text = "Offline";
            lblIdle.Text = "Idle";
            lblBusy.Text = "Busy";
            lblManual.Text = "Manual";
            lblAutomatic.Text = "Automatic";
            
        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            _log = new SqlLog();
            _modify = new SqlModify();

            string id = ScrLogin._identification;
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            string status = "offline";
            string role = "operator";

            _log = new SqlLog(id, date, time, status, role);
            _modify._timestamp(_log, ScrAdmin._tableLog);

            Application.Exit();
        }

        private void bttSignout_Click(object sender, EventArgs e)
        {
            _log = new SqlLog();
            _modify = new SqlModify();

            string id = ScrLogin._identification;
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            string status = "offline";
            string role = "operator";

            _log = new SqlLog(id, date, time, status, role);
            _modify._timestamp(_log, ScrAdmin._tableLog);

            new ScrLogin().Show();
            this.Close();
        }

        private void updatePLC_Tick(object sender, EventArgs e)
        {
            _modify = new SqlModify();
            _report = new SqlReport();

            _counter = (bool)_S71200.Read("DB1.DBX12.1");

            // Read Button
            _Run = (bool)_S71200.Read("DB1.DBX0.0");
            _Start = (bool)_S71200.Read("DB1.DBX0.1");
            _Mode = (bool)_S71200.Read("DB1.DBX0.2");

            _Rice = (bool)_S71200.Read("DB1.DBX2.0");
            _Malt = (bool)_S71200.Read("DB1.DBX2.1");
            _Filter = (bool)_S71200.Read("DB1.DBX2.2");
            _Hops = (bool)_S71200.Read("DB1.DBX2.3");
            _Settling = (bool)_S71200.Read("DB1.DBX2.4");

            // Read Status
            _Online = (bool)_S71200.Read("DB1.DBX4.0");
            _Offline = (bool)_S71200.Read("DB1.DBX4.1");
            _Idle = (bool)_S71200.Read("DB1.DBX4.2");
            _Busy = (bool)_S71200.Read("DB1.DBX4.3");

            _Manual = (bool)_S71200.Read("DB1.DBX6.0");
            _Automatic = (bool)_S71200.Read("DB1.DBX6.1");

            _Step[0] = (bool)_S71200.Read("DB1.DBX8.0");
            _Step[1] = (bool)_S71200.Read("DB1.DBX8.1");
            _Step[2] = (bool)_S71200.Read("DB1.DBX8.2");
            _Step[3] = (bool)_S71200.Read("DB1.DBX8.3");
            _Step[4] = (bool)_S71200.Read("DB1.DBX8.4");
            _Step[5] = (bool)_S71200.Read("DB1.DBX8.5");
            _Step[6] = (bool)_S71200.Read("DB1.DBX8.6");

            _Clean_Rice = (bool)_S71200.Read("DB1.DBX10.0");
            _Clean_Malt = (bool)_S71200.Read("DB1.DBX10.1");
            _Clean_Filter = (bool)_S71200.Read("DB1.DBX10.2");
            _Clean_Hops = (bool)_S71200.Read("DB1.DBX10.3");
            _Clean_Settling = (bool)_S71200.Read("DB1.DBX10.4");

            // Read Sensors
            _SHCaustic = (bool)_S71200.Read("DB2.DBX2.0");
            _SLCaustic = (bool)_S71200.Read("DB2.DBX2.1");
            _SHAcid = (bool)_S71200.Read("DB2.DBX10.0");
            _SLAcid = (bool)_S71200.Read("DB2.DBX10.1");
            _SHWater = (bool)_S71200.Read("DB2.DBX18.0");
            _SLWater = (bool)_S71200.Read("DB2.DBX18.1");
            _SHRinse = (bool)_S71200.Read("DB2.DBX26.0");
            _SLRinse = (bool)_S71200.Read("DB2.DBX26.1");

            //Current
            _SHCurrent = (bool)_S71200.Read("DB2.DBX74.0");
            _SLCurrent = (bool)_S71200.Read("DB2.DBX74.1");
            _VRCurrent = (bool)_S71200.Read("DB2.DBX76.0");
            _VSCurrent = (bool)_S71200.Read("DB2.DBX76.1");
            _Motor = (bool)_S71200.Read("DB2.DBX78.0");

            // Read Valves
            _VCSCaustic = (bool)_S71200.Read("DB3.DBX2.0");
            _VCSAcid = (bool)_S71200.Read("DB3.DBX2.1");
            _VCSWater = (bool)_S71200.Read("DB3.DBX2.2");
            _VCSRinse = (bool)_S71200.Read("DB3.DBX2.3");

            _VCRCaustic = (bool)_S71200.Read("DB3.DBX6.0");
            _VCRAcid = (bool)_S71200.Read("DB3.DBX6.1");
            _VCRWater = (bool)_S71200.Read("DB3.DBX6.2");
            _VCRRinse = (bool)_S71200.Read("DB3.DBX6.3");
            _VCRDrain = (bool)_S71200.Read("DB3.DBX6.4");

            _VSCaustic = (bool)_S71200.Read("DB2.DBX4.1");
            _VSAcid = (bool)_S71200.Read("DB2.DBX12.1");
            _VSWater = (bool)_S71200.Read("DB2.DBX20.1");

            // Read Objects
            _PCS = (bool)_S71200.Read("DB3.DBX0.0");
            _PCR = (bool)_S71200.Read("DB3.DBX4.0");

            _PSCaustic = (bool)_S71200.Read("DB2.DBX6.1");
            _PSAcid = (bool)_S71200.Read("DB2.DBX14.1");
            _PSWater = (bool)_S71200.Read("DB2.DBX22.1");
            

            // Status Colors
            if (_Online)
            {
                lblOnline.ForeColor = Color.Green;
            }
            else
            {
                lblOnline.ForeColor = Color.Gray;
            }
            if (_Offline)
            {
                lblOffline.ForeColor = Color.Red;
            }
            else
            {
                lblOffline.ForeColor = Color.Gray;
            }
            if (_Idle)
            {
                lblIdle.ForeColor = Color.Green;
            }
            else
            {
                lblIdle.ForeColor = Color.Gray;
            }
            if (_Busy)
            {
                lblBusy.ForeColor = Color.Red;
            }
            else
            {
                lblBusy.ForeColor = Color.Gray;
            }
            if (_Manual)
            {
                lblManual.ForeColor = Color.Green;
            }
            else
            {
                lblManual.ForeColor = Color.Gray;
            }
            if (_Automatic)
            {
                lblAutomatic.ForeColor = Color.Green;
            }
            else
            {
                lblAutomatic.ForeColor = Color.Gray;
            }

            if (_Rice || _Clean_Rice)
            {
                lblCRice.Text = "Current";
            }
            else
            {
                lblCRice.Text = "0";
            }
            if (_Clean_Rice & _Busy)
            {
                lblCRice.ForeColor = Color.Green;  
            }
            else
            {
                lblCRice.ForeColor = Color.Red;
            }
            if (_Malt || _Clean_Malt)
            {
                lblCMalt.Text = "Current";
            }
            else
            {
                lblCMalt.Text = "0";
            }
            if (_Clean_Malt & _Busy)
            {
                lblCMalt.ForeColor = Color.Green;
            }
            else
            {
                lblCMalt.ForeColor = Color.Red;
            }
            if (_Filter || _Clean_Filter)
            {
                lblCFilter.Text = "Current";
            }
            else
            {
                lblCFilter.Text = "0";
            }
            if (_Clean_Filter & _Busy)
            {
                lblCFilter.ForeColor = Color.Green;
            }
            else
            {
                lblCFilter.ForeColor = Color.Red;
            }
            if (_Hops || _Clean_Hops)
            {
                lblCHops.Text = "Current";
            }
            else
            {
                lblCHops.Text = "0";
            }
            if (_Clean_Hops & _Busy)
            {
                lblCHops.ForeColor = Color.Green;
            }
            else
            {
                lblCHops.ForeColor = Color.Red;
            }
            if (_Settling || _Clean_Settling)
            {
                lblCSettling.Text = "Current";
            }
            else
            {
                lblCSettling.Text = "0";
            }
            if (_Clean_Settling & _Busy)
            {
                lblCSettling.ForeColor = Color.Green;
            }
            else
            {
                lblCSettling.ForeColor = Color.Red;
            }
        }

        private void updateOBJ_Tick(object sender, EventArgs e)
        {
            _p1 = _VCSCaustic;
            _p2 = _VCSCaustic;
            _p3 = _VCSCaustic;
            _p4 = _VCSAcid;
            _p5 = _VCSAcid;
            _p6 = _VCSAcid || _VCSCaustic;
            _p7 = _VCSWater;
            _p8 = _VCSWater;
            _p9 = _VCSWater || _VCSAcid || _VCSCaustic;
            _p10 = _VCSRinse;
            _p11 = _VCSRinse;
            _p12 = _VCSRinse || _VCSWater || _VCSAcid || _VCSCaustic;

            _p13 = _VCRRinse || _VCRAcid || _VCRCaustic || _VCRDrain;
            _p14 = _VCRAcid || _VCRCaustic || _VCRDrain;
            _p15 = _VCRAcid || _VCRCaustic || _VCRDrain;
            _p16 = _VCRCaustic || _VCRDrain;
            _p17 = _VCRRinse;
            _p18 = _VCRRinse;
            _p21 = _VCRAcid;
            _p22 = _VCRAcid;
            _p23 = _VCRCaustic;
            _p24 = _VCRCaustic;
            _p25 = _VCRCaustic || _VCRDrain;
            _p26 = _VCRDrain;
            _p27 = _VCRDrain;
            _p28 = _VCRDrain;
            _p29 = _VCRDrain;
            _p30 = _VCRDrain;
            _p31 = _VCRDrain;
            _p32 = _VCRDrain;
            _p33 = _VCRDrain;
            _p34 = _VCRDrain;
            _p35 = _VCRDrain;


            _Object._Ctrl(objTCaustic, _SLCaustic, !_SLCaustic & !_SHCaustic, _SHCaustic);
            _Object._Ctrl(objTAcid, _SLAcid, !_SLAcid & !_SHAcid, _SHAcid);
            _Object._Ctrl(objTWater, _SLWater, !_SLWater & !_SHWater, _SHWater);
            _Object._Ctrl(objTRinse, _SLRinse, !_SLRinse & !_SHRinse, _SHRinse);

            // Supply
            _Object._Ctrl(objPCS, !_PCS, _PCS, false);

            _Object._Ctrl(objVCSCaustic, !_VCSCaustic, _VCSCaustic, false);
            _Object._Ctrl(objP1, !_p1, _p1, false);
            _Object._Ctrl(objP2, !_p2, _p2, false);
            _Object._Ctrl(objP3, !_p3, _p3, false);

            _Object._Ctrl(objVCSAcid, !_VCSAcid, _VCSAcid, false);
            _Object._Ctrl(objP4, !_p4, _p4, false);
            _Object._Ctrl(objP5, !_p5, _p5, false);
            _Object._Ctrl(objP6, !_p6, _p6, false);

            _Object._Ctrl(objVCSWater, !_VCSWater, _VCSWater, false);
            _Object._Ctrl(objP7, !_p7, _p7, false);
            _Object._Ctrl(objP8, !_p8, _p8, false);
            _Object._Ctrl(objP9, !_p9, _p9, false);

            _Object._Ctrl(objVCSRinse, !_VCSRinse, _VCSRinse, false);
            _Object._Ctrl(objP10, !_p10, _p10, false);
            _Object._Ctrl(objP11, !_p11, _p11, false);
            _Object._Ctrl(objP12, !_p12, _p12, false);

            // Sources
            _Object._Ctrl(objSCaustic, !_VSCaustic, _VSCaustic, false);
            _Object._Ctrl(objVSCaustic, !_VSCaustic, _VSCaustic, false);
            _Object._Ctrl(objPSCaustic, !_VSCaustic, _VSCaustic, false);
            _Object._Ctrl(objPS1, !_PSCaustic, _PSCaustic, false);
            _Object._Ctrl(objPS2, !_PSCaustic, _PSCaustic, false);
            _Object._Ctrl(objPS3, !_PSCaustic, _PSCaustic, false);
            _Object._Ctrl(objPS4, !_PSCaustic, _PSCaustic, false);
            _Object._Ctrl(objPS5, !_PSCaustic, _PSCaustic, false);

            _Object._Ctrl(objSAcid, !_VSAcid, _VSAcid, false);
            _Object._Ctrl(objVSAcid, !_VSAcid, _VSAcid, false);
            _Object._Ctrl(objPSAcid, !_VSAcid, _VSAcid, false);
            _Object._Ctrl(objPS6, !_PSAcid, _PSAcid, false);
            _Object._Ctrl(objPS7, !_PSAcid, _PSAcid, false);
            _Object._Ctrl(objPS8, !_PSAcid, _PSAcid, false);
            _Object._Ctrl(objPS9, !_PSAcid, _PSAcid, false);
            _Object._Ctrl(objPS10, !_PSAcid, _PSAcid, false);
            _Object._Ctrl(objPS11, !_PSAcid, _PSAcid, false);
            _Object._Ctrl(objPS12, !_PSAcid, _PSAcid, false);
            _Object._Ctrl(objPS13, !_PSAcid, _PSAcid, false);

            _Object._Ctrl(objVSWater, !_VSWater, _VSWater, false);
            _Object._Ctrl(objPSWater, !_VSWater, _VSWater, false);
            _Object._Ctrl(objPS14, !_PSWater, _PSWater, false);
            _Object._Ctrl(objPS15, !_PSWater, _PSWater, false);
            _Object._Ctrl(objPS16, !_PSWater, _PSWater, false);
            _Object._Ctrl(objPS17, !_PSWater, _PSWater, false);
            _Object._Ctrl(objPS18, !_PSWater, _PSWater, false);
            _Object._Ctrl(objPS19, !_PSWater, _PSWater, false);

            // Recovery
            _Object._Ctrl(objPCR, !_PCR, _PCR, false);

            _Object._Ctrl(objVCRRinse, !_VCRRinse, _VCRRinse, false);

            _Object._Ctrl(objVCRWater, !_VCRWater, _VCRWater, false);

            _Object._Ctrl(objVCRAcid, !_VCRAcid, _VCRAcid, false);

            _Object._Ctrl(objVCRCaustic, !_VCRCaustic, _VCRCaustic, false);

            _Object._Ctrl(objVCRDrain, !_VCRDrain, _VCRDrain, false);

            _Object._Ctrl(objP13, !_p13, _p13, false);
            _Object._Ctrl(objP14, !_p14, _p14, false);
            _Object._Ctrl(objP15, !_p15, _p15, false);
            _Object._Ctrl(objP16, !_p16, _p16, false);
            _Object._Ctrl(objP17, !_p17, _p17, false);
            _Object._Ctrl(objP18, !_p18, _p18, false);
            _Object._Ctrl(objP19, !_p19, _p19, false);
            _Object._Ctrl(objP20, !_p20, _p20, false);
            _Object._Ctrl(objP21, !_p21, _p21, false);
            _Object._Ctrl(objP22, !_p22, _p22, false);
            _Object._Ctrl(objP23, !_p23, _p23, false);
            _Object._Ctrl(objP24, !_p24, _p24, false);
            _Object._Ctrl(objP25, !_p25, _p25, false);
            _Object._Ctrl(objP26, !_p26, _p26, false);
            _Object._Ctrl(objP27, !_p27, _p27, false);
            _Object._Ctrl(objP28, !_p28, _p28, false);
            _Object._Ctrl(objP29, !_p29, _p29, false);
            _Object._Ctrl(objP30, !_p30, _p30, false);
            _Object._Ctrl(objP31, !_p31, _p31, false);
            _Object._Ctrl(objP32, !_p32, _p32, false);
            _Object._Ctrl(objP33, !_p33, _p33, false);
            _Object._Ctrl(objP34, !_p34, _p34, false);
            _Object._Ctrl(objP35, !_p35, _p35, false);

            // Current Tank
            _pcs1 = _VSCurrent;
            _pcs2 = _VSCurrent;
            _pcr1 = _VRCurrent;
            _pcr2 = _VRCurrent;

            _Object._Ctrl(objTCurrent, _SLCurrent, !_SLCurrent & !_SHCurrent, _SHCurrent);
            _Object._Ctrl(objMotor, !_Motor, _Motor, false);
            _Object._Ctrl(objVSCurrent, !_VSCurrent, _VSCurrent, false);
            _Object._Ctrl(objVRCurrent, !_VRCurrent, _VRCurrent, false);

            _Object._Ctrl(objPCS1, !_pcs1, _pcs1, false);
            _Object._Ctrl(objPCS2, !_pcs2, _pcs2, false);
            _Object._Ctrl(objPCR1, !_pcr1, _pcr1, false);
            _Object._Ctrl(objPCR2, !_pcr2, _pcr2, false);

            lblCurrent.Text = "";
            lblSup.Text = "CIP S";
            lblRec.Text = "CIP R";
            lblStep.Text = "Step";
            if (_Clean_Rice)
            {
                lblCurrent.Text = "Rice";
                lblSup.Text = "Rice S";
                lblRec.Text = "Rice R";
            }
            if (_Clean_Malt)
            {
                lblCurrent.Text = "Malt";
                lblSup.Text = "Malt S";
                lblRec.Text = "Malt R";
            }
            if (_Clean_Filter)
            {
                lblCurrent.Text = "Filter";
                lblSup.Text = "Filter S";
                lblRec.Text = "Filter R";
            }
            if (_Clean_Hops)
            {
                lblCurrent.Text = "Hops";
                lblSup.Text = "Hops S";
                lblRec.Text = "Hops R";
            }
            if (_Clean_Settling)
            {
                lblCurrent.Text = "Settling";
                lblSup.Text = "Settling S";
                lblRec.Text = "Settling R";
            }
            if (_Step[0])
            {
                lblStep.Text = "Step 1";
            }
            if (_Step[1])
            {
                lblStep.Text = "Step 2";
            }
            if (_Step[2])
            {
                lblStep.Text = "Step 3";
            }
            if (_Step[3])
            {
                lblStep.Text = "Step 4";
            }
            if (_Step[4])
            {
                lblStep.Text = "Step 5";
            }
            if (_Step[5])
            {
                lblStep.Text = "Step 6";
            }
            if (_Step[6])
            {
                lblStep.Text = "Step 7";
            }
        }

        private void bttRun_Click(object sender, EventArgs e)
        {
            _S71200.Write("DB1.DBX0.0", !_Run);
        }

        private void bttStart_Click(object sender, EventArgs e)
        {
            if (_Idle)
            {
                _S71200.Write("DB1.DBX0.1", !_Start);
            }
        }

        private void bttMode_Click(object sender, EventArgs e)
        {
            if (_Idle)
            {
                _S71200.Write("DB1.DBX0.2", !_Mode);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_Idle)
            {
                _S71200.Write("DB1.DBX2.0", !_Rice);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_Idle)
            {
                _S71200.Write("DB1.DBX2.1", !_Malt);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_Idle)
            {
                _S71200.Write("DB1.DBX2.2", !_Filter);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_Idle)
            {
                _S71200.Write("DB1.DBX2.3", !_Hops);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_Idle)
            {
                _S71200.Write("DB1.DBX2.4", !_Settling);
            }
        }

        private void btnVRP_Click(object sender, EventArgs e)
        {
            ScrORP _formReport = new ScrORP();
            _formReport.ShowDialog();
        }

        private void updateCounter_Tick(object sender, EventArgs e)
        {
            bool _counterRice = (bool)_S71200.Read("DB37.DBX0.0");
            bool _counterMalt = (bool)_S71200.Read("DB37.DBX0.1");
            bool _counterFilter = (bool)_S71200.Read("DB37.DBX0.2");
            bool _counterHops = (bool)_S71200.Read("DB37.DBX0.3");
            bool _counterSettling = (bool)_S71200.Read("DB37.DBX0.4");
            bool _counterCaustic = (bool)_S71200.Read("DB37.DBX0.5");
            bool _counterAcid = (bool)_S71200.Read("DB37.DBX0.6");
            bool _counterWater = (bool)_S71200.Read("DB37.DBX0.7");
            bool _counterRinse = (bool)_S71200.Read("DB37.DBX1.0");
            bool _counterS7 = (bool)_S71200.Read("DB37.DBX1.1");
            bool _counterCC = (bool)_S71200.Read("DB37.DBX1.2");
            bool _counterCA = (bool)_S71200.Read("DB37.DBX1.3");
            bool _LM = (bool)_S71200.Read("DB37.DBX1.4");
                        
            if ((_counterRice & _counterS7) || (_LM & _Clean_Rice))
            {
                _ZRice = _ZRice + 1;
                _TRice = _TRice + 1;
                _S71200.Write("DB37.DBX0.0", 0);
                _S71200.Write("DB37.DBX1.1", 0);
                _S71200.Write("DB37.DBX1.4", 0);
                _LM = false;
                _counterS7 = false;
                _counterRice = false;
                lblCounter.Text = "Done CIP Rice";
            }
            if ((_counterMalt & _counterS7) || (_LM & _Clean_Malt))
            {
                _ZMalt = _ZMalt + 1;
                _TMalt = _TMalt + 1;
                _S71200.Write("DB37.DBX0.1", 0);
                _S71200.Write("DB37.DBX1.1", 0);
                _S71200.Write("DB37.DBX1.4", 0);
                _LM = false;
                _counterS7 = false;
                _counterMalt = false;
                lblCounter.Text = "Done CIP Malt";
            }
            if ((_counterFilter & _counterS7) || (_LM & _Clean_Filter))
            {
                _ZFilter = _ZFilter + 1;
                _TFilter = _TFilter + 1;
                _S71200.Write("DB37.DBX0.2", 0);
                _S71200.Write("DB37.DBX1.1", 0);
                _S71200.Write("DB37.DBX1.4", 0);
                _LM = false;
                _counterS7 = false;
                _counterFilter = false;
                lblCounter.Text = "Done CIP Filter";
            }
            if ((_counterHops & _counterS7) || (_LM & _Clean_Hops))
            {
                _ZHops = _ZHops + 1;
                _THops = _THops + 1;
                _S71200.Write("DB37.DBX0.3", 0);
                _S71200.Write("DB37.DBX1.1", 0);
                _S71200.Write("DB37.DBX1.4", 0);
                _LM = false;
                _counterS7 = false;
                _counterHops = false;
                lblCounter.Text = "Done CIP Hops";
            }
            if ((_counterSettling & _counterS7) || (_LM & _Clean_Settling))
            {
                _ZSettling = _ZSettling + 1;
                _TSettling = _TSettling + 1;
                _S71200.Write("DB37.DBX0.4", 0);
                _S71200.Write("DB37.DBX1.1", 0);
                _S71200.Write("DB37.DBX1.4", 0);
                _LM = false;
                _counterS7 = false;
                _counterSettling = false;
                lblCounter.Text = "Done CIP Settling";
            }
            
            if(_counterCaustic)
            {
                _ZCaustic = _ZCaustic + 1;
                _TCaustic = _TCaustic + 1;
                _CCaustic = 0;
                _S71200.Write("DB37.DBX0.5", 0);
                _counterCaustic = false;
            }
            if(_counterAcid)
            {
                _ZAcid = _ZAcid + 1;
                _TAcid = _TAcid + 1;
                _CAcid = 0;
                _S71200.Write("DB37.DBX0.6", 0);
                _counterAcid = false;
            }
            if(_counterWater)
            {
                _ZWater = _ZWater + 1;
                _TWater = _TWater + 1;
                _S71200.Write("DB37.DBX0.7", 0);
                _counterWater = false;
            }
            if(_counterRinse)
            {
                _ZRinse = _ZRinse + 1;
                _TRinse = _TRinse + 1;
                _S71200.Write("DB37.DBX1.0", 0);
                _counterRinse = false;
            }
            if(_counterCC)
            {
                _CCaustic = _CCaustic + 1;
                _S71200.Write("DB37.DBX1.2", 0);
                _counterCC = false;
            }
            if (_counterCA)
            {
                _CAcid = _CAcid + 1;
                _S71200.Write("DB37.DBX1.3", 0);
                _counterCA = false;
            }

            if (_SHCaustic)
            {
                _SCaustic = "high";
            }
            else
            {
                if (_SLCaustic)
                {
                    _SCaustic = "low";
                }
            }
            if (_SHAcid)
            {
                _SAcid = "high";
            }
            else
            {
                if (_SLAcid)
                {
                    _SAcid = "low";
                }
            }
            if (_SHWater)
            {
                _SWater = "high";
            }
            else
            {
                if (_SLWater)
                {
                    _SWater = "low";
                }
            }
            if (_SHCurrent & _Clean_Rice)
            {
                _SRice = "high";
            }
            else
            {
                if (_SLCurrent & _Clean_Rice)
                {
                    _SRice = "low";
                }
            }
            if (_SHCurrent & _Clean_Malt)
            {
                _SMalt = "high";
            }
            else
            {
                if (_SLCurrent & _Clean_Malt)
                {
                    _SMalt = "low";
                }
            }
            if (_SHCurrent & _Clean_Filter)
            {
                _SFilter = "high";
            }
            else
            {
                if (_SLCurrent & _Clean_Filter)
                {
                    _SFilter = "low";
                }
            }
            if (_SHCurrent & _Clean_Hops)
            {
                _SHops = "high";
            }
            else
            {
                if (_SLCurrent & _Clean_Hops)
                {
                    _SHops = "low";
                }
            }
            if (_SHCurrent & _Clean_Settling)
            {
                _SSettling = "high";
            }
            else
            {
                if (_SLCurrent & _Clean_Settling)
                {
                    _SSettling = "low";
                }
            }
            if (_SHRinse)
            {
                _SRinse = "high";
            }
            else
            {
                if (_SLRinse)
                {
                    _SRinse = "low";
                }
            }

            _report = new SqlReport("0", "Rice", _SRice, _ZRice.ToString("F"), _TRice.ToString("F"), "NA");
            _sqlPlc._update(_report, ScrAdmin._tableReport);

            _report = new SqlReport("1", "Malt", _SMalt, _ZMalt.ToString("F"), _TMalt.ToString("F"), "NA");
            _sqlPlc._update(_report, ScrAdmin._tableReport);

            _report = new SqlReport("2", "Filter", _SFilter, _ZFilter.ToString("F"), _TFilter.ToString("F"), "NA");
            _sqlPlc._update(_report, ScrAdmin._tableReport);

            _report = new SqlReport("3", "Hops", _SHops, _ZHops.ToString("F"), _THops.ToString("F"), "NA");
            _sqlPlc._update(_report, ScrAdmin._tableReport);

            _report = new SqlReport("4", "Settling", _SSettling, _ZSettling.ToString("F"), _TSettling.ToString("F"), "NA");
            _sqlPlc._update(_report, ScrAdmin._tableReport);

            _report = new SqlReport("5", "Caustic", _SCaustic, _ZCaustic.ToString("F"), _TCaustic.ToString("F"), _CCaustic.ToString("F"));
            _sqlPlc._update(_report, ScrAdmin._tableReport);

            _report = new SqlReport("6", "Acid", _SAcid, _ZAcid.ToString("F"), _TAcid.ToString("F"), _CAcid.ToString("F"));
            _sqlPlc._update(_report, ScrAdmin._tableReport);

            _report = new SqlReport("7", "Water", _SWater, _ZWater.ToString("F"), _TWater.ToString("F"), "NA");
            _sqlPlc._update(_report, ScrAdmin._tableReport);

            _report = new SqlReport("8", "Rinse", _SRinse, _ZRinse.ToString("F"), _TRinse.ToString("F"), "NA");
            _sqlPlc._update(_report, ScrAdmin._tableReport);
        }
    }
}
