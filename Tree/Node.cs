namespace Tree
{
    public class Node
    {
        public List<Node> Children { get; set; }
        public int Value { get; set; }

        public Node(int value)
        {
            Value = value;
            Children = new List<Node>();
        }
        public void AddChild(Node child)
        {
            Children.Add(child);
        }
    }
}
