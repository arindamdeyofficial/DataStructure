using System;

namespace StackLibrary
{
    public class StackLogic
    {
        private int[] stack;
        private int top;
        private int capacity;

        public StackLogic(int initialCapacity = 4)
        {
            capacity = initialCapacity;
            stack = new int[capacity];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top < 0;
        }

        public bool Push(int data)
        {
            if (top + 1 >= capacity)
            {
                Resize();
            }

            stack[++top] = data;
            return true;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack Underflow");
            }

            return stack[top--];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack Underflow");
            }

            return stack[top];
        }

        public int[] GetStack()
        {
            int[] result = new int[top + 1];
            Array.Copy(stack, result, top + 1);
            return result;
        }

        private void Resize()
        {
            capacity *= 2;
            int[] newStack = new int[capacity];
            Array.Copy(stack, newStack, top + 1);
            stack = newStack;
        }
    }
}
