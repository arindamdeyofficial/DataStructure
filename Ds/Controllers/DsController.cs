using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Sorts;

namespace Ds.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DsController : ControllerBase
    {
        private readonly ILogger<DsController> _logger;

        readonly Stopwatch _watch = new Stopwatch();
        readonly int[] _arr = { 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5, 10, 7, 8, 9, 1, 5,
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
        readonly int _n = 0;

        public DsController(ILogger<DsController> logger)
        {
            _logger = logger;
            _n = _arr.Length;
        }

        [HttpGet("~/api/[controller]/QuickSortHoareAlgo")]
        public IActionResult QuickSortHoareAlgo()
        {
            _watch.Start();
            QuickSortHoare.SortDefault(_arr);
            _watch.Stop();
            _watch.Reset();
            return Content($"Execution Time: {_watch.Elapsed}"
                + Environment.NewLine + string.Join(",", _arr));
        }

        [HttpGet("~/api/[controller]/QuickSortLomutoAlgo")]
        public IActionResult QuickSortLomutoAlgo()
        {
            _watch.Start();
            QuickSortLomuto.SortDefault(_arr);
            _watch.Stop();
            _watch.Reset();
            return Content($"Execution Time: {_watch.Elapsed}"
                + Environment.NewLine + string.Join(",", _arr));
        }

        [HttpGet("~/api/[controller]/InsertionSortAlgo")]
        public IActionResult InsertionSortAlgo()
        {
            _watch.Start();
            InsertionSort.Sort(_arr);
            _watch.Stop();
            _watch.Reset();
            return Content($"Execution Time: {_watch.Elapsed}"
                + Environment.NewLine + string.Join(",", _arr));
        }

        [HttpGet("~/api/[controller]/MergeSortAlgo")]
        public IActionResult MergeSortAlgo()
        {
            _watch.Start();
            MergeSort.Sort(_arr, 0, _n -1);
            _watch.Stop();
            _watch.Reset();
            return Content($"Execution Time: {_watch.Elapsed}"
                + Environment.NewLine + string.Join(",", _arr));
        }

        [HttpGet("~/api/[controller]/HeapSortAlgo")]
        public IActionResult HeapSortAlgo()
        {
            _watch.Start();
            HeapSort.Sort(_arr, 0, _n - 1);
            _watch.Stop();
            _watch.Reset();
            return Content($"Execution Time: {_watch.Elapsed}"
                + Environment.NewLine + string.Join(",", _arr));
        }

        [HttpGet("~/api/[controller]/BubbleSortAlgo")]
        public IActionResult BubbleSortAlgo()
        {
            _watch.Start();
            BubbleSort.Sort(_arr, 0, _n - 1);
            _watch.Stop();
            _watch.Reset();
            return Content($"Execution Time: {_watch.Elapsed}"
                + Environment.NewLine + string.Join(",", _arr));
        }

        [HttpGet("~/api/[controller]/BinaryInsertionSortAlgo")]
        public IActionResult BinaryInsertionSortAlgo()
        {
            _watch.Start();
            BinaryInsertionSort.Sort(_arr, 0, _n - 1);
            _watch.Stop();
            _watch.Reset();
            return Content($"Execution Time: {_watch.Elapsed}"
                + Environment.NewLine + string.Join(",", _arr));
        }

        [HttpGet("~/api/[controller]/SelectionSortAlgo")]
        public IActionResult SelectionSortAlgo()
        {
            _watch.Start();
            SelectionSort.Sort(_arr, 0, _n - 1);
            _watch.Stop();
            _watch.Reset();
            return Content($"Execution Time: {_watch.Elapsed}"
                + Environment.NewLine + string.Join(",", _arr));
        }
    }
}
