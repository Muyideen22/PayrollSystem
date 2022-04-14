namespace PayrollSystem
{
    internal class Payroll
    {
        public string PayrollID { get; set; }
        public Employee Employee { get; set; }
        public double NetSalary { get; set; }
        public double GrossSalary { get; set; }
        public double TaxDeducted { get; set; }

        public Payroll(string ID, Employee employee, double grossSalary)
        { 
            PayrollID = ID;
            Employee = employee;
            GrossSalary = grossSalary;
        }
        public void calculateTax() { }
        public void calculateNetSalary() { }
    }
}
