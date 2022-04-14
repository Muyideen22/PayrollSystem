using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    internal class PayGrade
    {
        public string GradeID { get; set; }
        public string GradeName { get; set; }
        public int HourlyPay { get; set; }
        public int overTimePay { get; set; } = 0;
    
        public PayGrade(string ID, string name, int hourlyRate, int overtimeRate)
        {
            GradeID = ID;
            GradeName = name;
            HourlyPay = hourlyRate;
            overTimePay = overtimeRate;
        }
    }
}
