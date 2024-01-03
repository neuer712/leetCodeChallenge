using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _39_CombinationSum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> results = new List<IList<int>>();
            Array.Sort<int>(candidates);
            tryTheCombination(candidates, target, 0, new List<int>(), 0, results);
            return results;
        }

        public void tryTheCombination(int[] candidates, int target, int currentPos,List<int> currentList, int currentSum, IList<IList<int>> results)
        {
            for (int i = currentPos; i < candidates.Length; i++)
            {
                int testSum = currentSum + candidates[i];
                if (testSum > target)
                {
                    return;
                }

                if (testSum == target)
                {
                    currentList.Add(candidates[i]);
                    results.Add(new List<int>(currentList));
                }

                else
                {
                    currentList.Add(candidates[i]);
                    tryTheCombination(candidates, target, i, currentList, testSum, results);
                }

                int currentCount = currentList.Count;
                if (currentCount > 0)
                { 
                    currentList.RemoveAt(currentCount - 1);
                }
            }
        }
    }
}
