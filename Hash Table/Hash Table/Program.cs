﻿using Hash_Table.Classes;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hash_Table
{
    public class Program
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

            Node n6 = new Node("Yahia", "2000JD");
            Node n7 = new Node("Ahmad", "15000JD");
            Node n8 = new Node("Njood", "200000JD");
            Node n9 = new Node("Mahmoud", "55500JD");
            Node n10 = new Node("Omar", "444000JD");
            HashTable hashtable2 = new HashTable();

            hashtable2.Add(n6.Key, n6.Value);
            hashtable2.Add(n7.Key, n7.Value);
            hashtable2.Add(n8.Key, n8.Value);
            hashtable2.Add(n9.Key, n9.Value);
            hashtable2.Add(n10.Key, n10.Value);

            //Console.WriteLine(hashtable.Get("Yahia"));

            //Console.WriteLine(hashtable.Get("Ahmad"));

            //Console.WriteLine(hashtable.Get("Njood"));

            //Console.WriteLine(hashtable.Contains("Mahmoud"));

            //Console.WriteLine(hashtable.Contains("Omar"));

            //Console.WriteLine(hashtable.Contains("Khaled"));

            //Console.WriteLine("+++++++++++++++++++++++++++");

            //string exampleOne = "Once upon a time, there was a brave princess who...";
            //string exampleTwo = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";

            //string exampleThree = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";

            //Console.WriteLine(RepeatedWordfunctin(exampleOne));
            //Console.WriteLine(RepeatedWordfunctin(exampleTwo));
            //Console.WriteLine(RepeatedWordfunctin(exampleThree));

            List<string> joinData = Program.LeftJoin(hashtable, hashtable2);

            foreach (string join in joinData)
            {
                Console.WriteLine(join);
            }

            Console.ReadLine();


        }
        public static string RepeatedWordfunctin(string phrase)
        {
            string[] words = phrase.Split(' ');

            HashTable hashtable = new HashTable();

            for (int i = 0; i < words.Length; i++)
            {
                string word = Regex.Replace(words[i].ToLower(), @"[^\w\d\s]", "");

                if (hashtable.Contains(word))
                {
                    return hashtable.Get(word);
                }

                hashtable.Add(word, word);
            }

            return "No Repeated Word";
        }
        public static List<string> LeftJoin(HashTable left, HashTable right)
        {
            //List to hold join data.
            List<string> joinTable = new List<string>();

            //Stepping through all hashnode is left hash table
            for (int i = 0; i < left.Table.Length; i++)
            {
                //If the bucket has a hashnode in it
                if (left.Table[i] != null)
                {
                    //Take the first hashnode out of the bucket.
                    Node currentNode = left.Table[i];

                    //Runs until collision storage is null
                    while (currentNode != null)
                    {
                        //Will hold the data collected from hashnode
                        string concat = null;
                        //Adds left hashnode key and value
                        concat = concat + $"{currentNode.Key}, {currentNode.Value}, ";
                        //Checks to see if right hashtable contains matching key
                        if (right.Contains(currentNode.Key))
                        {
                            // Adds right hashnodes value to concat
                            concat = concat + right.Get(currentNode.Key);
                        }
                        else
                        {
                            //Adds NULL if right hashtable doesnt have matching key
                            concat = concat + "NULL";
                        }
                        //Adds saved key value data to list.
                        joinTable.Add(concat);
                        //Moves to next node in collision storage.
                        currentNode = currentNode.Next;
                    }
                }
            }
            //Returns joinTable
            return joinTable;
        }


    }
}
    
