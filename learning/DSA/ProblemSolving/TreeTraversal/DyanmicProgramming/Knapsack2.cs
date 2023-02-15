using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DyanmicProgramming
{
    internal class Knapsack2
    {
        public int solve(List<int> A, List<int> B, int C)
        {
            //dp[i,j] is the dp state denoting the min size the knapsack should be for 
            // value of j
            //for j=0 the size(dpStates) will be 0; for i=0 the size(dpStates) will be INFINITE
            int n = A.Count();
            int m = 500 * A.Max();
            int[,] dp = new int[2, m + 1];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    if (j != 0) dp[i, j] = C + 1;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    dp[i % 2, j] = dp[(i - 1) % 2, j];
                    if (j >= A[i - 1])
                    {
                        int a = B[i - 1] + dp[(i - 1) % 2, j - A[i - 1]];
                        dp[i % 2, j] = Math.Min(dp[i % 2, j], a);
                    }
                }
            }
            int val = 0;
            for (int i = 0; i <= 1; i++)
            {
                for (int k = m; k >= 0; k--)
                {
                    if (dp[i, k] <= C)
                    {
                        val = Math.Max(k, val);
                    }
                }
            }
            return val;
        }
    }
}
