using System;
using System.Collections.Generic;
using System.Text;

namespace DyanmicProgramming
{
    internal class SixDiceThrow
    {
        public int solve(int A)
        {
            int[] dp = new int[A + 1];
            dp[0] = 1;
            for (int i = 1; i <= A; i++)
            {
                int s = 0;
                for (int j = 1; j <= 6 && j <= i; j++)
                { 
                    s = (s +  dp[i-j]) % 1000000007;
                }
                dp[i] = s;
                
            }
            return dp[A] % 10000000;
        }
    }
}
