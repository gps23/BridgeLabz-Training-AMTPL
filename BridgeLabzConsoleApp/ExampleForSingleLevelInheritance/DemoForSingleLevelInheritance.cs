using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzConsoleApp.ExampleForSingleLevelInheritance
{
    internal class DemoForSingleLevelInheritance
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("cat",2);
            animal.MakeSound();
            Cat cat = new Cat("charli",3);
            cat.MakeSound();
            Animal animal1 = new Cat("abc",3);
            animal1.MakeSound();
        }
    }
}
