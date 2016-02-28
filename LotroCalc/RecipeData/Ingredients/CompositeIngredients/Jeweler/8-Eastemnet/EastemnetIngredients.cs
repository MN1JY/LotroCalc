using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Jeweler._8_Eastemnet
{
    public abstract class EastemnetIngredients : JewelerIngredients
    {
        protected EastemnetIngredients()
        {
            Tier = ProfessionTierEnum.Eastemnet;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(EastemnetBrooch.DisplayName, new EastemnetBrooch(1));
            dict.Add(MetalShavings.DisplayName, new MetalShavings(1));
            dict.Add(PolishedRedAgate.DisplayName, new PolishedRedAgate(1));
            dict.Add(RedAgateBracelet.DisplayName, new RedAgateBracelet(1));
            dict.Add(RedAgateEarring.DisplayName, new RedAgateEarring(1));
            dict.Add(RedAgateNecklace.DisplayName, new RedAgateNecklace(1));
        }

    }
}