using System;

class ArrayOperations
{
    static void Main()
    {
        int[] numbers = { 10, 25, 7, 56, 32, 18 };

        Console.WriteLine("Array Elements: " + string.Join(", ", numbers));

        Console.WriteLine($"Maximum: {FindMax(numbers)}");
        Console.WriteLine($"Minimum: {FindMin(numbers)}");
        Console.WriteLine($"Sum: {FindSum(numbers)}");

        Console.WriteLine("Reversed Array: " + string.Join(", ", ReverseArray(numbers)));
    }

    // Method to find max
    static int FindMax(int[] arr)
    {
        int max = arr[0];
        foreach (int num in arr)
            if (num > max)
                max = num;
        return max;
    }

    // Method to find min
    static int FindMin(int[] arr)
    {
        int min = arr[0];
        foreach (int num in arr)
            if (num < min)
                min = num;
        return min;
    }

    // Method to find sum
    static int FindSum(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
            sum += num;
        return sum;
    }

    // Method to reverse array
    static int[] ReverseArray(int[] arr)
    {
        Array.Reverse(arr);
        return arr;
    }
}
