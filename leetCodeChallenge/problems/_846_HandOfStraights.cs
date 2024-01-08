using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _846_HandOfStraights
    {
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize > 0)
            {
                return false; 
            }

            Array.Sort<int>(hand);
            List<int> values = new List<int>();
            List<int> freqs = new List<int>();

            int value = hand[0];
            int freq = 0;
            foreach (int h in hand)
            {
                if (h > value)
                {
                    values.Add(value);
                    freqs.Add(freq);
                    freq = 1;
                    value = h;
                }
                else
                {
                    freq++;
                }
            }

            values.Add(value);
            freqs.Add(freq);

            LinkedList<int> list = new LinkedList<int>();
            int count = 0;
            for (int i = 0; i < values.Count; i++)
            {
                if (list.Count == 0)
                {
                    list.AddLast(i);
                }
                else 
                {
                    if (values[i] > values[i - 1] + 1)
                    {
                        list.Clear();
                        list.AddLast(i);
                    }
                    else
                    {
                        list.AddLast(i);
                    }
                }

                if (i - list.First() >= (groupSize -1) )
                {
                    int min = freqs[list.First()], pos = -1, minpos = 0; ;
                    foreach (int j in list)
                    {
                        pos++;
                        if (freqs[j] == min)
                        {
                            minpos = pos;
                            min = freqs[j];
                        }
                        if (freqs[j] < min)
                        {
                            return false;
                        }
                    }

                    for (int j = 0; j <= minpos; j++)
                    {
                        list.RemoveFirst();
                    }

                    count += (minpos + 1) * min;

                    foreach (int j in list)
                    {
                        freqs[j] = freqs[j] - min;
                        count += min;
                    }
                }
            }

            return count == hand.Length;
        }
    }
}
