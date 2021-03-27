using LastAndSecondLast;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string w = "APPLE";

            string expected = "E L";

            var result = Result.lastLetters(w);

            Assert.AreEqual(expected, result);
        }
    }
}
