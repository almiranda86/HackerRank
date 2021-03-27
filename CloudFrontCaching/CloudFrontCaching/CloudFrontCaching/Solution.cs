using System;
using System.Collections.Generic;
using System.Globalization;

namespace CloudFrontCaching
{
    public class Node
    {
        public Dictionary<int, Node> children = new Dictionary<int, Node>();

        public int value;
    }

    public static class Solution
    {
        public static int connectedSum(int n, List<string> edges)
        {
            List<Node> connections = new List<Node>();

            var arr = edges.ToArray();

            Node root = new Node();

            foreach (var e in edges)
            {
                var edgeLeaf = e.Split(" ");

                int x = Convert.ToInt32(edgeLeaf[0]);
                int y = Convert.ToInt32(edgeLeaf[1]);

                Node curr = root;

                if (curr.children.ContainsKey(x) || curr.children.ContainsKey(y))
                {
                    curr = curr.children[x];
                }
                else if (curr.value == x || curr.value == y)
                {
                    root = new Node();
                    root.children[y] = curr;
                    root.value = x;
                }
                else
                {
                    curr = new Node();
                    curr.value = x;
                    curr.children[y] = new Node() { value = y };
                    root = curr;
                }
                
                connections.Add(root);
            }

            return 0;
        }

        public static Node findChildren(int n, Node curr)
        {
            if (!curr.children.ContainsKey(n))
            {
                return null;
            }
            else
            {
                curr = curr.children[n];
            }

            return curr;
        }
    }
}