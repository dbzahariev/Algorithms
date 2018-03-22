using System;

namespace P04_Generating_Vectors
{
    class Program
    {
        public static void Main()
        {
            int vectorLength = int.Parse(Console.ReadLine());
            GenerateVectors(vectorLength, new int[vectorLength]);
        }

        private static void GenerateVectors(int vectorLength, int[] vector, int currIndex = 0)
        {
            if (currIndex == vectorLength)
            {
                Console.WriteLine(string.Join("", vector));
            }
            else
            {
                vector[currIndex] = 0;
                GenerateVectors(vectorLength, vector, currIndex + 1);

                vector[currIndex] = 1;
                GenerateVectors(vectorLength, vector, currIndex + 1);
            }
        }
    }
}
