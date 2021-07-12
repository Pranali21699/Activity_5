using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_5
{
    public class SeniorProjectManager:Employee
    {
        public double CarAllowance { get; set; }
        public SeniorProjectManager()
        {
            CarAllowance = 6000;
        }
        public override double CalculateSalary()
        {
            return BasicSalary + CarAllowance;
        }
    }
}
