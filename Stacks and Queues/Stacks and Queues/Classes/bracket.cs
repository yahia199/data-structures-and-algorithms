using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Classes
{
  public  class bracket
    {
        public bool BracketValidation(string v)
        {
            Stack<char> Stack1 = new Stack<char>();
            foreach(char x in v.ToCharArray())
            {
                switch (x)
                {
                    case '{':
                    case '[':
                    case '(':
                        Stack1.Push(x);
                        break;
                    case ')':
                    if(!Stack1.Pop().Equals('('))
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (!Stack1.Pop().Equals('['))
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (!Stack1.Pop().Equals('{'))
                        {
                            return false;
                        }
                        break;
                }
            }
            if(Stack1.Count.Equals(0))
            {
            return  true;
            }
            else
            {
                return false;
            }

        }
    }
}
