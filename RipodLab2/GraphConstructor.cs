using System.Collections.Generic;
using System.Windows.Forms;

namespace RipodLab2
{
    public class GraphConstructor
    {
        public Graph ConstructGraph(DataGridView nodes, string types)
        {
            var graph = new Graph();
            var nodesArr = ReadNodes(types);
            FormGraph(nodesArr, nodes);
            graph.Roots = GetRoots(nodesArr);

            return graph;
        }

        private IList<Node> GetRoots(Node[] nodesArr)
        {
            var roots = new List<Node>();

            for (var i = 0; i < nodesArr.Length; i++)
            {
                if (nodesArr[i].Parents.Count == 0)
                {
                    roots.Add(nodesArr[i]);
                }
            }

            return roots;
        }

        private void FormGraph(Node[] nodesArr, DataGridView nodes)
        {
            for (var i = 0; i < nodesArr.Length; i++)
            {
                var index = FildColumnIndex(nodes, i);
                if (index > -1)
                {
                    nodesArr[i].Next = nodesArr[index];
                    nodesArr[index].Parents.Add(nodesArr[i]);
                }
                else
                {
                    nodesArr[i].Next = null;
                }
            }
        }

        private Node[] ReadNodes(string types)
        {
            var nodesArr = new Node[types.Length];

            for (var i = 0; i < nodesArr.Length; i++)
            {
                nodesArr[i] = new Node
                {
                    Value = (i + 1).ToString(),
                    Type = types[i].ToString()
                };
            }

            return nodesArr;
        }

        private int FildColumnIndex(DataGridView nodes, int rowIndex)
        {
            for (var i = 0; i < nodes.ColumnCount; i++)
            {
                if (nodes[i, rowIndex].Value.Equals("1"))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
