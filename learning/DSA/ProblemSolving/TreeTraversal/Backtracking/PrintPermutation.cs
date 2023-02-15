using System;
using System.Collections.Generic;
using System.Text;

namespace Backtracking
{
    internal class PrintPermutation
    {
        public void solve(int[] arr, int n, int i)
        {
            if (i == n - 1)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[j]);
                    
                }
                Console.WriteLine();
                //return;
            }

            for (int j = i; j < arr.Length; j++)
            {
                Swap(arr, i, j);

                solve(arr, arr.Length, i + 1);

                Swap(arr, i, j);
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
