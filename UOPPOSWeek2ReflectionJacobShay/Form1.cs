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
            //Clear list box
            lstAnswer.Items.Clear();
            //Refresh list box
            lstAnswer.Refresh();

            //Create variables for the total salary and total employes. Initalize them
            double totalSalary = 0;
            int totalEmployees = 0;

            //For loop for the departments
            for (int i = 0; i < 2; i++)
            {
                var department = Factory.Get(i);
                //Console.WriteLine("Where id = {0}, department = {1}, avg salary = {2}", i, department.GetDepartmentName, department.avgSalary);

                double dblSalary = double.Parse(department.avgSalary.ToString());

                //Get the number of employees for the department
                int employees = department.employees;

                //Format the salary into a currency readable string format
                string salary = String.Format("{0:C}", dblSalary);

                //Simple answer string
                string answer = "Department: " + department.GetDepartmentName + ", avg salary: " + salary + ", Number Employees: " + employees.ToString();
                //Add the answer string to the list box
                lstAnswer.Items.Add(answer);
                //Refresh the list box
                lstAnswer.Refresh();
                //Add the total salary
                totalSalary = dblSalary + totalSalary;
                //Keep total of the total employees
                totalEmployees = totalEmployees + employees;
            }

            //Format the new total salary into currency string format
            string strTotalSalary = String.Format("{0:C}", totalSalary);

            //Add the final total salary and total employees to the list box
            lstAnswer.Items.Add("---------------------------");
            lstAnswer.Items.Add("Total Salary: " + strTotalSalary + ", Total Employees: " + totalEmployees.ToString());

        }
    }
}
