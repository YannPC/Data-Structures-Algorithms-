using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    internal class myStack
    {
        private int[] array;

        private int capacity;

        private int top;

        public myStack(int size)
        {
            
            capacity = size;
            array = new int[capacity];
            top = -1;
        }

        public void push(int x)
        {

            if (top == capacity - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }

            array[++top] = x;
        }

       public  int pop()
        {

            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }

            return array[top--];
        }
       public int peek()
        {

            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }

            return array[top];
        }

    }


}
