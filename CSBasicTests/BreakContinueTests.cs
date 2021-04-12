using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic.Tests
{
    [TestClass()]
    public class BreakContinueTests
    {
        [TestMethod()]
        public void DemoBreakTest()
        {
            System.Console.WriteLine("----- DemoBreakTest Test Run -----");

            //Arrange
            var brkConObj = new BreakContinue();
            var expectedValue = new List<string>() { "jay", "kairav", "bijay", "sujata"};

            //Act
            var actualValue = brkConObj.DemoBreak();           

            //Assert
            CollectionAssert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void DemoContinueTest()
        {
            System.Console.WriteLine("----- DemoContinueTest Test Run -----");

            //Arrange
            var brkConObj = new BreakContinue();
            var expectedValue = new List<string>() { "jay", "kairav", "bijay", "sujata", "batman", "alferd" };

            //Act
            var actualValue = brkConObj.DemoContinue();

            //Assert
            CollectionAssert.AreEqual(expectedValue, actualValue);
        }
    }
}