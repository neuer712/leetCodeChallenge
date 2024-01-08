using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _739_DailyTemperatures
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            Stack<int> stack = new Stack<int>();
            int[] results = new int[temperatures.Length];
            for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
                {
                    int lastResolved = stack.Pop();
                    results[lastResolved] = i - lastResolved;
                }

                stack.Push(i);
            }


            return results;
        }
    }
}
