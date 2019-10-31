using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CamelCase
{
    [TestClass]
    public class TestConvertToCamelCase
    {
        [TestMethod]
        public void ConvertToCamelCaseTest1()
        {
            Assert.AreEqual("theCatInTheHat", ConvertToCamelCase.toCamelCase("The cat in the hat"));
        }
        [TestMethod]
        public void ConvertToCamelCaseTest2()
        {
            Assert.AreEqual("iLoveMyFamily", ConvertToCamelCase.toCamelCase("I love my family"));
        }
        [TestMethod]
        public void ConvertToCamelCaseTest3()
        {
            Assert.AreEqual("myAnniversaryIsMayFifth", ConvertToCamelCase.toCamelCase("My anniversary is May fifth"));
        }
    }
}