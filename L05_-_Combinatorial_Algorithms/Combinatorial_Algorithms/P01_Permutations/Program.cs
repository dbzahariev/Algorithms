using System;
using System.Linq;

namespace P01_Permutations
{
    class MainClass
    {
        static string[] elements;
        static bool[] used;
        static string[] permutations;

        public static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", permutations));
            }
            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!used[i])
                    {
                        var currentNumbers = elements[i];
                        used[i] = true;
                        permutations[index] = currentNumbers;
                        Permute(index + 1);
                        used[i] = false;
                    }
                }
            }
        }


        public static void Main()
        {
            elements = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            used = new bool[elements.Length];
            permutations = new string[elements.Length];

            Permute(0);
        }
    }
}