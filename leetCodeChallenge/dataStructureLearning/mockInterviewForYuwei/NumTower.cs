using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.dataStructureLearning.mockInterviewForYuwei
{
    internal class NumTower
    {
        public static void MakeTower(int n)
        {
            int[] lastArr = new int[] { 1 };
            printOneLine(lastArr);
            for (int i=1 ; i < n; i++)
            {
                int[] newArr = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        newArr[j] = 1;
                    }
                    else
                    {
                        newArr[j] = lastArr[j] + lastArr[j - 1];
                    }
                }
                printOneLine(newArr);
                lastArr = newArr;
            }
        }

        private static void printOneLine(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write("   " + i);
            }
            Console.WriteLine();
        }

        private static void printOneLine(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("   " + arr[i]);
            }
            Console.WriteLine();
        }


        public static void MakeTower2(int n)
        {
            int[] arr = new int[n];
            arr[0] = 1;
            printOneLine(arr, 1);
            for (int i=1 ; i < n; i++)
            {
                int lastLineLeftNum = 1;
                int replacedJ = 0;
                int j = 1;
                for (; j < i; j++) 
                {
                    replacedJ = lastLineLeftNum + arr[j];
                    lastLineLeftNum = arr[j];
                    arr[j] = replacedJ;
                }

                arr[j] = 1;
                printOneLine(arr, i+1);
            }
        }
    }
}
