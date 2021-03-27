using System;
using System.Collections.Generic;
using System.Text;

namespace LastAndSecondLast
{
    public static class Result
    {

        /*
         * Complete the 'lastLetters' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING word as parameter.
         */

        public static string lastLetters(string word)
        {
            char[] wordArray = word.ToCharArray();

            int lastPosition = wordArray.Length - 1;
            int secondLastPosition = wordArray.Length - 2;

            string response = $"{wordArray[lastPosition]} {wordArray[secondLastPosition]}";

            return response;
        }

    }
}
