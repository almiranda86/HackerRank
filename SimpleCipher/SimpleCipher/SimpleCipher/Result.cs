using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCipher
{
    public static class Result
    {

        /*
         * Complete the 'simpleCipher' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING encrypted
         *  2. INTEGER k
         */

        public static string simpleCipher(string encrypted, int k)
        {
            List<char> alphabet = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            string response = "";

            char x = new char();

            foreach (char c in encrypted.ToCharArray())
            {
                int positionC = alphabet.IndexOf(c);

                for (int i = 0; i <= k; i++)
                {
                    x = alphabet[positionC];
                    positionC--;

                    if (positionC < 0)
                        positionC = alphabet.Count - 1;
                }

                response += x;
            }

            return response;
        }

    }
}
