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

    }
}
