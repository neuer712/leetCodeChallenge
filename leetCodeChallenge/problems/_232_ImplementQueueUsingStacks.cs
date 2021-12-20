using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _232_ImplementQueueUsingStacks
    {
        private static Stack<int> stack1;

        private static Stack<int> stack2;

        public _232_ImplementQueueUsingStacks() 
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        public void Push(int x)
        {
            stack1.Push(x);
        }

        public int Pop()
        {
            this.shuffle();
            return stack2.Pop();    // get an exception if stack2 is still empty.
        }

        public int Peek()
        {
            this.shuffle();
            return stack2.Peek();                 // get an exception if stack2 is still empty.
        }

        public bool Empty()
        {
            return 0 == (stack1.Count + stack2.Count);
        }

        private void shuffle() 
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
        }
    }
}
