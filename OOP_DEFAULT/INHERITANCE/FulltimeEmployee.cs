using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
    public class FulltimeEmployee : Employee
    {
        public decimal MonthlySalary { get; set; }
        public decimal Insurance { get; set; }

        // Method override
        public override decimal CalculateSalary()
        {
            return MonthlySalary - Insurance;
        }
    }
}
