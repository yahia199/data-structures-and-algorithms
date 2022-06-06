using Hash_Table.Classes;
using System;
using Xunit;

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

            Assert.Equal("Value", testHashtable.Get("Test").Value);
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
            Assert.Equal("ValueOne", testHashtable.Get("Test").Value);
            Assert.Equal("ValueTwo", testHashtable.Get("eTst").Value);
        }

        [Fact]
        public void CanrHashAKeyToAnInRangeValue()
        {
            HashTable testHashtable = new HashTable();

            testHashtable.Add("Test", "ValueOne");

            Assert.InRange(testHashtable.Hash("Test"), 0, 1024);
        }
    }
}
