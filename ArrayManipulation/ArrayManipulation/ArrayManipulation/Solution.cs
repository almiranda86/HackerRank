using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayManipulation
{
    public static class Solution
    {
        public static long arrayManipulation(int n, int[][] queries)
        {
            int[] arr = new int[n];

            //BRUTE FORCE -> O(n*m)
            for (int i = 0; i < queries.Length; i++)
            {
                int beginChangeItem = queries[i][0] - 1;
                int endChangeItem = queries[i][1] - 1;
                int itemValue = queries[i][2];

                for (int j = beginChangeItem; j <= endChangeItem; j++)
                {
                    arr[j] += itemValue;
                }
            }

            return arr.Max();
        }

        public static long  stackOverflowSolution(int n, int[][] queries)
        {
            long[] computation = new long[n];

            //O(n)
            for (int i = 0; i < queries.Length; i++)
            {
                int a = queries[i][0] - 1;
                int b = queries[i][1] - 1;
                int k = queries[i][2];

                computation[a] += k;

                //PREFIX ALGORITHM CIRCUIR BREAK
                if (b + 1 < n)
                {
                    computation[b + 1] -= k;
                }
            }

            long max = 0; long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += computation[i];
                max = Math.Max(max, sum);
            }

            return max;
        }
    }
}
