using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelectingStocks;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 55;

            int saving = 250;
            List<int> currentVal = new List<int> { 175, 133, 109, 210, 97 };
            List<int> futureVal = new List<int> { 200, 125, 128, 228, 133 };

            var result = Result.selectStock(saving, currentVal, futureVal);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void TestMethod2()
        {
            int expected = 6;

            int saving = 30;
            List<int> currentVal = new List<int> { 1, 2, 4, 6 };
            List<int> futureVal = new List<int> { 5, 3, 5, 6 };

            var result = Result.selectStock(saving, currentVal, futureVal);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int expected = 0;

            int saving = 500;
            List<int> currentVal = new List<int> { 150, 199, 200, 168, 153 };
            List<int> futureVal = new List<int> { 140, 175, 199, 121, 111 };

            var result = Result.selectStock(saving, currentVal, futureVal);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int expected = 745;

            int saving = 449;
            List<int> currentVal = new List<int> { 125, 158, 1, 210, 104, 243, 238, 161, 227, 264, };
            List<int> futureVal = new List<int> { 298, 268, 287, 84, 267, 64, 269, 284, 273, 96 };

            var result = Result.selectStock(saving, currentVal, futureVal);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void TestMethod5()
        {
            int expected = 2757;

            int saving = 938;
            List<int> currentVal = new List<int>() { 29, 192, 150, 91, 65, 147, 206, 211, 173, 250, 168, 231, 77, 65, 65, 195, 220, 63, 129, 4, 286, 162, 204, 22, 20, 183, 69, 242, 58, 91, 3, 55, 228, 216, 141 };
            List<int> futureVal = new List<int> { 247, 182, 76, 292, 263, 98, 287, 194, 285, 233, 6, 180, 165, 293, 273, 148, 251, 120, 114, 282, 198, 32, 135, 294, 279, 37, 55, 280, 252, 219, 84, 290, 65, 103, 168 };

            var result = Result.selectStock(saving, currentVal, futureVal);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void TestMethod6()
        {
            int expected = 8099;

            int saving = 938;
            List<int> currentVal = new List<int>() { 199, 193, 201, 172, 159, 106, 42, 70, 118, 209, 202, 108, 189, 162, 283, 5, 123, 43, 127, 128, 105, 90, 91, 225, 192, 37, 251, 77, 195, 64, 7, 289, 24, 59, 84, 110, 48, 88, 248, 174, 131, 258, 244, 58, 50, 169, 217, 160, 41, 95, 283, 200, 149, 249, 106, 116, 174, 47, 159, 21, 119, 105, 42, 56 };
            List<int> futureVal = new List<int> { 231, 234, 7, 253, 35, 289, 27, 288, 278, 170, 238, 72, 146, 129, 254, 245, 16, 177, 272, 267, 12, 116, 289, 62, 25, 247, 138, 272, 28, 280, 297, 263, 51, 262, 38, 229, 146, 204, 285, 1, 269, 57, 290, 296, 293, 294, 297, 299, 264, 191, 266, 299, 277, 26, 269, 297, 94, 248, 46, 104, 288, 17, 33, 279 };

            var result = Result.selectStock(saving, currentVal, futureVal);

            Assert.AreEqual(expected, result);
        }
    }
}
