using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.Classes
{
   public class Graph
    {
        public List<Vertex> Vertices { get; set; } = new List<Vertex>();

        public Object AddNode(Object value)
        {
            Vertex node = new Vertex(value);
            Vertices.Add(node);
            return node;
        }

        public void AddEdge(Vertex vertA, Vertex vertB, int weight)
        {
            if (vertA == vertB)
            {
                Vertex point = Vertices.Find(v => v.Value == vertA.Value);
                Edge edge = new Edge(point, weight);
                Vertices.Find(v => v.Value == vertA.Value).Edge.Add(edge);
                return;
            }

            Vertex pointA = Vertices.Find(v => v.Value == vertA.Value);
            Vertex pointB = Vertices.Find(v => v.Value == vertB.Value);

            Edge edgeA = new Edge(pointB, weight);
            pointA.Edge.Add(edgeA);

            Edge edgeB = new Edge(pointA, weight);
            pointB.Edge.Add(edgeB);
        }

        public List<Vertex> GetNodes()
        {
            if (Vertices.Count == 0)
            {
                return null;
            }
            else
            {
                return Vertices;
            }
        }

        public List<Edge> GetNeighbors(Vertex node)
        {
            return Vertices.Find(v => v.Value == node.Value).Edge;
        }


        public int Size()
        {
            return Vertices.Count;
        }
        public List<Vertex> BreadthFirst(Vertex node)
        {
            Vertex root = Vertices.Find(n => n.Value == node.Value);
            List<Vertex> nodePath = new List<Vertex>();
            Queue<Vertex> nodeQueue = new Queue<Vertex>();

            root.Visited = true;
            nodeQueue.Enqueue(root);

            while (nodeQueue.Count > 0)
            {
                Vertex front = nodeQueue.Dequeue();
                nodePath.Add(front);

                foreach (Edge edge in front.Edge)
                {
                    if (!edge.Neighbor.Visited)
                    {
                        edge.Neighbor.Visited = true;
                        nodeQueue.Enqueue(edge.Neighbor);
                    }
                }
            }

            return nodePath;
        }
        public static int? BusinessTrip(Graph graph, string[] cityNames)
        {
            int Cost = 0;
            if (cityNames.Length <= 1)
            {
                return null;
            }
            for (int i = 0; i < cityNames.Length - 1; i++)
            {
                List<Edge> Edges = graph.GetNeighbors(new Vertex(cityNames[i]));

                if (!Edges.Exists(n => n.Neighbor.Value.ToString() == cityNames[i + 1]))
                {
                    return null;
                }
                else
                {
                    Cost += Edges.Find(n => n.Neighbor.Value.ToString() == cityNames[i + 1]).Weight;
                }
            }
            return Cost;
        }

    }
}
