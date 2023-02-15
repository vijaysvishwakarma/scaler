using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    internal class LevelOrderTraversal
    {
        public void LevelWiseTraverse(TreeNode root)
        { 
            Queue<TreeNode> qTreeNode = new Queue<TreeNode>();
            qTreeNode.Enqueue(root);
            while (qTreeNode.Count > 0)
            { 
                TreeNode node = qTreeNode.Peek();
                qTreeNode.Dequeue();
                Console.WriteLine(node.val);
                if (node.left != null)
                {
                    qTreeNode.Enqueue(node.left);
                }
                if (node.right != null) { 
                    qTreeNode.Enqueue(node.right);
                }
            }
        }
    }
}
