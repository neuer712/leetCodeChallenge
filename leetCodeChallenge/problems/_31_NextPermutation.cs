using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _31_NextPermutation
    {
        public void NextPermutation(int[] nums)
        {
            int leftP = nums.Length - 2;
            
            for (; leftP >= 0; leftP--)
            {
                if (nums[leftP] < nums[leftP + 1]) break;
            }
            if (leftP >= 0)
            {
                this.shuffleAndReplaceNum(nums, leftP);
            }
            else 
            {
                this.shuffleAndReplace0(nums);
            }
        }

        public void shuffleAndReplace0(int[] nums)
        {
            int length = nums.Length;
            int i = 0;
            for (; i < (length / 2); i++) 
            {
                int temp = nums[i];
                nums[i] = nums[length - 1 - i];
                nums[length -1 - i] = temp;
            }
            i = 0;
            while (nums[i] == 0) 
            {
                i++;
            }
            if (i != 0) {
                int temp = nums[0];
                nums[0] = nums[i];
                nums[i] = temp;
            }
        }

        public void shuffleAndReplaceNum(int[] nums, int leftP)
        {
            int i = 0;
            for (; i < (nums.Length - leftP) / 2; i++)
            {
                int temp = nums[leftP+1+i];
                nums[leftP + 1 + i] = nums[nums.Length-1-i];
                nums[nums.Length -1- i] = temp;
            }
            for (int j = 0; j < (nums.Length - 1 - leftP); j++) {
                if (nums[leftP+1+j] > nums[leftP]) 
                {
                    int temp = nums[leftP+1+j];
                    nums[leftP+1+j] = nums[leftP];
                    nums[leftP] = temp;
                    break;
                }
            }
        }
    }


}
