using System;
using System.Linq;

namespace P02_Permutations_with_Repetitions
{
    class MainClass
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .ToArray();
            Array.Sort(arr);
            PermuteRep(arr, 0, arr.Length - 1);
        }

        static void PermuteRep(string[] arr, int start, int end)
        {
            Print(arr);
            for (int left = end - 1; left >= start; left--)
            {
                for (int right = left + 1; right <= end; right++)
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr, left, right);
                        PermuteRep(arr, left + 1, end);
                    }
                var firstElement = arr[left];
                for (int i = left; i <= end - 1; i++)
                    arr[i] = arr[i + 1];
                arr[end] = firstElement;
            }
        }

        private static void Swap(ref string[] arr, int first, int second)
        {
            string temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }

        private static void Print (string[] arr){
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
