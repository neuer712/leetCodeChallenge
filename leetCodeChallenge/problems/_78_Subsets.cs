using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _78_Subsets
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            return findSome(new List<int>(), 0, nums);
        }

        public List<IList<int>> findSome(List<int> last, int i, int[] nums)
        {
            List<int> another = new List<int>(last);
            another.Add(nums[i]);
            List<IList<int>> results = new List<IList<int>>();
            if (i == nums.Length - 1)
            {
                results.Add(last);
                results.Add(another);
            }
            else
            {
                results.AddRange(findSome(last, i + 1, nums));
                results.AddRange(findSome(another, i + 1, nums));
            }
            return results;
        }
    }
}
