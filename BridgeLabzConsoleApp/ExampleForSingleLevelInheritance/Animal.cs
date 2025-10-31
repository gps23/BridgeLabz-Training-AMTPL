using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzConsoleApp.ExampleForSingleLevelInheritance
{
    internal class Animal
    {
        public string Name;
        public int Age;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void MakeSound(float a, int b)
        {
            Console.WriteLine("Animal makes a sound");

        }
        public virtual void MakeSound(int b,float a)
        {
            Console.WriteLine("Animal makes a sound");

        }
        public virtual void MakeSound(float a)
        {
            Console.WriteLine("Animal makes a sound");

        }
        public virtual void MakeSound(int a)
        {
            Console.WriteLine("Animal makes a sound");

        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");

        }
    }
}
