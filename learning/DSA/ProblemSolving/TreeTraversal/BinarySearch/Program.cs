using System;
using System.Collections.Generic;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search!");
            FindUnique findUnique = new FindUnique();
            /// TC - O(n)
            var input = new List<int>() {3,3,1,1,8,8,10,10,9,66,66,22,22,44,44 };
            Console.Write(findUnique.Solve(input));
            Console.ReadLine();

        }
    }
}
