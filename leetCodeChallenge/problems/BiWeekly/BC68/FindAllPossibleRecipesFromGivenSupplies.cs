using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems.BiWeekly.BC68
{
    class FindAllPossibleRecipesFromGivenSupplies
    {
        public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies)
        {
            ISet<string> suppliesSet = new HashSet<string>(supplies);
            IList<string> results = new List<string>();
            var em = ingredients.GetEnumerator();
            Dictionary<string,IList<string>> map = new Dictionary<string, IList<string>>();
            for (int i = 0; i < recipes.Length; i++) {
                em.MoveNext();
                map.Add(recipes[i], em.Current);
            }
            for (int i = 0; i < recipes.Length; i++)
            {
                var loopSet = new HashSet<string>();
                loopSet.Add(recipes[i]);
                if (canBeMade(recipes[i], suppliesSet, map, loopSet)) 
                {
                    results.Add(recipes[i]);
                    suppliesSet.Add(recipes[i]);
                }   
            }
            return results;
        }

        public bool canBeMade(string recipe, ISet<string> supplies, Dictionary<string, IList<string>> map, ISet<string> loop) 
        { 
            IList<string> ingredientOfRecipe = null;
            map.TryGetValue(recipe, out ingredientOfRecipe);
            foreach (string ingredient in ingredientOfRecipe)
            {
                if (loop.Contains(ingredient)) {
                    return false;
                }
                if (!supplies.Contains(ingredient))
                {
                    if (map.Keys.Contains(ingredient))
                    {
                        loop.Add(ingredient);
                        if (!canBeMade(ingredient, supplies, map, loop)) {
                            return false;
                        }
                        loop.Remove(ingredient);
                    }
                    else {
                        return false;
                    }
                }
            }
            return true;
        }
    }

}
