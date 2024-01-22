using leetCodeChallenge.problems.BiWeekly.BC68;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _40_CombinationSumII
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            if (candidates == null || candidates.Length == 0)
            { 
                return new List<IList<int>>();
            }

            List<int> items = new List<int>();
            Dictionary<int,int> countdict = new Dictionary<int,int>();
            foreach (int a in candidates)
            {
                if (a > target)
                {
                    continue;
                }
                if (countdict.TryGetValue(a, out int value))
                {
                    countdict[a]++;
                }
                else
                { 
                    items.Add(a);
                    countdict[a] = 1;
                }
            }

            if (items.Count == 0)
            {
                return new List<IList<int>>();
            }

            return FindAllPossibleCombinations(new List<int>(), 0, countdict, items, 0, target);
        }

        public List<IList<int>> FindAllPossibleCombinations(List<int> currentListWithPartialItems, int currentSum, Dictionary<int, int> countDict, List<int> items, int currentPos, int target)
        { 
            List<IList<int>> result = new List<IList<int>>();
            int currentElement = items[currentPos];
            int currentItemCount = countDict[currentElement];
            if (currentPos < items.Count - 1)
            {
                result.AddRange(FindAllPossibleCombinations(new List<int>(currentListWithPartialItems), currentSum, countDict, items, currentPos + 1, target));
            }
            for (int i = 0; i < currentItemCount; i++)
            {
                currentSum += currentElement;
                currentListWithPartialItems.Add(currentElement);
                if (currentSum == target)
                {
                    result.Add(currentListWithPartialItems);
                    return result;
                }

                if (currentSum > target)
                {
                    return result;
                }

                if (currentPos < items.Count - 1)
                {
                    result.AddRange(FindAllPossibleCombinations(new List<int>(currentListWithPartialItems), currentSum, countDict, items, currentPos + 1, target));
                }
            }

            return result;
        }
    }
}
