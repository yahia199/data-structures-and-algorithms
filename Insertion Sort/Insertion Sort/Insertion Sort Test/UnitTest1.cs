using System;
using Xunit;
using Insertion_Sort;

namespace Insertion_Sort_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestFirst()
        {
            int[] First = { 8, 4, 23, 42, 16, 15 };

            Assert.Equal(new int[] { 4, 8, 15, 16, 23, 42 }, Program.InsertionSort(First));
        }
        [Fact]
        public void TestReverseSorted()
        {
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };

            Assert.Equal(new int[] { -2, 5, 8, 12, 18, 20 }, Program.InsertionSort(reverseSorted));
        }

        [Fact]
        public void TestFewUniques()
        {
            int[] fewUniques = { 5, 12, 7, 5, 5, 7 };

            Assert.Equal(new int[] { 5, 5, 5, 7, 7, 12 }, Program.InsertionSort(fewUniques));
        }

        [Fact]
        public void TestNearlySorted()
        {
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

            Assert.Equal(new int[] { 2, 3, 5, 7, 11, 13 }, Program.InsertionSort(nearlySorted));
        }

    }
}
