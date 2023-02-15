using System;
using System.Collections.Generic;
using System.Text;

namespace DyanmicProgramming
{
    internal class MaxSumWithAdjacent
    {
        public int adjacent(List<int> A)
        { 
            var n = A.Count;
            List<int> dp = new List<int>(A.Count);

            dp[0] = A[0];
            dp[1] = Math.Max(A[0], A[1]);

            for (int i = 2; i < n; i++)
            {
                dp[i] = Math.Max(Math.Max(dp[i - 1], dp[i - 2] + A[i]), A[i]);
            
            }
            return dp[n-1];
        }
    }
}
