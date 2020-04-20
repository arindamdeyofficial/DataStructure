using System;

namespace StackLibrary
{
    public static class StackLogic
    {
        static readonly int MAX = 1000;
        static int top = -1;
        static readonly int[] stack = new int[MAX];

        static bool IsEmpty()
        {
            return (top < 0);
        }
        public static bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        public static int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        public static int Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
                return stack[top];
        }

        public static int[] GetStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return new int[0];
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                return stack;
            }
        }
    }
}
