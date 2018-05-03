using System;
using System.Linq;

namespace P04_Variations_with_Repetition
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
                Console.WriteLine(string.Join(" ", variations));
            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    variations[index] = elements[i];
                    Variations(index + 1);
                }
            }
        }
    }
}
