using System;
using Xunit;
using LinkedLists;
using Microsoft.VisualStudio.TestPlatform.TestHost;

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
        [InlineData(new int[] { 10, 20, 30, 40, 50 }, 60)] //Can successfully add a node to the end of the linked list
        public void canAddToTheEnd(int[] nums, int target)
        {
            Linked_Lists list = new Linked_Lists();
            foreach (var num in nums)
                list.AddFirst(num);
            list.Append(target);

            Assert.True(list.Search(target));
        }
        [Theory]
        [InlineData(new int[] { 30 }, 30, 23)]
        [InlineData(new int[] { 10, 20, 30, 40, 50 }, 30, 55)] //Can successfully insert after a node in the middle of the linked list
        [InlineData(new int[] { 10, 20, 30, 40, 50 }, 50, 55)] //Can successfully insert a node after the last node of the linked list
        public void CaninsertAfter(int[] nums, int index, int value)
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


        [Fact]
        public void FromEndTest()
        {
            Linked_Lists liste = new Linked_Lists();
            liste.Append(5);
            liste.Append(4);
            liste.Append(3);
            liste.Append(2);
            liste.Append(1);
            liste.FromEnd(4);

            //Assert
            Assert.Equal(5, liste.FromEnd(4));
        }
        [Fact]
        public void WhereKisgreaterthanthelengthofthelinkedlist() //Where k is greater than the length of the linked list
        {
            Linked_Lists liste = new Linked_Lists();
            liste.Append(5);
            liste.Append(4);
            liste.Append(3);
            liste.Append(2);
            liste.Append(1);
            liste.FromEnd(10);

            //Assert
            Assert.Equal(-1, liste.FromEnd(10));
        }
        [Fact]
        public void WhereKandthelengthofthelistarethesame() //Where k and the length of the list are the same
        {
            Linked_Lists liste = new Linked_Lists();
            liste.Append(5);
            liste.Append(4);
            liste.Append(3);
            liste.Append(2);
            liste.Append(1);
            liste.FromEnd(4);

            //Assert
            Assert.Equal(5, liste.FromEnd(4));
        }
        [Fact]
        public void WhereKisnotapositiveinteger() //Where k is not a positive integer
        {
            Linked_Lists liste = new Linked_Lists();
            liste.Append(5);
            liste.Append(4);
            liste.Append(3);
            liste.Append(2);
            liste.Append(1);
            liste.FromEnd(-2);

            //Assert
            Assert.Equal(-1, liste.FromEnd(-2));
        }
        [Fact]
        public void Wherethelinkedlistisofasize1() //Where the linked list is of a size 1
        {
            Linked_Lists liste = new Linked_Lists();
            liste.Append(5);
            liste.FromEnd(0);

            //Assert
            Assert.Equal(5, liste.FromEnd(0));
        }
        [Fact]
        public void whereKisnotattheend() //where k is not at the end
        {
            Linked_Lists liste = new Linked_Lists();
            liste.Append(5);
            liste.Append(4);
            liste.Append(3);
            liste.Append(2);
            liste.Append(1);
            liste.FromEnd(2);

            //Assert
            Assert.Equal(3, liste.FromEnd(2));
        }
        [Fact]

        public void Testziplist()
        {
            Linked_Lists list1 = new Linked_Lists();
            list1.AddFirst(1);
            list1.AddFirst(2);
            list1.AddFirst(3);




            Linked_Lists list2 = new Linked_Lists();

            list2.AddFirst(5);
            list2.AddFirst(10);
            list2.AddFirst(15);

            Linked_Lists liste = new Linked_Lists();
            liste.ZipLists(list1, list2);
            Assert.Equal("[ 3 ] -> [ 15 ] -> [ 2 ] -> [ 10 ] -> [ 1 ] -> [ 5 ] -> NULL", liste.Tostring());




        }
        [Fact]

        public void Testziplist2()
        {
            Linked_Lists list1 = new Linked_Lists();
            list1.AddFirst(1);
            list1.AddFirst(2);




            Linked_Lists list2 = new Linked_Lists();

            list2.AddFirst(5);
            list2.AddFirst(10);
            list2.AddFirst(15);

            Linked_Lists liste = new Linked_Lists();
            liste.ZipLists(list1, list2);
            Assert.Equal("[ 2 ] -> [ 15 ] -> [ 1 ] -> [ 10 ] -> [ 5 ] -> NULL", liste.Tostring());
        }
    }
}