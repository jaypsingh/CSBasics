using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSBasic.Tests
{
    [TestClass()]
    public class FlowAndLoopTests
    {
        [TestMethod()]
        public void AddListNumbersForEachTest()
        {
            //Arrange
            var handleObj = new FlowAndLoop();
            var expectedValue = 16.5;

            //Act
            var actualValue = handleObj.AddListNumbersForEach();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void PrintIfTrueIfConditionTest()
        {
            //Arrange
            var handleObj = new FlowAndLoop();
            var expectedValue = 16.5;

            //Act
            var actualValue = handleObj.PrintIfTrue(10);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void PrintIfTrueElseConditionTest()
        {
            //Arrange
            var handleObj = new FlowAndLoop();
            var expectedValue = 21;

            //Act
            var actualValue = handleObj.PrintIfTrue(21);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void AddListNumbersDoWhileTest()
        {
            //Arrange
            var handleObj = new FlowAndLoop();
            var expectedValue = 16.5;

            //Act
            var actualValue = handleObj.AddListNumbersDoWhile();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void AddListNumbersWhileTest()
        {
            //Arrange
            var handleObj = new FlowAndLoop();
            var expectedValue = 16.5;

            //Act
            var actualValue = handleObj.AddListNumbersWhile();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void AddListNumbersForTest()
        {
            //Arrange
            var handleObj = new FlowAndLoop();
            var expectedValue = 16.5;

            //Act
            var actualValue = handleObj.AddListNumbersFor();

            //Assert
            Assert.AreEqual(expectedValue, actualValue); ;
        }
    }
}