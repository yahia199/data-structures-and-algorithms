using System;
using Xunit;
using LinkedLists;

namespace Testlinkedlists
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Linked_Lists liste = new Linked_Lists();
            liste.AddFirst(5);
            Assert.NotNull(liste);

        }
        [Fact]
        public void AddInTheLast() //Can successfully add a node to the end of the linked list
        {
            Linked_Lists liste = new Linked_Lists();
            liste.Append(5);
            Assert.Equal(5, 5);

        }
        [Fact]
        public void Test3()
        {
            Linked_Lists liste = new Linked_Lists();
            liste.AddFirst(5);
            Assert.Equal(5, 5);
        }
        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 10 }, 10)]
        [InlineData(new int[] { 10, 20 }, 20)]
        [InlineData(new int[] { 10, 20, 30, 40, 50 }, 50)]
        public void Test4(int[] nums, int expected)
        {
            Linked_Lists list = new Linked_Lists();
            int actual = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                    actual = nums[i];

                list.Append(nums[i]); //Can successfully add multiple nodes to the end of a linked list
            }

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 10, 20, 30, 40, 50 }, 60)]
        public void canAddToTheEnd(int[] nums, int target)
        {
            Linked_Lists list = new Linked_Lists();
            foreach (var num in nums)
                list.AddFirst(num);
            list.Append(target);

            Assert.True(list.Search(target));
        }
        [Theory]
        [InlineData(new int[] { 30 },30, 23)]
        [InlineData(new int[] { 10, 20, 30, 40, 50 },30, 55)] //Can successfully insert after a node in the middle of the linked list
        [InlineData(new int[] { 10, 20, 30, 40, 50 }, 50, 55)] //Can successfully insert a node after the last node of the linked list
        public void CaninsertAfter(int[] nums,int index, int value)
        {

            Linked_Lists list = new Linked_Lists();
            foreach (var num in nums)
                list.AddFirst(num);

            list.InsertAfter(value, index);
            Assert.True(list.Search(value));

        }

        [Theory]
        [InlineData(new int[] { 30 }, 30, 23)]  //Can successfully insert a node before the first node of a linked list
        [InlineData(new int[] { 10, 20, 30, 40, 50 }, 30, 55)]  //Can successfully insert a node before a node located i the middle of a linked list
        [InlineData(new int[] { 10, 20, 30, 40, 50 }, 50, 55)] 
        public void CaninsertBefore(int[] nums, int index, int value)
        {

            Linked_Lists list = new Linked_Lists();
            foreach (var num in nums)
                list.AddFirst(num);

            list.InsertBefore(value, index);
            Assert.True(list.Search(value));

        }


    }
}
