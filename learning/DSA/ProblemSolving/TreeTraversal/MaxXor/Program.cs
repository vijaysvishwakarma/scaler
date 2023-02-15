using System;
using System.Collections.Generic;

namespace MaxXor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MaxXor maxXor = new MaxXor();
            //List<int> elements = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> elements = new List<int>() { 5, 17, 100, 11 };
            //var result = maxXor.solve(elements);
            MaxXor2 maxXor2 = new MaxXor2();
            var result = maxXor2.solve(elements);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
