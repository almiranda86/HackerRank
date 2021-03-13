using System;
using System.Collections.Generic;

namespace LeadALife
{
    public class Result
    {
        public static int calculateProfit(int n, List<int> earning, List<int> cost, int e)
        {
            if (n == 0)
                return 0;

            if (e == 0)
                return 0;

            if (earning.Count == 0)
                return 0;

            if (cost.Count == 0)
                return 0;

            int units = 0;

            for (int i = 0; i < n; i++)
            {
                if (earning[i] <= cost[i] && i + 1 != n)
                {
                    continue;
                }
                else if (earning[i] <= cost[i] && i + 1 == n)
                {
                    units += e * earning[i];
                }
                else if (i + 1 == n)
                {
                    units += e * earning[i];
                }
                else
                {
                    units += (e * earning[i]) - (e * cost[i]);
                }
            }

            return units;
        }

    }
}
