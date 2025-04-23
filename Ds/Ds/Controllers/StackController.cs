using MathHelpers;
using Microsoft.AspNetCore.Mvc;
using Sorts;
using StackLibrary;
using System.Diagnostics;

namespace Ds.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StackController : ControllerBase
    {
        private readonly ILogger<StackController> _logger;

        public StackController(ILogger<StackController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("StackOperate")]
        public string StackOperate()
        {
            string msg = "";
            var stack = new StackLogic();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            msg += "Stack Created: " + string.Join(", ", stack.GetStack()) + Environment.NewLine;
            msg += "Top: " + stack.Peek() + Environment.NewLine; // 30
            int popped = stack.Pop();
            msg += "Popped: " + popped + Environment.NewLine; // 30
            msg += "Current Stack: " + string.Join(", ", stack.GetStack()) + Environment.NewLine; // 10, 20
            return msg;
        }

        [HttpGet]
        [Route("QueueOperate")]
        public string QueueOperate()
        {
            string msg = "";
            var queue = new QueueLogic();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            msg += "Front: " + queue.Peek() + Environment.NewLine; // 10
            int dequeued = queue.Dequeue();
            msg += "Dequeued: " + dequeued + Environment.NewLine; // 10
            msg += "Current Queue: " + string.Join(", ", queue.GetQueue()) + Environment.NewLine; // 20, 30
            return msg;
        }

        [HttpGet]
        [Route("HeapOperate")]
        public string HeapOperate()
        {
            string msg = "";
            var heap = new HeapLogic();
            heap.Insert(40);
            heap.Insert(10);
            heap.Insert(20);
            heap.Insert(5);
            msg += "Min: " + heap.Peek() + Environment.NewLine; // 5
            msg += "Extracted Min: " + heap.ExtractMin() + Environment.NewLine; // 5
            msg += "Current Heap: " + string.Join(", ", heap.GetHeap()) + Environment.NewLine; // 10, 40, 20
            return msg;
        }
    }
}
