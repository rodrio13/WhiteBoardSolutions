using Microsoft.VisualStudio.TestTools.UnitTesting;
//Add the namespace from the one you're testing.
using CountCapitals;

namespace CountCapitalsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCountCapitalsStarWarsTest()
        {
            Assert.AreEqual(2, UpperCase.CountCapitals("Star Wars"));
        }
    }
}