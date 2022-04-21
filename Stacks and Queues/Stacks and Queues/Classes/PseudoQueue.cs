using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Classes
{
   public  class PseudoQueue
    {
        public Stack Stack1 = new Stack();
        public Stack Stack2 = new Stack();

        public void EnqueueStack(int value)
        {
            if (Stack1.Top == null)
            {
                Stack1.Push(value);
            }
            else
            {
                while (Stack1.Top != null)
                {
                    Stack2.Push(Stack1.Pop());
                }
                Stack1.Push(value);
                while (Stack2.Top != null)
                {
                    Stack1.Push(Stack2.Pop());
                }
            }
        }
        public int DequeueStack()
        {
           
            
            
                while (Stack1.Top != null)
                {
                    Stack2.Push(Stack1.Pop());
                }
            while (Stack2.Top != null)
            {
                Stack1.Push(Stack2.Pop());
            }
            int x=  Stack1.Pop();

            return x;
          






        }
    }
}
