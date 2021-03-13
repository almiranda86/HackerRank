using System;
using System.Collections.Generic;
using System.IO;

namespace MeetupSchec
{
    class Soltution
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int firstDayCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> firstDay = new List<int>();

            for (int i = 0; i < firstDayCount; i++)
            {
                int firstDayItem = Convert.ToInt32(Console.ReadLine().Trim());
                firstDay.Add(firstDayItem);
            }

            int lastDayCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> lastDay = new List<int>();

            for (int i = 0; i < lastDayCount; i++)
            {
                int lastDayItem = Convert.ToInt32(Console.ReadLine().Trim());
                lastDay.Add(lastDayItem);
            }

            int result = Result.countMeetings(firstDay, lastDay);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }


    class Result
    {

        /*
         * Complete the 'countMeetings' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY firstDay
         *  2. INTEGER_ARRAY lastDay
         */

        public static int countMeetings(List<int> firstDay, List<int> lastDay)
        {
            if (firstDay.Count == 0)
                return 0;

            if (lastDay.Count == 0)
                return 0;

            if (firstDay.Count != lastDay.Count)
                return 0;

            List<int> possibleMeetings = new List<int>();

            foreach (int fd in firstDay)
            {
                foreach (int ld in lastDay)
                {
                    if (fd == ld && !possibleMeetings.Contains(fd))
                    {
                        possibleMeetings.Add(fd);
                    }
                    else if (fd < ld && !possibleMeetings.Contains(fd))
                    {
                        possibleMeetings.Add(fd);
                    }
                    else if (!possibleMeetings.Contains(ld))
                    {
                        possibleMeetings.Add(ld);
                    }
                }
            }
            return possibleMeetings.Count;
        }

    }
}
