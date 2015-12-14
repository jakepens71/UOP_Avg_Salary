using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UOPPOSWeek2ReflectionJacobShay
{
    class LoadDLLRandomEarnings
    {
        //Loads the "RandomEarnings.dll" into memory
        Assembly assem = Assembly.LoadFrom("RandomEarnings.dll");

        /*
        *Constructor for the LoadDLLRandomEarnings class
        *
        */
        public LoadDLLRandomEarnings()
        {

        }

        /*
        *Gets the getSalary method from the RandomEarnings.dll that is in memory
        *
        */
        public double getSalary()
        {
            Type[] types = assem.GetTypes();
            double salary = 0;


            foreach (var item in types)
            {
                object classInstance = Activator.CreateInstance(item);


                MethodInfo[] methods = item.GetMethods();

                foreach (var methodItems in methods)
                {
                    if (methodItems.Name == "getSalary")
                    {
                        salary = (double)item.InvokeMember(methodItems.Name, BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, null, classInstance, null);
                    }
                }
            }
            return salary;
        }


        /*
        *Gets the getEmployees method from the RandomEarnings.dll that is in memory
        *
        */
        public int getEmployees()
        {
            Type[] types = assem.GetTypes();
            int employees = 0;


            foreach (var item in types)
            {
                object classInstance = Activator.CreateInstance(item);


                MethodInfo[] methods = item.GetMethods();

                foreach (var methodItems in methods)
                {
                    if (methodItems.Name == "getEmployees")
                    {
                        employees = (int)item.InvokeMember(methodItems.Name, BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, null, classInstance, null);
                    }
                }
            }
            return employees;
        }

    }
}
