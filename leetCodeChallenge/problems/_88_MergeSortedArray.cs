using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _88_MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
            {
                return;
            }

            if (m == 0) 
            {
                for (int i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
                return;
            }
            int x = m - 1, y = n - 1, z = m + n - 1;
            while (y >= 0) 
            {
                if (x >= 0 && nums1[x] > nums2[y])
                {
                    nums1[z] = nums1[x];
                    x--;
                }
                else 
                {
                    nums1[z] = nums2[y];
                    y--;
                }
                z--;
            }
        }
    }
}
