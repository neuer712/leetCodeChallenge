using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _1143_LongestCommonSubsequence
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int[][] matrix = new int[text1.Length][];
            for (int i = 0; i < text1.Length; i++)
            {
                matrix[i] = new int[text2.Length];
                for (int j = 0; j < text2.Length; j++)
                {
                    if (text1[i] == text2[j])
                    {
                        matrix[i][j] = -1;
                    }
                    else
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            if (matrix[0][0] == -1)
            {
                matrix[0][0] = 1;
            }

            for(int j = 1; j < text2.Length; j++)
            {
                if (matrix[0][j - 1] == 1 || matrix[0][j] != 0)
                {
                    matrix[0][j] = 1;
                }
            }

            for (int i = 1; i < text1.Length; i++)
            {
                if (matrix[i - 1][0] != 0 || matrix[i][0] != 0)
                {
                    matrix[i][0] = 1;
                }
                for (int j = 1; j < text2.Length; j++)
                { 
                    int localmax = Math.Max(matrix[i - 1][j], matrix[i][j - 1]);
                    if (matrix[i][j] == -1)
                    { 
                        localmax = Math.Max(localmax, matrix[i-1][j-1] + 1);
                    }

                    matrix[i][j] = localmax;
                }
            }

            return matrix[text1.Length - 1][text2.Length - 1];
        }
    }
}
