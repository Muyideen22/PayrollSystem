namespace PayrollSystem
{
    internal class Attendance
    {
        public string AttendanceId { get; set; }
        public Employee Employee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double RegularHours { get; set; }
        public double OvertimeHours { get; set; } = 0;

        public Attendance(string ID, Employee employee, DateTime startDate, DateTime endDate, double regularHours, double overtimeHours)
        {
            AttendanceId = ID;
            Employee = employee;
            StartDate = startDate;
            EndDate = endDate;
            RegularHours = regularHours;
            OvertimeHours = overtimeHours;
        }
    }
}
