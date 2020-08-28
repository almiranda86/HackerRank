using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;

namespace SockMerchantTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 9;
            int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            int expected = 3;

            int result = SockMerchant.Program.sockMerchant(n, ar);

            Assert.AreEqual(expected, result);
        }
    }
}
