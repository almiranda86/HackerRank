using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ChooseAFlaskConsole
{
    class Result
    {

        /*
         * Complete the 'chooseFlask' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY requirements
         *  2. INTEGER flaskTypes
         *  3. 2D_INTEGER_ARRAY markings
         */

        public static int chooseFlask(List<int> requirements, int flaskTypes, List<List<int>> markings)
        {
            return 0;
        }

    }

    class Solution
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int requirementsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> requirements = new List<int>();

            for (int i = 0; i < requirementsCount; i++)
            {
                int requirementsItem = Convert.ToInt32(Console.ReadLine().Trim());
                requirements.Add(requirementsItem);
            }

            int flaskTypes = Convert.ToInt32(Console.ReadLine().Trim());

            int markingsRows = Convert.ToInt32(Console.ReadLine().Trim());
            int markingsColumns = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> markings = new List<List<int>>();

            for (int i = 0; i < markingsRows; i++)
            {
                markings.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(markingsTemp => Convert.ToInt32(markingsTemp)).ToList());
            }

            int result = 0;

            try
            {
                result = Result.chooseFlask(requirements, flaskTypes, markings);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();

        }
    }
}