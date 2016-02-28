using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._3_Expert;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._3_Expert
{
    public abstract class ExpertIngredients : ProspectorCompIngredients
    {
        protected ExpertIngredients()
        {
            Tier = ProfessionTierEnum.Expert;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(GoldIngot.DisplayName, new GoldIngot(1));
            dict.Add(HighGradeSteelIngots.DisplayName, new HighGradeSteelIngots(1));
            dict.Add(RichIronIngot.DisplayName, new RichIronIngot(1));
            dict.Add(WhiteGoldIngot.DisplayName, new WhiteGoldIngot(1));

        }
    }
}