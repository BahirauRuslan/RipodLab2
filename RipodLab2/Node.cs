using System.Collections.Generic;

namespace RipodLab2
{
    public class Node
    {
        public Node()
        {
            Parents = new List<Node>();
        }

        public IList<Node> Parents { get; set; }

        public Node Next { get; set; }

        public string Value { get; set; }

        public string Type { get; set; }
    }
}
