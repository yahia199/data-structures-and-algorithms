using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
   public class Binary_Search_Tree
    {
        public Node head;
        public int count;

        public void add(object value)
        {
            if(head == null)
            {
                head = new Node(value);
            }
            else
            {
                AddTo(head, value);
            }
            count++;
        }
        private void AddTo(Node node, object value)
        {
            if ((int)value < (int)node.value)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }

        }
        
        public bool Contains(object value)
        {
            Node current = head;
            while (current != null)
            {
                if ((int)value > (int)current.value)
                {
                    current = current.Right;
                }
                else if ((int)value < (int)current.value)
                {
                    current = current.Left;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        public object Getmax()
        {
            Node current = head;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.value;
        }
      


    }
}
