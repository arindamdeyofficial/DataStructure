using System;

namespace Sorts
{
    public static class Quicksort
    {        
        public static int[] Sort(int[] arr, int left, int right, bool asc = true)
        {
            if(left < right)
            {
                int pivotIndex = Partition(arr, left, right, asc);
                Sort(arr, left, pivotIndex - 1, asc);
                Sort(arr, pivotIndex + 1, right, asc);
            }
            return arr;
        }

        private static int Partition(int[] arr, int left, int right, bool asc)
        {
            int pivot = arr[right];
            for (int i = left; i < right; i++)
            {
                if ((asc && (arr[i] <= pivot)) || (!asc && (arr[i] > pivot)))
                {
                    Swap(arr, i, left);
                    left++;
                }
            }
            Swap(arr, left, right);
            return left;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
