using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOPPOSWeek2ReflectionJacobShay
{
    abstract class Departments
    {
        public abstract string GetDepartmentName { get; }
        public abstract double avgSalary { get; }
    }
}
