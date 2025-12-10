using System;

namespace BridgeLabzConsoleApp.ExceptionHandling
{
   
    public class AgeTooLowException : Exception
    {
        public AgeTooLowException(string message) : base(message)
        {
        }
    }

    public class CustomExceptionExample
    {
        public void Demo()
        {
            int age = 16;  

            try
            {
                if (age < 18)
                {
                    throw new AgeTooLowException("Age must be 18 or above to register!");
                }

                Console.WriteLine("Registration successful.");
            }
            catch (AgeTooLowException ex)
            {
                Console.WriteLine("Custom Exception Caught:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
