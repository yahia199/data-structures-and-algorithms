using Graphs.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace GraphTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddNode()
        {
            Graph graph = new Graph();

            Vertex node = (Vertex)graph.AddNode("A");

            Assert.Contains(node, graph.Vertices);
        }

        [Fact]
        public void AddEdge()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("A");
            Vertex B = (Vertex)graph.AddNode("B");
            Vertex C = (Vertex)graph.AddNode("C");

            graph.AddEdge(A, B, 15);

            Assert.NotEmpty(A.Edge);
        }

        [Fact]
        public void GetGraphNodeList()
        {
            Graph graph = new Graph();
            graph.AddNode("1");
            graph.AddNode("2");
            graph.AddNode("3");
            graph.AddNode("4");
            graph.AddNode("5");
            graph.AddNode("6");
            graph.AddNode("7");

            var list = graph.GetNodes();

            Assert.IsType<List<Vertex>>(list);
        }

        [Fact]
        public void GetNeighborsFromNode()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("1");
            Vertex B = (Vertex)graph.AddNode("2");
            Vertex C = (Vertex)graph.AddNode("3");
            graph.AddEdge(A, B, 35);
            graph.AddEdge(A, C, 8);

            var result = graph.GetNeighbors(A);

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void NieghborNodesHaveWeight()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("1");
            Vertex B = (Vertex)graph.AddNode("2");
            graph.AddEdge(A, B, 55);

            Edge[] result = graph.GetNeighbors(A).ToArray();

            Assert.Equal(55, result[0].Weight);
        }

        [Fact]
        public void GetSizeOfGraph()
        {
            Graph graph = new Graph();
            graph.AddNode("1");
            graph.AddNode("2");
            graph.AddNode("3");

            int count = graph.Size();

            Assert.Equal(3, count);
        }

        [Fact]
        public void GraphCanHaveOneNodeAndEdge()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("A");
            graph.AddEdge(A, A, 7);

            List<Vertex> result = graph.GetNodes();

            Assert.Equal(A, result.ToArray()[0]);
        }

        [Fact]
        public void EmptyGraphReturnsNull()
        {
            Graph graph = new Graph();

            var result = graph.GetNodes();

            Assert.Null(result);
        }
        [Fact]
        public void CanReturnSelfPointingEdge()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            Vertex A = new Vertex("A");
            graph.AddEdge(A, A, 1);

            List<Vertex> result = graph.BreadthFirst(A);

            Assert.Equal("A", result[0].Edge[0].Neighbor.Value);
        }

        [Fact]
        public void CanReturnEdgelessNode()
        {
            Graph graph = new Graph();
            graph.AddNode("Edgeless");
            Vertex edgelessNode = new Vertex("Edgeless");

            List<Vertex> result = graph.BreadthFirst(edgelessNode);

            Assert.Equal("Edgeless", result[0].Value);
        }
        [Fact]
        public void BusinessTriptest()
        {
            Graph graph = new Graph();
            graph.AddNode("Amman");
            graph.AddNode("Zarqa");
            graph.AddNode("Irbid");
            graph.AddNode("Jarash");
            graph.AddNode("Salt");
            Vertex A = new Vertex("Amman");
            Vertex B = new Vertex("Zarqa");
            Vertex C = new Vertex("Irbid");
            Vertex D = new Vertex("Jarash");
            Vertex E = new Vertex("Salt");
            graph.AddEdge(A, B, 50);
            graph.AddEdge(A, C, 32);
            graph.AddEdge(B, C, 110);
            graph.AddEdge(C, D, 99);
            graph.AddEdge(C, E, 159);
            graph.AddEdge(D, E, 75);
            string[] citynames = { "Amman", "Zarqa", "Irbid" };
            var result = Graph.BusinessTrip(graph, citynames);
            var expected = 160;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GraphReturnsPreOrderList()
        {
            Graph graph = new Graph();
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            Vertex D = new Vertex("D");
            Vertex E = new Vertex("E");
            Vertex F = new Vertex("F");
            Vertex G = new Vertex("G");
            Vertex H = new Vertex("H");
            Vertex I = new Vertex("I");
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");
            graph.AddNode("H");
            graph.AddNode("I");
            graph.AddEdge(A, B, 5);
            graph.AddEdge(A, C, 5);
            graph.AddEdge(B, D, 5);
            graph.AddEdge(B, E, 5);
            graph.AddEdge(C, F, 5);
            graph.AddEdge(C, G, 5);
            graph.AddEdge(F, G, 5);
            graph.AddEdge(F, H, 5);
            graph.AddEdge(G, H, 5);
            graph.AddEdge(H, I, 5);

            List<Vertex> list = Graph.DepthFirst(graph);
            List<object> result = new List<object>();
            foreach (Vertex node in list)
            {
                result.Add(node.Value);
            }
            List<object> expected = new List<object> { "A", "B", "D", "E", "C", "F", "G", "H", "I" };

            Assert.Equal(expected, result);
        }


    }
}
