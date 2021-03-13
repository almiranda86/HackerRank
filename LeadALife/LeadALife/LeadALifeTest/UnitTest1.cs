using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeadALifeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 2;
            List<int> earnings = new List<int> { 1, 2 };
            List<int> cost = new List<int> { 1, 4 };
            int e = 5;

            var response = LeadALife.Result.calculateProfit(n, earnings, cost, e);

            int expected = 10;

            Assert.AreEqual(expected, response);

        }


        [TestMethod]
        public void TestMethod2()
        {
            int n = 3;
            List<int> earnings = new List<int> { 1, 2, 4 };
            List<int> cost = new List<int> { 1, 3, 6 };
            int e = 5;

            var response = LeadALife.Result.calculateProfit(n, earnings, cost, e);

            int expected = 20;

            Assert.AreEqual(expected, response);

        }

        [TestMethod]
        public void TestMethod3()
        {
            int n = 3;
            List<int> earnings = new List<int> { 1, 5, 5 };
            List<int> cost = new List<int> { 2, 1, 4 };
            int e = 4;

            var response = LeadALife.Result.calculateProfit(n, earnings, cost, e);

            int expected = 36;

            Assert.AreEqual(expected, response);

        }

        [TestMethod]
        public void TestMethod4()
        {
            int n = 4;
            List<int> earnings = new List<int> { 1,8,6,7 };
            List<int> cost = new List<int> { 1,3,4,1 };
            int e = 5;

            var response = LeadALife.Result.calculateProfit(n, earnings, cost, e);

            int expected = 70;

            Assert.AreEqual(expected, response);

        }

        [TestMethod]
        public void TestMethod5()
        {
            int n = 18;
            List<int> earnings = new List<int> { 9, 7, 9, 2, 7, 7, 9, 6, 7, 6, 6, 3, 4, 2, 8, 4, 6, 10 };
            List<int> cost = new List<int> { 4, 1, 1, 5, 2, 3, 3, 3, 2, 4, 4, 3, 3, 4, 4, 1, 2, 5 };
            int e = 5;

            var response = LeadALife.Result.calculateProfit(n, earnings, cost, e);

            int expected = 70;

            Assert.AreEqual(expected, response);

        }
    }
}
