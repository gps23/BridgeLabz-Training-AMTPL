using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.Collections.GenericCollections
{
    public class QueueExample
    {
        public void Demo()
        {
            Queue<string> queue = new();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            Console.WriteLine("Queue Dequeue:");
            Console.WriteLine(queue.Dequeue());
        }
    }
}
