using System;

namespace FizzBuzzChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            fizzBuzz(n);
        }

        /// <summary>
        /// Give a number n, for each integer i in the range from 1 to n inclusive
        /// print one per line as follows:
        /// If i is a multiple of both 3 and 5, print FizzBuzz
        /// If i is a multiple of 3 but not of 5, print Fizz
        /// If i is a multiple of 5 but not of 3, print Buzz
        /// If i is not a multiple of 3 or 5, print the value of i
        /// </summary>
        /// <param name="n"></param>
        static void fizzBuzz(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                string response = i.ToString();

                if (i % 3 == 0)
                {
                    response = "Fizz";
                }

                if (i % 5 == 0)
                {
                    response = "Buzz";
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    response = "FizzBuzz";
                }

                Console.WriteLine(response);
            }
        }
    }
}
