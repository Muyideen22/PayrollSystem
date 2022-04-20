namespace PayrollSystem
{
    internal class Admin
    {
        public string AdminId { get; set; }
        public string AdminName { get; set; }
        public string Password { get; set; }
        public Admin(string id, string name, string pass)
        {
            AdminId = id;
            AdminName = name;
            Password = pass;
        }

    }
}
