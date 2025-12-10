using System;
using System.Text.RegularExpressions;

namespace BridgeLabzConsoleApp.RegexModule
{
    public class EmailValidationExample
    {
        public void Demo()
        {
            
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z]+\.[a-z]{2,3}$";

            string email = "praja@gmail.com";

            bool result = Regex.IsMatch(email, pattern);

            Console.WriteLine(result ? "Valid Email" : "Invalid Email");
        }
    }
}
