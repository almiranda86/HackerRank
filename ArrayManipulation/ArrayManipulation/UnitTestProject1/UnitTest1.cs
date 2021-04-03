using ArrayManipulation;
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
            int n = 5;

            string numeros = "1 2 100|2 5 100|3 4 100";
            string[] arrayNums = numeros.Split('|');

            int[][] queries = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                queries[i] = Array.ConvertAll(arrayNums[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int expected = 200;

            long result = Solution.arrayManipulation(n, queries);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int n = 10;

            string numeros = "2 6 8|3 5 7|1 8 1|5 9 15";
            string[] arrayNums = numeros.Split('|');

            int[][] queries = new int[arrayNums.Length][];

            for (int i = 0; i < arrayNums.Length; i++)
            {
                queries[i] = Array.ConvertAll(arrayNums[i].Split(" "), arrTemp => Convert.ToInt32(arrTemp));
            }

            int expected = 200;

            long result = Solution.stackOverflowSolution(n, queries);

            Assert.AreEqual(expected, result);
        }
    }
}
