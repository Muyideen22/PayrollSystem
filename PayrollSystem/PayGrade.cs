using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    internal class PayGrade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        public double HourlyPay { get; set; }
        public double overTimePay { get; set; } = 0;
    
        public PayGrade(int ID, string name, double hourlyRate, double overtimeRate)
        {
            GradeID = ID;
            GradeName = name;
            HourlyPay = hourlyRate;
            overTimePay = overtimeRate;
        }
    }
}
