using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MeetupSchedule
{
    /// <summary>
    /// A start-up owner is looking to meet new investors to get some founds for his company.
    /// Each investor has a tight schedule that the owner has to respect.
    /// Given the schedules of the days investors are available, determine how many meetings the owner can schedule
    /// Note that the owner can only have one meeting per day.
    /// 
    /// The schedule consists of two integer arrays, firstDay and lastDay.
    /// Each elemente in the firstDay represents the first day an investor is available, and each element in lastDay represents the last day an investor is available, both inclusive.
    /// 
    /// Example:
    /// firstDay = [1,2,3,3,3]
    /// lastDay = [2,2,3,4,4]
    /// 
    /// There are 5 investors [I-0, I-1, I-2, I-3, I-4]
    /// The investor I-0 is available from day 1 to day 2 inclusive [1,2]
    /// The investor I-1 is available day 2 only [2,2]
    /// The investor I-3 and I-4 are available from day 3 to day 4 only [3,3]
    /// 
    /// The owner can only meet 4 investors out of 5
    /// I-0 in day 1; I-1 in day 2; I-2 in day 3 and I-3 in day 4
    /// 
    /// </summary>

    public class Result
    {

        /*
         * Complete the 'countMeetings' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY firstDay
         *  2. INTEGER_ARRAY lastDay
         */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstDay">an array of integers where the value of each element is the first day the investor is available to meet</param>
        /// <param name="lastDay">an array of integers where the value of each element is the last day the investor is available to meet</param>
        /// <returns>
        /// an integer that represents the maximum number of meetins possible
        /// </returns>
        /// 



        private static object _lockObj = new object();
        private static List<int> _firstDay = new List<int>();
        private static List<int> _lastDay = new List<int>();
        private static List<int> _possibleMeetings;

        public static int countMeetings(List<int> firstDay, List<int> lastDay)
        {
            _possibleMeetings = new List<int>();

            if (firstDay.Count == 0)
                return 0;
            else
                _firstDay = firstDay;

            if (lastDay.Count == 0)
                return 0;
            else
                _lastDay = lastDay;

            if (firstDay.Count != lastDay.Count())
                return 0;


            List<int> possibleMeetings = new List<int>();

            int i = 0;

            while(i < firstDay.Count)
            {
                int fd = firstDay[i];
                int ld = lastDay[i];

                if ((fd <= ld) && !possibleMeetings.Contains(fd))
                {
                    possibleMeetings.Add(fd);
                }
                else if (!possibleMeetings.Contains(ld))
                {
                    possibleMeetings.Add(ld);
                }

                i++;
            }

            return possibleMeetings.Count;

            return possibleMeetings.Count;
        }
        static int[] _values = Enumerable.Range(0, 1000).ToArray();
        static void Example(int x)
        {
            int fd = _firstDay[x];
            int ld = _lastDay[x];

            if (fd <= ld && !_possibleMeetings.Contains(fd))
            {
                _possibleMeetings.Add(fd);
            }
            else if (!_possibleMeetings.Contains(ld))
            {
                _possibleMeetings.Add(ld);
            }
        }

        //private static void DoTheDance(List<int> firstDay, List<int> lastDay)
        //{
        //    foreach (int fd in firstDay)
        //    {
        //        foreach (int ld in lastDay)
        //        {
        //            if (fd == ld && !possibleMeetings.Contains(fd))
        //            {
        //                possibleMeetings.Add(fd);
        //                break;
        //            }
        //            else if (fd < ld && !possibleMeetings.Contains(fd))
        //            {
        //                possibleMeetings.Add(fd);
        //                break;
        //            }
        //            else if (!possibleMeetings.Contains(ld))
        //            {
        //                possibleMeetings.Add(ld);
        //                break;
        //            }
        //        }
        //    }
        //}
    }
}
