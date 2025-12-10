//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        string[] arr = { "apple", "banana", "apple", "orange", "banana", "kiwi" };
//        string firstUnique = GetFirstUniqueString(arr);
//        if (firstUnique != null)
//            Console.WriteLine($"First unique string: {firstUnique}");
//        else
//            Console.WriteLine("No unique string found");
//    }

//    static string GetFirstUniqueString(string[] arr)
//    {
//        Dictionary<string, int> count = new Dictionary<string, int>();

     
//        foreach (string s in arr)
//        {
//            if (count.ContainsKey(s))
//                count[s]++;
//            else
//                count[s] = 1;
//        }

      
//        foreach (string s in arr)
//        {
//            if (count[s] == 1)
//                return s;
//        }

//        return null; 
//    }
//}
