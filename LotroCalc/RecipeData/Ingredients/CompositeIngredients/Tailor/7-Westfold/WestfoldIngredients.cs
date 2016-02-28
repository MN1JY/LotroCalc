using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._7_Westfold.Ingredients;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Tailor._7_Westfold
{
    public abstract class WestfoldIngredients : TailorIngredients 
    {
        protected WestfoldIngredients()
        {
            Tier = ProfessionTierEnum.Westfold;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BrushedBoots.DisplayName, new BrushedBoots(1));
            dict.Add(BrushedShoes.DisplayName, new BrushedShoes(1));
        }
    }
}