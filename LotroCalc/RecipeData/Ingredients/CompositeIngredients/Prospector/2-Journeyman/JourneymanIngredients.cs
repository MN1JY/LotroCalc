using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Cook._2_Journeyman;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._2_Journeyman
{
    public abstract class JourneymanIngredients : ProspectorCompIngredients
    {
        protected JourneymanIngredients()
        {
            Tier = ProfessionTierEnum.Journeyman;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BarrowIronIngot.DisplayName, new BarrowIronIngot(1));
            dict.Add(LowGradeSteelIngots.DisplayName, new LowGradeSteelIngots(1));
            dict.Add(SilverIngot.DisplayName, new SilverIngot(1));

        }
    }
}