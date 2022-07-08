using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Tests
{
    [TestClass()]
    public class DemoClassTests
    {
        [TestMethod()]
        public void AddTwoNumberTest()
        {
            DemoClass demoClass = new DemoClass();
            Assert.AreEqual(5, demoClass.AddTwoNumber(2, 3));
        }
    }
}