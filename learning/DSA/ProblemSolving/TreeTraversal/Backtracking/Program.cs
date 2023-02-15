using System;

namespace Backtracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //PrintPermutation printPermutation = new PrintPermutation();
            //var input = new int[] { 1, 2, 3 };
            //printPermutation.solve(input, input.Length, 0);
            PrintPermutation1 printPermutation = new PrintPermutation1();
            var input = new int[] { 1, 2, 3 };
            var result = new System.Collections.Generic.List<int>();
            printPermutation.solve(input,result , 0);
        }
    }
}
