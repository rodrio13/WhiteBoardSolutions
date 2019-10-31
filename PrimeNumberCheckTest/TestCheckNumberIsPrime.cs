using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumberCheck
{
    [TestClass]
    public class TestCheckNumberIsPrime
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(CheckNumberIsPrime.IsPrime(9));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(CheckNumberIsPrime.IsPrime(10));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsFalse(CheckNumberIsPrime.IsPrime(-9));
        }
    }
}