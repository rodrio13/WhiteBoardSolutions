using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwapingValues
{
    [TestClass]
    public class TestFlippingInt
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("43 and 9.2", FlippingInt.FlipTheValues(9.2, 43));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("3 and 3", FlippingInt.FlipTheValues(3, 3));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("-3 and 0", FlippingInt.FlipTheValues(0, -3));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("-23 and -8.9", FlippingInt.FlipTheValues(-8.9, -23));
        }
    }
}