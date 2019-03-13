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
        public void TestMethodAddition()
        {
            int numb = 5+ 5;

            Assert.AreEqual(10, numb);
        }

        [TestMethod]
        public void TestMethodSubtraction()
        {
            int numb = 10 - 5;

            Assert.AreEqual(5, numb);
        }

    }
}
