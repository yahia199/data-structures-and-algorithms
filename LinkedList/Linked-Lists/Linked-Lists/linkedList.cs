using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Linked_Lists
    {
       public Node Head;
      public  Node Tail;

        public Linked_Lists()
        {
            Head = null;
            Tail = null;
        }

        // To add in the last of the linked list
        public void AddLast(int value)
        {
            Node item = new Node(value);

            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                Tail.Next = item;
                Tail = item;
            }
        }

        // To display linked list
        public void ToString()
        {
            Node start = Head;
            if (start == null)
            {
                Console.WriteLine("Your llist is empty");
            }
            else
            {
                while (start != null)
                {
                    Console.Write("[" + start.Data + "] -> ");
                    start = start.Next;
                }
                Console.WriteLine("null");
            }
        }

        public void AddFirst(int value)
        {
            Node item = new Node(value);

            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                item.Next = Head;
                Head = item;
            }
        }

        public bool Search(int value)
        {
            Node current = new Node(value);
            current = Head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    Console.WriteLine("Found it");
                    return true;
                }
                current = current.Next;
            }
            if (current == null)
            {
                Console.WriteLine("Not found");
            }
            return false;
        }
    }
}
