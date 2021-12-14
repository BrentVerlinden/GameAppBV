using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameAppBV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppBV.Tests
{
    [TestClass()]
    public class TestTests
    {
        [TestMethod()]
        public void EmployeeTest()
        {
            Test employee = new Test(50);
            Assert.AreEqual(50, employee.mySalary);
        }
    }
}