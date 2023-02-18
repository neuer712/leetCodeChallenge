using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _227_BasicCalculatorII_noneStack  //TODO make a stack version!
    {
        public int Calculate(string s)
        {
            s = s + "+0";
            int lastAdd = 0;
            char lastOperationDown = '+';
            char lastOperationUp = '*';
            int lastMulti = 1;
            bool up = false;
            int lastNumStart = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                
                switch (current)
                {
                    case '+':
                        {
                            int lastNumber = Convert.ToInt32(s.Substring(lastNumStart, i - lastNumStart));
                            if (up)
                            {
                                lastAdd = eval(lastAdd, eval(lastMulti, lastNumber, lastOperationUp), lastOperationDown);
                                up = false;

                            }
                            else
                            {
                                lastAdd = eval(lastAdd, lastNumber, lastOperationDown);
                            }
                            lastOperationDown = '+';
                            lastNumStart = i + 1;
                            break;
                        }
                    case '-':
                        {
                            int lastNumber = Convert.ToInt32(s.Substring(lastNumStart, i - lastNumStart));
                            if (up)
                            {
                                lastAdd = eval(lastAdd, eval(lastMulti, lastNumber, lastOperationUp), lastOperationDown);
                                up = false;

                            }
                            else
                            {
                                lastAdd = eval(lastAdd, lastNumber, lastOperationDown);
                            }
                            lastOperationDown = '-';
                            lastNumStart = i + 1;
                            break;
                        }
                    case '*':
                        {
                            int lastNumber = Convert.ToInt32(s.Substring(lastNumStart, i - lastNumStart));
                            if (up)
                            {
                                lastMulti = eval(lastMulti, lastNumber, lastOperationUp);
                            }
                            else
                            {
                                up = true;
                                lastMulti = lastNumber;
                            }
                            lastOperationUp = '*';
                            lastNumStart = i + 1;
                            break;
                        }
                    case '/':
                        {
                            int lastNumber = Convert.ToInt32(s.Substring(lastNumStart, i - lastNumStart));
                            if (up)
                            {
                                lastMulti = eval(lastMulti, lastNumber, lastOperationUp);
                            }
                            else
                            {
                                up = true;
                                lastMulti = lastNumber;
                            }
                            lastOperationUp = '/';
                            lastNumStart = i + 1;
                            break;
                        }
                }
            }
            return lastAdd;

        }

        private int eval(int left, int right, char operation)
        {
            switch (operation)
            {
                case '+': return left + right;
                case '-': return left - right;
                case '*': return left * right;
                default: return left / right;
            }
        }
    }
}
