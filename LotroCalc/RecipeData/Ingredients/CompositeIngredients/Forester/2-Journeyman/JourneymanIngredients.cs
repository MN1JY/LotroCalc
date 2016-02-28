using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Forester._2_Journeyman
{
    public abstract class JourneymanIngredients : ForesterCompIngredients 
    {
        protected JourneymanIngredients()
        {
            Tier = ProfessionTierEnum.Journeyman;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(Logholder.DisplayName, new Logholder(1));
            dict.Add(PieceOfMediumLeather.DisplayName, new PieceOfMediumLeather(1));
            dict.Add(PlankOfTreatedAsh.DisplayName, new PlankOfTreatedAsh(1));
        }
    }
}