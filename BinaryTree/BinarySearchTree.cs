using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree(Node root) : base(root)
        {
        }

        public void AddNode(Node node)
        {
            if (node == null)
            {
                return;
            }

            Node current = Root;

            while (true)
            {
                if (node.Value < current.Value)
                {
                    if (current.Left == null)
                    {
                        base.AddNode(node, current, true);
                        break;
                    }

                    current = current.Left;
                }

                if (node.Value > current.Value)
                {
                    if (current.Right == null)
                    {
                        base.AddNode(node, current, false);
                        break;
                    }

                    current = current.Right;
                }
            }
        }
    }
}
