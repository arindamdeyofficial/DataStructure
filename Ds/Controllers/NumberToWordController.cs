using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NumberToWord;
using NumberToWord.Tests;
using System;
using System.Diagnostics;
using System.Text;

namespace Ds.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumberToWordController : ControllerBase
    {
        readonly Stopwatch _watch = new Stopwatch();
        private readonly ILogger<NumberToWordController> _logger;
        public NumberToWordController(ILogger<NumberToWordController> logger)
        {
            _logger = logger;
        }

        [HttpGet("~/api/[controller]/SpellNumber")]
        public IActionResult SpellNumber()
        {
            _watch.Start();
            StringBuilder s = new StringBuilder();
            var w = new NumericLibrary();
            for (Int64 i = 1; i < 100; i++)
            {
                s.Append(string.Format("Number: {0} InWords: {1}", i, w.SpellNumber(i)+ Environment.NewLine));
            }
            _watch.Stop();
            _watch.Reset();
            return Content("Execution Time: " + _watch.Elapsed + Environment.NewLine + s.ToString());
        }
    }
}
