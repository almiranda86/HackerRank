using System;
using System.Linq;

namespace EqualizeTheArray
{

    /// <summary>
    /// Karl has an array of integers. He wants to reduce the array until all remaining elements are equal. 
    /// Determine the minimum number of elements to delete to reach his goal.
    /// For example, if his array is arr=[1,2,2,3], we see that he can delete the 2 elements 1 and 3 leaving arr=[2,2].
    /// He could also delete both twos and either the 1 or the 3, but that would take 3 deletions.
    /// The minimum number of deletions is 2.
    /// </summary>
    public class Equalize
    {

        /// <summary>
        /// Complete the equalizeArray function in the editor below. 
        /// It must return an integer that denotes the minimum number of deletions required.
        ///equalizeArray has the following parameter(s) :
        ///Input Format
        ///The first line contains an integer, the number of elements in .
        ///The next line contains  space-separated integers.
        /// </summary>
        /// <param name="arr">an array of integers</param>
        /// <returns></returns>
        public static int equalizeArray(int[] arr)
        {
            int response = 0;

            if(arr.Length == 0)
                return response;

            var grouped = arr.GroupBy(a => a);

            int maxOccur = grouped.Max(a => a.Count());

            response = arr.Length - maxOccur;

            return response;
        }
    }
}
