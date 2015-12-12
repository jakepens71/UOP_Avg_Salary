using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOPPOSWeek2ReflectionJacobShay
{
    class ITDepartment : Departments
    {
        public double avgSalary
        {
            get
            {
                return 200.000;
            }
        }

        public string GetDepartmentName
        {
            get
            {
                return "Information Technology";
            }
        }
    }
}
