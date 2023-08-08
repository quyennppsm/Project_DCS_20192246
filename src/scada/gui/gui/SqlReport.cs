namespace final_ui
{
    class SqlReport
    {
        private string _id;
        private string _name;
        private string _status;
        private string _sigma;
        private string _session;
        private string _cycle;

        public SqlReport()
        {
        }

        public SqlReport(string id, string name, string status, string sigma, string session, string cycle)
        {
            _id = id;
            _name = name;
            _status = status;
            _sigma = sigma;
            _session = session;
            _cycle = cycle;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Status { get => _status; set => _status = value; }
        public string Sigma { get => _sigma; set => _sigma = value; }
        public string Session { get => _session; set => _session = value; }
        public string Cycle { get => _cycle; set => _cycle = value; }
    }
}
