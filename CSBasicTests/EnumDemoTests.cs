using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSBasic.Tests
{
    [TestClass()]
    public class EnumDemoTests
    {
        [TestMethod()]
        public void GetOptionsYesValueTest()
        {
            //Arrange
            var handleObj = new EnumDemo();
            var expectedValue = 0;

            //Act
            var actualValue = (int)EnumDemo.Options.yes;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void GetOptionsNoValueTest()
        {
            //Arrange
            var handleObj = new EnumDemo();
            var expectedValue = 1;

            //Act
            var actualValue = (int)EnumDemo.Options.no;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void GetSuperHeroBatmanValueTest()
        {
            //Arrange
            var handleObj = new EnumDemo();
            var expectedValue = 1;

            //Act
            var actualValue = (int)EnumDemo.SuperHero.BatMan;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void GetSuperHeroSupermanValueTest()
        {
            //Arrange
            var handleObj = new EnumDemo();
            var expectedValue = 3;

            //Act
            var actualValue = (int)EnumDemo.SuperHero.SuperMan;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}