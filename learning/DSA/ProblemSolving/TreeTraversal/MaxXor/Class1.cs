using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxXor
{
    class Node {
        public Dictionary<int, Node> ch = new Dictionary<int, Node>();
        public Node() {
            
        }
    }
    internal class MaxXor
    {
        public int solve(List<int> A)
        {
            var max = A.Max();
            var maxSetBit = setBitNumber(max);
            Node root = new Node();
            for (int i = 0; i < A.Count; i++)
            {
                insert(root, A[i], maxSetBit);
            }
            var ans = int.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                ans = Math.Max(ans, A[i] ^ query(root, A[i], maxSetBit));
            }
            return ans;
        }

        private int query(Node root, int ele, int maxSetBit)
        {
            int ans = 0;
            //for (int i = maxSetBit; i >= 0; i--)
            for (int i = 31; i >= 0; i--)
            {
                int e = checkBit(ele, i);
                //if e == 1 we need 0
                // if e == 0 we need 1
                // for e , find 1 - e
                if (e == 0)
                {
                    if (root.ch.ContainsKey(1))
                    {
                        ans = ans + (1 << i);
                        root = root.ch[1];
                    }
                    else
                    {
                        root = root.ch[0];
                    }
                }
                else {

                    if (root.ch.ContainsKey(0))
                    {
                        root = root.ch[0];
                    }
                    else {
                        ans = ans + (1 << i);
                        root = root.ch[1];
                    }
                }
                    
            }
            return ans;
        }
        int checkBit(int n, int k)
        {
            return  (n & (1 << k)) > 0 ? 1 : 0;
        }
         void insert(Node root, int ele, int maxSetBit)
        {
            for (int i = 31; i >= 0; i--)
            {
                int e = checkBit(ele, i);
                if (!root.ch.ContainsKey(e))
                {
                    root.ch.Add(e,new Node());
                    
                }
                root = root.ch[e];
            }
        }

        static int setBitNumber(int n)
        {
            if (n == 0)
                return 0;

            int msb = 0;
            n = n / 2;

            while (n != 0)
            {
                n = n / 2;
                msb++;
            }

            return (1 << msb);
        }
    }
}
