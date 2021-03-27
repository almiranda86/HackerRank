using AddingTwoNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float x = 2.3F;
            float y = 1.9F;

            int expected = 4;

            var result = Result.addNumbers(x, y);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void Teste2()
        {
            float x = 433718.08F;
            float y = 770767.45F;

            int expected = 1204485;

            var result = Result.addNumbers(x, y);

            Assert.AreEqual(expected, result);
        }
    }
}
