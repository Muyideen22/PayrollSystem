using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
