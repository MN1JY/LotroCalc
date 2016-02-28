using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._1_Apprentice
{
    public abstract class ApprenticeIngredients : ForesterCompIngredients
    {
        protected ApprenticeIngredients()
        {
            Tier = ProfessionTierEnum.Apprentice;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(PieceOfLightLeather.DisplayName, new PieceOfLightLeather(1));
            dict.Add(PlankOfTreatedRowan.DisplayName, new PlankOfTreatedRowan(1));
        }
    }
}