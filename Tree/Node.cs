namespace Tree
{
    public class Node
    {
        public List<Node> Children { get; set; }
        public Node Father { get; set; }
        public int Value { get; set; }

        public Node(int value, Node father)
        {
            Value = value;
            Children = new List<Node>();
            Father = father;
            if (father != null)
            {
                father.AddChild(this);
            }
        }
        private void AddChild(Node child)
        {
            Children.Add(child);
        }
    }
}
