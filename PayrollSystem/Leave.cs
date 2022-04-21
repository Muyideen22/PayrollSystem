namespace PayrollSystem
{
    internal class Leave
    {
        public string LeaveID { get; set; }
        public Employee Employee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Leave(string leaveID, Employee employee, DateTime start, DateTime end)
        {
            LeaveID = leaveID;
            Employee = employee;
            StartDate = start;
            EndDate = end;
        }
    }
}
