using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;


namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Woodworker._9_Westemnet
{
    public abstract class WestemnetIngredients : WoodworkerIngredients
    {
        protected WestemnetIngredients()
        {
            Tier = ProfessionTierEnum.Westemnet;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            //dict.Add(BagofEastemnetCoffeeGrounds.DisplayName, new BagofEastemnetCoffeeGrounds(1));
        }
    }
}
