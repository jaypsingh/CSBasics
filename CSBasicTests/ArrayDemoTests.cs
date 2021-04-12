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
            System.Console.WriteLine("----- SumDoubleArrayTest Test Run -----");

            //Arrange
            var intArrObj = new ArrayDemo();
            var expectedValue = 6.6;

            //Act
            var actualValue = intArrObj.SumDoubleArray();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void SumIntArrayTest()
        {
            System.Console.WriteLine("----- SumIntArrayTest Test Run -----");

            //Arrange
            var intArrObj = new ArrayDemo();
            var expectedValue = 3;

            //Act
            var actualValue = intArrObj.SumIntArray();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void GetItemIndexTest()
        {
            System.Console.WriteLine("----- GetItemIndexTest Test Run -----");

            //Arrange
            var arrObj = new ArrayDemo();
            var expectedValue = 1;

            //Act
            var actualValue = arrObj.GetItemIndex("orange");

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void GetItemCountTest()
        {
            System.Console.WriteLine("----- GetItemCountTest Test Run -----");

            //Arrange
            var arrObj = new ArrayDemo();
            var expectedValue = 3;

            //Act
            var actualValue = arrObj.GetItemCount();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void SetArrayValueTest()
        {
            System.Console.WriteLine("----- GetItemCountTest Test Run -----");

            //Arrange
            var arrObj = new ArrayDemo();
            var expectedValue = new string[] { "apple", "grape", "banana" };

            //Act
            var actualValue = arrObj.SetArrayValue(1, "grape");

            //Assert
            CollectionAssert.AreEqual(expectedValue, actualValue);
        }
    }
}