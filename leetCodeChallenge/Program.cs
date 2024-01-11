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
            var cal = new _2136_EarliestPossibleDayOfFullBloom();
            Console.WriteLine(cal.EarliestFullBloom(new int[] { 1,4,3 }, new int[] {2,3,1 }));
            Console.ReadLine();
        }
    }
}
