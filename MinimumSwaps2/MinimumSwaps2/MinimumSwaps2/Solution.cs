using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinimumSwaps2
{

    /*
    Think about this example:
    4 3 1 2
    
    We start and know that 4 should not be the start.
    We know that in each set 1 will be the start. So 4 needs to move. But where? 
    Simple. 
    
    As the numbers match the spaces in the array, send them to those places.
    4 - 1 = 3, the place it needs to go in the array. 
    
    So we switch it there. 
    Now we have the following:
    2 3 1 4
    
    And we repeat the process.
    2 doesn't belong. It needs to go to the 2 - 1 place, or the 1 place. 
    So we switch it:
    3 2 1 4
    
    3 doesn't belong. It needs to go to the 3 - 1 or 2 place in the array:
    1 2 3 4
    
    Keep track of those swaps with incrementation, and you have your answer.      
    */
    public static class Solution
    {
        private static int swaps;
        public static int minimumSwaps(int[] arr)
        {
            swaps = 0;

            if (IsSorted(arr))
                return 0;

            int i = 0;

            while (i < arr.Length)
            {
                if (arr[i] != i + 1)
                {
                    int temp = arr[i];
                    arr[i] = arr[arr[i] - 1];
                    arr[temp - 1] = temp;
                    swaps++;
                }
                else i++;
            }

            return swaps;
        }

        private static void MinhaSolucao(int[] arr)
        {
            int lengthArray = arr.Length;

            int halfArray = lengthArray / 2;

            int remmainingArray = lengthArray % 2;

            if (remmainingArray > 0)
            {
                var frontHalf = arr.Take(halfArray + 1).ToArray();
                if (frontHalf.Length % 2 == 1)
                {
                    frontHalf = arr.Take(halfArray + 2).ToArray();
                }
                SelectionSort(frontHalf);
                int frontHalfEnd = frontHalf.Length - 1;
                var backHalf = arr.Skip(halfArray + 1).Prepend(frontHalf[frontHalfEnd]).ToArray();
                if (backHalf.Length % 2 == 1)
                {
                    backHalf = arr.Skip(halfArray + 2).Prepend(frontHalf[frontHalfEnd]).ToArray();
                }
                SelectionSort(backHalf);
            }
            else
            {
                var frontHalf = arr.Take(halfArray).ToArray();
                if (frontHalf.Length % 2 == 1)
                {
                    frontHalf = arr.Take(halfArray + 2).ToArray();
                }
                SelectionSort(frontHalf);
                
                var backHalf = arr.Skip(halfArray - 2).ToArray();
                if (backHalf.Length % 2 == 1)
                {
                    backHalf = arr.Skip(halfArray - 2).ToArray();
                }
                SelectionSort(backHalf);
            }
        }

        private static void SelectionSort(int[] vetor)
        {
            int min, aux;

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++)
                    if (vetor[j] < vetor[min])
                        min = j;

                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                    swaps++;
                }
            }
        }


        private static void GnomeSort(int[] arr)
        {
            int p = 0;
            int aux;
            while (p < (arr.Length - 1))
            {
                if (arr[p] > arr[p + 1])
                {
                    aux = arr[p];
                    arr[p] = arr[p + 1];
                    arr[p + 1] = aux;
                    swaps++;
                    if (p > 0)
                    {
                        p -= 2;
                    }
                }
                p++;
            }
        }

        private static void ShellSort(int[] vetor)
        {
            int h = 1;
            int n = vetor.Length;

            while (h < n)
            {
                h = h * 3 + 1;
            }

            h = h / 3;
            int c, j;
            while (h > 0)
            {
                for (int i = h; i < n; i++)
                {
                    c = vetor[i];
                    j = i;
                    while (j >= h && vetor[j - h] > c)
                    {
                        vetor[j] = vetor[j - h];
                        j = j - h;
                    }
                    vetor[j] = c;
                    swaps++;
                }
                h = h / 2;
            }
        }

        private static void MinMaxSelectionSort(int[] arr, int n)
        {
            for (int i = 0, j = n - 1;
                     i < j; i++, j--)
            {
                int min = arr[i], max = arr[i];
                int min_i = i, max_i = i;
                for (int k = i; k <= j; k++)
                {
                    if (arr[k] > max)
                    {
                        max = arr[k];
                        max_i = k;
                    }

                    else if (arr[k] < min)
                    {
                        min = arr[k];
                        min_i = k;
                    }
                }

                swap(arr, i, min_i);

                if (arr[min_i] == max)
                {
                    swap(arr, j, min_i);
                }
                else
                {
                    swap(arr, j, max_i);
                }                    
            }
        }

        private static int[] swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            swaps++;
            return arr;
        }


        public static void BubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comparacoes = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        swaps++;
                    }
                }
            }
        }


        private static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
        }

        private static void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                    swaps++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                    swaps++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                    swaps++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                    swaps++;
                }
            }
        }


        private static void QuickSort(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                        swaps++;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = p;
                swaps++;

                QuickSort(vetor, inicio, f - 1);
                QuickSort(vetor, f + 1, fim);
            }
        }


        public static List<int> BucketSort(params int[] x)
        {
            List<int> result = new List<int>();

            int numOfBuckets = 5;

            List<int>[] buckets = new List<int>[numOfBuckets];

            for (int i = 0; i < numOfBuckets; i++)
                buckets[i] = new List<int>();

            for (int i = 0; i < x.Length; i++)
            {
                int buckitChoice = (x[i] / numOfBuckets);
                buckets[buckitChoice].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                int[] temp = SelectionSortList(buckets[i]);
                result.AddRange(temp);
            }
            return result;
        }

        //SelectionSortList w/ ListInput
        public static int[] SelectionSortList(List<int> input)
        {

            int min, aux;

            for (int i = 0; i < input.Count - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < input.Count; j++)
                    if (input[j] < input[min])
                        min = j;

                if (min != i)
                {
                    aux = input[min];
                    input[min] = input[i];
                    input[i] = aux;
                    swaps++;
                }
            }

            return input.ToArray();
        }



        public static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1].CompareTo(arr[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
