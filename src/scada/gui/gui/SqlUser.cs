namespace final_ui
{
    class SqlUser
    {
        private string _id;
        private string _name;
        private string _account;
        private string _password;
        private string _role;

        public SqlUser()
        {
        }

        public SqlUser(string id, string name, string account, string password, string role)
        {
            _id = id;
            _name = name;
            _account = account;
            _password = password;
            _role = role;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Account { get => _account; set => _account = value; }
        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }
    }
}
