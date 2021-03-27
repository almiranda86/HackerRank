using FindTheRunningMedian;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindTheRunningMedianTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] expected = new double[] { 12.0, 8.0, 5.0, 4.5, 5.0, 6.0 };

            int[] a = new int[] { 12, 4, 5, 3, 8, 7 };

            var result = Solution.findMedia(a);

            Assert.AreEqual(expected, result);
        }
    }
}
