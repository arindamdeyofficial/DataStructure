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
            var minheap = new MinHeap();
            minheap.Insert(40);
            minheap.Insert(10);
            minheap.Insert(20);
            minheap.Insert(5);
            msg += Environment.NewLine + "MinHeap: " + Environment.NewLine;
            msg += "Current Heap: " + string.Join(", ", minheap.GetHeap()) + Environment.NewLine;
            msg += "Min: " + minheap.Peek() + Environment.NewLine; // 5
            msg += "Extracted Min: " + minheap.ExtractMin() + Environment.NewLine; // 5
            msg += "Current Heap: " + string.Join(", ", minheap.GetHeap()) + Environment.NewLine; // 10, 40, 20

            var maxheap = new MaxHeap();
            maxheap.Insert(10);
            maxheap.Insert(50);
            maxheap.Insert(30);
            msg += Environment.NewLine + "MaxHeap: " + Environment.NewLine;
            msg += "Created Heap: " + string.Join(", ", minheap.GetHeap()) + Environment.NewLine;
            msg += "Min: " + maxheap.Peek() + Environment.NewLine; // 5
            msg += "Extracted Min: " + maxheap.ExtractMax() + Environment.NewLine; // 5
            msg += "Current Heap: " + string.Join(", ", maxheap.GetHeap()) + Environment.NewLine; // 10, 40, 20

            var pq = new PriorityQueueLibrary.PriorityQueue<string>();
            pq.Enqueue("Low Priority", 5);
            pq.Enqueue("High Priority", 1);
            pq.Enqueue("Medium Priority", 3);
            msg += "PriorityQueue: " + Environment.NewLine;
            msg += Environment.NewLine + "Created Heap: " + string.Join(", ", minheap.GetHeap()) + Environment.NewLine;
            msg += pq.Dequeue() + Environment.NewLine; // Output: High Priority
            msg += pq.Dequeue() + Environment.NewLine; // Output: Medium Priority
            msg += pq.Dequeue() + Environment.NewLine; // Output: Low Priority

            return msg;
        }
    }
}
