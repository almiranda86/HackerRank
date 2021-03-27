using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1;
            List<int> spaces = new List<int>() { 1, 2, 3, 1, 2 };

            var response = Solution.Segment(x, spaces);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int x = 3;
            List<int> spaces = new List<int>() { 2,5,4,6,8 };

            var response = Solution.Segment(x, spaces);
        }
    }
}
