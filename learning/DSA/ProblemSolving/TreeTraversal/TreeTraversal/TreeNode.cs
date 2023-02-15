using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    internal class TreeNode
    { 
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
        public int val { get; set; }
       
        public TreeNode(int data)
        {
            this.val = data;

        }
        
        public TreeNode(int[] values) : this(values, 0) { }

        TreeNode(int[] values, int index)
        {
            Load(this, values, index);
        }

        void Load(TreeNode tree, int[] values, int index)
        {
            this.val = values[index];
            if (index * 2 + 1 < values.Length)
            {
                this.left = new TreeNode(values, index * 2 + 1);
            }
            if (index * 2 + 2 < values.Length)
            {
                this.right = new TreeNode(values, index * 2 + 2);
            }
        }
    }
}
