using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DyanmicProgramming
{
    internal class CoidChange2
    {
        public int coinchange2(List<int> A, int B)
        {
            {
            int n = A.Count();
            int[] first = new int[B + 1];
            int[] second = new int[B + 1];

            for (int i = 0; i < n; i++)
            {
                second[0] = 1;
                for (int j = 1; j <= B; j++)
                {
                    second[j] = (first[j] + (j - A[i] >= 0 ? second[j - A[i]] : 0)) % 1000007;
                }
                int[] temp = first;
                first = second;
                second = temp;
            }

            return first[B];
        }
    }
}
