using System;

namespace Ds
{
    //Simple and small array

    //    i ← 1
    //while i<length(A)
    //  j ← i
    //    while j > 0 and A[j - 1] > A[j]
    //          swap A[j] and A[j - 1]
    //          j ← j - 1
    //    end while
    //    i ← i + 1
    //end while

    public static class InsertionSort
    {        
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}
