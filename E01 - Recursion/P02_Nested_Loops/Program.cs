﻿using System;

namespace P02_Nested_Loops
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SimulateNestedLoops(new int[n]);
        }

        private static void SimulateNestedLoops(int[] arr, int currIndex = 0)
        {
            if (currIndex == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[currIndex] = i;
                    SimulateNestedLoops(arr, currIndex + 1);
                }
            }
        }
    }
}
