using Hash_Table.Classes;
using System;
using Xunit;
using Hash_Table;
using System.Collections.Generic;

namespace HashTableTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddAKeyValueToHashtableResultsInTheValueBeingInTheDataStructure()
        {
            HashTable testHashtable = new HashTable();

            testHashtable.Add("Test", "Value");

            Assert.True(testHashtable.Contains("Test"));
        }

        [Fact]
        public void CanRetrieveBasedOnAKeyReturnsTheValueStored()
        {
            HashTable testHashtable = new HashTable();

            testHashtable.Add("Test", "Value");

            Assert.Equal("Value", testHashtable.Get("Test"));
        }

        [Fact]
        public void ReturnsNullForAKeyThatDoesNotExistInTheHashtable()
        {
            HashTable testHashtable = new HashTable();

            testHashtable.Add("Test", "Value");

            Assert.Null(testHashtable.Get("Hello"));
        }

        [Fact]
        public void CanHandleACollisionWithinTheHashtable()
        {
            HashTable testHashtable = new HashTable();

            testHashtable.Add("Test", "ValueOne");
            testHashtable.Add("eTst", "ValueTwo");

            Assert.Equal(testHashtable.Hash("eTst"), testHashtable.Hash("Test"));
        }

        [Fact]
        public void CanrRetrieveAValueFromABucketWithinTheHashtableThatHasACollision()
        {
            HashTable testHashtable = new HashTable();

            testHashtable.Add("Test", "ValueOne");
            testHashtable.Add("eTst", "ValueTwo");

            Assert.Equal(testHashtable.Hash("eTst"), testHashtable.Hash("Test"));
            Assert.Equal("ValueOne", testHashtable.Get("Test"));
            Assert.Equal("ValueTwo", testHashtable.Get("eTst"));
        }

        [Fact]
        public void CanrHashAKeyToAnInRangeValue()
        {
            HashTable testHashtable = new HashTable();

            testHashtable.Add("Test", "ValueOne");

            Assert.InRange(testHashtable.Hash("Test"), 0, 1024);
        }
        [Fact]
        public void ReturnTheFirstWordToOccurMoreThanOnceTestOne()
        {
            string testPhrase = "Once upon a time, there was a brave princess who...";

            Assert.Equal("a", Program.RepeatedWordfunctin(testPhrase));
        }

        [Fact]
        public void ReturnTheFirstWordToOccurMoreThanOnceTestTwo()
        {
            string testPhrase = "Hello, World! Hello, World!";

            Assert.Equal("hello", Program.RepeatedWordfunctin(testPhrase));
        }

        [Fact]
        public void ReturnTheFirstWordToOccurMoreThanOnceTestThree()
        {
            string testPhrase = "Hello, World! World! World!";

            Assert.NotEqual("hello", Program.RepeatedWordfunctin(testPhrase));
        }
        [Fact]
        public void TestingWithNoCollisions()
        {
            HashTable left = new HashTable();
            left.Add("Bob", "First");
            left.Add("Frank", "First");

            HashTable right = new HashTable();
            right.Add("Bob", "Second");
            right.Add("Jim", "Second");

            List<string> expected = new List<string>();
            expected.Add("Frank, First, NULL");
            expected.Add("Bob, First, Second");

            List<string> actual = Program.LeftJoin(left, right);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingWithCollisions()
        {
            HashTable left = new HashTable();
            left.Add("Bob", "First");
            left.Add("Frank", "First");

            HashTable right = new HashTable();
            right.Add("Bob", "Second");
            right.Add("Jim", "Second");

            List<string> expected = new List<string>();
            expected.Add("Frank, First, NULL");
            expected.Add("Bob, First, Second");

            List<string> actual = Program.LeftJoin(left, right);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingWithAdditionalData()
        {
            HashTable left = new HashTable();
            left.Add("Bob", "First");
            left.Add("Frank", "First");
            left.Add("JimBob", "Crab Cakes");
            left.Add("Wu", "Tang");

            HashTable right = new HashTable();
            right.Add("Bob", "Second");
            right.Add("Jim", "Second");
            right.Add("JimBob", "Are Tasty");
            right.Add("Wu", "Clan");

            List<string> expected = new List<string>();
            expected.Add("Frank, First, NULL");
            expected.Add("Bob, First, Second");
            expected.Add("Wu, Tang, Clan");
            expected.Add("JimBob, Crab Cakes, Are Tasty");

            List<string> actual = Program.LeftJoin(left, right);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CanDetect5And3AsIntersections()
        {

            Node n1 = new Node("Yahia", "1000JD");
            Node n2 = new Node("Ahmad", "15000JD");
            Node n3 = new Node("Njood", "2000JD");
            Node n4 = new Node("Mahmoud", "5000JD");
            Node n5 = new Node("Omar", "444000JD");

            Node n6 = new Node("Yahia", "2000JD");
            Node n7 = new Node("Ahmad", "15000JD");
            Node n8 = new Node("Njood", "500JD");

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Head.Left = n2;
            tree1.Head.Right = n3;
            tree1.Head.Left.Right = n4;

            BinaryTree tree2 = new BinaryTree(n5);
            tree2.Head.Left = n6;
            tree2.Head.Right = n7;
            tree2.Head.Right.Left = n8;

            List<string> expected = new List<string> { "2000JD", "15000JD" };

            //Assert
            Assert.Equal(expected, Program.TreeIntersection(tree1, tree2));
        }

        [Fact]
        public void CanDetectAllAsIntersections()
        {
            //Arrange

            Node n1 = new Node("Yahia", "1000JD");
            Node n2 = new Node("Ahmad", "15000JD");
            Node n3 = new Node("Njood", "2000JD");
            Node n4 = new Node("Mahmoud", "500JD");
            Node n5 = new Node("Omar", "444000JD");

            Node n6 = new Node("Yahia", "2000JD");
            Node n7 = new Node("Ahmad", "15000JD");
            Node n8 = new Node("Njood", "500JD");

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Head.Left = n2;
            tree1.Head.Right = n3;
            tree1.Head.Left.Right = n4;

            BinaryTree tree2 = new BinaryTree(n5);
            tree2.Head.Left = n6;
            tree2.Head.Right = n7;
            tree2.Head.Right.Left = n8;

            List<string> expected = new List<string> { "2000JD","15000JD","500JD"};

            //Assert
            Assert.Equal(expected, Program.TreeIntersection(tree1, tree2));
        }

        [Fact]
        public void CanDetectNoIntersections()
        {
            //Arrange

            Node n1 = new Node("Yahia", "1000JD");
            Node n2 = new Node("Ahmad", "150500JD");
            Node n3 = new Node("Njood", "20200JD");
            Node n4 = new Node("Mahmoud", "5000JD");
            Node n5 = new Node("Omar", "444000JD");

            Node n6 = new Node("Yahia", "2000JD");
            Node n7 = new Node("Ahmad", "15000JD");
            Node n8 = new Node("Njood", "500JD");

            BinaryTree tree1 = new BinaryTree(n1);
            tree1.Head.Left = n2;
            tree1.Head.Right = n3;
            tree1.Head.Left.Right = n4;

            BinaryTree tree2 = new BinaryTree(n5);
            tree2.Head.Left = n6;
            tree2.Head.Right = n7;
            tree2.Head.Right.Left = n8;

            List<string> expected = new List<string>();

            //Assert
            Assert.Equal(expected, Program.TreeIntersection(tree1, tree2));
        }
    }
}
