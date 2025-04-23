using System;

namespace Sorts
{
    public static class InsertionSort
    {        
        public static int[] Sort(int[] arr, bool asc = true)
        {
            for (int i = 1; i < arr.Length; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && ((asc && (arr[j] > key)) || (!asc && (arr[j] < key))))
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }
    }
}
