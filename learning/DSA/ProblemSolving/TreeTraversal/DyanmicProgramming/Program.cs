using System;

namespace DyanmicProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //  FibonacciSeriesA1 fibonacciSeries = new FibonacciSeriesA1();
            //var n = 4;
            //var n = 6;
            //Console.WriteLine(fibonacciSeries.GetFibonacciSeriesNthValue(n));
            //Console.ReadLine();

            //var n = 6;
            //FibonacciSeriesA2 fibonacciSeriesA1 = new FibonacciSeriesA2();
            //Console.WriteLine(fibonacciSeriesA1.GetFibonacciSeriesNthValue(n));

            //var n = 6;
            //FibonacciSeriesA3 fibonacciSeriesA1 = new FibonacciSeriesA3();
            //Console.WriteLine(fibonacciSeriesA1.GetFibonacciSeriesNthValue(n));

            DanceLandPersonNumberOfWays personNumberOfWays = new DanceLandPersonNumberOfWays();
            //Console.WriteLine(personNumberOfWays.Solve(19));
            Console.WriteLine(personNumberOfWays.Solve(3));

            //DanceLandPersonNumberOfWaysOptimised personNumberOfWays = new DanceLandPersonNumberOfWaysOptimised();
            //Console.WriteLine(personNumberOfWays.Solve(3));
            //Console.WriteLine(personNumberOfWays.Solve(5));

            //MinPerfectSquare minPerfectSquare = new MinPerfectSquare();
            //var input = 6;
            //Console.WriteLine(minPerfectSquare.countMinSquares(6));

            //SixDiceThrow sixDiceThrow = new SixDiceThrow();

            //var input = 4;
            //Console.WriteLine(sixDiceThrow.solve(input));

            //LongestCommonSubsequence longestCommonSubsequence = new LongestCommonSubsequence();
            //var s1 = "abbcdgf";
            //var s2 = "bachegf";
            //Console.WriteLine(longestCommonSubsequence.Solve(s1,s2));

            Console.ReadLine();
        }
    }
}
