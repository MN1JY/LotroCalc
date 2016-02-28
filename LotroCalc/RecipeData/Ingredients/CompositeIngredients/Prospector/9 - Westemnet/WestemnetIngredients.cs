using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;


namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._9_Westemnet
{
    public abstract class WestemnetIngredients : ProspectorCompIngredients
    {
        protected WestemnetIngredients()
        {
            Tier = ProfessionTierEnum.Westemnet;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(LowGradeEorlingasIngot.DisplayName, new LowGradeEorlingasIngot(1));
            dict.Add(MediumGradeEorlingasIngot.DisplayName, new MediumGradeEorlingasIngot(1));
            dict.Add(HighGradeEorlingasIngot.DisplayName, new HighGradeEorlingasIngot(1));
        }
    }
}
