using System;

namespace BridgeLabzConsoleApp.ExampleForMultiLevelInheritance
{
    internal class MultiInheritance
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Play();
        }
    }
}
