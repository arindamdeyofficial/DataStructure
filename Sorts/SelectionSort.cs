using System;

namespace Sorts
{
    
    public static class SelectionSort
    {
        public static int[] Sort(int[] arr, bool asc = true)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // Find the minimum or maximum element in the unsorted array
                int index = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((asc && arr[j] < arr[index]) || (!asc && arr[j] > arr[index]))
                    {
                        index = j;
                    }
                }
                // Swap the found minimum or maximum element with the first element
                Swap(arr, index, i);
            }
            return arr;
        }
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
