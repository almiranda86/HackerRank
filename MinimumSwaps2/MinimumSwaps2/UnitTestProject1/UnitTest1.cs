using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinimumSwaps2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = new int[] { 4, 3, 1, 2 };

            int expected = 3;

            var result = Solution.minimumSwaps(array);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void TestMethod2()
        {
            int[] array = new int[] { 7, 1, 3, 2, 4, 5, 6 };

            int expected = 5;

            var result = Solution.minimumSwaps(array);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] array = new int[] { 2, 3, 4, 1, 5 };

            int expected = 3;

            var result = Solution.minimumSwaps(array);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void TestMethod4()
        {
            int[] array = new int[] { 3, 7, 6, 9, 1, 8, 10, 4, 2, 5 };

            int expected = 9;

            var result = Solution.minimumSwaps(array);

            Assert.AreEqual(expected, result);
        }


    }
}
