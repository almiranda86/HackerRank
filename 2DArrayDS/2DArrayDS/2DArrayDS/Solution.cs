using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArrayDS
{
    public static class Solution
    {
        public static int hourglassSum(int[][] arr)
        {
            int limitX = 3;
            int limitY = 3;
            int totalSum = int.MinValue;

            for (var y = 0; y <= limitY; y++)
            {
                for (var x = 0; x <= limitX; x++)
                {
                    var sum = arr[y][x] + arr[y][x + 1] + arr[y][x + 2];
                    sum += arr[y + 1][x + 1];
                    sum += arr[y + 2][x] + arr[y + 2][x + 1] + arr[y + 2][x + 2];

                    if (totalSum < sum)
                        totalSum = sum;
                }
            }

            return totalSum;
        }
    }
}
