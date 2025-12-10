using System;
using System.Collections.Generic;

namespace BridgeLabzConsoleApp.Collections.GenericCollections
{
    public class ListExample
    {
        public void Demo()
        {
            List<string> names = new List<string>
            {
                "Praja",
                "Sree",
                "Kumar"
            };

            names.Add("Anu");

            Console.WriteLine("List Items:");
            foreach (var name in names)
                Console.WriteLine(name);
        }
    }
}
