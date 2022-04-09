using System;
using System.Collections.Generic;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Linked_Lists liste = new Linked_Lists();

            //liste.Append(10);
            //liste.Append(15);
            //liste.Append(20);
            //liste.AddFirst(1);
            //liste.Search(7);
            //liste.Search(10);
            //liste.InsertBefore(5, 15);
            //liste.InsertAfter(5, 15);
            //liste.FromEnd(4);
          //  liste.ToString();
            Linked_Lists list1 = new Linked_Lists();
            list1.AddFirst(1);
            list1.AddFirst(2);
           // list1.AddFirst(3);
            Console.WriteLine( list1.Tostring());




            Linked_Lists list2 = new Linked_Lists();

            list2.AddFirst(5);
            list2.AddFirst(10);
            list2.AddFirst(15);

            Console.WriteLine(list2.Tostring());


            liste.ZipLists(list1, list2);
            Console.WriteLine(liste.Tostring());


            liste.ReverseList(list2);
            Console.WriteLine(list2.Tostring());




        }


    }
}
