using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepeatedString;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "aba";
            long n = 10;
            long expected = 7;

            var result = Solution.repeatedString(s, n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string s = "ababa";
            long n = 3;
            long expected = 2;

            var result = Solution.repeatedString(s, n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "a";
            long n = 1000000000000;
            long expected = 1000000000000;

            var result = Solution.repeatedString(s, n);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void TestMethod3()
        {
            string s = "x";
            long n = 1000000000000;
            long expected = 0;

            var result = Solution.repeatedString(s, n);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string s = "kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm";
            long n = 736778906400;
            long expected = 51574523448;

            var result = Solution.repeatedString(s, n);

            Assert.AreEqual(expected, result);
        }
    }
}