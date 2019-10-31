using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DistinctArrayElements
{
    [TestClass]
    public class TestArrayToDistinct
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, ArrayToDistinct.GiveDistinctCount(new int[] { 1, 1, 1, 1, 2 }));
        }
    }
}