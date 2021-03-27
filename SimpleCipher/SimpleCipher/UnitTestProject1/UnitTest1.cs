using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCipher;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string encrypted = "VTAOG";
            int k = 2;
            string expected = "TRYME";

            var response = Result.simpleCipher(encrypted, k);

            Assert.AreEqual(expected, response);
        }

        [TestMethod]
        public void Teste1()
        {
            string encrypted = "VGXGPU";
            int k = 12;
            string expected = "JULUDI";

            var response = Result.simpleCipher(encrypted, k);

            Assert.AreEqual(expected, response);
        }
    }
}
