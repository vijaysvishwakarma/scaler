using System;
using System.Collections.Generic;
using System.Text;

namespace GreedyAlgorithms
{
    internal class FindMaximumJobs
    {
        public int solve(List<int> A, List<int> B)
        {
            List<KeyValuePair<int, int>> startEndJobs = new List<KeyValuePair<int, int>>();
            if (A.Count < 1)
                return 0;

            for (var i = 0; i < A.Count; i++)
            {
                startEndJobs.Add(new KeyValuePair<int, int>(B[i], A[i]));
            }
            startEndJobs.Sort((x, y) => x.Key.CompareTo(y.Key));
            var counter = 0;
            var endTime = int.MinValue;
            for (var i = 0; i < startEndJobs.Count; i++)
            {
                if (startEndJobs[i].Value >= endTime)
                {
                    counter++;
                    endTime = startEndJobs[i].Key;
                }
                
            }

            return counter;
        }
    }
}
