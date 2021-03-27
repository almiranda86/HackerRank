using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheRunningMedian
{

    public static class Solution
    {
        public static double[] runningMedian(int[] a)
        {
            double[] result = new double[a.Length];

            int x = 1;

            for (int i = 0; i < a.Length; i++)
            {
                bool even = x % 2 == 0 ? true : false;

                int y = x / 2;

                var aux = a.Take(x).OrderBy(n => n);

                if (even)
                {
                    result[i] = ((double)aux.ElementAt(y - 1) + (double)aux.ElementAt(y)) / 2;
                }
                else
                {
                    result[i] = aux.ElementAt(y);
                }

                x++;
            }


            //double[] result = new double[a.Length];

            //List<int> aux = new List<int>();

            //int i = 1;

            //var aux2 = a.Take(i).OrderByDescending(x => x);

            //foreach (int n in a)
            //{
            //    aux.Add(n);

            //    aux.Sort();

            //    int mid = aux.Count / 2;

            //    bool even = aux.Count % 2 == 0 ? true : false;

            //    if (even)
            //    {
            //        result[i] = ((double)aux[mid - 1] + (double)aux[mid]) / 2;
            //    }
            //    else
            //    {
            //        result[i] = aux[mid];
            //    }

            //    i++;
            //}

            return result;
        }


        public static double[] findMediaJava(int[] a)
        {
            int[] aux = new int[a.Length];
            double[] result = new double[a.Length];
            int x = 0;

            for (int i = 0; i < a.Length; i++)
            {
                aux[i] = a[i];
                x++;

                if (i == 0)
                {
                    result[i] = (double)aux[i];
                }
                else
                {
                    Array.Sort(aux, 0, i + 1);
                    int y = x / 2;

                    if (x % 2 == 0)
                        result[i] = (aux[y] + aux[y - 1]) / 2.0;
                    else
                        result[i] = aux[y];
                }
            }

            return result;
        }

        public static double[] findMedia(int[] a)
        {
            double[] result = new double[a.Length];

            double med = a[0];

            List<int> smallHeap = new List<int>();

            List<int> bigHeap = new List<int>();
            smallHeap.Add(a[0]);
            result[0] = med;

            for (int i = 1; i < a.Length; i++)
            {
                int x = a[i];

                if (smallHeap.Count > bigHeap.Count)
                {
                    if (x < med)
                    {
                        smallHeap.Sort();
                        smallHeap.Reverse();
                        bigHeap.Add(smallHeap[0]);
                        smallHeap.RemoveAt(0);
                        smallHeap.Add(x);
                    }
                    else
                    {
                        bigHeap.Add(x);
                    }

                    smallHeap.Sort();
                    smallHeap.Reverse();
                    bigHeap.Sort();
                    med = (double)(smallHeap[0] + bigHeap[0]) / 2;
                }
                else if (smallHeap.Count == bigHeap.Count)
                {
                    if (x < med)
                    {
                        smallHeap.Add(x);
                        smallHeap.Sort();
                        smallHeap.Reverse();
                        med = (double)smallHeap[0];
                    }
                    else
                    {
                        bigHeap.Add(x);
                        bigHeap.Sort();
                        med = (double)bigHeap[0];
                    }
                }
                else
                {
                    if (x > med)
                    {
                        bigHeap.Sort();
                        smallHeap.Add(bigHeap[0]);
                        bigHeap.RemoveAt(0);
                        bigHeap.Add(x);
                    }
                    else
                    {
                        smallHeap.Add(x);
                    }

                    bigHeap.Sort();
                    smallHeap.Sort();
                    smallHeap.Reverse();
                    med = (double)(smallHeap[0] + bigHeap[0]) / 2;

                }
                result[i] = med;
            }

            return result;
        }
    }
}
