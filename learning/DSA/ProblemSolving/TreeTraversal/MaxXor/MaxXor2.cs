using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxXor
{
    internal class MaxXor2
    {
        class Node
        {
            public int ch;
            public Node[] children;
            public Node(int data)
            {
                ch = data;
                children = new Node[2];
            }
        }
        public int solve(List<int> A)
        {
            var max = A.Max();
            var maxNoBit = Convert.ToString(max, 2).Length;
            Node root = new Node('0');
            for (int i = 0; i < A.Count; i++)
            {
                insert(root, A[i], maxNoBit);
            }
            var ans = int.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                ans = Math.Max(ans, A[i] ^ query(root, A[i], maxNoBit));
            }
            return ans;
        }

        private int query(Node root, int ele, int maxSetBit)
        {
            int ans = 0;
            var curr = root;
            for (int i = maxSetBit; i > 0; i--)
            {
                int indexBit = checkBit(ele, i);
                //if e == 1 we need 0
                // if e == 0 we need 1
                // for e , find 1 - e
                if (curr.children[indexBit == 0 ? 1 : 0] != null)
                {
                    indexBit = indexBit == 0 ? 1 : 0;
                    ans += indexBit * (int)(Math.Pow(2, i - 1));
                }
                else if (curr.children[indexBit] != null)
                {

                    ans += indexBit * (int)(Math.Pow(2, i - 1));
                }
                else
                {
                    break;
                }
                curr = curr.children[indexBit];
            }
            return ans;
        }
        int checkBit(int n, int k)
        {
            return (1 & (n >> (k - 1)));
        }
        void insert(Node root, int ele, int maxSetBit)
        {
            var curr = root;
            for (int i = maxSetBit; i > 0; i--)
            {
                int indexBit = checkBit(ele, i);
                if (curr.children[indexBit] == null)
                {
                    curr.children[indexBit] = new Node(indexBit);

                }
                curr = curr.children[indexBit];
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