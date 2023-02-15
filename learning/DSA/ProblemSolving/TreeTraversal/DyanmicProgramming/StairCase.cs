using System;
using System.Collections.Generic;
using System.Text;

namespace DyanmicProgramming
{
    internal class StairCase
    {
        public int climbStairs(int A)
        {
            return cilmbStairs(A);
        }
        private int cilmbStairs(int n)
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
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }

    }
}
