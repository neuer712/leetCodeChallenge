using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge
{
    public class _211_DesignAddandSearchWordsDataStructure_fake
    {
        Dictionary<int, HashSet<string>> theDictionary;

        public _211_DesignAddandSearchWordsDataStructure_fake()
        {
            theDictionary = new Dictionary<int, HashSet<string>>();
        }

        public void AddWord(string word)
        {
            if (!theDictionary.TryGetValue(word.Length, out HashSet<string> set))
            {
                set = new HashSet<string>();
                theDictionary[word.Length] = set;
            }
            set.Add(word);
        }

        public bool Search(string word)
        {
            if (!theDictionary.ContainsKey(word.Length))
            {
                return false;
            }

            var words = theDictionary[word.Length];

            if (words.Contains(word))
            {
                return true;
            }

            List<int> dotPos = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '.')
                { 
                    dotPos.Add(i);
                }
            }

            if (dotPos.Count == 0)
            {
                return false;
            }

            StringBuilder sb = new StringBuilder(word);

            for (short i = 0; i < 26; i++)
            {
                sb.Remove(dotPos[0], 1);
                sb.Insert(dotPos[0], (char)('a' + i));
                if (dotPos.Count == 2)
                {
                    for (short j = 0; j < 26; j++)
                    {
                        sb.Remove(dotPos[1], 1);
                        sb.Insert(dotPos[1], (char)('a' + j));
                        if (words.Contains(sb.ToString()))
                        {
                            return true;
                        }
                    }
                }
                else {
                    if (words.Contains(sb.ToString()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
