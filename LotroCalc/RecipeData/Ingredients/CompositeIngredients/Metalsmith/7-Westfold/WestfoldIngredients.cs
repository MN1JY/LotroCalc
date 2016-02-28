using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._7_Westfold.Ingredients;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Metalsmith._7_Westfold
{
    public abstract class WestfoldIngredients : MetalsmithIngredients
    {
        protected WestfoldIngredients()
        {
            Tier = ProfessionTierEnum.Westfold;
            SuperiorForgeRequired = true;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(CalenardChisel.DisplayName, new CalenardChisel(1));
            dict.Add(CalenardRiffler.DisplayName, new CalenardRiffler(1));
            dict.Add(CalenardWarGauntlets.DisplayName, new CalenardWarGauntlets(1));
            dict.Add(CalenardWarPauldrons.DisplayName, new CalenardWarPauldrons(1));
            dict.Add(DunlendingCampaignShield.DisplayName, new DunlendingCampaignShield(1));
            dict.Add(DunlendingSkirmishShield.DisplayName, new DunlendingSkirmishShield(1));
            dict.Add(DunlendingWarArmour.DisplayName, new DunlendingWarArmour(1));
            dict.Add(DunlendingWarShield.DisplayName, new DunlendingWarShield(1));
            dict.Add(LargeWestfoldCrest.DisplayName, new LargeWestfoldCrest(1));
            dict.Add(MediumWestfoldCrest.DisplayName, new MediumWestfoldCrest(1));
            dict.Add(SmallWestfoldCrest.DisplayName, new SmallWestfoldCrest(1));
            dict.Add(SuperiorCalenardChisel.DisplayName, new SuperiorCalenardChisel(1));
            dict.Add(SuperiorCalenardRiffler.DisplayName, new SuperiorCalenardRiffler(1));
            dict.Add(WestfoldWarBoots.DisplayName, new WestfoldWarBoots(1));
            dict.Add(WestfoldWarHelmet.DisplayName, new WestfoldWarHelmet(1));
            dict.Add(WestfoldWarLeggings.DisplayName, new WestfoldWarLeggings(1));
        }
    }
}