// See https://aka.ms/new-console-template for more information

using Tree;
using BinaryTree;

Console.WriteLine("Tree");

Tree.Node treeRoot = new Tree.Node(2, null);
Tree.Node treeChild1 = new Tree.Node(3, treeRoot);
Tree.Node treeChild2 = new Tree.Node(1, treeRoot);
Tree.Node treeChild3 = new Tree.Node(5, treeChild1);
Tree.Node treeChild4 = new Tree.Node(6, treeChild2);
Tree.Node treeChild5 = new Tree.Node(8, treeChild2);
Tree.Node treeChild6 = new Tree.Node(9, treeChild2);

Tree.Tree tree = new Tree.Tree(treeRoot);
tree.TraversePreOrder(treeRoot);
Console.WriteLine();
tree.TraverseBreadthFirst(treeRoot);

Console.WriteLine("Binary Tree");

BinaryTree.Node binaryRoot = new BinaryTree.Node(2);
BinaryTree.Node binaryChild1 = new BinaryTree.Node(1);
BinaryTree.Node binaryChild2 = new BinaryTree.Node(4);
BinaryTree.Node binaryChild3 = new BinaryTree.Node(8);
BinaryTree.Node binaryChild4 = new BinaryTree.Node(3);
BinaryTree.Node binaryChild5 = new BinaryTree.Node(6);
BinaryTree.Node binaryChild6 = new BinaryTree.Node(5);
BinaryTree.Node binaryChild7 = new BinaryTree.Node(7);

BinaryTree.BinaryTree binaryTree = new BinaryTree.BinaryTree(binaryRoot);
binaryTree.AddNode(binaryChild1, binaryRoot, true);
binaryTree.AddNode(binaryChild2, binaryChild1, true);
binaryTree.AddNode(binaryChild3, binaryChild1, false);
binaryTree.AddNode(binaryChild4, binaryRoot, false);
binaryTree.AddNode(binaryChild5, binaryChild4, true);
binaryTree.AddNode(binaryChild6, binaryChild4, false);
binaryTree.AddNode(binaryChild7, binaryChild6, false);

binaryTree.TraversePreOrder(binaryRoot);
Console.WriteLine();
binaryTree.TraverseBreadthFirst(binaryRoot);

Console.WriteLine();

binaryTree.RemoveNode(binaryChild4);

//binaryTree.TraversePreOrder(binaryRoot);
//Console.WriteLine();
//binaryTree.TraverseBreadthFirst(binaryRoot);
//Console.WriteLine(binaryRoot.ToString());
//Console.WriteLine(binaryChild1.ToString());
//Console.WriteLine(binaryChild2.ToString());
//Console.WriteLine(binaryChild3.ToString());
//Console.WriteLine(binaryChild5.ToString());
//Console.WriteLine(binaryChild6.ToString());
//Console.WriteLine(binaryChild7.ToString());

Console.WriteLine("Binary Search Tree");

BinaryTree.Node binarySearchRoot = new BinaryTree.Node(30);
BinaryTree.Node binarySearchChild1 = new BinaryTree.Node(4);
BinaryTree.Node binarySearchChild2 = new BinaryTree.Node(7);
BinaryTree.Node binarySearchChild3 = new BinaryTree.Node(33);
BinaryTree.Node binarySearchChild4 = new BinaryTree.Node(55);
BinaryTree.Node binarySearchChild5 = new BinaryTree.Node(67);
BinaryTree.Node binarySearchChild6 = new BinaryTree.Node(42);
BinaryTree.Node binarySearchChild7 = new BinaryTree.Node(8);

BinaryTree.BinarySearchTree binarySearchTree = new(binarySearchRoot);
binarySearchTree.AddNode(binarySearchChild1);
binarySearchTree.AddNode(binarySearchChild2);
binarySearchTree.AddNode(binarySearchChild3);
binarySearchTree.AddNode(binarySearchChild4);
binarySearchTree.AddNode(binarySearchChild5);
binarySearchTree.AddNode(binarySearchChild6);
binarySearchTree.AddNode(binarySearchChild7);

binarySearchTree.TraverseInOrder(binarySearchRoot);
Console.WriteLine();
binarySearchTree.TraverseBreadthFirst(binarySearchRoot);



