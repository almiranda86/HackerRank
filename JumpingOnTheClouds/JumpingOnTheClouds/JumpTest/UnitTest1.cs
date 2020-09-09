using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JumpTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] input = { 0, 0, 1, 0, 0, 1, 0 };
            int expected = 4;
            var result = JumpingOnTheClouds.Jump.jumpingOnClouds(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] input = { 0, 0, 0, 0, 1, 0 };
            int expected = 3;
            var result = JumpingOnTheClouds.Jump.jumpingOnClouds(input);

            Assert.AreEqual(expected, result);
        }
    }
}
