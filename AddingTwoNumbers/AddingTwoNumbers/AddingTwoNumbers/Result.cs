using System;
using System.Collections.Generic;
using System.Text;

namespace AddingTwoNumbers
{
    public static class Result
    {

        /*
         * Complete the 'addNumbers' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. FLOAT a
         *  2. FLOAT b
         */

        public static int addNumbers(float a, float b)
        {
            float result = a + b;

            return (int)Math.Round(result);
        }

    }
}
