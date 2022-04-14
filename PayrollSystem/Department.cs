﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    internal class Department
    {

        public string DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public Department(string ID, string Name) 
        { 
            DepartmentID = ID;
            DepartmentName = Name;
        }
    }
   
}
