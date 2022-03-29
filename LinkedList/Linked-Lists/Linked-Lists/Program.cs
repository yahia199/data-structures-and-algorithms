using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Linked_Lists liste = new Linked_Lists();

            liste.Append(10);
            liste.Append(15);
            liste.Append(20);
            liste.AddFirst(1);
            liste.Search(7);
            liste.Search(10);
            liste.InsertBefore(5, 15);
            liste.InsertAfter(5, 15);
            liste.ToString();

        }
    }
}
