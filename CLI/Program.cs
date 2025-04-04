﻿// See https://aka.ms/new-console-template for more information

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
tree.Traverse(treeRoot);
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

binaryTree.Traverse(binaryRoot);
Console.WriteLine();
binaryTree.TraverseBreadthFirst(binaryRoot);

