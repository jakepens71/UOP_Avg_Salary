using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOPPOSWeek2ReflectionJacobShay
{
    static class Factory
    {
        public static Departments Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new ITDepartment();
                case 1:
                default:
                    return null;
            }
        }
    }
}
