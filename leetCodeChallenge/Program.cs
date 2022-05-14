using leetCodeChallenge.problems;
using leetCodeChallenge.problems.BiWeekly.BC68;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCodeChallenge.dataStructureLearning.section9_graphTheory;


namespace leetCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> testCase = new Dictionary<string, List<string>>();
            testCase.Add("v1",(new string[]{"v2","v3","v4"}).ToList());
            testCase.Add("v2",(new string[]{"v5","v4"}).ToList());
            testCase.Add("v3",(new string[]{"v6"}).ToList());
            testCase.Add("v4",(new string[]{"v6","v3","v7"}).ToList());
            testCase.Add("v5",(new string[]{"v7","v4"}).ToList());
            testCase.Add("v7",(new string[]{"v6"}).ToList());
            string[] testResults = TopoSort.GetTopoSortResult(testCase);
            foreach (var oneSinlgeResult in testResults)
            {
                Console.Write(oneSinlgeResult + ' ');
            }
            Console.ReadLine();
        }
    }
}
