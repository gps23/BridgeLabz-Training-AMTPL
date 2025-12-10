using System;
using System.Collections;

namespace BridgeLabzConsoleApp.Collections.NonGenericCollections
{
    public class SortedListExample
    {
        public void Demo()
        {
            SortedList sorted = new();
            sorted.Add(3, "Three");
            sorted.Add(1, "One");
            sorted.Add(2, "Two");

            Console.WriteLine("SortedList Items:");
            foreach (DictionaryEntry entry in sorted)
                Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
