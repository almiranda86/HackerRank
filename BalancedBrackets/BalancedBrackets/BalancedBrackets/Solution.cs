using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedBrackets
{
    public class Solution
    {
        public static string isBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();

            char[] braces = s.ToCharArray();

            for (int i = 0; i < braces.Length; i++)
            {
                if (braces[i].Equals('(') || braces[i].Equals('[') || braces[i].Equals('{'))
                    stack.Push(braces[i]);

                if (braces[i].Equals(')') || braces[i].Equals(']') || braces[i].Equals('}'))
                {
                    if (stack.Count == 0)
                    {
                        return "NO";
                    }
                    else if (!matchBraces(stack.Pop(), braces[i]))
                    {
                        return "NO";
                    }
                }
            }


            if (stack.Count == 0)
                return "YES";
            else
            {
                return "NO";
            }
        }

        static Boolean matchBraces(char char1, char char2)
        {
            if (char1 == '(' && char2 == ')')
                return true;
            else if (char1 == '{' && char2 == '}')
                return true;
            else if (char1 == '[' && char2 == ']')
                return true;
            else
                return false;
        }
    }
}
