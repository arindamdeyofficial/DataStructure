using System;

namespace PriorityQueueLibrary
{
    public class PriorityQueue<T>
    {
        //min-priority queue
        private (T Item, int Priority)[] heap;
        private int size;
        private int capacity;

        public PriorityQueue(int initialCapacity = 4)
        {
            capacity = initialCapacity;
            heap = new (T, int)[capacity];
            size = 0;
        }

        public bool IsEmpty() => size == 0;

        public void Enqueue(T item, int priority)
        {
            if (size == capacity)
                Resize();

            heap[size] = (item, priority);
            HeapifyUp(size);
            size++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Priority queue is empty.");

            T item = heap[0].Item;
            heap[0] = heap[size - 1];
            size--;
            HeapifyDown(0);
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Priority queue is empty.");

            return heap[0].Item;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0 && heap[index].Priority < heap[Parent(index)].Priority)
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }
        }

        private void HeapifyDown(int index)
        {
            int smallest = index;
            int left = Left(index);
            int right = Right(index);

            if (left < size && heap[left].Priority < heap[smallest].Priority)
                smallest = left;

            if (right < size && heap[right].Priority < heap[smallest].Priority)
                smallest = right;

            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }

        private void Resize()
        {
            capacity *= 2;
            var newHeap = new (T, int)[capacity];
            Array.Copy(heap, newHeap, size);
            heap = newHeap;
        }

        private void Swap(int i, int j)
        {
            (heap[i], heap[j]) = (heap[j], heap[i]);
        }

        private int Parent(int i) => (i - 1) / 2;
        private int Left(int i) => 2 * i + 1;
        private int Right(int i) => 2 * i + 2;
    }
}
