using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity_5;

namespace Activity_5UI
{
   public  class Program
    {
        static void Main(string[] args)
        {
            Employee employeeObj = new SystemsEngineer("C#");
            Finance financeObj = new Finance();
            financeObj.GetCalculatedSalary(employeeObj);
            Employee managerObj = new Manager();
            financeObj.GetCalculatedSalary(managerObj);
            Employee seniorprojectmanagerObj = new SeniorProjectManager();
            financeObj.GetCalculatedSalary(seniorprojectmanagerObj);
        }
    }
}
