using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UOPPOSWeek2ReflectionJacobShay
{
    class ITDepartment : Departments
    {
        LoadDLLRandomEarnings loadDllRandomEarnings = new LoadDLLRandomEarnings();

        public override double avgSalary
        {
            get
            {
                double salary = loadDllRandomEarnings.getSalary();
                return salary;
            }
        }

        public override string GetDepartmentName
        {
            get
            {
                return "Information Technology";
            }
        }

       
    }
}
