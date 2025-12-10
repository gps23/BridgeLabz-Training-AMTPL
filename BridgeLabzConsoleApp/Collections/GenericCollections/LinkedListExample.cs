using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.Collections.GenericCollections
{
    public class LinkedListExample
    {
        public void Demo()
        {
            LinkedList<string> list = new();
            list.AddLast("A");
            list.AddLast("B");
            list.AddLast("C");

            Console.WriteLine("LinkedList Items:");
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
