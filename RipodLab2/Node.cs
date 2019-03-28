using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
