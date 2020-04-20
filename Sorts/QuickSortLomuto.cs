using System;

namespace Sorts
{
    //Lomuto partition scheme
    //pivot that is typically the last element in the array.

    //    algorithm quicksort(A, lo, hi) is
    //    if lo<hi then
    //        p := partition(A, lo, hi)
    //        quicksort(A, lo, p - 1)
    //        quicksort(A, p + 1, hi)

    //algorithm partition(A, lo, hi) is
    //    pivot := A[hi]
    //    i := lo
    //    for j := lo to hi do
    //        if A[j] < pivot then
    //            swap A[i] with A[j]
    //            i := i + 1
    //    swap A[i] with A[hi]
    //    return i

    public static class QuickSortLomuto
    {
        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i+1];
            arr[i+1] = arr[high];
            arr[high] = temp1;

            return i+1;
        }
        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(arr, low, high);
                Sort(arr, low, p - 1);
                Sort(arr, p + 1, high);
            }
        }
        public static void SortDefault(int[] arr)
        {
            int n = arr.Length;
            Sort(arr, 0, n - 1);
        }
    }
}
