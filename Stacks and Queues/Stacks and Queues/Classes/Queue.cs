using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Stacks_and_Queues.Classes
{
   public class Queue
    {
        public Node Front;
        public Node Rare;

        public Queue()
        {

        }
        public Queue(Node node)
        {
            Front = Rare = node;
        }

        public void Enqeue(int val)
        {
            Node node = new Node(val);
            if (Front == null && Rare == null)
            {
                Front = Rare = node;
            }
            else
            {
                Rare.Next = node;
                Rare = node;
            }


        }
        public void Denqeue()
        {
            if(Front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node x = Front;
                Front = Front.Next;
                x.Next = null;
                Console.WriteLine(x.Value+ " Is delete");
            }

        }
        public int Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            Console.WriteLine("Is a peek "+Front.Value);
            return Front.Value;
        }
        public bool IsEmpty
        {
            get { return Front == null; }
        }
        public string Print()
        {
            if (IsEmpty)
            {
                return "Queue is empty";
            }
            string format = "";
            Node current = Front;
            while (current != null)
            {
                format += $"[ {current.Value} ] -> ";
                current = current.Next;
            }

            format += "NULL";
            return format;
        }


    }
}
