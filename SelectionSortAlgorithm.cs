using System;

class SelectionSort
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
        SelectionSortAlgorithm(arr);
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }

    static void SelectionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}