using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace TreeHeightOfABinaryTree
{
    public class Node
    {
        public int _data;
        public Node _left;
        public Node _right;

        public Node(int data)
        {
            _data = data;
        }

        public static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root._data)
                {
                    cur = insert(root._left, data);
                    root._left = cur;
                }
                else
                {
                    cur = insert(root._right, data);
                    root._right = cur;
                }
                return root;
            }
        }

        public static int height(Node root)
        {
            // Write your code here.

            if (root == null || (root._left == null && root._right == null))
            {
                return 0;
            }
            else
            {
                int ld = height(root._left);
                int rd = height(root._right);

                if (ld > rd)
                {
                    return ld + 1;
                }
                else
                {
                    return rd + 1;
                }
            }
        }

        public static string levelOrder(Node root)
        {
            if (root == null)
            {
                return "";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);
                while (queue.Count != 0)
                {
                    Node tempNode = queue.Dequeue();
                    sb.Append(tempNode._data + " ");

                    /*Enqueue left child */
                    if (tempNode._left != null)
                    {
                        queue.Enqueue(tempNode._left);
                    }

                    /*Enqueue right child */
                    if (tempNode._right != null)
                    {
                        queue.Enqueue(tempNode._right);
                    }
                }

                return sb.ToString().TrimEnd();
            }
        }

        public static string inorderTraversal(Node root)
        {
            StringBuilder sb = new StringBuilder();

            if (root != null)
            {
                inorderTraversal(root._left);
                sb.Append(root._data + " ");
                inorderTraversal(root._right);
            }
            else
            {
                return "";
            }

            return sb.ToString();
        }

        public static string preorderTraversal(Node root)
        {
            StringBuilder sb = new StringBuilder();

            if (root != null)
            {
                sb.Append(root._data + " ");
                preorderTraversal(root._left);
                preorderTraversal(root._right);
            }
            else
            {
                return "";
            }

            return sb.ToString();
        }


        public void postorderTraversal(Node root)
        {
            StringBuilder sb = new StringBuilder();

            if (root != null)
            {
                postorderTraversal(root._left);
                postorderTraversal(root._right);
                sb.Append(root._data + " ");
            }
            else
            {
                return "";
            }

            return sb.ToString();
        }
    }
}
