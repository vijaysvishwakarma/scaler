using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class Solution
    {
        public int majorityElement(List<int> A)
        {
            // n = 5
            // n = 5/2 = 2
            // find occurence of each number
            var numberOccurrence = new Dictionary<int, int>();
            var maxFloorTime = Math.Floor(A.Count / 2.0);
            if (A.Count == 1)
                return A[0];

            for (var i = 0; i < A.Count; i++)
            {
                if (numberOccurrence.TryGetValue(A[i], out int occurred))
                {
                    numberOccurrence[A[i]] = ++occurred;
                }
                else
                {
                    numberOccurrence.Add(A[i], 1);
                }

            }

            foreach (var key in numberOccurrence.Keys)
            {
                if (numberOccurrence[key] > maxFloorTime)
                    return key;
            }
            return -1;
        }
    }

}

