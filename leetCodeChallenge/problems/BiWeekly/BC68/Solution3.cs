using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems.BiWeekly.BC68
{
    class Solution3
    {
        /*public bool CanBeValid(string s, string locked)
        {
            int lenth = s.Length;
            int avLeft = 0;
            int avRight = 0;
            int leftMore = 0;
            for (int i = 0; i < lenth; i++) {

                if (s[i] == '(')
                {
                    leftMore++;
                    if (locked[i] == '0')
                    {
                        avLeft++;
                    }
                }
                else {
                    leftMore--;
                    if (locked[i] == '0')
                    {
                        avRight++;
                    }
                }
                if (leftMore < 0) {
                    if (avRight > 0)
                    {
                        avRight--;
                    }
                    else return false;
                }
            }
            if (leftMore < avLeft) { }

        }*/
    }
}
