using System;

namespace P03_Recursive_Drawing
{
    class Program
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            Draw(size);
        }

        private static void Draw(int size)
        {
            if (size < 1)
            {
                return;
            }

            Console.WriteLine(new string('*', size));
            Draw(size - 1);
            Console.WriteLine(new string('#', size));
        }
    }
}
