using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepeatedString
{
    public static class Solution
    {
        // Complete the repeatedString function below.
        public static long repeatedString(string s, long n)
        {
            var lengthS = s.Length;

            if (lengthS == 1)
            {
                if (!s.Equals("a"))
                {
                    return 0;
                }
                return n;
            }

            long countA = s.Count(c => c.Equals('a'));

            long repetitions = n / s.Length;
            long remmainning = n % s.Length;
            long totalCount = repetitions * countA;

            string remainderString = s.Substring(0, (int)remmainning);

            if (remmainning == 0)
            {
                return totalCount;
            }

            return totalCount + remainderString.Take((int)remmainning).Count(c => c.Equals('a'));
        }
    }
}
