using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewYearChaos;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] queue = new int[] { 2, 1, 5, 3, 4 };

            Solution.minimumBribes(queue);
        }


        [TestMethod]
        public void TestMethod2()
        {
            int[] queue = new int[] { 2, 5, 1, 3, 4 };

            Solution.minimumBribes(queue);
        }
    }
}
