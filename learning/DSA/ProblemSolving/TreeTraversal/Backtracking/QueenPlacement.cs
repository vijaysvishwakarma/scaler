using System;
using System.Collections.Generic;
using System.Text;

namespace Backtracking
{
    internal class QueenPlacement
    {
        public void Solve(int[][] mat, int n, int i)
        {
            if (i == n)
            {
                Console.WriteLine("print matrix");
                for (int row = 0; row < n; row++)
                {
                    for (int column = 0; column < n; column++)
                    {
                        Console.WriteLine(mat[row][column]);
                    }
                }
            }

            for (int j = 0; j < n; j++)
            {
                if (check(mat, i, j))
                { 
                    mat[i][j] = 1;
                    Solve(mat, n, i++);
                    mat[i][j] = 0;
                }
            }
        }

        private bool check(int[][] mat, int i, int j)
        {
            int r = 0;
            int c = 0;
            for (r = 0; r < i; r++)
            {
                if (mat[r][j] == 1)
                {
                    return false;
                }
            }

            // left diagonal
            r = i; c = j;
            while (r >= 0 && c >= 0)
            {
                if (mat[r][c] == 1)
                {
                    return false;
                }
                r--; c--;
            }

            // right diagonal
            r = i; c = j;
            while (r >= 0 && c <= 0)
            {
                if (mat[r][c] == 1)
                {
                    return false;
                }
                r--; c++;
            }

            return true;
        }
    }
}
