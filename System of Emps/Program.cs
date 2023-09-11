using Company.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main()
        {
            Console.Write("Fulltime press 1 or part time 2: ");
            int num = int.Parse(Console.ReadLine());
            #region Full time
            if (num == 1)
            {
                Fulltimeemployeesurvices emp = new Fulltimeemployeesurvices();
                Console.Write("Enter salary: ");
                emp.Salary = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Tax= {emp.CalculateTax()}");
                Console.WriteLine($"Net Salary= {emp.CalculateSalary()}");
            }
            #endregion

            #region Part time
            else if (num == 2)
            {
                Parttimeemployeesurvices emp1 = new Parttimeemployeesurvices();
                Console.Write("Enter count of hours: ");
                emp1.Nhours = double.Parse(Console.ReadLine());
                Console.Write("Enter price an hour: ");
                emp1.Price_Hour = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Salary= {0}", emp1.CalculateSalary());
            }
            #endregion



        }
    }
}
