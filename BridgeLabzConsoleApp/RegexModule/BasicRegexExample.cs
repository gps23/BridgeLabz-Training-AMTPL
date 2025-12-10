using System;
using System.Text.RegularExpressions;

namespace BridgeLabzConsoleApp.RegexModule
{
    public class BasicRegexExample
    {
        public void Demo()
        {
            // Pattern: First letter uppercase + minimum 3 letters
            string pattern = @"^[A-Z][a-z]{2,}$";
            string name = "Praja";

            bool result = Regex.IsMatch(name, pattern);

            Console.WriteLine(result ? "Valid Name" : "Invalid Name");
        }
    }
}
