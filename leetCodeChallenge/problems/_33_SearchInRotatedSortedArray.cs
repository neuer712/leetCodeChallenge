using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _33_SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            return SearchPartial(nums, target, 0, nums.Length - 1);
        }

        public int SearchPartial(int[] nums, int target, int l, int r)
        {

            if (nums[r] == target)
            {
                return r;
            }

            if (nums[l] == target)
            {
                return l;
            }

            if (r <= l + 1)
            {
                return -1;
            }

            int m = (l + r) / 2;
            if (nums[m] > target)
            {
                if (nums[r] < target || nums[r] > nums[m])
                {
                    return SearchPartial(nums, target, l + 1, m - 1);
                }
                else
                {
                    return SearchPartial(nums, target, m + 1, r - 1);
                }
            }

            if (nums[m] < target)
            {
                if (nums[r] > target || nums[r] < nums[m])
                {
                    return SearchPartial(nums, target, m + 1, r - 1);
                }
                else
                {
                    return SearchPartial(nums, target, l + 1, m - 1);
                }
            }

            return m;
        }
    }
}
