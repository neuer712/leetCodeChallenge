using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _133__CloneGraph
    {
        Dictionary<int, Node> nodeDict= new Dictionary<int, Node>();

        public Node CloneGraph(Node node)
        {
            if (node == null)
            {
                return null;
            }
            Node result = new Node(node.val);
            nodeDict.Add(node.val, result);
            List<Node> newNeighbors = new List<Node>();
            result.neighbors = newNeighbors;
            foreach (Node neighbor in node.neighbors)
            {
                if (nodeDict.TryGetValue(neighbor.val, out Node someNodeKnown))
                {
                    newNeighbors.Add(someNodeKnown);
                }
                else
                { 
                    newNeighbors.Add(CloneGraph(neighbor));
                }
            }

            return result;
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
