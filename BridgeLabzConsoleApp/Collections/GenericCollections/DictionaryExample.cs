using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.Collections.GenericCollections
{
    public class DictionaryExample
    {
        public void Demo()
        {
            Dictionary<int, string> students = new()
            {
                { 1, "Praja" },
                { 2, "Sree" }
            };

            students[3] = "Anu";

            Console.WriteLine("Dictionary Items:");
            foreach (var pair in students)
                Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
