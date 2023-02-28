using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _238_ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            bool hasZero = false;
            int current = 1;
            int[] left = new int[nums.Length];
            left[0] = 1;
            int[] right = new int[nums.Length];
            right[nums.Length - 1] = 1;
            int i = 0;
            for (; i < nums.Length - 1; i++)
            {
                if (nums[i] == 0) break;
                current *= nums[i];
                left[i + 1] = current;
            }

            while (i < nums.Length - 1)
            {
                left[i + 1] = 0;
                i++;
            }

            current = 1;
            for (; i > 0; i--)
            {
                if (nums[i] == 0) break;
                current *= nums[i];
                right[i - 1] = current;
            }

            while (i > 0)
            {
                right[i - 1] = 0;
                i--;
            }

            int[] results = new int[nums.Length];
            for (; i < nums.Length; i++)
            {
                results[i] = left[i] * right[i];
            }

            return results;

        }
    }
}
