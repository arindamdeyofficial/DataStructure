using System;

namespace Sorts
{
    //Hoare partition scheme
    //two indices that start at the ends of the array being partitioned, then move toward each other, 
    //until they detect an inversion: a pair of elements, one greater than or equal to the pivot, 
    //one lesser or equal, that are in the wrong order relative to each other. The inverted elements are then swapped
    
    //More efficient than Lomuto 
    
    //    algorithm quicksort(A, lo, hi) is
    //    if lo<hi then
    //        p := partition(A, lo, hi)
    //        quicksort(A, lo, p)
    //        quicksort(A, p + 1, hi)

    //algorithm partition(A, lo, hi) is
    //    pivot := A[⌊(hi + lo) / 2⌋]
    //    i := lo - 1
    //    j := hi + 1
    //    loop forever
    //        do
    //            i := i + 1
    //        while A[i] < pivot
    //        do
    //            j := j - 1
    //        while A[j] > pivot
    //        if i ≥ j then
    //            return j
    //        swap A[i] with A[j]

    public static class QuickSortHoare
    {
        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low - 1, j = high + 1;

            while (true)
            {
                // Find leftmost element greater 
                // than or equal to pivot 
                do
                {
                    i++;
                } while (arr[i] < pivot);

                // Find rightmost element smaller 
                // than or equal to pivot 
                do
                {
                    j--;
                } while (arr[j] > pivot);

                // If two pointers met. 
                if (i >= j)
                    return j;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                //swap(arr[i], arr[j]); 
            }
        }
        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index,  
                arr[p] is now at right place */
                int pi = Partition(arr, low, high);

                // Separately sort elements before 
                // partition and after partition 
                Sort(arr, low, pi);
                Sort(arr, pi + 1, high);
            }
        }
        public static void SortDefault(int[] arr)
        {
            int n = arr.Length;
            Sort(arr, 0, n - 1);
        }
    }
}
