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
    public class ArrayDemoTests
    {
        [TestMethod()]
        public void SumDoubleArrayTest()
        {
            //Arrange
            var handleObj = new ArrayDemo();
            var expectedValue = 6.6;

            //Act
            var actualValue = handleObj.SumDoubleArray();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void SumIntArrayTest()
        {
            //Arrange
            var handleObj = new ArrayDemo();
            var expectedValue = 3;

            //Act
            var actualValue = handleObj.SumIntArray();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void GetItemIndexTest()
        {
            //Arrange
            var handleObj = new ArrayDemo();
            var expectedValue = 1;

            //Act
            var actualValue = handleObj.GetItemIndex("orange");

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void GetItemCountTest()
        {
            //Arrange
            var handleObj = new ArrayDemo();
            var expectedValue = 3;

            //Act
            var actualValue = handleObj.GetItemCount();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void SetArrayValueTest()
        {
            //Arrange
            var handleObj = new ArrayDemo();
            var expectedValue = new string[] { "apple", "grape", "banana" };

            //Act
            var actualValue = handleObj.SetArrayValue(1, "grape");

            //Assert
            CollectionAssert.AreEqual(expectedValue, actualValue);
        }
    }
}