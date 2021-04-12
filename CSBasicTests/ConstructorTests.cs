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
    public class ConstructorTests
    {
        [TestMethod()]
        public void AddNumberToListTest()
        {
            System.Console.WriteLine("----- AddNumberToListTest Test Run -----");

            //Arrange
            var handleObj = new Constructor("Archer");
            var expectedValue = new List<double>() { 1.1, 1.2, 1.3 };

            //Act
            handleObj.AddNumberToList(1.3);
            var actualValue = handleObj.number;
;
            //Assert
            CollectionAssert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void GetBookNameTest()
        {
            //Arrange
            var handleObj = new Constructor("Archer");
            var expectedValue = "Archer";

            //Act
            var actualValue = handleObj.GetBookName();
            ;
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}