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
        public void Test2()
        {
            Linked_Lists liste = new Linked_Lists();
            liste.AddLast(5);
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

                list.AddFirst(nums[i]);
            }

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 20,30, 40, 50 }, 1)]
        [InlineData(new int[] { 10, 2, 30, 40, 50 }, 2)]
        [InlineData(new int[] { 10, 20, 30, 40, 50 }, 30)]
        [InlineData(new int[] { 10, 20, 30, 40}, 40)]
        [InlineData(new int[] { 10, 20, 30, 40, 50 }, 50)]
        public void test5(int[] nums, int target)
        {
            Linked_Lists list = new Linked_Lists();
            foreach (var num in nums)
                list.AddFirst(num);

            Assert.True(list.Search(target));
        }



    }
}
