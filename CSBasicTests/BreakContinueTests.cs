using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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