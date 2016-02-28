using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Scholar._8_Eastemnet
{
    public abstract class EastemnetIngredients : ScholarCompIngredients
    {
        protected EastemnetIngredients()
        {
            Tier = ProfessionTierEnum.Eastemnet;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {

        }

    }
}