using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _8_StringToInteger
    {
        public int MyAtoi(string s)
        {
            string alter = s.Trim();
            int position = 0;
            if (alter.Length == 0)
            {
                return 0;
            }

            int positive = 1;
            int startNumPos = 0;

            if (alter[position] == '+')
            {
                startNumPos++;
                position++;
            }
            else if (alter[position] == '-')
            {
                startNumPos++;
                position++;
                positive = -1;
            }

            while (position < alter.Length && alter[position] == '0')
            {
                startNumPos++;
                position++;
            }

            while (position < alter.Length && isNum(alter, position))
            {
                position++;
            }

            string final = alter.Substring(startNumPos, position - startNumPos);
            if (final.Length == 0)
            {
                return 0;
            }

            if (final.Length > 10)
            {
                return positive == 1 ? 2147483647 : -2147483648;
            }

            long possibleValue = Int64.Parse(alter.Substring(startNumPos, position - startNumPos)) * positive;

            return possibleValue > 2147483647 ? 2147483647 : possibleValue < -2147483648 ? -2147483648 : (int)possibleValue;
        }

        public static bool isNum(string s, int position)
        {
            return s[position] >= '0' && s[position] <= '9';
        }
    }
}
