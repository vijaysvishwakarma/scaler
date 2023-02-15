using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    /**
 * Definition for binary tree
 * class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) {this.val = x; this.left = this.right = null;}
 * }
 */
    using System.Collections;
    using System.Collections.Generic;
    class Solution
    {
        public int lca(TreeNode A, int B, int C)
        {
            List<int> path1 = new List<int>();
            List<int> path2 = new List<int>();

            if (!findPath(A, path1, B) || !findPath(A, path2, C))
            {
                return -1;
            }
            var i = 0;
            for (; i < path1.Count && i < path2.Count; i++)
            {
                if (path1[i] != path2[i])
                    break;
            }
            return path1[i - 1];
        }

        bool findPath(TreeNode A, List<int> path, int value)
        {
            var root = A;
            if (root == null)
                return false;

            path.Add(root.val);

            if (root.val == value)
                return true;

            if (root.left != null && findPath(root.left, path, value))
            {
                return true;
            }

            if (root.right != null && findPath(root.right, path, value))
            {
                return true;
            }

            path.RemoveAt(path.Count - 1);

            return false;
        }
    }

}
