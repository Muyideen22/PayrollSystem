namespace PayrollSystem
{
    internal class Employee
    {
        
        public int EmployeeID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Department { get; set; }
        public int Grade { get; set; }

        public Employee(int ID, string fname, string lname, string gender, int age, int department, int grade) {
            EmployeeID = ID;
            FName = fname;
            LName = lname;
            Gender = gender;
            Age = age;
            Department = department;
            Grade = grade;

        }

        new public string[] ToString()
        {
            return new []{
                   EmployeeID.ToString(),
                   FName,
                   LName,
                   Gender,
                   Age.ToString(),
                   Department.ToString(),
                   Grade.ToString()
            };
        }
    }
}
