namespace BinaryTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(Node root)
        {
            Root = root;
        }

        public void AddNode(Node node, Node parent, bool side)
        {
            if (side)
            {
                parent.Left = node;
            }
            else
            {
                parent.Right = node;
            }

            node.Father = parent;
        }

        public void RemoveNode(Node node)
        {
            if (node == null)
                return;

            // Leaf nodes
            if (node.Left == null && node.Right == null)
            {
                if (node.Father == null)
                {
                    Root = null;
                }
                else if (node.Father.Left == node)
                {
                    node.Father.Left = null;
                }
                else
                {
                    node.Father.Right = null;
                }
            }
            // One child
            else if (node.Left == null || node.Right == null)
            {
                Node child = node.Left ?? node.Right;

                if (node.Father == null)
                {
                    Root = child;
                    child.Father = null;
                }
                else if (node.Father.Left == node)
                {
                    node.Father.Left = child;
                    child.Father = node.Father;
                }
                else
                {
                    node.Father.Right = child;
                    child.Father = node.Father;
                }
            }
            // Complete node (two child nodes)
            else
            {
                // Node left goes up
                Node replacement = node.Left;

                // First we find the rightmost node of the left subtree
                Node insertionPoint = replacement;
                while (insertionPoint.Right != null)
                {
                    insertionPoint = insertionPoint.Right;
                }

                // Inserts the rightmost node of the left subtree into the right subtree
                insertionPoint.Right = node.Right;
                node.Right.Father = insertionPoint;

                // Replace the node with the left child node
                if (node.Father == null)
                {
                    Root = node.Left;
                    node.Left.Father = null;
                }
                else if (node.Father.Left == node)
                {
                    node.Father.Left = node.Left;
                    node.Left.Father = node.Father;
                }
                else
                {
                    node.Father.Right = node.Left;
                    node.Left.Father = node.Father;
                }
            }

            // Cleaning the node
            node.Left = null;
            node.Right = null;
            node.Father = null;
        }

        public void TraversePreOrder(Node node)
        {
            Console.WriteLine(node.Value);

            if (node.Left != null)
            {
                TraversePreOrder(node.Left);
            }

            if (node.Right != null)
            {
                TraversePreOrder(node.Right);
            }
        }

        public void TraverseInOrder(Node node)
        {
            if (node.Left != null)
            {
                TraverseInOrder(node.Left);
            }

            Console.WriteLine(node.Value);

            if (node.Right != null)
            {
                TraverseInOrder(node.Right);
            }
        }

        public void TraversePostOrder(Node node)
        {
            if (node.Left != null)
            {
                TraversePostOrder(node.Left);
            }
            if (node.Right != null)
            {
                TraversePostOrder(node.Right);
            }

            Console.WriteLine(node.Value);
        }

        public void TraverseBreadthFirst(Node node)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                Console.WriteLine(current.Value);
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null) {
                    queue.Enqueue(current.Right);
                }
            }
        }
    }
}
