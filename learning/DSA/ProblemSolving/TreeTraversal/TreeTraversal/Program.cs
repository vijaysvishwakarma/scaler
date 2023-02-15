// See https://aka.ms/new-console-template for more information
using TreeTraversal;

Console.WriteLine("Hello, World!");
var data = new int[] { 3, 9, 8,-1, 6, 2, -7, -4, 8, 10 };
//var data = new int[] { 1,2,3,4,5,6};

List<List<int>> mylist = new List<List<int>>();
mylist.Add(new List<int> { 1, 2, 3, 4 });
mylist.Add(new List<int> { 5, 6, 7, 8 });


TreeNode binaryTree = new TreeNode(data);
LevelOrderTraversal levelOrderTraversal = new LevelOrderTraversal();
levelOrderTraversal.LevelWiseTraverse(binaryTree);
