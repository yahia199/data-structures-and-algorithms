using System;
using System.Collections.Generic;

namespace Trees
{
   public class Program
    {
        static void Main(string[] args)
        {
            

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            Binarytree binarytree = new Binarytree(node1 );
            binarytree.Head = node1;
            binarytree.Head.Left = node2;
            binarytree.Head.Left.Right = node5;
            binarytree.Head.Right = node3;
            binarytree.Head.Right.Left = node4;


            Console.WriteLine("Pre order");
            var Pre_Order = binarytree.Pre_Order(binarytree.Head);
            foreach (var item in Pre_Order)
            {
                Console.WriteLine(item);
            }
            binarytree.myList.Clear();
            Console.WriteLine("In order");
            var In_Order = binarytree.In_Order(binarytree.Head);
            foreach (var item in In_Order)
            {
                Console.WriteLine(item);
            }
            binarytree.myList.Clear();
            Console.WriteLine("Post order");
            var Post_Order = binarytree.Post_Order(binarytree.Head);
            foreach (var item in Post_Order)
            {
                Console.WriteLine(item);
            }
            binarytree.myList.Clear();


            Console.WriteLine("FizzBazz");

            var Fizz = binarytree.FizzBuzzTree(binarytree.Head);
            foreach (var item in Fizz)
            {
                Console.WriteLine(item);
            }
            Binary_Search_Tree obj = new Binary_Search_Tree();
            obj.add(8);
            obj.add(3);
            obj.add(10);
            obj.add(2);
            obj.add(6);
            obj.add(14);
            obj.add(9);
            obj.add(9);
            Console.WriteLine(obj.Contains(9));

            Console.WriteLine(obj.Getmax());



        }
      
    }
}
