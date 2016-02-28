using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._7_Westfold.Ingredients;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._7_Westfold
{
    public abstract class WestfoldIngredients : ProspectorCompIngredients
    {
        protected WestfoldIngredients()
        {
            Tier = ProfessionTierEnum.Westfold;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BitOfPureCalenard.DisplayName, new BitOfPureCalenard(1));
            dict.Add(LowQualityCalenardIngot.DisplayName, new LowQualityCalenardIngot(1));
            dict.Add(MediumQualityCalenardIngot.DisplayName, new MediumQualityCalenardIngot(1));
            dict.Add(HighQualityCalenardIngotsmelting.DisplayName, new HighQualityCalenardIngotsmelting(1));
        }
    }
}