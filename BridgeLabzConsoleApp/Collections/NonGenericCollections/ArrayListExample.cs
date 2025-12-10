using System;
using System.Collections;

namespace BridgeLabzConsoleApp.Collections.NonGenericCollections
{
    public class ArrayListExample
    {
        public void Demo()
        {
            ArrayList list = new();
            list.Add(10);
            list.Add("Hello");
            list.Add(99.9);

            Console.WriteLine("ArrayList Items:");
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
