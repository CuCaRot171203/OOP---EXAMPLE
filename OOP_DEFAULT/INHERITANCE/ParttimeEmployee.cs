using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
    public class ParttimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
}
