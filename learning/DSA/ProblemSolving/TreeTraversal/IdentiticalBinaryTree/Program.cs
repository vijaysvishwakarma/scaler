// See https://aka.ms/new-console-template for more information
using System;

//var firstTreeNode = new TreeNode(1);7
//firstTreeNode.left = new TreeNode(11);
//firstTreeNode.left.left = new TreeNode(112);
//var secondTreeNode = new TreeNode(1);
//secondTreeNode.left = new TreeNode(11);

//Solution solution = new Solution();

//Console.WriteLine(solution.isSameTree(firstTreeNode, secondTreeNode));
//Console.ReadLine();

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

class Solution {
    public int isSameTree(TreeNode A, TreeNode B)
    { 
        if (A == null && B == null)
            return 1;
        
        if (A == null && B != null || B == null && A != null)
            return 0;

        if (A != null && B != null && A.val != B.val)
            return 0;


        int result = isSameTree(A.left, B.left) == 1 &&
                isSameTree(A.right, B.right) == 1 ? 1: 0;
        return result;
        
    }

}

