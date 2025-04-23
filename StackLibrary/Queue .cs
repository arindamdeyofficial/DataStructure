using System;

namespace StackLibrary
{
    public class QueueLogic
    {
        //Queue (FIFO)
        //Enqueue() Dequeue() Peek() IsEmpty()
        private int[] queue;
        private int front;
        private int rear;
        private int size;
        private int capacity;

        public QueueLogic(int initialCapacity = 4)
        {
            capacity = initialCapacity;
            queue = new int[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(int data)
        {
            if (size == capacity)
            {
                Resize();
            }

            rear = (rear + 1) % capacity;
            queue[rear] = data;
            size++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue Underflow");
            }

            int data = queue[front];
            front = (front + 1) % capacity;
            size--;
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue Underflow");
            }

            return queue[front];
        }

        public int[] GetQueue()
        {
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = queue[(front + i) % capacity];
            }
            return result;
        }

        private void Resize()
        {
            int[] newQueue = new int[capacity * 2];
            for (int i = 0; i < size; i++)
            {
                newQueue[i] = queue[(front + i) % capacity];
            }
            queue = newQueue;
            front = 0;
            rear = size - 1;
            capacity *= 2;
        }
    }
}
