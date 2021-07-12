using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_5
{
    public class SystemsEngineer:Employee
    {
        public double SpecialistAllowance { get; set; }
        public string Specialization { get; set; }
        public SystemsEngineer(string specialization) : base()
        {
            Specialization = specialization;
        }
        public override double CalculateSalary()
        {
            if (Specialization.Contains("C#") || Specialization.Contains("Java") || Specialization.Contains("SQL"))
            {
                SpecialistAllowance = 3000;
            }
            else
            {
                SpecialistAllowance = 0.0;
            }

            return BasicSalary + SpecialistAllowance;
        }
    }
}
