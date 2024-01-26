using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _79_WordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0)
            {
                return false;
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (Find(board, word, 0, i, j))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool Find(char[][] board, string word, short n, int i, int j)
        {
            if (board[i][j] == word[n])
            {
                if (n == word.Length - 1)
                {
                    return true;
                }
                n++;
                board[i][j] = ' ';
                if (i > 0 && Find(board, word, n, i - 1, j))
                { 
                    return true;
                }

                if (i < board.Length - 1  && Find(board, word, n, i + 1, j))
                {
                    return true;
                }

                if (j > 0 && Find(board, word, n, i, j - 1))
                {
                    return true;
                }

                if (j < board[0].Length -1 && Find(board, word, n, i, j + 1))
                {
                    return true;
                }

                n--;
                board[i][j] = word[n];
            }

            return false;
        }
    }
}
