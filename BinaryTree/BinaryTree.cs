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

        public void Traverse(Node node)
        {
            Console.WriteLine(node.Value);
            if (node.Left != null)
            {
                Traverse(node.Left);
            }

            if (node.Right != null)
            {
                Traverse(node.Right);
            }
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
