using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    //need to think about it.
    public class _131_PalindromePartitioning
    {
        /*
        public IList<IList<string>> Partition(string s)
        {
            int length = s.Length;
            int totalPossibleCenterLength = length * 2 - 1;
            Dictionary<int,int> maxPalindromeAtPos = new Dictionary<int,int>();
            for (int i = 0; i < totalPossibleCenterLength; i++)
            {
                maxPalindromeAtPos[i] = findPalindromePossibility(s, i);
            }


        }

        public bool PutPart(string s, int pos, Dictionary<int, int> maxPalindromeAtPos, int occupiedLetter, IList<string> partialResult, IList<IList<string>> result)
        { 
            for(int i = 0; i < )
        }

        public int findPalindromePossibility(string s, int pos)
        {
            if (pos % 2 == 0)
            {
                int actualPos = pos / 2;
                int i = 0;
                while (actualPos - (i + 1) > 0 && actualPos + (i + 1) < s.Length && (s[actualPos - (i + 1)] == s[actualPos + (i + 1)]))
                {
                    i++;
                }

                return i;
            }
            else
            {
                int lowPos = pos / 2, highPos = pos / 2 + 1;
                int i = 0;
                while (lowPos > 0 && highPos < s.Length && s[lowPos] == s[highPos]) 
                {
                    i++;
                    lowPos--;
                    highPos++;
                }

                return i;
            }
        }
        */
    }
}
