﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stacks_and_Queues.Classes
{
    public class Node
    {
       

        public int Value { get; set; }

        public Node Next { get; set; }
       

        public Node(int v)
        {
           Value = v;
        }
        public Node()
        {

        }

       
    }
   
}
