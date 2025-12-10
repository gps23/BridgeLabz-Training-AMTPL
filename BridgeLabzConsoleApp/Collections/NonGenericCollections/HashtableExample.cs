using System;
using System.Collections;

namespace BridgeLabzConsoleApp.Collections.NonGenericCollections
{
    public class HashtableExample
    {
        public void Demo()
        {
            Hashtable ht = new();
            ht.Add(1, "Praja");
            ht.Add(2, "Sree");
            ht.Add(3, "Anu");

            Console.WriteLine("Hashtable Items:");
            foreach (DictionaryEntry entry in ht)
                Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
