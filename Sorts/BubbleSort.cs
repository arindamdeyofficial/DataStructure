using System;

namespace Sorts
{

    public static class BubbleSort
    {
        public static int[] Sort(int[] arr, bool asc = true)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if ((asc && (arr[j] < arr[j + 1])) || (!asc && (arr[j] > arr[j + 1])))
                    {
                         Swap(arr, j, j+1);
                    }
                }
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
