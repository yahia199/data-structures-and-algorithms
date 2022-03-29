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
        public void Append(int value)
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
        public void InsertBefore(int data, int x)
        {
            Node temp;

            // if list is empty
            if (Head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            // if x is the first node the new node will be inserted before the first node
            if (x == Head.Data)
            {
                temp = new Node(data);
                temp.Next = Head;
                Head = temp;
                return;

            }
            Node p = Head;
            while (p.Next != null)
            {
                if (p.Next.Data == x)
                    break;
                p = p.Next;
            }

            if (p.Next == null)
                Console.WriteLine(x + " not present in the list");
            else
            {
                temp = new Node(data);
                temp.Next = p.Next;
                p.Next = temp;
            }


        }

        public void InsertAfter(int data, int x)
        {
            Node p = Head;
            while (p != null)
            {
                if (p.Data == x)
                    break;
                p = p.Next;
            }

            if (p == null)
                Console.WriteLine(x + " not present  the list");
            else
            {
                Node temp = new Node(data);
                temp.Next = p.Next;
                p.Next = temp;
            }
        }




    }
}
