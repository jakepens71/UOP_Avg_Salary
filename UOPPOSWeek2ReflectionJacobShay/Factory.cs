using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOPPOSWeek2ReflectionJacobShay
{
    /*
    *A factory class that creates our departments for us.
    *
    */
    abstract class Factory
    {
        public static Departments Get(int id)
        {
            //Switch between the classes that we are going to create.
            switch (id)
            {
                case 0:
                    return new ITDepartment();
                case 1:
                    return new HumanResourceDepartment();
                default:
                    return null;
            }
        }
    }
}
