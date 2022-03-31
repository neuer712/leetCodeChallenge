using System.Collections.Generic;
using System.Linq;

namespace leetCodeChallenge.dataStructureLearning.section9_graphTheory
{
    public class TopoSort
    {
        public static string[] GetTopoSortResult(Dictionary<string, List<string>> graph)
        {
            Dictionary<string, int> indegrees = new Dictionary<string, int>();
            HashSet<string> noIndegreeKeySet = graph.Keys.ToHashSet();
            // ISet<string> vertexes = new HashSet<string>();
            foreach (var entry in graph)
            {
                var graphValues = entry.Value;
                foreach (var vertex in graphValues)
                {
                    indegrees.TryGetValue(vertex, out var indegreeNum);
                    indegrees[vertex] = indegreeNum + 1;
                }
            }
            noIndegreeKeySet.ExceptWith(indegrees.Keys);
            List<string> results = new List<string>();
            var noIndegreeKeys = noIndegreeKeySet.ToList();
            while (noIndegreeKeys.Count > 0)
            {
                var oneNoIndegreeKeyItem = noIndegreeKeys.Last();
                results.Add(oneNoIndegreeKeyItem);
                noIndegreeKeys.RemoveAt(noIndegreeKeys.Count - 1);
                if (graph.TryGetValue(oneNoIndegreeKeyItem, out var graphValues))
                {
                    graphValues.ForEach(item =>
                    {
                        indegrees[item] = indegrees[item] - 1;
                        if (indegrees[item] == 0)
                        {
                            noIndegreeKeys.Add(item);
                        }
                    });
                }
            }

            return results.ToArray();
        }
    }
}