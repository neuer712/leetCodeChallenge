using leetCodeChallenge.problems;
using leetCodeChallenge.problems.BiWeekly.BC68;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace leetCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testCase = new int[] { 1, 3, 2 };
            new _31_NextPermutation().NextPermutation(testCase);
            foreach(var c in testCase)
            {
                Console.WriteLine($" {c }");
            }
            
            Console.ReadLine();
        }
    }
}
