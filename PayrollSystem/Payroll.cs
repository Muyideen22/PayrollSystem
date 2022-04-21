namespace PayrollSystem
{
    internal class Payroll
    {
        public string PayrollID { get; set; }
        public int Employee { get; set; }
        public double NetSalary { get; set; }
        public double GrossSalary { get; set; }
        public double TaxDeducted { get; set; }

        public Payroll(string ID, int employee, double grossSalary)
        {
            PayrollID = ID;
            Employee = employee;
            GrossSalary = grossSalary;
        }
        public void calculateTax() { }
        public void calculateNetSalary() { }
    }
}
