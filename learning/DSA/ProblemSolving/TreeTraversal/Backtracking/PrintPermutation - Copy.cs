using System;
using System.Collections.Generic;
using System.Text;

namespace Backtracking
{
    internal class PrintPermutation1
    {
        public void solve(int[] arr, List<int> resultSet, int i)
        {
            if (i == arr.Length)
            {
                for (int j = 0; j < resultSet.Count; j++)
                {
                    Console.Write(resultSet[j]);
                    
                }
                Console.WriteLine();
                return;
            }

            //for (int j = i; j < arr.Length; j++)
            //{

           //     resultSet.Add(5);
                solve(arr, resultSet, i + 1);
                
                resultSet.Add(arr[i]);
                solve(arr, resultSet, i + 1);
                resultSet.Remove(arr[i]);
            /// i = 0, 
            ///  solve(a, result, 0) -> solve(a, result, 1) -> solve(a, result, 2)

            //}
        }

        private static void Swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
