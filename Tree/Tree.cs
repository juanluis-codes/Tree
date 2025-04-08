using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Tree
    {
        public Node Root { get; set; }
        public Tree(Node root)
        {
            Root = root;
        }

        public void TraversePreOrder(Node node)
        {
            Console.WriteLine(node.Value);
            foreach (var child in node.Children)
            {
                TraversePreOrder(child);
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
                foreach (var child in current.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }
    }
}
