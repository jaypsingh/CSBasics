using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
 
namespace CSBasic.Tests
{
    [TestClass()]
    public class DictionaryDemoTests
    {
        [TestMethod()]
        public void AddItemToDictTest()
        {
            //Arrange            
            var handleObj = new DictionaryDemo();
            var expectedValue = new Dictionary<string, string>()
            {
                { "BatMan", "Bruce" },
                { "SpiderMan", "Peter" },
                { "Deadpool", "Wade"}
            };

            //Act
            handleObj.AddItemToDict("Deadpool", "Wade");
            var actualValue = handleObj.Hero;            

            //Asert
            CollectionAssert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void GetDictItemTest()
        {
            //Arrange
            var handleObj = new DictionaryDemo();
            var expectedValue = "Peter";

            //Act
            var actualValue = handleObj.GetDictItem("SpiderMan");

            //Asert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void GetDictItemContainsTest()
        {
            //Arrange
            var handleObj = new DictionaryDemo();
            var expectedValue = "Bruce";

            //Act
            var actualValue = handleObj.GetDictItemContains("BatMan");

            //Asert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void GetDictItemTryGetTest()
        {
            //Arrange
            var handleObj = new DictionaryDemo();
            var expectedValue = "Peter";

            //Act
            var actualValue = handleObj.GetDictItemTryGet("SpiderMan");

            //Asert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}