using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;


namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._9_Westemnet
{
    public abstract class WestemnetIngredients : JewelerIngredients
    {
        protected WestemnetIngredients()
        {
            Tier = ProfessionTierEnum.Westemnet;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(PolishedEmerald.DisplayName, new PolishedEmerald(1));
            dict.Add(LargeWestemnetSymbol.DisplayName, new LargeWestemnetSymbol(1));
            dict.Add(MediumWestemnetSymbol.DisplayName, new MediumWestemnetSymbol(1));
            dict.Add(SmallWestemnetSymbol.DisplayName, new SmallWestemnetSymbol(1));
        }
    }
}

