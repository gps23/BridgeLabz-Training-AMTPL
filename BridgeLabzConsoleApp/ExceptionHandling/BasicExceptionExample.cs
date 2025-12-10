using System;

namespace BridgeLabzConsoleApp.ExceptionHandling
{
    public class BasicExceptionExample
    {
        public void Demo()
        {
            try
            {
                int a = 10;
                int b = 0;
                Console.WriteLine(a / b);  
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
        }
    }
}
