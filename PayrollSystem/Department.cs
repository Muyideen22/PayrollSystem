namespace PayrollSystem
{
    internal class Department
    {

        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public Department(int ID, string Name)
        {
            DepartmentID = ID;
            DepartmentName = Name;
        }
    }

}
