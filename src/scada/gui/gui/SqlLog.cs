namespace final_ui
{
    class SqlLog
    {
        private string _id;
        private string _date;
        private string _time;
        private string _status;
        private string _role;

        public SqlLog()
        {
        }

        public SqlLog(string id, string date, string time, string status, string role)
        {
            _id = id;
            _date = date;
            _time = time;
            _status = status;
            _role = role;
        }

        public string Id { get => _id; set => _id = value; }
        public string Date { get => _date; set => _date = value; }
        public string Time { get => _time; set => _time = value; }
        public string Status { get => _status; set => _status = value; }
        public string Role { get => _role; set => _role = value; }
    }
}
