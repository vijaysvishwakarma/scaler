namespace DyanmicProgramming
{
    internal class FibonacciSeriesA3
    {
        // Bottom to top approach
        //  TC = O(N);
        //  SC = O(N);
        public int GetFibonacciSeriesNthValue(int n)
        {
            return Fibo(n);
        }
        private int Fibo(int n)
        {
            int[] dp = new int[n + 1];
            
            dp[0] = 0;
            dp[1] = 1;
            if (n <= 1)
            {
                dp[n] = n;
                return n;
            }

            for (var i = 2; i <= n; i++)
            {
                dp[i] = dp[i-1] + dp[i-2];
            }
            return dp[n];
        }
    }
}
