using System;
using System.Collections.Generic;
using System.Text;

namespace DyanmicProgramming
{
    internal class MinPerfectSquare
    {
        public int countMinSquares(int A)
        {
            var dp = new int[A +1];
            Array.Fill(dp, int.MaxValue);
            dp[0] = 0;
            var ans = 0;
            for (var i = 1; i <= A; i++)
            {
                for (var j = 1; j * j <= i; j++)
                {
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                }
            }
            return dp[A];
        }
    }
}
