using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DyanmicProgramming
{
    internal class LongestCommonSubsequence
    {
        public int Solve(string A, string B)
        {
            var n = A.Length-1;
            var m = B.Length-1;
            int[,] dp = new int[n+1,m+1];
            for (var i = 0; i <= n; i++)
            {
                for (var j = 0; j <= m; j++)
                    dp[i, j] = -1;
            }
            return Lcs(A, B, n, m, dp);
        }
        int Lcs(string s1, string s2, int i, int j, int[,] dp)
        {
            if (i == -1 || j == -1)
                return 0;
            if (dp[i,j] == -1)
            {
                if (s1[i] == s2[j])
                {
                    dp[i,j] = 1 + Lcs(s1, s2, i - 1, j - 1, dp);
                }
                else
                {
                    dp[i,j] = Math.Max(Lcs(s1, s2, i - 1, j, dp), Lcs(s1, s2, i, j - 1, dp));

                }

            }
            return dp[i,j];
        }
    }
}
