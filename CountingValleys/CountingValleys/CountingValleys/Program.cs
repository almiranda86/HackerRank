using System;

namespace CountingValleys
{
    /// <summary>
    /// Gary is an avid hiker. 
    /// He tracks his hikes meticulously, paying close attention to small details like topography. 
    /// During his last hike he took exactly  steps. For every step he took, he noted if it was an uphill, or a downhill, step. 
    /// Gary's hikes start and end at sea level and each step up or down represents a  unit change in altitude. We define the following terms:
    ///A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
    ///A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
    ///Given Gary's sequence of up and down steps during his last hike, find and print the number of valleys he walked through.
    ///For example, if Gary's path is DDUUUUDD, he first enters a valley  units deep. 
    ///Then he climbs out an up onto a mountain  units high. 
    ///Finally, he returns to sea level and ends his hike.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            string s = "UDDDUDUU";
            Console.WriteLine(countingValleys(n, s).ToString());
        }

        /// <summary>
        /// Complete the countingValleys function in the editor below. 
        /// It must return an integer that denotes the number of valleys Gary traversed.
        /// countingValleys has the following parameter(s):
        /// </summary>
        /// <param name="n">the number of steps Gary takes</param>
        /// <param name="s"> a string describing his path</param>
        /// <returns></returns>
        public static int countingValleys(int n, string s)
        {
            int response = 0;

            if (n != s.Length)
                return response;

            int seaLevel = 0;
            int valleys = 0;

            char[] charS = s.ToCharArray();

            for (var i = 0; i < charS.Length; i++)
            {

                if (charS[i].Equals('D'))
                {
                    seaLevel--;
                }

                if (charS[i].Equals('U'))
                {
                    seaLevel++;
                }

                if (seaLevel == 0 && charS[i].Equals('U'))
                {
                    valleys++;
                }
            }

            response = valleys;
            return response;
        }
    }
}
