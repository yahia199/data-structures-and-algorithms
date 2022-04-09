using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }



        public int count = 0;

        public void Push(int v)
        {
            Node node = new Node(v);
            node.Next = Top;
            Top = node;
            
            count++;
        }

        public int Size()
        {
            return count;
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public string Print()
        {
            if (IsEmpty)
            {
                return "Stack is empty";
            }
            string format = "";
            Node current = Top;
            while (current != null)
            {
                format += $"[ {current.Value} ] -> ";
                current = current.Next;
            }

            format += "NULL";
            return format;

        }
        public int Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            Node x = Top;
            Top = Top.Next;
            count--;
            return x.Value;
        }
        public int Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
           Console.WriteLine("Peek is " + Top.Value);
            return Top.Value;
        }
    }

 }

