using System;

class LinearSearch
{
    static void Main()
    {
        int[] arr = { 5, 2, 8, 4, 7, 1, 3, 6 };
        int target = 7;

        Console.WriteLine("Original array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nTarget element: " + target);

        int result = LinearSearchAlgorithm(arr, target);

        if (result == -1)
        {
            Console.WriteLine("Target element not found");
        }
        else
        {
            Console.WriteLine("Target element found at index " + result);
        }
    }

    static int LinearSearchAlgorithm(int[] arr, int target)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }

        return -1;
    }
}