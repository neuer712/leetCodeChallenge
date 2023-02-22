using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    internal class _875_KokoEatingBananas
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            Array.Sort(piles);
            long sum = 0;
            foreach (int i in piles)
            {
                sum += i;
            }
            int min = (int)(sum / h);
            if (sum % h > 0) min++;
            int max = piles[piles.Count() - 1];
            if (min == max) return min;
            do
            {
                int middle = (min + max) / 2;
                if (WithInHHours(piles, middle, h))
                {
                    max = middle;
                }
                else
                {
                    min = middle + 1;
                }
            }
            while (min != max);
            return min;
        }

        private bool WithInHHours(int[] piles, int n, int h)
        {
            int resultH = 0;
            foreach (int i in piles)
            {
                int currentH = i / n;
                resultH += currentH;
                if (i % n != 0)
                {
                    resultH++;
                }
            }
            return resultH <= h;
        }
    }
}
