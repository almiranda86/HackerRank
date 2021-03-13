using System;
using System.Collections.Generic;

namespace Contacts
{
    public class Node
    {
        public Dictionary<char, Node> children = new Dictionary<char, Node>();

        public int count = 1;
    }

    public static class Solution
    {
        public static int[] contacts(string[][] queries)
        {
            List<int> found = new List<int>();

            Node root = new Node();

            foreach (var item in queries)
            {
                if (item[0].Equals("add"))
                {
                    Node curr = root;

                    foreach (char c in item[1])
                    {
                        if (curr.children.ContainsKey(c))
                        {
                            curr = curr.children[c];
                            curr.count = curr.count + 1;
                        }
                        else
                        {
                            Node newNode = new Node();
                            curr.children[c] = newNode;
                            curr = newNode;
                        }
                    }
                }
                else
                {
                    found.Add(findPartial(item[1], root));
                }
            }

            return found.ToArray();
        }

        public static int findPartial(string partial, Node curr)
        {
            foreach (char c in partial)
            {
                if (!curr.children.ContainsKey(c))
                {
                    return 0;
                }
                else
                {
                    curr = curr.children[c];
                }
            }

            return curr.count;
        }

    }
}
