using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOPPOSWeek2ReflectionJacobShay
{
    class HumanResourceDepartment : Departments
    {
        //The loadDLLRandomEarnings new object that was created from LoadDLLRandomEarnings
        //loads the assymble dll "RandomEarnings" and then we use this to get the results of avg salary
        //and the number of employees from the dll "RandomEarnings".
        LoadDLLRandomEarnings loadDllRandomEarnings = new LoadDLLRandomEarnings();

        /*
       *Gets the avg salary for the HumanResource department. 
       *This method is from the "RandomEarnings" dll
       */
        public override double avgSalary
        {
            get
            {
                System.Threading.Thread.Sleep(100);
                double salary = loadDllRandomEarnings.getSalary();
                return salary;
            }
        }

        /*
      *Gets the number of employees for the HumanResource department. 
      *This method is from the "RandomEarnings" dll
      */
        public override int employees
        {
            get
            {
                int employees = loadDllRandomEarnings.getEmployees();
                return employees;
            }
        }

        /*
        *Use this department name for the "HumanResourceDepartment" class
        *
        */
        public override string GetDepartmentName
        {
            get
            {
                return "Human Resources";
            }
        }
    }
}
