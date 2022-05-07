using System;
using Xunit;
using Trees;
using System.Collections.Generic;

namespace TreeTest
{
    public class UnitTest1
    {
        public class UnitTestBinaryTree
        {
            [Fact]
            public void CanSuccessfullyInstantiateAnEmptyTree()
            {
                Binarytree binaryTree = new Binarytree(null);

                Assert.NotNull(binaryTree);
            }
            [Fact]
            public void CanSuccessfullyInstantiateATreeWithASingleRoot()
            {
                Node node = new Node(5);
                Binarytree binaryTree = new Binarytree(node);

                Assert.NotNull(binaryTree);
                Assert.Equal(5, binaryTree.Head.value);
            }
            [Fact]
            public void CanSuccessfullyAddALeftChildAndRightchildToASingleRootNode()
            {
                Node node1 = new Node(5);
                Node node2 = new Node(2);
                Node node3 = new Node(3);

                Binarytree binaryTree = new Binarytree(node1);

                binaryTree.Head = node1;
                binaryTree.Head.Left = node2;
                binaryTree.Head.Right = node3;

                Assert.Equal(5, binaryTree.Head.value);
                Assert.Equal(2, binaryTree.Head.Left.value);
                Assert.Equal(3, binaryTree.Head.Right.value);
            }
            [Fact]
            public void PreorderTraversalTest()
            {
                Node node1 = new Node(1);
                Node node2 = new Node(2);
                Node node3 = new Node(3);
                Node node4 = new Node(4);
                Node node5 = new Node(5);

                Binarytree binarytree = new Binarytree(node1);
                binarytree.Head = node1;
                binarytree.Head.Left = node2;
                binarytree.Head.Left.Right = node5;
                binarytree.Head.Right = node3;
                binarytree.Head.Right.Left = node4;

                Assert.Equal(new List<object> { 1, 2, 5,3,4 }, binarytree.Pre_Order(binarytree.Head));
            }
            [Fact]
            public void InorderTraversalTest()
            {
                Node node1 = new Node(1);
                Node node2 = new Node(2);
                Node node3 = new Node(3);
                Node node4 = new Node(4);
                Node node5 = new Node(5);

                Binarytree binarytree = new Binarytree(node1);
                binarytree.Head = node1;
                binarytree.Head.Left = node2;
                binarytree.Head.Left.Right = node5;
                binarytree.Head.Right = node3;
                binarytree.Head.Right.Left = node4;

                Assert.Equal(new List<object> { 2, 5, 1, 4, 3 }, binarytree.In_Order(binarytree.Head));
            }
            [Fact]
            public void PostorderTraversalTest()
            {
                Node node1 = new Node(1);
                Node node2 = new Node(2);
                Node node3 = new Node(3);
                Node node4 = new Node(4);
                Node node5 = new Node(5);

                Binarytree binarytree = new Binarytree(node1);
                binarytree.Head = node1;
                binarytree.Head.Left = node2;
                binarytree.Head.Left.Right = node5;
                binarytree.Head.Right = node3;
                binarytree.Head.Right.Left = node4;

                Assert.Equal(new List<object> { 5, 2, 4, 3, 1 }, binarytree.Post_Order(binarytree.Head));
            }
            [Fact]
            public void ContainMethodTest()
            {
               
                Binary_Search_Tree obj = new Binary_Search_Tree();
                obj.add(8);
                obj.add(3);
                obj.add(10);
                obj.add(2);
                obj.add(6);
                obj.add(14);
                obj.add(9);
                obj.add(9);

                Assert.True(obj.Contains(9));

            }
            [Fact]
            public void GetMaxTest()
            {

                Binary_Search_Tree obj = new Binary_Search_Tree();
                obj.add(8);
                obj.add(3);
                obj.add(10);
                obj.add(2);
                obj.add(6);
                obj.add(14);
                obj.add(9);
                obj.add(9);

                Assert.Equal(14, obj.Getmax());

            }
            [Fact]
            public void FizzBuzzTreeTest()
            {
                Node node1 = new Node(1);
                Node node2 = new Node(2);
                Node node3 = new Node(3);
                Node node4 = new Node(4);
                Node node5 = new Node(5);

                Binarytree binarytree = new Binarytree(node1);
                binarytree.Head = node1;
                binarytree.Head.Left = node2;
                binarytree.Head.Left.Right = node5;
                binarytree.Head.Right = node3;
                binarytree.Head.Right.Left = node4;

                Assert.Equal(new List<object> { 1, 2, "Buzz", "Fizz", 4 }, binarytree.FizzBuzzTree(binarytree.Head));
            }


        }
    }
}

