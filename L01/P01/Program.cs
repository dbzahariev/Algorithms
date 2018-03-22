using System;
using System.Linq;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(SumArray(arr));
        }

        private static int SumArray(int[] arr, int index = 0)
        {
            if (index == arr.Length - 1)
            {
                return arr[index];
            }

            return arr[index] + SumArray(arr, index + 1);
}
    }
}
