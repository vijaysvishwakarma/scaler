using System;
using System.Collections.Generic;
using System.Text;

namespace DyanmicProgramming
{
    internal class DanceLandPersonNumberOfWaysOptimised
    {
        public int Solve(int A)
        {
            return NumberOfWays(A);
        }
        private int NumberOfWays(int n)
        {

            var a = 1;
            var b = 1;
            var c = 0;
            if (n <= 1)
            {
                return n;
            }

            for (var i = 2; i <= n; i++)
            {
                //dp[i] = (dp[i - 1] + dp[i - 2] * (i - 1)) % 10003;
                c = (a + b * (i - 1)) % 10003;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
