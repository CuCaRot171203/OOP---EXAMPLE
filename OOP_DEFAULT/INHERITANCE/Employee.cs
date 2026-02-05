using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
    public abstract class Employee
    {
        public string Name { get; set; } = "";

        // General behaviors - but not same properties
        // Use keyword abstract to child class can be override method
        public abstract decimal CalculateSalary();
    }
}
