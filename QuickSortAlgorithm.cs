using System;

class QuickSort
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
        QuickSortAlgorithm(arr, 0, arr.Length - 1);
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }

    static void QuickSortAlgorithm(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                QuickSortAlgorithm(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSortAlgorithm(arr, pivot + 1, right);
            }
        }
    }

    static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {
            while (arr[left] < pivot)
            {
                left++;
            }
            while (arr[right] > pivot)
            {
                right--;
            }
            if (left < right)
            {
                if (arr[left] == arr[right])
                {
                    return right;
                }
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
            else
            {
                return right;
            }
        }
    }
}