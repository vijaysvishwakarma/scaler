using System;
using System.Collections.Generic;
using System.Text;

namespace Sum_of_Common_Node
{
    public class TreeNode
    {
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
        public int val { get; set; }

        public TreeNode(int data)
        {
            this.val = data;
        }

    }
    public class Solution
    {
        public int solve(TreeNode A, TreeNode B)
        {
            
                int sum = 0;
                Stack<TreeNode> s1 = new Stack<TreeNode>();
                Stack<TreeNode> s2 = new Stack<TreeNode>();
            while (true) {
                if (A != null)
                {
                    s1.Push(A);
                    A = A.left;
                }
                else if (B != null)
                { 
                    s2.Push(B);
                    B = B.left;
                }else if (s1.Count > 0 && s2.Count > 0)
                { 
                    A = s1.Peek();
                    B = s2.Peek();
                    if (A.val == B.val)
                    {
                          sum = sum + A.val;
                        A = s1.Pop();
                        B = s2.Pop();
                        A = A.right;
                        B = B.right;
                    }
                    else if (A.val < B.val)
                    {
                        A = s1.Pop();
                        A = A.right;
                        B = null;

                    }
                    else if (A.val > B.val) {
                                   
                        B = s2.Pop() ;
                        B= B.right ;
                        A = null;
                    }

                }
                else
                {

                    break;
                }
            
            }

            return sum % (10 * 9 + 7);
        }
    }
}
