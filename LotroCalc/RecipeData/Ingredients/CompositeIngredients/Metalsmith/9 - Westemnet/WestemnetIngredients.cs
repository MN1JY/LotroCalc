using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;


namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._9_Westemnet
{
    public abstract class WestemnetIngredients : MetalsmithIngredients
    {
        protected WestemnetIngredients()
        {
            Tier = ProfessionTierEnum.Westemnet;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(LargeWestemnetCrest.DisplayName, new LargeWestemnetCrest(1));
            dict.Add(MediumWestemnetCrest.DisplayName, new MediumWestemnetCrest(1));
            dict.Add(SmallWestemnetCrest.DisplayName, new SmallWestemnetCrest(1));
        }
    }
}

