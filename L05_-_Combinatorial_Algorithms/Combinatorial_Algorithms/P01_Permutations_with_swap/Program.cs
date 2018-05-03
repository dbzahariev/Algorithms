using System;
using System.Linq;

namespace P01_Permutations_with_swap
{
    class MainClass
    {
        static string[] elements;

        public static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
            }
            else
            {
                Permute(index + 1);
                for (int i = index+1; i < elements.Length; i++)
                {
                    Swap(index, i);
                    Permute(index + 1);
                    Swap(index, i);
                }
            }
        }

        public static void Swap(int first, int second){
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }

        public static void Main()
        {
            elements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Permute(0);
        }
    }
}