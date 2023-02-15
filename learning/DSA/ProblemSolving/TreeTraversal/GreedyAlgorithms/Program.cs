using System;
using System.Collections.Generic;

namespace GreedyAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //GreedyAlgorithm greedyAlgorithm = new GreedyAlgorithm();
            //var input = new List<KeyValuePair<int, int>>();
            //input.Add(new KeyValuePair<int, int>(1, 250));
            //input.Add(new KeyValuePair<int, int>(1, 200));
            //input.Add(new KeyValuePair<int, int>(1, 350));
            //input.Add(new KeyValuePair<int, int>(2, 150));
            //input.Add(new KeyValuePair<int, int>(2, 200));
            //input.Add(new KeyValuePair<int, int>(4, 250));
            //input.Add(new KeyValuePair<int, int>(4, 300));
            //input.Add(new KeyValuePair<int, int>(5, 600));
            //input.Add(new KeyValuePair<int, int>(5, 100));
            //input.Add(new KeyValuePair<int, int>(5, 400));
            //Console.WriteLine(greedyAlgorithm.maxCost(input));

            FindMaximumJobs findMaximumJobs = new FindMaximumJobs();
            //var startJob = new List<int> {1,5,7,1 };
            //var endJob = new List<int> {7,8,8,8 };
            var startJob = new List<int> { 3, 2, 6 };
            var endJob = new List<int> { 9, 8, 9 };
            
            
            Console.WriteLine(findMaximumJobs.solve(startJob, endJob));
            Console.ReadLine();
        }
    }
}
