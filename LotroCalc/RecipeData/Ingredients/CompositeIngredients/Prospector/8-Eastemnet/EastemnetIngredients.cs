using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._8_Eastemnet
{
    public abstract class EastemnetIngredients : ProspectorCompIngredients
    {
        protected EastemnetIngredients()
        {
            Tier = ProfessionTierEnum.Eastemnet;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(BitofPureRiddermarkOre.DisplayName, new BitofPureRiddermarkOre(1));
            dict.Add(HighQualityRiddermarkIngot.DisplayName, new HighQualityRiddermarkIngot(1));
            dict.Add(LowqualityRiddermarkIngot.DisplayName, new LowqualityRiddermarkIngot(1));
            dict.Add(MediumqualityRiddermarkIngot.DisplayName, new MediumqualityRiddermarkIngot(1));
        }

    }
}