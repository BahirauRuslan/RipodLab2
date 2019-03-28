using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipodLab2
{
    public class Plan
    {
        private IList<IList<Node>> steps;

        public Plan(Graph graph)
        {
            steps = new List<IList<Node>>();
            CreatePlan(graph);
        }

        public int GetCountType(int step, string type)
        {
            int count = 0;

            for (var i = 0; i < steps[step].Count; i++)
            {
                if (steps[step][i].Type.Equals(type))
                {
                    count++;
                }
            }

            return count;
        }

        public IList<IList<Node>> GetSteps()
        {
            return steps;
        }

        private void CreatePlan(Graph graph)
        {
            while (graph.Roots.Count != 0)
            {
                IList<Node> newNodes = new List<Node>();
                steps.Add(new List<Node>());
                for (var i = 0; i < graph.Roots.Count; i++)
                {
                    if (graph.Roots[i].Parents.Count == 0 && graph.Roots[i].Next != null)
                    {
                        steps.Last().Add(graph.Roots[i]);
                        if (!HasNode(newNodes, graph.Roots[i].Next))
                        {
                            newNodes.Add(graph.Roots[i].Next);
                        }

                        graph.Roots[i].Next.Parents.Remove(graph.Roots[i]);
                    }
                    else if (graph.Roots[i].Next == null)
                    {
                        steps.Last().Add(graph.Roots[i]);
                    }
                    else
                    {
                        if (!HasNode(newNodes, graph.Roots[i]))
                        {
                            newNodes.Add(graph.Roots[i]);
                        }
                    }
                }

                graph.Roots = newNodes;
            }
        }

        private bool HasNode(IEnumerable<Node> nodes, Node node)
        {
            foreach (IList<Node> step in steps)
            {
                foreach (Node nodeItem in step)
                {
                    if (nodeItem.Value.Equals(node.Value))
                    {
                        return true;
                    }
                }
            }

            foreach (Node nodeItem in nodes)
            {
                if (nodeItem.Value.Equals(node.Value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
