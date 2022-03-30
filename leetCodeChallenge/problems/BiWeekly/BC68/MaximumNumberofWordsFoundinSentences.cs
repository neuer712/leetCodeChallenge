using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems.BiWeekly.BC68
{
    class MaximumNumberofWordsFoundinSentences
    {
        public int MostWordsFound(string[] sentences)
        {
            int max = 0;
            foreach (string str in sentences)
            {
                int countNow = str.Count(c => c == ' ') + 1;
                if (countNow > max)
                {
                    max = countNow;
                }
            }
            return max;
        }
    }
}
