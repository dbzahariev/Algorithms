using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            int[] numbers = Console.ReadLine()
                .Split(separator: ' ')    
                .Select(int.Parse)
                .ToArray();
            
            Console.WriteLine(numbers);
            Console.WriteLine("END");
            Console.WriteLine(Sum(numbers));
        }

        private static bool Sum(int[] numbers)
        {
            throw new NotImplementedException();
        }
    }
}
