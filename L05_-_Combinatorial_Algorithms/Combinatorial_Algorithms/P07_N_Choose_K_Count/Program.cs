using System;

namespace P07_N_Choose_K_Count
{
    class MainClass
    {
        private static int n;
        private static int k;

        public static void Main()
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Console.WriteLine(Binom(n,k));
        }

        public static decimal Binom(int n1, int k1)
        {
            if (k1 > n1)
                return 0;
            if (k1 == 0 || k1 == n1)
                return 1;
            return Binom(n1 - 1, k1 - 1) + Binom(n1 - 1, k1);
        }
    }
}
