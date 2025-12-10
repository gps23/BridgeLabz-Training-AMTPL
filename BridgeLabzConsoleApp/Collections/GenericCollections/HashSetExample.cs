using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.Collections.GenericCollections
{
    public class HashSetExample
    {
        public void Demo()
        {
            HashSet<int> set = new() { 1, 2, 2, 3 };

            Console.WriteLine("HashSet Items:");
            foreach (var item in set)
                Console.WriteLine(item);
        }
    }
}
