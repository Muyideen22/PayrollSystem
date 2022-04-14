namespace PayrollSystem
{
    internal class Admin
    {
        public string AdminId { get; set; }
        public string AdminName { get; set; }
        public string Password { get; set; }

        public void addEmployee() { }
        public void removeEmployee() { }
        public void addPayGrade() { }
        public void removePayGrade() { }
        public void generatePayroll() { }
        public void approveLeaveRequests() { }
        public void approveAttendance() { }
    }
}
