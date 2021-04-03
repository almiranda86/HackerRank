using System.Collections.Generic;
using System.Linq;

namespace ArraysLeftRotation
{
    public class Solution
    {
        public static int[] rotLeft(int[] a, int d)
        {
            var filterArray = a.Take(d);

            var remainningFilterArray = a.Skip(d);

            List<int> newArray = new List<int>();
            newArray.AddRange(remainningFilterArray);
            newArray.AddRange(filterArray);

            return newArray.ToArray();
        }
    }
}
