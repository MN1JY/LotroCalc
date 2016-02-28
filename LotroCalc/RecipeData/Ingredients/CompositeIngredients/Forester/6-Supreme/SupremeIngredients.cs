using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._6_Supreme
{
    public abstract class SupremeIngredients : ForesterCompIngredients 
    {
        protected SupremeIngredients()
        {
            Tier = ProfessionTierEnum.Supreme;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(MithrilinlaidTreatedMallornPlank.DisplayName, new MithrilinlaidTreatedMallornPlank(1));
            dict.Add(MithrilReinforcedExtraordinaryLeather.DisplayName, new MithrilReinforcedExtraordinaryLeather(1));
            dict.Add(PieceOfExtraordinaryLeather.DisplayName, new PieceOfExtraordinaryLeather(1));
            dict.Add(PieceOfMagnificentLeather.DisplayName, new PieceOfMagnificentLeather(1));
            dict.Add(PlankofTreatedIlex.DisplayName, new PlankofTreatedIlex(1));
            dict.Add(PlankofTreatedMallorn.DisplayName, new PlankofTreatedMallorn(1));
        }
    }
}