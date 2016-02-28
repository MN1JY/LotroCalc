using System.Collections.Generic;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._1_Apprentice
{
    public abstract class ApprenticeIngredients : ProspectorCompIngredients
    {
        protected ApprenticeIngredients()
        {
            Tier = ProfessionTierEnum.Apprentice;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BronzeIngots.DisplayName, new BronzeIngots(1));
            dict.Add(CopperIngots.DisplayName, new CopperIngots(1));
            dict.Add(TinIngot.DisplayName, new TinIngot(1));

        }
    }
}