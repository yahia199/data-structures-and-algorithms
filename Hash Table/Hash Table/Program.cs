using Hash_Table.Classes;
using System;
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

            Console.WriteLine(hashtable.Get("Yahia").Value);

            Console.WriteLine(hashtable.Get("Ahmad").Value);

            Console.WriteLine(hashtable.Get("Njood").Value);

            Console.WriteLine(hashtable.Contains("Mahmoud"));

            Console.WriteLine(hashtable.Contains("Omar"));

            Console.WriteLine(hashtable.Contains("Khaled"));

            Console.WriteLine("+++++++++++++++++++++++++++");

            string exampleOne = "Once upon a time, there was a brave princess who...";
            string exampleOnee = " ";
            string exampleTwo = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
          
            string exampleThree = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";

            Console.WriteLine(RepeatedWordfunctin(exampleOne));
            Console.WriteLine(RepeatedWordfunctin(exampleOnee));
            Console.WriteLine(RepeatedWordfunctin(exampleTwo));
            Console.WriteLine(RepeatedWordfunctin(exampleThree));
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
                    return hashtable.Get(word).Value;
                }

                hashtable.Add(word, word);
            }

            return "No Repeated Word";
        }

    }
}
