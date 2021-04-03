using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectingStocks
{
    public static class Result
    {
        /*
     * Complete the 'selectStock' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER saving
     *  2. INTEGER_ARRAY currentValue
     *  3. INTEGER_ARRAY futureValue
     */

        public static int selectStock(int saving, List<int> currentValue, List<int> futureValue)
        {
            if (saving == 0)
                return 0;

            if (currentValue.Count != futureValue.Count)
                return 0;

            int totalStocks = currentValue.Count;

            List<int> results = new List<int>();

            for (int idx = 0; idx < totalStocks; idx++)
            {
                results.Add(futureValue[idx] - currentValue[idx]);
            }

            List<int> stocksBuyed = new List<int>();

            while (results.Count != 0)
            {
                var buy = results.Max();

                var index = results.IndexOf(buy);

                int currentCur = currentValue.ElementAt(index);

                if (saving >= currentCur)
                {
                    stocksBuyed.Add(buy);
                    saving = saving - currentCur;
                    results.RemoveAt(index);
                    currentValue.RemoveAt(index);
                }
                else
                {
                    results.RemoveAt(index);
                    currentValue.RemoveAt(index);
                }
            }

            return stocksBuyed.Sum() > 0 ? stocksBuyed.Sum() : 0;
        }
    }
}
