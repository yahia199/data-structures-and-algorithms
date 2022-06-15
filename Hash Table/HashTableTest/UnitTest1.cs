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
    }
}
