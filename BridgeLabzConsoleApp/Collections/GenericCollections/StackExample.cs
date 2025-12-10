using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.Collections.GenericCollections
{
    public class StackExample
    {
        public void Demo()
        {
            Stack<int> stack = new();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Stack Pop:");
            Console.WriteLine(stack.Pop());
        }
    }
}
