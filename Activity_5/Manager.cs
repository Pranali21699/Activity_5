using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_5
{
    public class Manager : Employee
    {
        public double PhoneAllowance { get; set; }
        public Manager()
        {
            PhoneAllowance = 4000;
        }
        public override double CalculateSalary()
        {
            return BasicSalary + PhoneAllowance;
        }
    }
}
