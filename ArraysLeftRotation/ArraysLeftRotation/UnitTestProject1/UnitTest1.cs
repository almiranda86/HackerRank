using ArraysLeftRotation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int rotations = 4;

            int[] expected = new int[] { 5, 1, 2, 3, 4 };
            var result = Solution.rotLeft(array, rotations);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] array = new int[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 };
            int rotations = 10;

            int[] expected = new int[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 };
            var result = Solution.rotLeft(array, rotations);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] array = new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 };
            int rotations = 10;

            int[] expected = new int[] { 87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60 };
            var result = Solution.rotLeft(array, rotations);

            Assert.AreEqual(expected, result);

        }
    }
}
