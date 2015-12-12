using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UOPPOSWeek2ReflectionJacobShay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                var department = Factory.Get(i);
                Console.WriteLine("Where id = {0}, position = {1}, avg salary = {2}", i, department.GetDepartmentName, department.avgSalary);
            }
        }
    }
}
