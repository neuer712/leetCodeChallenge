using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _16_3Sum_Closest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int deltaFinal = 99999;
            int final = 0;
            for (int r = nums.Length - 1; r > 1; r--)
            {
                int l = 0, r1 = r - 1;
                while (l < r1) {
                    int local = nums[r] + nums[l] + nums[r1];
                    int deltaLocal = Math.Abs(local - target);
                    if (deltaLocal < deltaFinal) 
                    {
                        deltaFinal = deltaLocal;
                        final = local;
                    }
                    if (local == target)
                    {
                        return target;
                    }
                    else if (local > target)
                    {
                        r1--;
                    }
                    else 
                    {
                        l++; 
                    }
                }
            }
            return final;
        }
    }
}
