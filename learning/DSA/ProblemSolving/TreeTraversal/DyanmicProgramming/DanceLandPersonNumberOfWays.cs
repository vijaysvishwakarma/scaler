using System;
using System.Collections.Generic;
using System.Text;

namespace DyanmicProgramming
{
    internal class DanceLandPersonNumberOfWays
    {
        public int Solve(int A)
        {
            return NumberOfWays(A);
        }
        private int NumberOfWays(int n)
        {
            int[] dp = new int[n + 1];

            dp[0] = 1;
            dp[1] = 1;
            if (n <= 1)
            {
                dp[n] = n;
                return n;
            }

            for (var i = 2; i <= n; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 2] * (i - 1)) % 10003;
            }
            return dp[n];
        }
    }
}
