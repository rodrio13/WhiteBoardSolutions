using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReversingIntegers
{
    [TestClass]
    public class TestReversingIntegers
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12345, ReverseTheInteger.Reverse(54321));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(6862, ReverseTheInteger.Reverse(2686));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, ReverseTheInteger.Reverse(1));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(92, ReverseTheInteger.Reverse(29));
        }
    }
}