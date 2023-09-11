using Company.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Classes
{
    class Parttimeemployeesurvices:PartTimeemployee,IEmployee
    {
        public decimal CalculateSalary()
        {
            return (decimal)Nhours * Price_Hour;
        }
    }
}
