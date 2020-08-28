using System;
using System.Collections.Generic;
using System.IO;

namespace SockMerchant
{
    public class Program
    {
        /// <summary>
        ///John works at a clothing store. 
        ///He has a large pile of socks that he must pair by color for sale. 
        ///Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
        ///For example, there are socks with colors.
        ///There is one pair of color  and one of color . 
        ///There are three odd socks left, one of each color. 
        ///The number of pairs is .
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        /// <summary>
        /// Complete the sockMerchant function in the editor below.
        /// It must return an integer representing the number of matching pairs of socks that are available
        /// The first line contains an integer , the number of socks represented in .
        /// The second line contains  space-separated integers describing the colors of the socks in the pile.
        /// </summary>
        /// <param name="n">the number of socks in the pile</param>
        /// <param name="ar">the colors of each sock</param>
        /// <returns></returns>
        public static int sockMerchant(int n, int[] ar)
        {
            int response = 0;

            if (ar.Length != n)
                return response;

            List<int> aux = new List<int>();
            for(var i = 0; i < ar.Length; i++)
            {
                if (!aux.Contains(ar[i]))
                {
                    aux.Add(ar[i]);
                }
                else
                {
                    aux.Remove(ar[i]);
                    response++;
                }
            }
            
            return response;
        }
    }
}
