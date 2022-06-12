using Hash_Table.Classes;
using System;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node("Yahia", "1000JD");
            Node n2 = new Node("Ahmad", "1500JD");
            Node n3 = new Node("Njood", "2000JD");
            Node n4 = new Node("Mahmoud", "500JD");
            Node n5 = new Node("Omar", "4000JD");


            HashTable hashtable = new HashTable();

            hashtable.Add(n1.Key, n1.Value);
            hashtable.Add(n2.Key, n2.Value);
            hashtable.Add(n3.Key, n3.Value);
            hashtable.Add(n4.Key, n4.Value);
            hashtable.Add(n5.Key, n5.Value);

            Console.WriteLine(hashtable.Get("Yahia").Value);

            Console.WriteLine(hashtable.Get("Ahmad").Value);

            Console.WriteLine(hashtable.Get("Njood").Value);

            Console.WriteLine(hashtable.Contains("Mahmoud"));

            Console.WriteLine(hashtable.Contains("Omar"));

            Console.WriteLine(hashtable.Contains("Khaled"));
        }
    }
}
