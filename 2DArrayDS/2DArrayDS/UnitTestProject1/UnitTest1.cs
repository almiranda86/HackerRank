using _2DArrayDS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string numeros = "1 1 1 0 0 0|0 1 0 0 0 0|1 1 1 0 0 0|0 0 2 4 4 0|0 0 0 2 0 0|0 0 1 2 4 0";
            string[] arrayNums = numeros.Split('|');


            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(arrayNums[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int expected = 19;

            int result = Solution.hourglassSum(arr);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string numeros = "-1 -1 0 -9 -2 -2|-2 -1 -6 -8 -2 -5|-1 -1 -1 -2 -3 -4|-1 -9 -2 -4 -4 -5|-7 -3 -3 -2 -9 -9|-1 -3 -1 -2 -4 -5";
            string[] arrayNums = numeros.Split('|');


            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(arrayNums[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int expected = 19;

            int result = Solution.hourglassSum(arr);

            Assert.AreEqual(expected, result);
        }
    }
}
