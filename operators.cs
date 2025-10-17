Arithmetic 
using System;

class Geeks 
{
    static void Main(string[] args)
    {
        int x = 8, y = 4;

        // Using different arithmetic operators
        Console.WriteLine("Addition: " + (x + y));
        Console.WriteLine("Subtraction: " + (x - y));
        Console.WriteLine("Multiplication: " + (x * y));
        Console.WriteLine("Division: " + (x / y));
        Console.WriteLine("Modulo: " + (x % y));
    }
}

Relational Operators
using System;

class Geeks
{
    static void Main(string[] args)
    {
        int x = 10, y = 20;

        // Compare using different relational operators
        Console.WriteLine(x == y);
        Console.WriteLine(x != y);
        Console.WriteLine(x > y);
        Console.WriteLine(x < y);
        Console.WriteLine(x >= y);
        Console.WriteLine(x <= y);
    }
}

Logical Operators

using System;

class Geeks 
{
    static void Main(string[] args)
    {
        bool a = true, b = false;

        // conditional operators
        if (a && b)
            Console.WriteLine("a and b are true");

        if (a || b)
            Console.WriteLine("Either a or b is true");

        if (!a)
            Console.WriteLine("a is not true");
        if (!b)
            Console.WriteLine("b is not true");
    }
}

Assignment Operators
using System;

class Geeks
{
    static void Main(string[] args)
    {
        int a = 10;

        // Using different assignment operators
        a += 5;
        Console.WriteLine("Add Assignment: " + a);

        a -= 3;
        Console.WriteLine("Subtract Assignment: " + a);

        a *= 2;
        Console.WriteLine("Multiply Assignment: " + a);

        a /= 4;
        Console.WriteLine("Division Assignment: " + a);

        a %= 5;
        Console.WriteLine("Modulo Assignment: " + a);
    }
}

Increment/Decrement Operators

using System;

public class Geeks
{
    static public void Main()
    {
        int a = 5;
      
      	// pre-increment
        Console.WriteLine("++a returns: " + ++a);
      
      	// post-increment
		Console.WriteLine("a++ returns: " + a++);

      	Console.WriteLine("Final value of a: " + a);
      
      	Console.WriteLine();
      
        // pre-decrement
      	Console.WriteLine("--a returns: " + --a);
      
      	// post-decrement
      	Console.WriteLine("a-- returns: " + a--);
      	
      	Console.WriteLine("Final value of a: " + a);
    }
}
