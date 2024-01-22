using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _90_SubSet2
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return new List<IList<int>>() { new List<int>()};
            }

            Dictionary<int, int> appearTimes = new Dictionary<int, int>();
            List<int> appearItems = new List<int>();
            foreach (int ii in nums)
            {
                if (appearTimes.TryGetValue(ii, out int value))
                {
                    appearTimes[ii] = value + 1;
                }
                else
                {
                    appearTimes[ii] = 1;
                    appearItems.Add(ii);
                }
            }

            return putSomething(appearTimes, appearItems, currentPos: 0, new List<int>());
        }

        public List<IList<int>> putSomething(Dictionary<int, int> appearTimes, List<int> appearItems, int currentPos, List<int> lastStep)
        {
            List<IList<int>> result = new List<IList<int>>();
            bool isLast = currentPos == appearItems.Count - 1;
            int times = appearTimes[appearItems[currentPos]];
            var lastAdded = lastStep;
            for (int i = 0; i < times; i++)
            {
                lastAdded = new List<int>(lastAdded);
                lastAdded.Add(appearItems[currentPos]);
                if (isLast)
                {
                    result.Add(lastAdded);
                }
                else
                {
                    result.AddRange(putSomething(appearTimes, appearItems, currentPos + 1, lastAdded));
                }
            }

            if (isLast)
            {
                result.Add(lastStep);
            }
            else
            { 
                result.AddRange(putSomething(appearTimes, appearItems, currentPos + 1, lastStep));
            }

            return result;
        }
    }
}
