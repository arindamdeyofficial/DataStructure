using System;

namespace Sorts
{
    //    MergeSort(arr[], l, r)
    //If r > l
    //     1. Find the middle point to divide the array into two halves:  
    //             middle m = (l + r) / 2
    //     2. Call mergeSort for first half:   
    //             Call mergeSort(arr, l, m)
    //     3. Call mergeSort for second half:
    //             Call mergeSort(arr, m+1, r)
    //     4. Merge the two halves sorted in step 2 and 3:
    //             Call merge(arr, l, m, r)
    public static class MergeSort
    {        
        public static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Same as (l+r)/2, but avoids overflow for 
                // large l and h 
                int m = l + (r - l) / 2;

                // Sort first and second halves 
                Sort(arr, l, m);
                Sort(arr, m + 1, r);

                Merge(arr, l, m, r);
            }

        }
        public static void Merge(int[] arr, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            /* create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /* Copy data to temp arrays L[] and R[] */
            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];

            /* Merge the temp arrays back into arr[l..r]*/
            i = 0; // Initial index of first subarray 
            j = 0; // Initial index of second subarray 
            k = l; // Initial index of merged subarray 
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy the remaining elements of L[], if there 
               are any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy the remaining elements of R[], if there 
               are any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
