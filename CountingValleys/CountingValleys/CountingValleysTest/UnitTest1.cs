using CountingValleys;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountingValleysTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 8;
            string s = "UDDDUDUU";
            int expected = 1;

            int result = Program.countingValleys(n, s);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int n = 8;
            string s = "DDUUUUDD";
            int expected = 1;

            int result = Program.countingValleys(n, s);

            Assert.AreEqual(expected, result);
        }
        
    }
}
