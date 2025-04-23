using System;

public static class HeapSort
{
    public static int[] Sort(int[] arr, bool asc = true)
    {
        int n = arr.Length;

        // Build heap (rearrange array)
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i, asc);

        // One by one extract elements from heap
        for (int i = n - 1; i > 0; i--)
        {
            // Move current root to end
            (arr[0], arr[i]) = (arr[i], arr[0]);

            // call max/min heapify on the reduced heap
            Heapify(arr, i, 0, asc);
        }
        return arr;
    }

    // To heapify a subtree rooted with node i
    static void Heapify(int[] arr, int n, int i, bool asc)
    {
        int extreme = i; // Initialize largest/smallest as root
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        // If left child is larger/smaller than root
        if (left < n && ((asc && arr[left] > arr[extreme]) || (!asc && arr[left] < arr[extreme])))
            extreme = left;

        // If right child is larger/smaller than largest/smallest so far
        if (right < n && ((asc && arr[right] > arr[extreme]) || (!asc && arr[right] < arr[extreme])))
            extreme = right;

        // If largest/smallest is not root
        if (extreme != i)
        {
            (arr[i], arr[extreme]) = (arr[extreme], arr[i]);
            Heapify(arr, n, extreme, asc); // Recursively heapify the affected sub-tree
        }
    }
}
