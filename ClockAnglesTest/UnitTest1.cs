using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClockAngles
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ClockAngleTest1()
        {
            Assert.AreEqual(90, ClockAngles.ClockAngle(3, 0));
        }
        public void ClassAngleTest2()
        {
            Assert.AreEqual(180, ClockAngles.ClockAngle(6, 0));
        }
        public void ClassAngleTest3()
        {
            Assert.AreEqual(0, ClockAngles.ClockAngle(12, 0));
        }
    }
}