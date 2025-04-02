namespace BinaryTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<Node> Nodes { get; set; }

        public BinaryTree(Node root)
        {
            Root = root;
            Nodes = new List<Node>();
            Nodes.Add(root);
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
            Nodes.Add(node);
        }
    }
}
