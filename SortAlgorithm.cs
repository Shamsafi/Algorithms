using System;

namespace DataStructureAlgorithmExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of integers separated by spaces:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int[] array = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            Array.Sort(array);

            Console.WriteLine("Sorted array:");
            foreach (int number in array)
            {
                Console.Write($"{number} ");
            }
        }
    }
}