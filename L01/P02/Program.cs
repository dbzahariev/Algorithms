using System;

namespace P02
{
    class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorial(num));
        }

        private static int GetFactorial(int num)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("Number must be non-negative!");
            }

            if (num < 2)
            {
                return 1;
            }

            return num * GetFactorial(num - 1);
        }
    }
}
