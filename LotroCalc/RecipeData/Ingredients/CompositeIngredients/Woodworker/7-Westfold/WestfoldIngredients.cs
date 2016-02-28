using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Woodworker._7_Westfold
{
    public abstract class WestfoldIngredients : WoodworkerIngredients
    {
        protected WestfoldIngredients()
        {
            Tier = ProfessionTierEnum.Westfold;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BirchHorn.DisplayName, new BirchHorn(1));
            dict.Add(BirchwoodHammer.DisplayName, new BirchwoodHammer(1));
            dict.Add(LargeWestfoldCarving.DisplayName, new LargeWestfoldCarving(1));
            dict.Add(MediumWestfoldCarving.DisplayName, new MediumWestfoldCarving(1));
            dict.Add(SmallWestfoldCarving.DisplayName, new SmallWestfoldCarving(1));
            dict.Add(WestfoldClub.DisplayName, new WestfoldClub(1));
        }
    }
}