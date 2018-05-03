using System;
using System.Linq;

namespace P05_Combinations_without_Repetition
{
    class MainClass
    {
        private static string[] elements;
        private static int k;
        private static string[] combinations;
        private static bool[] used;

        public static void Main()
        {
            elements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .ToArray();
            k = int.Parse(Console.ReadLine());

            combinations = new string[k];
            used = new bool[elements.Length];
            Comb(0, 0);
        }

        private static void Comb(int index, int start)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", combinations));
            }
            else
            {
                for (int i = start; i < elements.Length; i++)
                {
                    combinations[index] = elements[i];
                    Comb(index + 1, i + 1);
                }
            }
        }
    }
}