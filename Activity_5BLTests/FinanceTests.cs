using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_5.Tests
{
    [TestClass()]
    public class FinanceTests
    {
        [TestMethod()]
        public void GetCalculatedSalaryTest1()
        {
            Employee o1 = new SystemsEngineer("C#");
            Finance o2 = new Finance();
            double actual = o2.GetCalculatedSalary(o1);
            double expected = 18000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCalculatedSalaryTest2()
        {
            Employee o1 = new SystemsEngineer("Java");
            Finance o2= new Finance();
            double actual = o2.GetCalculatedSalary(o1);
            double expected = 18000;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetCalculatedSalaryTest3()
        {
            Employee o1 = new SystemsEngineer("SQL");
            Finance o2 = new Finance();
            double actual = o2.GetCalculatedSalary(o1);
            double expected = 18000;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetCalculatedSalaryTest4()
        {
            Employee SEObj = new SystemsEngineer("Python");
            Finance FObj = new Finance();
            double actual = FObj.GetCalculatedSalary(SEObj);
            double expected = 15000;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetCalculatedSalaryTestM()
        {
            Employee m1 = new Manager();
            Finance f1 = new Finance();
            double actual = f1.GetCalculatedSalary(m1);
            double expected = 23000;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetCalculatedSalaryTestSPM()
        {

            Employee s1 = new SeniorProjectManager();
            Finance s2 = new Finance();
            double actual = s2.GetCalculatedSalary(s1);
            double expected = 31000;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetCalculatedSalaryTestEmp()
        {
            Employee e1 = new Employee();
            Finance e2 = new Finance();
            double actual = e2.GetCalculatedSalary(e1);
            double expected = 10000;
            Assert.AreEqual(expected, actual);
        }
    }
}