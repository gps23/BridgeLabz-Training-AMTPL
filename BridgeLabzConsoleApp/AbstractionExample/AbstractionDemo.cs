using System;

namespace BridgeLabzConsoleApp.AbstractionExample
{
    public class AbstractionDemo
    {
        public static void MainAbstraction()
        {
           
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            circle.Display();
            Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");

            rectangle.Display();
            Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}");
        }
    }
}
