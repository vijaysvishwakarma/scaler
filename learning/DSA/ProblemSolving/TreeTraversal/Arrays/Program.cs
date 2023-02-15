using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution solution = new Solution();
            var result = solution.majorityElement(new List<int> { 2, 1, 1 });
            Console.WriteLine(result);

            //RotationGame1 game1 = new RotationGame1();
            //RotationGame2 game2 = new RotationGame2();
            //var input = new int[] { 1, 2, 3, 4 };
            //var b = 2;
            //game2.solve(input, b);

            // Equilibrium
            //Equilibrium equilibrium = new Equilibrium();
            //var inputdata = new List<int>() { -7, 1, 5, 2, -4, 3, 0 };
            //Console.WriteLine(equilibrium.solve(inputdata));

            //PF_PickFromBothSide pickFromBothSide = new PF_PickFromBothSide();
            var inputdata = new List<int>() { 5, -2, 3, 1, 2 };
            var b = 3;
            //var inputdata = new List<int>() { 1,2};
            //var b = 1;
            //Console.WriteLine(pickFromBothSide.solve(inputdata, b));

            var caseInput = Int32.Parse(Console.ReadLine());
            while (caseInput > 0)
            {
                var arrayLength = Int32.Parse(Console.ReadLine());
                var input = Console.ReadLine().Trim().Split(" ").Select(x => Int32.Parse(x)).ToArray();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 != 0)
                    {
                        Console.Write(input[i] + " ");
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 == 0)
                    {
                        Console.Write(input[i] + " ");
                    }
                }
                
                caseInput--;
            }

        }
    }
}
