using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
  public class Node
    {
        int data;
        Node next;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        public object Value { get; internal set; }

        public Node(int value)
        {
            this.data = value;
            this.next = null;
        }
    }
}
