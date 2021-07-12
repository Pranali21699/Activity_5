using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_5
{
    public class Employee
    {
        public double basicSalary;
        public double bonus;
        public int employeeId;
        public double BasicSalary {
            get {
                return basicSalary;
            } 
            set {
                basicSalary = value;
            }
        }
        public double Bonus { 
            get {
                return bonus;
            } 
            set
            {
                bonus = value;
            }
        }
        public int EmployeeId {
            get {
                return employeeId;
            } 
            set {
                employeeId = value;
            } 
        }
        public Employee()
        {
            BasicSalary = 10000;
        }
        public virtual double CalculateSalary()
        {
            return BasicSalary;
        }
    }
}
