using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_5
{
    public class Finance
    {
        public Finance() { }
        public double GetCalculatedSalary(Employee obj)
        {
            if (obj.GetType() == typeof(SystemsEngineer))
            {
                obj.Bonus = 5000;
            }
            else if (obj.GetType() == typeof(Manager))
            {
                obj.Bonus = 9000;
            }
            else if (obj.GetType() == typeof(SeniorProjectManager))
            {
                obj.Bonus = 15000;
            }
            else
            {
                obj.Bonus = 0.0;
            }
            Console.WriteLine("Total Salary:" + (obj.CalculateSalary() + obj.Bonus));
            return obj.CalculateSalary() + obj.Bonus;
        }
    }
}
