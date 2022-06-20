using Graphs.Classes;
using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {

            Graph graph = new Graph();
            graph.AddNode("1");
            graph.AddNode("2");
            graph.AddNode("3");


            Console.WriteLine($"Number of nodes in graph: {graph.Size()}");


            Vertex A = new Vertex("1");
            Vertex B = new Vertex("2");
            Vertex C = new Vertex("3");
            graph.AddEdge(A, B, 10);
            graph.AddEdge(A, C, 5);


            Console.WriteLine("Neighbors and weights of node A:");
            List<Edge> resultA = graph.GetNeighbors(A);
            foreach (Edge edge in resultA)
            {
                Console.Write($" {edge.Neighbor.Value} ");
                Console.Write($" {edge.Weight} ");
                Console.WriteLine();
            }
            Console.WriteLine("Neighbors and weights of node C:");
            List<Edge> resultC = graph.GetNeighbors(C);
            foreach (Edge edge in resultC)
            {
                Console.Write($" {edge.Neighbor.Value} ");
                Console.Write($" {edge.Weight} ");
                Console.WriteLine();
            }

            List<Vertex> nodes = graph.GetNodes();
            Console.Write("List of nodes in graph: ");
            foreach (Vertex node in nodes)
            {
                Console.Write($" {node.Value} ");
            }

        }
    }
    }

