using System;

namespace BridgeLabzConsoleApp.DSA.Searching
{
    public class BinarySearch
    {
        // Assumes the array is already sorted!
        public int Search(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                    return mid;

                if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1; // Not found
        }

        // Optional demo method to check functionality
        public void Demo()
        {
            int[] arr = { 1, 2, 3, 5, 8, 10, 14 };
            int target = 10;

            int result = Search(arr, target);

            if (result != -1)
                Console.WriteLine($"Element {target} found at index {result}");
            else
                Console.WriteLine($"Element {target} not found");
        }
    }
}
