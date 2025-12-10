using System;

namespace BridgeLabzConsoleApp.DSA.Searching
{
    public class LinearSearch
    {
        // Returns index of target if found, otherwise -1
        public int Search(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }

            return -1; // Not found
        }

        // Optional: Demo method to test the search
        public void Demo()
        {
            int[] nums = { 3, 7, 1, 9, 2 };
            int target = 9;

            int result = Search(nums, target);

            if (result != -1)
                Console.WriteLine($"Element {target} found at index {result}");
            else
                Console.WriteLine($"Element {target} not found");
        }
    }
}
