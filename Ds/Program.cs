﻿using System;

namespace Ds
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            int[] arr = { 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
            10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5};
            int n = arr.Length;
            watch.Start();
            MergeSort.Sort(arr, 0 , n-1);
            MergeSort.PrintArray(arr);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.Elapsed}");
        }
    }
}