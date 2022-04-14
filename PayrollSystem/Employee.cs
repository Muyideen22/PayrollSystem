namespace PayrollSystem
{
    internal class Employee
    {
        
        public string EmployeeID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }
        public PayGrade Grade { get; set; }

        public Employee(string ID, string fname, string lname, string gender, int age, Department department, PayGrade grade) {
            EmployeeID = ID;
            FName = fname;
            LName = lname;
            Gender = gender;
            Age = age;
            Department = department;
            Grade = grade;

        }
    }
}
