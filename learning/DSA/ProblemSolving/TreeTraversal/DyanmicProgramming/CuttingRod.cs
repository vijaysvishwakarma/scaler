using System;
using System.Collections.Generic;
using System.Text;

namespace DyanmicProgramming
{
    internal class CuttingRod
    {
        public int Solve(List<int> A)
        {
            int n = A.Count;
            int[] dp = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                dp[i] = -1;
            }
            dp[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                int res = 0;
                for (int j = 0; j < i; j++)
                {
                    res = Math.Max(res, A[j] + dp[i - j - 1]);
                }
                dp[i] = res;
            }
            return dp[n];
        }
    }
}
