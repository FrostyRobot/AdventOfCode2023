using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Node
    {
        public char Value { get; set; }       
        public String chainedValue { get; set; }
        
        public List<Node> Children { get; set; }
        public Node Parent { get; set; }

        public Node(Node parent, char value)
        {
            Value = value;
            Children = new List<Node>();
            Parent = parent;

            if(parent != null)
            {
                if(parent.Value == Trie.ROOT_NODE_MARKER){
                    chainedValue = value.ToString();
                }
                else{
                    chainedValue = Parent.chainedValue + value;
                }
            }
        }

        public bool IsLeaf()
        {
            return Children.Count == 0;
        }

        public Int32 getDecimal()
        {
            switch(chainedValue)
            {
                case "one":return 1;
                case "two": return 2;
                case "three": return 3;
                case "four": return 4;
                case "five": return 5;
                case "six": return 6;
                case "seven": return 7;
                case "eight": return 8;
                case "nine": return 9;
                default: throw new Exception("Something went wrong here");
            }
        }

        public void Add(Node childNode)
        {
            Children.Add(childNode);
        }

        public Node FindChildNode(char c)
        {
            foreach (var child in Children)
                if (child.Value == c)
                    return child;

            return null;
        }

        public void DeleteChildNode(char c)
        {
            for (var i = 0; i < Children.Count; i++)
                if (Children[i].Value == c)
                    Children.RemoveAt(i);
        }
    }
}
