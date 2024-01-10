using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCodeChallenge.problems.TimeMap;

namespace leetCodeChallenge.problems
{
    public class _981_TimeBasedKVStore
    {
    }

    public class TimeMap
    {
        private readonly Dictionary<string, ValueItem> innerMap;

        public TimeMap()
        {
            innerMap = new Dictionary<string, ValueItem>();
        }

        public void Set(string key, string value, int timestamp)
        {
            ValueItem valueItem = null;
            if (!innerMap.TryGetValue(key, out valueItem))
            {
                valueItem = new ValueItem();
                innerMap[key] = valueItem;
            }

            valueItem.Set(timestamp, value);
        }

        public string Get(string key, int timestamp)
        {
            ValueItem valueItem = null;
            if (!innerMap.TryGetValue(key, out valueItem))
            {
                return string.Empty;
            }

            return valueItem.Get(timestamp);
        }
    }

    public class ValueItem
    {
        List<int> timestamps = new List<int>();
        List<string> values = new List<string>();
        Dictionary<int,int> fastTable = new Dictionary<int,int>();

        public void Set(int timestamp, string value)
        { 
            timestamps.Add(timestamp);
            values.Add(value);
            fastTable.Add(timestamp, timestamps.Count - 1);
        }

        public string Get(int timestamp)
        {
            if (fastTable.TryGetValue(timestamp, out int pos))
            { 
                return values[pos];
            }

            if (timestamp > timestamps[timestamps.Count - 1])
            {
                return values[timestamps.Count - 1];
            }

            if (timestamp < timestamps[0])
            {
                return string.Empty;
            }

            int l = 0, r = timestamps.Count - 2;
            while (l < r - 2)
            {
                int midPos = (l + r) / 2;
                if (timestamps[midPos] > timestamp)
                {
                    r = midPos;
                }
                else if (timestamps[midPos + 1] < timestamp)
                {
                    l = midPos;
                }
                else
                {
                    return values[midPos];
                }
            }

            if (timestamps[l] < timestamp && timestamp < timestamps[r])
            {
                return values[l];
            }

            return values[r];
        }
    }
}
