using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodIsTrue()
        {
            bool a = true;
            Assert.IsTrue(a);
        }

        [TestMethod]
        public void TestMethodIsFalse()
        {
            bool a = false;
            Assert.IsFalse(a);
        }

        [TestMethod]
        public void TestMethodFail()
        {
            Assert.Fail();
        }

    }
}
