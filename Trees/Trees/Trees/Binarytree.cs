using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Binarytree
    {
        public Node Head { get; set; }
        public List<object> myList = new List<object>();

        public Binarytree(Node head)
        {
            Head = head;
        }

        public List<object> Pre_Order(Node node)
        {
            object value = node.value;
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
        public List<object> In_Order(Node node)
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
        public List<object> Post_Order(Node node)
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
        public List<object> FizzBuzzTree(Node node)
        {
            if ((int)(node.value) % 15 == 0)
            {
                node.value = "FizzBuzz";
            }
            else if ((int)(node.value) % 3 == 0)
            {
                node.value = "Fizz";

            }
            else if ((int)(node.value) % 5 == 0)
            {
                node.value = "Buzz";
            }
            myList.Add(node.value);


            if (node.Left != null)
            {
                FizzBuzzTree(node.Left);
            }
            if (node.Right != null)
            {
                FizzBuzzTree(node.Right);
            }
            return myList;
        }

        public  object FindMaximumValue(Binarytree tree)
        {
            List<object> listOfNodes = tree.Pre_Order(tree.Head);
            object temp = tree.Head.value;
            foreach (var value in listOfNodes)
            {
                if ((int)temp < (int)value)
                {
                    temp = value;
                }
            }
            return temp;
        }
       
        public List<object> BreadthFirstMethod(Binarytree Tree)
        {
           
            Node node = Tree.Head;
            Queue<Node> MyQueue = new Queue<Node>();
            List<object> MyList = new List<object>();
            MyQueue.Enqueue(node);
            while (MyQueue.Count > 0)
            {
                node = MyQueue.Dequeue();
                MyList.Add(node.value);

                if (node.Left != null)
                {
                    MyQueue.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    MyQueue.Enqueue(node.Right);
                }
            }
            return MyList;
        }
    }
    }
