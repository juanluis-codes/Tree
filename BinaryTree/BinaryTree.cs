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
    }
}
