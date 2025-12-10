using System;
using System.Text.RegularExpressions;

namespace BridgeLabzConsoleApp.RegexModule
{
    public class PhoneValidationExample
    {
        public void Demo()
        {
            // Validates exactly 10 digits
            string pattern = @"^[0-9]{10}$";

            string phone = "9876543210";

            bool result = Regex.IsMatch(phone, pattern);

            Console.WriteLine(result ? "Valid Phone Number" : "Invalid Phone Number");
        }
    }
}
