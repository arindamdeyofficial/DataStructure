using System;

namespace StackLibrary
{
    public class MinHeap
    {
        //Heap (Priority Queue (Binary Heap), fast min/max retrieval)
        //A complete binary tree used to maintain priority order.\r\nTwo types: Max Heap(biggest on top) and Min Heap(smallest on top).\r\nSupports efficient insertion and removal of top priority item.
        //Insert() ExtractTop() PeekTop() IsEmpty()
        private int[] heap;
        private int size;
        private int capacity;

        public MinHeap(int initialCapacity = 4)
        {
            capacity = initialCapacity;
            heap = new int[capacity];
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Insert(int data)
        {
            if (size == capacity)
                Resize();

            heap[size] = data;
            HeapifyUp(size);
            size++;
        }

        public int ExtractMin()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Heap is empty");

            int root = heap[0];
            heap[0] = heap[size - 1];
            size--;
            HeapifyDown(0);
            return root;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Heap is empty");

            return heap[0];
        }

        public int[] GetHeap()
        {
            int[] result = new int[size];
            Array.Copy(heap, result, size);
            return result;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0 && heap[index] < heap[Parent(index)])
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

            if (left < size && heap[left] < heap[smallest])
                smallest = left;

            if (right < size && heap[right] < heap[smallest])
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
            int[] newHeap = new int[capacity];
            Array.Copy(heap, newHeap, size);
            heap = newHeap;
        }

        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        private int Parent(int index) => (index - 1) / 2;
        private int Left(int index) => 2 * index + 1;
        private int Right(int index) => 2 * index + 2;
    }
}
