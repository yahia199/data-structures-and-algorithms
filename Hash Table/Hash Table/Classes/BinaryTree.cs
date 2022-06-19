using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table.Classes
{
  public class BinaryTree
    {
        public Node Head { get; set; }
        public List<string> myList = new List<string>();

        public BinaryTree(Node head)
        {
            Head = head;
        }

        public List<string> Pre_Order(Node node)
        {
            string value = node.Value;
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
        public List<string> In_Order(Node node)
        {
            if (node.Left != null)
            {
                In_Order(node.Left);
            }

            myList.Add(node.Value);

            if (node.Right != null)
            {
                In_Order(node.Right);
            }

            return myList;
        }
        public List<string> Post_Order(Node node)
        {
            if (node.Left != null)
            {
                Post_Order(node.Left);
            }

            if (node.Right != null)
            {
                Post_Order(node.Right);
            }

            myList.Add(node.Value);

            return myList;
        }
      
    }
}
