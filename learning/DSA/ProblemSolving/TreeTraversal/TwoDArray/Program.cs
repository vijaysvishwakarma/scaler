using System;
using System.Collections.Generic;

namespace TwoDArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transpose transpose = new Transpose();
            List<List<int>> A = new List<List<int>>();
            A.Add(new List<int>() { 21, 62, 16, 44, 55, 100, 16, 86, 29 });
            A.Add(new List<int>() { 62, 72, 85, 35, 14, 1, 89, 15, 73 });
            A.Add(new List<int>() { 42, 44, 30, 56, 25, 52, 61, 23, 54 });
            A.Add(new List<int>() { 5, 35, 12, 35, 55, 74, 50, 50, 80 });
            A.Add(new List<int>() { 2, 65, 65, 82, 26, 36, 66, 60, 1 });
            A.Add(new List<int>() { 18, 1, 16, 91, 42, 11, 72, 97, 35 });
            A.Add(new List<int>() { 23, 57, 9, 28, 13, 44, 40, 47, 98 });


            var result = transpose.Solve(A);

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[0].Count; j++)
                {
                    Console.Write(result[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();    
            }

           // Rotate90Degree rotate90Degree = new Rotate90Degree();   


            Console.ReadLine();
        }
    }
}
