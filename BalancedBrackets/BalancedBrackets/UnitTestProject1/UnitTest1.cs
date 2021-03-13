using BalancedBrackets;
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
            
            string[] expected = new string[] { "YES", "NO", "YES" };
            string[] brackets = new string[] { "}][}}(}][))]", "{{)[](}}", "{[()]}", "{[(])}", "{{[[(())]]}}" };
            int n = brackets.Length;

            for (int i = 0; i < n; i++)
            {
                var result = Solution.isBalanced(brackets[i]);
            }
        }
    }
}
