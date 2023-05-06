using System;

class BinarySearch
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int target = 7;

        Console.WriteLine("Original array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nTarget element: " + target);

        int result = BinarySearchAlgorithm(arr, target);

        if (result == -1)
        {
            Console.WriteLine("Target element not found");
        }
        else
        {
            Console.WriteLine("Target element found at index " + result);
        }
    }

    static int BinarySearchAlgorithm(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;

            if (arr[middle] == target)
            {
                return middle;
            }
            else if (arr[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1;
    }
}