using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeHeightOfABinaryTree;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodHeight()
        {
            int t = 1;
            Node root = null;

            //int[] nodeValues = new int[] { 7, 6, 4, 5, 1, 2, 3 };
            //int[] nodeValues = new int[] { 4, 5, 7, 1, 3 };
            int[] nodeValues = new int[] { 15 };

            while (t-- > 0)
            {
                int data = nodeValues[t];
                root = Node.insert(root, data);
            }

            int height = Node.height(root);

            Assert.AreEqual(3, height);
        }


        [TestMethod]
        public void TestMethodOrderTraversal()
        {
            int t = 6;
            Node root = null;

            int[] nodeValues = new int[] { 4, 3, 6, 5, 2, 1 };

            while (t-- > 0)
            {
                int data = nodeValues[t];
                root = Node.insert(root, data);
            }

            string order = Node.levelOrder(root);

            Assert.AreEqual("1 2 5 3 6 4", order);
        }
    }
}
