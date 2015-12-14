using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOPPOSWeek2ReflectionJacobShay
{
    /*
    *Our abstrat depart ments class creates various methods that all of our departments are going to use.
    *
    */
    abstract class Departments
    {
        public abstract string GetDepartmentName { get; }
        public abstract double avgSalary { get; }
        public abstract int employees { get; }
    }
}
