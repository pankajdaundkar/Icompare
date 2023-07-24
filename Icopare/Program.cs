using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icopare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee {Salary= 10000,Name="pankaj" };
            Employee employee2 = new Employee {Salary = 20000,Name="pratik" };

            SalaryComparison sal = new SalaryComparison();
            int result = sal.Compare(employee, employee2);

            if (result < 0)
            {
                Console.WriteLine("Pnakaj salary is less than Pratik");
            }
            else if (result > 0)
            {
                Console.WriteLine("Pankaj salary is more than Pratik");
            }
            else
            {
                Console.WriteLine("salary of Pankaj is same as Pratik");
            }
            

        }
    }
}
