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
            //Arrange
            var handleObj = new BreakContinue();
            var expectedValue = new List<string>() { "jay", "kairav", "bijay", "sujata"};

            //Act
            var actualValue = handleObj.DemoBreak();           

            //Assert
            CollectionAssert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void DemoContinueTest()
        {
            //Arrange
            var handleObj = new BreakContinue();
            var expectedValue = new List<string>() { "jay", "kairav", "bijay", "sujata", "batman", "alferd" };

            //Act
            var actualValue = handleObj.DemoContinue();

            //Assert
            CollectionAssert.AreEqual(expectedValue, actualValue);
        }
    }
}