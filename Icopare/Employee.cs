using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icopare
{
    public class Employee
    {
        public int Salary { get; set; }
        public string Name { get; set; }


    }
    public class SalaryComparison : IComparer<Employee>
    {
       public  int Compare(Employee x, Employee y)
        {
            if (x.Salary < y.Salary)
            {
                return -1;

            }
            else if (x.Salary > y.Salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

       
    }
}
