using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Sorts;
using StackLibrary;

namespace Ds.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StackController : ControllerBase
    {
        private readonly ILogger<StackController> _logger;

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

        public StackController(ILogger<StackController> logger)
        {
            _logger = logger;
            _n = _arr.Length;
        }

        [HttpGet("~/api/[controller]/StackOperation")]
        public IActionResult StackOperation()
        {
            _watch.Start();

            StackLogic.Push(10);
            StackLogic.Push(20);
            StackLogic.Push(30);
            StackLogic.Push(40);

            _watch.Stop();
            _watch.Reset();
            return Content("Execution Time: " + _watch.Elapsed + Environment.NewLine
                + "Item ready to be picked: " + StackLogic.Peek() + Environment.NewLine
                + "Item popped from Stack : " + string.Join(",", StackLogic.GetStack()));
        }
    }
}
