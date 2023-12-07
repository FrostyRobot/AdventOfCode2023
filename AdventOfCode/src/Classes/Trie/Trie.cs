using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Trie
    {
        public Node indexNode = null;
        public const char ROOT_NODE_MARKER = '^';

        private readonly Node _root;

        public bool isDead = false;  

        public enum State
        {
            NOMATCH,
            MATCH,
            INCREMENTED
        }

        public Trie()
        {
            _root = new Node(null, ROOT_NODE_MARKER);
            indexNode = _root;

            Build();
        }

        public void Build()
        {
            Node nodeO = Insert(_root, 'o');
            Node nodeON = Insert(nodeO, 'n');
            Node nodeONE = Insert(nodeON, 'e');

            Node nodeT = Insert(_root, 't'); 

            Node nodeTW = Insert(nodeT, 'w');
            Node nodeTWO = Insert(nodeTW, 'o');

            Node nodeTH = Insert(nodeT, 'h');
            Node nodeTHR = Insert(nodeTH, 'r');
            Node nodeTHRE = Insert(nodeTHR, 'e');
            Node nodeTHREE = Insert(nodeTHRE, 'e');

            Node nodeF = Insert(_root, 'f');
            Node nodeFO = Insert(nodeF, 'o');
            Node nodeFOU = Insert(nodeFO, 'u');
            Node nodeFOUR = Insert(nodeFOU, 'r');

            Node nodeFI = Insert(nodeF, 'i');
            Node nodeFIV = Insert(nodeFI, 'v');
            Node nodeFIVE = Insert(nodeFIV, 'e');

            Node nodeS = Insert(_root, 's');
            Node nodeSI = Insert(nodeS, 'i');
            Node nodeSIX = Insert(nodeSI, 'x');

            Node nodeSE = Insert(nodeS, 'e');
            Node nodeSEV = Insert(nodeSE, 'v');
            Node nodeSEVE = Insert(nodeSEV, 'e');
            Node nodeSEVEN = Insert(nodeSEVE, 'n');

            Node nodeE = Insert(_root, 'e');
            Node nodeEI = Insert(nodeE, 'i');
            Node nodeEIG = Insert(nodeEI, 'g');
            Node nodeEIGH = Insert(nodeEIG, 'h');
            Node nodeEIGHT = Insert(nodeEIGH, 't');

            Node nodeN = Insert(_root, 'n');
            Node nodeNI = Insert(nodeN, 'i');
            Node nodeNIN = Insert(nodeNI, 'n');
            Node nodeNINE = Insert(nodeNIN, 'e');
        }

        public Node Insert(Node parent, char s)
        {
            Node theNode = new Node(parent, s);

            if(parent == null){
                _root.Add(theNode);
            }
            else{
                parent.Add(theNode);
            }

            return theNode;
        }

        public State Index(char s)
        {
            indexNode = indexNode.FindChildNode(s);

            if(null == indexNode){
                isDead = true;
                return State.NOMATCH;
            }
            else if(indexNode.IsLeaf()){
                return State.MATCH;
            }
            else{
                return State.INCREMENTED;
            }
        }
    }
}
