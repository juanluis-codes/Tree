using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public Node Father { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
            Father = null;
        }

        public override string ToString()
        {
            string fatherVal = Father != null ? Father.Value.ToString() : "None";
            string leftVal = Left != null ? Left.Value.ToString() : "None";
            string rightVal = Right != null ? Right.Value.ToString() : "None";

            string type = Father == null ? "Root node" : "Node";

            return $"[{type}] Value: {Value} -> Father: ({fatherVal}), Left: ({leftVal}), Right: ({rightVal})";
        }
    }
}
