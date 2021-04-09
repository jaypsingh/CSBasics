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
    public class StringInterpolationTests
    {
        [TestMethod()]
        public void SayHelloEnglishTest()
        {
            System.Console.WriteLine("----- SayHelloEnglishTest Test Run -----");
            
            //Arrange
            var strIntPolObj = new StringInterpolation();
            var expectedValue = "Hello Archer !!";

            //Act
            var actualValue = strIntPolObj.SayHello("Archer");

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void SayHelloGermanTest()
        {
            System.Console.WriteLine("----- SayHelloGermanTest Test Run -----");

            //Arrange
            var strIntPolObj = new StringInterpolation();
            var expectedValue = "Hello Jürgen !!";

            //Act
            var actualValue = strIntPolObj.SayHello("Jürgen");

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}