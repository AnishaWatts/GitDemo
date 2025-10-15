
using System;
using System.Net;
using System.Security.Principal;
using System.Collections;
using System.ComponentModel.Design;

public class HelloWorld
{
  class StackusingArray
    {
        private int[] stack;
        private int top;
        private int max;
        public StackusingArray(int size)
        {
            stack = new int[size];
            top = -1;
            max = size;
        }
        public void Push(int data)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            stack[++top] = data;
            Console.WriteLine($"{data} pushed into Stack");
        }

        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            Console.WriteLine($"{stack[top--]} popped from stack");
        }

        public void Peek()
        {
            if (top == -1)
                Console.WriteLine("Stack is empty");
            else
                Console.WriteLine($"Top element: {stack[top]}");
        }

        public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return;
        }
        Console.WriteLine("Stack elements are:");
        for (int i = top; i >= 0; i--)
            Console.WriteLine(stack[i]);
    }
    }
    
         public static void Main(string[] args)
    {
        StackusingArray s = new StackusingArray(5);
        s.Push(10);
        s.Push(20);
        s.Push(30);
        s.Display();
        s.Pop();
        s.Peek();

        }
}