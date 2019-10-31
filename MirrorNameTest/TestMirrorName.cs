using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MirrorName
{
    [TestClass]
    public class TestMirrorName
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("gnilraD olleH", MirrorThisString.StringMirror("Hello Darling"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("  !TAERG  si  efiL  ", MirrorThisString.StringMirror("  Life  is  GREAT!  "));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("987654321", MirrorThisString.StringMirror("123456789"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("THE RODRIGUEZ FAMILY", MirrorThisString.StringMirror("YLIMAF ZEUGIRDOR EHT"));
        }
    }
}