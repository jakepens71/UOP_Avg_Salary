﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UOPPOSWeek2ReflectionJacobShay
{

    /*
    *The ITDepartment class inherits from Departments
    *
    */
    class ITDepartment : Departments
    {
        //The loadDLLRandomEarnings new object that was created from LoadDLLRandomEarnings
        //loads the assymble dll "RandomEarnings" and then we use this to get the results of avg salary
        //and the number of employees from the dll "RandomEarnings".
        LoadDLLRandomEarnings loadDllRandomEarnings = new LoadDLLRandomEarnings();

        /*
        *Gets the avg salary for the ITDepartment. 
        *This method is from the "RandomEarnings" dll
        */
        public override double avgSalary
        {
            get
            {
                double salary = loadDllRandomEarnings.getSalary();  //Load in the random salary generated 
                return salary;  //Return the salary
            }
        }

        /*
       *Gets the number of employees for the ITDepartment. 
       *This method is from the "RandomEarnings" dll
       */
        public override int employees
        {
            get
            {
                int employees = loadDllRandomEarnings.getEmployees(); //Load in the number of employees
                return employees;   //Return the number of employees
            }
        }

        /*
        *Use this department name for the "ITDepartment" class
        *
        */
        public override string GetDepartmentName
        {
            get
            {
                return "Information Technology";
            }
        }

       
    }
}
