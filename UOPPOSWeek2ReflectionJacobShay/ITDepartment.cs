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
        public override double avgSalary
        {
            get
            {
                Assembly assem = Assembly.LoadFrom("RandomEarnings.dll");

                Type[] types = assem.GetTypes();
                double salary = 0;
                

                foreach (var item in types)
                {
                    object classInstance = Activator.CreateInstance(item);


                    MethodInfo[] methods = item.GetMethods();

                    foreach(var methodItems in methods)
                    {
                        if (methodItems.Name == "getSalary")
                        {
                             salary = (double)item.InvokeMember(methodItems.Name, BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, null, classInstance, null);
                        }
                    }

                }
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
