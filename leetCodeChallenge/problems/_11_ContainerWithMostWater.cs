using System;
using System.Globalization;

namespace leetCodeChallenge
{
    /// <summary>
    /// 11. Container With Most Water
    /// </summary>
    public class _11_ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            if (height == null || height.Length < 2)
            {
                return 0;
            }
            int i = 0, j = height.Length - 1, maxValue = 0;
            int leftBigWall = 0, rightBigWall = 0;
            while (i < j)
            {
                int w = j - i;
                if (height[i] > height[j])
                {
                    if (height[j] > rightBigWall)
                    {
                        rightBigWall = height[j];
                        int currentValue = height[j] * w;
                        if (currentValue > maxValue)
                        {
                            maxValue = currentValue;
                        }
                    }
                    j--;
                }
                else
                {
                    if (height[i] > leftBigWall)
                    {
                        leftBigWall = height[i];
                        int currentValue = height[i] * w;
                        if (currentValue > maxValue)
                        {
                            maxValue = currentValue;
                        }
                    }
                    i++;
                }
            }
            return maxValue;
        }
    }

}