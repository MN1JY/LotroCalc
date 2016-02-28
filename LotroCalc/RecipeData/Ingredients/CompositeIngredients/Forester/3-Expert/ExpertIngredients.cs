using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._3_Expert
{
    public abstract class ExpertIngredients : ForesterCompIngredients 
    {
        protected ExpertIngredients()
        {
            Tier = ProfessionTierEnum.Expert;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(PieceOfSturdyLeather.DisplayName, new PieceOfSturdyLeather(1));
            dict.Add(PlankOfTreatedYew.DisplayName, new PlankOfTreatedYew(1));
        }
    }
}