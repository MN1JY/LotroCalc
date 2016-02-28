using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LotroCalc.RecipeData.Professions;

namespace LotroCalc.RecipeData.Ingredients.CompositeIngredients.Prospector._4_Artisan
{
    public abstract class ArtisanIngredients : ProspectorCompIngredients
    {
        protected ArtisanIngredients()
        {
            Tier = ProfessionTierEnum.Artisan;
        }

        public static void GetIngredients(ref SortedDictionary<string, Ingredient> dict)
        {
            dict.Add(DwarfIronIngot.DisplayName, new DwarfIronIngot(1));
            dict.Add(DwarfSteelIngots.DisplayName, new DwarfSteelIngots(1));
            dict.Add(PlatinumIngot.DisplayName, new PlatinumIngot(1));
            dict.Add(WesternesseSteelIngot.DisplayName, new WesternesseSteelIngot(1));
        }
    }
}