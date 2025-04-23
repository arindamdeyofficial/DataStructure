using MathHelpers;
using Microsoft.AspNetCore.Mvc;
using Sorts;
using System.Diagnostics;

namespace Ds.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SortController : ControllerBase
    {
        private readonly ILogger<SortController> _logger;

        public SortController(ILogger<SortController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("QuickSort")]
        public string QuickSortDo(string input = "4,5,87,65,0,4,25,78,42")
        {
            int[] arr = input.Split(',').Select(s => int.Parse(s.Trim())).ToArray();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] sortedasc = Quicksort.Sort((int[])arr.Clone(), 0, arr.Length - 1, asc:true);
            int[] sorteddesc = Quicksort.Sort((int[])arr.Clone(), 0, arr.Length - 1, asc: false);
            stopwatch.Stop();
            return "Original: " + input 
                + Environment.NewLine 
                + "Sorted Ascending: " + string.Join(", ", sortedasc)
                + Environment.NewLine
                + "Sorted Descending: " + string.Join(", ", sorteddesc)
                + Environment.NewLine 
                + "Time taken: " + stopwatch.Elapsed.TotalMilliseconds + " ms"
                + Environment.NewLine
                + "QuickSort is a divide-and-conquer algorithm that:\r\nPicks a pivot.\r\nPartitions the array into elements less than and greater than the pivot.\r\nRecursively sorts the sub-arrays." +
                "\r\n\r\nTime Complexity: Best: O(n log n) Average: O(n log n) Worst: O(n²)\r\nSpace Complexity: Worst-case: O(n)";
        }

        [HttpPost]
        [Route("InsertionSort")]
        public string InsertionSortDo(string input = "4,5,87,65,0,4,25,78,42")
        {
            int[] arr = input.Split(',').Select(s => int.Parse(s.Trim())).ToArray();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] sortedasc = InsertionSort.Sort((int[])arr.Clone(), asc: true);
            int[] sorteddesc = InsertionSort.Sort((int[])arr.Clone(), asc: false);
            stopwatch.Stop();
            return "Original: " + input
                + Environment.NewLine
                + "Sorted Ascending: " + string.Join(", ", sortedasc)
                + Environment.NewLine
                + "Sorted Descending: " + string.Join(", ", sorteddesc)
                + Environment.NewLine
                + "Time taken: " + stopwatch.Elapsed.TotalMilliseconds + " ms"
                + Environment.NewLine
                + "InsertionSort Start from index 1 to n-1:\r\n   a. Store the current element as \"key\".\r\n   b. Compare \"key\" with each element before it (from right to left).\r\n   c. Shift all greater elements one position to the right.\r\n   d. Insert \"key\" at its correct sorted position." +
                "\r\n\r\nTime Complexity: Best: O(n) Average: O(n²) Worst: O(n²)\r\nSpace Complexity: O(1)";
        }

        [HttpPost]
        [Route("BubbleSort")]
        public string BubbleSortDo(string input = "4,5,87,65,0,4,25,78,42")
        {
            int[] arr = input.Split(',').Select(s => int.Parse(s.Trim())).ToArray();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] sortedasc = BubbleSort.Sort((int[])arr.Clone(), asc: true);
            int[] sorteddesc = BubbleSort.Sort((int[])arr.Clone(), asc: false);
            stopwatch.Stop();
            return "Original: " + input
                + Environment.NewLine
                + "Sorted Ascending: " + string.Join(", ", sortedasc)
                + Environment.NewLine
                + "Sorted Descending: " + string.Join(", ", sorteddesc)
                + Environment.NewLine
                + "Time taken: " + stopwatch.Elapsed.TotalMilliseconds + " ms"
                + Environment.NewLine
                + "BubbleSort Repeat for n-1 passes:\r\n   a. Traverse the array from 0 to n-i-1\r\n   b. If current element > next element, swap them" +
                "\r\n\r\nTime Complexity: Best: O(n) Average: O(n²) Worst: O(n²)\r\nSpace Complexity: O(1)";
        }

        [HttpPost]
        [Route("SelectionSort")]
        public string SelectionSortDo(string input = "4,5,87,65,0,4,25,78,42")
        {
            int[] arr = input.Split(',').Select(s => int.Parse(s.Trim())).ToArray();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] sortedasc = SelectionSort.Sort((int[])arr.Clone(), asc: true);
            int[] sorteddesc = SelectionSort.Sort((int[])arr.Clone(), asc: false);
            stopwatch.Stop();
            return "Original: " + input
                + Environment.NewLine
                + "Sorted Ascending: " + string.Join(", ", sortedasc)
                + Environment.NewLine
                + "Sorted Descending: " + string.Join(", ", sorteddesc)
                + Environment.NewLine
                + "Time taken: " + stopwatch.Elapsed.TotalMilliseconds + " ms"
                + Environment.NewLine
                + "SelectionSort Find the minimum (or maximum) element in the unsorted part of the array and swap it with the first element of the unsorted part. Repeat for the remaining subarray." +
                "\r\n\r\nTime Complexity: Best: O(n²) Average: O(n²) Worst: O(n²)\r\nSpace Complexity: O(1)";
        }

        [HttpPost]
        [Route("MergeSort")]
        public string MergeSortDo(string input = "4,5,87,65,0,4,25,78,42")
        {
            int[] arr = input.Split(',').Select(s => int.Parse(s.Trim())).ToArray();
            Stopwatch stopwatch = new Stopwatch();
            int[] ascarr = (int[])arr.Clone();
            int[] descarr = (int[])arr.Clone();

            stopwatch.Start();
            int[] sortedasc = MergeSort.Sort(ascarr, 0, ascarr.Length - 1, asc: true);
            int[] sorteddesc = MergeSort.Sort(descarr, 0, ascarr.Length - 1, asc: false);
            stopwatch.Stop();
            return "Original: " + input
                + Environment.NewLine
                + "Sorted Ascending: " + string.Join(", ", sortedasc)
                + Environment.NewLine
                + "Sorted Descending: " + string.Join(", ", sorteddesc)
                + Environment.NewLine
                + "Time taken: " + stopwatch.Elapsed.TotalMilliseconds + " ms"
                + Environment.NewLine
                + "Merge Sort is a divide and conquer algorithm:\r\n\r\nDivide: Split the array into halves recursively.\r\n\r\nConquer: Sort each half.\r\n\r\nCombine: Merge the two sorted halves into one sorted array." +
                "\r\n\r\nTime Complexity: Best: O(n log n) Average: O(n log n) Worst: O(n log n)\r\nSpace Complexity: O(n)";
        }

        [HttpPost]
        [Route("HeapSort")]
        public string HeapSortDo(string input = "4,5,87,65,0,4,25,78,42")
        {
            int[] arr = input.Split(',').Select(s => int.Parse(s.Trim())).ToArray();
            Stopwatch stopwatch = new Stopwatch();
            int[] ascarr = (int[])arr.Clone();
            int[] descarr = (int[])arr.Clone();

            stopwatch.Start();
            int[] sortedasc = HeapSort.Sort(ascarr, asc: true);
            int[] sorteddesc = HeapSort.Sort(descarr, asc: false);
            stopwatch.Stop();
            return "Original: " + input
                + Environment.NewLine
                + "Sorted Ascending: " + string.Join(", ", sortedasc)
                + Environment.NewLine
                + "Sorted Descending: " + string.Join(", ", sorteddesc)
                + Environment.NewLine
                + "Time taken: " + stopwatch.Elapsed.TotalMilliseconds + " ms"
                + Environment.NewLine
                + "HeapSort Build a Max Heap\r\n\r\nSwap the first (max) element with the last\r\n\r\nReduce heap size and heapify from the root\r\n\r\nRepeat until sorted" +
                "\r\n\r\nTime Complexity: Best: O(n log n) Average: O(n log n) Worst: O(n log n)\r\nSpace Complexity: O(1)";
        }
    }
}
