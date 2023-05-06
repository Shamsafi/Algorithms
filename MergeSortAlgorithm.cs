using System;

class MergeSort
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
        MergeSortAlgorithm(arr, 0, arr.Length - 1);
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }

    static void MergeSortAlgorithm(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSortAlgorithm(arr, left, middle);
            MergeSortAlgorithm(arr, middle + 1, right);

            Merge(arr, left, middle, right);
        }
    }

    static void Merge(int[] arr, int left, int middle, int right)
    {
        int[] temp = new int[arr.Length];
        int i, leftEnd, numElements, tmpPos;

        leftEnd = (middle - 1);
        tmpPos = left;
        numElements = (right - left + 1);

        while ((left <= leftEnd) && (middle <= right))
        {
            if (arr[left] <= arr[middle])
            {
                temp[tmpPos++] = arr[left++];
            }
            else
            {
                temp[tmpPos++] = arr[middle++];
            }
        }

        while (left <= leftEnd)
        {
            temp[tmpPos++] = arr[left++];
        }

        while (middle <= right)
        {
            temp[tmpPos++] = arr[middle++];
        }

        for (i = 0; i < numElements; i++)
        {
            arr[right] = temp[right];
            right--;
        }
    }
}