using System;
using System.Collections.Generic;
using System.Text;

namespace DyanmicProgramming
{
    internal class FibonacciSeriesA2
    {
        // Top to bottom approach
        // TC = O(N)
        // SC = O(N)
        public int GetFibonacciSeriesNthValue(int n)
        {
            return Fibo(n);
        }
        private int Fibo(int n)
        {
            int[] dp = new int[n + 1];
            for (var i = 0; i < n + 1; i++)
            {
                dp[i] = -1;
            }
            if (n <= 1)
            {
                dp[n] = n;
                return n;
            }

            if (dp[n] == -1)
            { 
                dp[n] = Fibo(n - 1) + Fibo(n - 2);
                return dp[n];
            }
            return dp[n];
        }
    }
}
