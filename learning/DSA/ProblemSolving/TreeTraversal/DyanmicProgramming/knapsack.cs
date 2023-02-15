using System;
using System.Collections.Generic;
using System.Text;

namespace DyanmicProgramming
{
    class Knapsack
    {
        public int solve(List<int> A, List<int> B, int C)
        {
            return kpiterative(A.Count, C, A, B);
        }

        int kpiterative(int n, int k, List<int> A, List<int> B)
        {
            int[,] dp = new int[n + 1, k + 1];
            for (var i = 0; i <= k; i++)
            {
                dp[0,i] = 0;
            }
            for (var i = 1; i <= n; i++)
            {
                for (var j = 0; j <= k; j++)
                {
                    int a = dp[i - 1, j];
                    if (j >= B[i])
                    {
                        a = Math.Max(a, dp[i - 1, j - B[i]] + A[i]);
                    }
                    dp[i, j] = a;
                }
            }
            return dp[n, k];
        }
    }

}
