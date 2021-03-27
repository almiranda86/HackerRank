using CloudFrontCaching;
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
            //nodes
            int n = 8;
            
            //size
            int m = 4;

            List<string> edges = new List<string>();
            edges.Add("8 1");
            edges.Add("5 8");
            edges.Add("7 3");
            edges.Add("8 6");


            var result = Solution.connectedSum(n, edges);

        }
    }
}

