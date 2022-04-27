using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
   public class Binarytree
    {
        public Node Head { get; set; }
        public List<int> myList = new List<int>();

        public Binarytree(Node head)
        {
            Head = head;
        }

        public List<int> Pre_Order(Node node) 
        {
            int value = node.value;
            myList.Add(value);

            if (node.Left != null)
            {
                Pre_Order(node.Left);
            }
            if (node.Right != null)
            {
                Pre_Order(node.Right);
            }

            return myList;
        }
        public List<int> In_Order(Node node)
        {
            if (node.Left != null)
            {
                In_Order(node.Left);
            }

            myList.Add(node.value);

            if (node.Right != null)
            {
                In_Order(node.Right);
            }

            return myList;
        }
        public List<int> Post_Order(Node node)
        {
            if (node.Left != null)
            {
                Post_Order(node.Left);
            }

            if (node.Right != null)
            {
                Post_Order(node.Right);
            }

            myList.Add(node.value);

            return myList;
        }



    }
}
