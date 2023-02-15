using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulation
{
    internal class LongestPalindrome
    {
        public string solve(string A)
        {
            var ans = 0;
            var s = 0;
            var index = 0;
            var prevIndex = 0;
            for (int i = 0; i < A.Length; i++)
            {
                // ans = Math.Max(expand(i, i, A), ans);
                var temp = expand(i, i, A, ref index);
                if (temp > ans)
                {
                    ans = temp;
                    //   index = i;
                    prevIndex = index;
                    index = 0;
                }

            }
            
            for (int i = 0; i < A.Length -1; i++)
            {
                var temp = expand(i, i + 1, A, ref index);
                if (temp > ans)
                {
                    ans = temp;
                    // index = i;
                    prevIndex = index;
                    index = 0;
                }

               // ans = Math.Max(, ans);
            }

             Console.WriteLine(ans);
            return A.Substring(prevIndex + 1, ans);
        }


        private int expand(int s, int e, string A, ref int  index)
        {
            while (s >= 0 && e < A.Length && A[s] == A[e])
            {
                s--;
                e++;
            }
            index = s;
            return e-s-1;
        }
    }

    
}
