using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Push_Pop
{
    internal class Stack
    {
        int[] items;
        int top;
        int capacity;

        public Stack(int size)
        {
            items = new int[size];
            capacity = size;
            top = -1;
        }

        public void Push(int item)
        {
            //checking if stack is empty 
            
            if (top == capacity - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            items[++top] = item;
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            return items[top--];
        }

        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Is Empty");
                return -1;
            }
            return items[top];
        }
    }
}