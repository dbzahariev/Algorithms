using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Variations_without_Repetitions
{
    class MainClass
    {
        private static int k;
        private static string[] elements;
        private static string[] variations;
        private static bool[] used;

        public static void Main()
        {
            elements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            k = int.Parse(Console.ReadLine());

            variations = new string[k];
            used = new bool[elements.Length];
            Variations(0);
        }

        public static void Variations(int index)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", variations));
            }
            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        variations[index] = elements[i];
                        Variations(index + 1);
                        used[i] = false;
                    }
                }
            }
        }
    }
}