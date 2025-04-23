using System;

namespace Sorts
{
    public static class MergeSort
    {
        public static int[] Sort(int[] arr, int l, int r, bool asc = true)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                Sort(arr, l, m, asc);
                Sort(arr, m + 1, r, asc);

                Merge(arr, l, m, r, asc);
            }
            return arr;
        }

        public static void Merge(int[] arr, int l, int m, int r, bool asc)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (int j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];

            int ii = 0, jj = 0, k = l;

            while (ii < n1 && jj < n2)
            {
                if ((asc && L[ii] <= R[jj]) || (!asc && L[ii] >= R[jj]))
                {
                    arr[k++] = L[ii++];
                }
                else
                {
                    arr[k++] = R[jj++];
                }
            }

            while (ii < n1)
                arr[k++] = L[ii++];
            while (jj < n2)
                arr[k++] = R[jj++];
        }
    }
}
