using Company.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Classes
{
    class Fulltimeemployeesurvices:Fulltimeemployee,IFulltimeemployee,IEmployee
    {
        public decimal CalculateTax()
        {
            Tax= (Salary*14)/100;
            return Tax;
        }
        public decimal CalculateSalary()
        {
            return Salary - Tax;
        }
    }
}
