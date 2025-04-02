// See https://aka.ms/new-console-template for more information

using Tree;

Node root = new Node(2, null);
Node child1 = new Node(3, root);
Node child2 = new Node(1, root);
Node child3 = new Node(5, child1);
Node child4 = new Node(6, child2);
Node child5 = new Node(8, child2);
Node child6 = new Node(9, child2);

Tree.Tree tree = new Tree.Tree(root);
tree.Traverse(root);
Console.WriteLine();
tree.TraverseBreadthFirst(root);
