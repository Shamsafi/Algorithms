using System;

class BubbleSort
{
    static void Main()
    {
        int[] arr = { 5, 2, 8, 4, 7, 1, 3, 6 };

        Console.WriteLine("Original array:");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nSorted array:");
        BubbleSortAlgorithm(arr);
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }

    static void BubbleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}