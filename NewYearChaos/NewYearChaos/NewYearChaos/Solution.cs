using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearChaos
{
    public static class Solution
    {
        public static void minimumBribes(int[] q)
        {
            int bribes = 0;
            for (int i = q.Length - 1; i >= 0; i--)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                int x = Math.Max(0, q[i] - 2);

                for (int j = x; j < i; j++)
                    if (q[j] > q[i]) bribes++;
            }

            Console.WriteLine(bribes);
        }
    }
}
