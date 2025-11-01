using System;

namespace BridgeLabzConsoleApp.AbstractionExample
{
    
    public abstract class Shape
    {
        public abstract double CalculateArea();

        
        public void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }
}
