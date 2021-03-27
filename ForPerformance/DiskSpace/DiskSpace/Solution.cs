using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ClassLibrary1
{
    public static class Solution
    {
        public static int Segment(int x, List<int> space)
        {
            List<int> minimum = new List<int>();
            List<List<int>> parts = new List<List<int>>();

            if (x == 1)
                return space.Max();

            int lp = 0;
            int range = space.Count - x;
            do
            {
                List<int> p = new List<int>();
                int i = 0;

                for (; i < x; i++)
                {
                    p.Add(space[i]);
                }

                parts.Add(p);

                lp = space.IndexOf(space[i - range]);

                space.RemoveRange(0, lp);

                minimum.Add(p.Min());

            } while (parts.Count != x);


            return minimum.Max();
        }
    }
}
